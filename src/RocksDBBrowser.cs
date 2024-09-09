using Newtonsoft.Json.Linq;
using RocksDbSharp;
using System;
using System.Buffers.Binary;
using System.Data.SqlTypes;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace RocksDBBrowser
{
    public partial class RocksDBBrowser : Form
    {
        private List<(byte[], byte[])> CurrentRecords = new();
        private string CurrentDbPath;
        private string[] CurrentColumnFamilies;
        private string CurrentColumn;
        private bool EndOfData;
        private string DataCount;
        private IDbManger dbManger;
        public RocksDBBrowser()
        {
            InitializeComponent();
            KeyDataTypeComboBox.SelectedIndex = 0;
            dbManger = new DBManager();
        }

        private void OpenFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "Choose a folder";

                DialogResult result = folderDialog.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderDialog.SelectedPath))
                {
                    folderTreeView.Nodes.Clear();
                    LoadDirectory(folderDialog.SelectedPath, folderTreeView.Nodes);
                }
            }
        }

        private void LoadDirectory(string dirPath, TreeNodeCollection nodes)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(dirPath);
            TreeNode rootNode = new TreeNode(dirInfo.Name);
            rootNode.Tag = dirInfo.FullName;
            nodes.Add(rootNode);
            if (IsRocksDbFolder(dirPath))
            {
                ShowRocksDbColumns(dirPath, rootNode);
                return;
            }
            foreach (var dir in dirInfo.GetDirectories())
            {
                TreeNode node = new TreeNode(dir.Name);
                node.Tag = dir.FullName;
                LoadSubDirectories(node);
                rootNode.Nodes.Add(node);
            }
            rootNode.Expand();
        }
        private void LoadSubDirectories(TreeNode node)
        {
            string path = node.Tag as string;
            if (Directory.Exists(path))
            {
                DirectoryInfo dirInfo = new DirectoryInfo(path);
                try
                {
                    if (IsRocksDbFolder(path))
                    {
                        ShowRocksDbColumns(path, node);
                        return;
                    }
                    foreach (var dir in dirInfo.GetDirectories())
                    {
                        TreeNode childNode = new TreeNode(dir.Name);
                        childNode.Tag = dir.FullName;
                        childNode.Nodes.Add("Dummy"); // 
                        node.Nodes.Add(childNode);
                    }

                }
                catch (UnauthorizedAccessException)
                {
                }
            }
        }
        private void DirectoryTreeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode node = e.Node;
            if (node.Nodes.Count == 1 && node.Nodes[0].Text == "Dummy")
            {
                node.Nodes.Clear();
                LoadSubDirectories(node);
            }
        }

        private bool IsRocksDbFolder(string path)
        {
            return Directory.Exists(path) && File.Exists(Path.Combine(path, "CURRENT"));
        }

        private void ShowRocksDbColumns(string path, TreeNode node)
        {
            var columns = GetColumns(path);
            foreach (var column in columns)
            {
                TreeNode columnNode = new TreeNode(column);
                columnNode.Tag = column;
                node.Nodes.Add(columnNode);
            }
        }

        private string[] GetColumns(string path)
        {
            try
            {
                var cfNames = RocksDb.ListColumnFamilies(new DbOptions(), path);
                return cfNames.ToArray();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return [];
        }

        private void DirectoryTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode node = e.Node;
            string path = node.Tag as string;

            if (IsRocksDbFolder(path) && node.Nodes.Count == 0)
            {
                ShowRocksDbColumns(path, node);
                node.Expand();
            }
            else if (node.Parent != null && IsRocksDbFolder(node.Parent.Tag as string))
            {
                var nodePath = node.Parent.Tag as string;
                var column = node.Tag as string;
                if (nodePath != CurrentDbPath || column != CurrentColumn)
                {
                    CurrentDbPath = nodePath;
                    CurrentColumn = column;
                    CurrentRecords.Clear();
                    CurrentColumnFamilies = node.Parent.Nodes.Cast<TreeNode>().Select(n => n.Tag as string).ToArray();
                    var records = dbManger.GetRecords(CurrentDbPath, CurrentColumnFamilies, CurrentColumn, null, 50,out EndOfData);
                    CurrentRecords = CurrentRecords.Concat(records).ToList();
                    ShowRecords(true);
                }
            }
            else
            {
                toolStripStatusLabel.Text = "";
            }
        }

        private void ShowRecords(bool clear)
        {
            var startCount = dataGrid.RowCount - 1;
            if (clear)
            {
                dataGrid.Columns.Clear();
                dataGrid.Rows.Clear();
                DataGridViewTextBoxColumn noColumn = new DataGridViewTextBoxColumn
                {
                    Name = "Number",
                    HeaderText = "No.",
                    Width = 50,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                };
                dataGrid.Columns.Add(noColumn);

                DataGridViewTextBoxColumn keyColumn = new DataGridViewTextBoxColumn
                {
                    Name = "key",
                    HeaderText = "key",
                    Width = 200,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                };
                dataGrid.Columns.Add(keyColumn);

                DataGridViewTextBoxColumn valueColumn = new DataGridViewTextBoxColumn
                {
                    Name = "value",
                    HeaderText = "value",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                };
                dataGrid.Columns.Add(valueColumn);
                startCount = 0;
            }
            else
            {
                startCount = dataGrid.RowCount - 1;
            }

            if (CurrentRecords.Count > startCount)
            {
                for (int i = startCount; i < CurrentRecords.Count; i++)
                {
                    var tuple = CurrentRecords[i];
                    var keyRender = GetKeyString(tuple.Item1);
                    var valueRender = GetValueString(tuple.Item2);
                    dataGrid.Rows.Add((i + 1).ToString(), keyRender, valueRender);
                }
            }
            //toolStripStatusLabel.Text = $"{CurrentRecords.Count} of {DataCount} items loaded.";
            toolStripStatusLabel.Text = $"{CurrentRecords.Count} items loaded.";
        }
        private string GetKeyString(byte[] key)
        {
            long keyValue=0;
            string outPutString = "";
            switch (KeyDataTypeComboBox.Text)
            {
                case "Int64BigEndian":
                    keyValue = BinaryPrimitives.ReadInt64BigEndian(key);
                    break;
                case "Int32BigEndian":
                    keyValue = BinaryPrimitives.ReadInt32BigEndian(key);
                    break;
                case "String":
                    outPutString= Encoding.UTF8.GetString(key);
                    return outPutString;
                default:
                    keyValue = 0;
                    break;
            }
            switch (DisplayKeyComboBox.Text)
            {
                case "Raw":
                    outPutString = keyValue.ToString();
                    break;
                case "UTCTick2Time":
                    outPutString = (new DateTime(keyValue, DateTimeKind.Utc)).ToString("yyyy-MM-dd HH:mm:ss.fff");
                    break;
                default:
                    break;
            }
            return outPutString;
        }
        private string GetValueString(byte[] value)
        {
            string outPutString = "";
            switch (displayValueComboBox.Text)
            {
                case "Digital":
                    outPutString = BitConverter.ToInt64(value).ToString();
                    break;
                case "String":
                default:
                    outPutString = Encoding.UTF8.GetString(value);
                    break;
            }

            return outPutString;
        }
       
        private void DataGrid_SelectionChanged(object sender, EventArgs e)
        {
            ShowSelectedValue();
        }

        private void DataGrid_Scroll(object sender, ScrollEventArgs e)
        {
            if (EndOfData)
            {
                return;
            }

            if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
            {
                int firstDisplayIndex = dataGrid.FirstDisplayedScrollingRowIndex;

                int displayRowCount = dataGrid.DisplayedRowCount(false);
                int lastVisibleRowIndex = displayRowCount + firstDisplayIndex;

                if (dataGrid.Rows.Count - lastVisibleRowIndex < displayRowCount)
                {
                    var startKey = CurrentRecords.Last().Item1;
                    var records = dbManger.GetRecords(CurrentDbPath, CurrentColumnFamilies, CurrentColumn, startKey, displayRowCount,out EndOfData);
                    CurrentRecords = CurrentRecords.Concat(records).ToList();
                    ShowRecords(false);
                    dataGrid.FirstDisplayedScrollingRowIndex = firstDisplayIndex;
                }
            }
        }
        private void ShowSelectedValue()
        {
            if (dataGrid.SelectedCells.Count > 0)
            {
                var selectedCell = dataGrid.SelectedCells[0];
                var cellValue = selectedCell.Value?.ToString();

                ValueShowTextBox.Text = GetFormatedString(cellValue);
            }
        }

        private string GetFormatedString(string text)
        {
            string outPutString = text;
            try
            {
                switch (TextModeComboBox.Text)
                {
                    case "XML":
                        XDocument doc = XDocument.Parse(text);
                        outPutString = doc.ToString();
                        break;
                    case "JSON":
                        var parsedJson = JToken.Parse(text);
                        outPutString = parsedJson.ToString(Newtonsoft.Json.Formatting.Indented);
                        break;
                    case "Text":
                    default:
                        outPutString = text;
                        break;
                }
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
            }

            return outPutString;
        }

        private void KeyDataTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowRecords(true);
        }

        private void DisplayKeyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowRecords(true);
        }
        private void TextModeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowSelectedValue();
        }

        private void displayValueAsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowRecords(true);
        }
    }
}