using RocksDbSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocksDBBrowser
{
    interface IDbManger
    {
        List<(byte[], byte[])> GetRecords(string dbPath, string[] columnFamilyNames, string columnFamilyName, byte[]? startKey, int maxNumber, out bool endOfData);
    }
    class DBManager:IDbManger
    {
        public List<(byte[], byte[])> GetRecords(string dbPath, string[] columnFamilyNames, string columnFamilyName, byte[]? startKey, int maxNumber, out bool endOfData)
        {
            List<(byte[], byte[])> records = new();
            endOfData=false;
            var options = new DbOptions().SetCreateIfMissing(false).EnableStatistics();
            var columnFamilies = new ColumnFamilies();
            foreach (string familyName in columnFamilyNames)
            {
                columnFamilies.Add(familyName, new ColumnFamilyOptions());
            }
            try
            {
                using (var db = RocksDb.Open(options, dbPath, columnFamilies))
                {
                    var columnFamily = db.GetColumnFamily(columnFamilyName);
                    using (var iterator = db.NewIterator(columnFamily))
                    {
                        if (startKey == null)
                        {
                            iterator.SeekToFirst();
                        }
                        else
                        {
                            iterator.Seek(startKey);
                        }

                        int count = 0;
                        while (iterator.Valid() && count < maxNumber)
                        {
                            var key = iterator.GetKeySpan().ToArray();
                            var value = iterator.GetValueSpan().ToArray();

                            iterator.Next();
                            if (startKey != null && key.SequenceEqual(startKey))
                            {
                                continue;
                            }
                            records.Add((key, value));
                            count++;
                        }
                        if (count < maxNumber - 1)
                        {
                            endOfData = true;
                        }
                        else
                        {
                            endOfData = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return records;
        }
    }
}
