namespace RocksDBBrowser
{
    partial class RocksDBBrowser
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openFolderToolStripMenuItem = new ToolStripMenuItem();
            shortCutToolStrip = new ToolStrip();
            openFolderToolStripButton = new ToolStripButton();
            dataGrid = new DataGridView();
            folderTreeView = new TreeView();
            ValueShowTextBox = new TextBox();
            mainTableLayoutPanel = new TableLayoutPanel();
            midlleTableLayoutPanel = new TableLayoutPanel();
            middleToptableLayoutPanel = new TableLayoutPanel();
            KeyTypeLabel = new Label();
            KeyDataTypeComboBox = new ComboBox();
            DisplayKeyComboBox = new ComboBox();
            DisplayKeyLabel = new Label();
            displayValueAsLabel = new Label();
            displayValueComboBox = new ComboBox();
            rightSplitContainer = new SplitContainer();
            valueShowTableLayoutPanel = new TableLayoutPanel();
            rightTopTableLayoutPanel = new TableLayoutPanel();
            TextModeComboBox = new ComboBox();
            TextModeLabel = new Label();
            toolTableLayoutPanel = new TableLayoutPanel();
            mainStatusStrip = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            menuStrip.SuspendLayout();
            shortCutToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            mainTableLayoutPanel.SuspendLayout();
            midlleTableLayoutPanel.SuspendLayout();
            middleToptableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)rightSplitContainer).BeginInit();
            rightSplitContainer.Panel1.SuspendLayout();
            rightSplitContainer.Panel2.SuspendLayout();
            rightSplitContainer.SuspendLayout();
            valueShowTableLayoutPanel.SuspendLayout();
            rightTopTableLayoutPanel.SuspendLayout();
            mainStatusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(1899, 28);
            menuStrip.TabIndex = 1;
            menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openFolderToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // openFolderToolStripMenuItem
            // 
            openFolderToolStripMenuItem.Name = "openFolderToolStripMenuItem";
            openFolderToolStripMenuItem.Size = new Size(174, 26);
            openFolderToolStripMenuItem.Text = "Open Folder";
            openFolderToolStripMenuItem.Click += OpenFolder_Click;
            // 
            // shortCutToolStrip
            // 
            shortCutToolStrip.CanOverflow = false;
            shortCutToolStrip.ImageScalingSize = new Size(20, 20);
            shortCutToolStrip.Items.AddRange(new ToolStripItem[] { openFolderToolStripButton });
            shortCutToolStrip.Location = new Point(0, 28);
            shortCutToolStrip.Name = "shortCutToolStrip";
            shortCutToolStrip.Size = new Size(1899, 27);
            shortCutToolStrip.TabIndex = 15;
            shortCutToolStrip.Text = "shortCutToolStrip";
            // 
            // openFolderToolStripButton
            // 
            openFolderToolStripButton.ImageTransparentColor = Color.Magenta;
            openFolderToolStripButton.Name = "openFolderToolStripButton";
            openFolderToolStripButton.Size = new Size(95, 24);
            openFolderToolStripButton.Text = "Open Folder";
            openFolderToolStripButton.Click += OpenFolder_Click;
            // 
            // dataGrid
            // 
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Dock = DockStyle.Fill;
            dataGrid.Location = new Point(3, 53);
            dataGrid.Name = "dataGrid";
            dataGrid.RowHeadersWidth = 51;
            dataGrid.Size = new Size(1107, 799);
            dataGrid.TabIndex = 8;
            dataGrid.Scroll += DataGrid_Scroll;
            dataGrid.SelectionChanged += DataGrid_SelectionChanged;
            // 
            // folderTreeView
            // 
            folderTreeView.Dock = DockStyle.Fill;
            folderTreeView.Location = new Point(3, 3);
            folderTreeView.Name = "folderTreeView";
            folderTreeView.Size = new Size(294, 855);
            folderTreeView.TabIndex = 9;
            folderTreeView.BeforeExpand += DirectoryTreeView_BeforeExpand;
            folderTreeView.NodeMouseClick += DirectoryTreeView_NodeMouseClick;
            // 
            // ValueShowTextBox
            // 
            ValueShowTextBox.Dock = DockStyle.Fill;
            ValueShowTextBox.Location = new Point(3, 53);
            ValueShowTextBox.Multiline = true;
            ValueShowTextBox.Name = "ValueShowTextBox";
            ValueShowTextBox.ScrollBars = ScrollBars.Both;
            ValueShowTextBox.Size = new Size(468, 568);
            ValueShowTextBox.TabIndex = 13;
            // 
            // mainTableLayoutPanel
            // 
            mainTableLayoutPanel.ColumnCount = 3;
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            mainTableLayoutPanel.Controls.Add(folderTreeView, 0, 0);
            mainTableLayoutPanel.Controls.Add(midlleTableLayoutPanel, 1, 0);
            mainTableLayoutPanel.Controls.Add(rightSplitContainer, 2, 0);
            mainTableLayoutPanel.Dock = DockStyle.Fill;
            mainTableLayoutPanel.Location = new Point(0, 55);
            mainTableLayoutPanel.Margin = new Padding(3, 50, 3, 3);
            mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            mainTableLayoutPanel.RowCount = 1;
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            mainTableLayoutPanel.Size = new Size(1899, 861);
            mainTableLayoutPanel.TabIndex = 14;
            // 
            // midlleTableLayoutPanel
            // 
            midlleTableLayoutPanel.ColumnCount = 1;
            midlleTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            midlleTableLayoutPanel.Controls.Add(dataGrid, 0, 1);
            midlleTableLayoutPanel.Controls.Add(middleToptableLayoutPanel, 0, 0);
            midlleTableLayoutPanel.Dock = DockStyle.Fill;
            midlleTableLayoutPanel.Location = new Point(303, 3);
            midlleTableLayoutPanel.Name = "midlleTableLayoutPanel";
            midlleTableLayoutPanel.RowCount = 2;
            midlleTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            midlleTableLayoutPanel.RowStyles.Add(new RowStyle());
            midlleTableLayoutPanel.Size = new Size(1113, 855);
            midlleTableLayoutPanel.TabIndex = 0;
            // 
            // middleToptableLayoutPanel
            // 
            middleToptableLayoutPanel.ColumnCount = 8;
            middleToptableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.98701F));
            middleToptableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.9870138F));
            middleToptableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.09091F));
            middleToptableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.9870138F));
            middleToptableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.9870138F));
            middleToptableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.9870138F));
            middleToptableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.9870138F));
            middleToptableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.9870138F));
            middleToptableLayoutPanel.Controls.Add(KeyTypeLabel, 0, 0);
            middleToptableLayoutPanel.Controls.Add(KeyDataTypeComboBox, 1, 0);
            middleToptableLayoutPanel.Controls.Add(DisplayKeyComboBox, 4, 0);
            middleToptableLayoutPanel.Controls.Add(DisplayKeyLabel, 3, 0);
            middleToptableLayoutPanel.Controls.Add(displayValueAsLabel, 6, 0);
            middleToptableLayoutPanel.Controls.Add(displayValueComboBox, 7, 0);
            middleToptableLayoutPanel.Dock = DockStyle.Fill;
            middleToptableLayoutPanel.Location = new Point(3, 3);
            middleToptableLayoutPanel.Name = "middleToptableLayoutPanel";
            middleToptableLayoutPanel.RowCount = 1;
            middleToptableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            middleToptableLayoutPanel.Size = new Size(1107, 44);
            middleToptableLayoutPanel.TabIndex = 9;
            // 
            // KeyTypeLabel
            // 
            KeyTypeLabel.AutoSize = true;
            KeyTypeLabel.Location = new Point(3, 0);
            KeyTypeLabel.Name = "KeyTypeLabel";
            KeyTypeLabel.Size = new Size(96, 20);
            KeyTypeLabel.TabIndex = 0;
            KeyTypeLabel.Text = "KeyDataType";
            // 
            // KeyDataTypeComboBox
            // 
            KeyDataTypeComboBox.FormattingEnabled = true;
            KeyDataTypeComboBox.Items.AddRange(new object[] { "Int64BigEndian", "Int32BigEndian", "String" });
            KeyDataTypeComboBox.Location = new Point(146, 3);
            KeyDataTypeComboBox.Name = "KeyDataTypeComboBox";
            KeyDataTypeComboBox.Size = new Size(137, 28);
            KeyDataTypeComboBox.TabIndex = 1;
            KeyDataTypeComboBox.Text = "Int64BigEndian";
            KeyDataTypeComboBox.SelectedIndexChanged += KeyDataTypeComboBox_SelectedIndexChanged;
            // 
            // DisplayKeyComboBox
            // 
            DisplayKeyComboBox.FormattingEnabled = true;
            DisplayKeyComboBox.Items.AddRange(new object[] { "Raw", "UTCTick2Time" });
            DisplayKeyComboBox.Location = new Point(532, 3);
            DisplayKeyComboBox.Name = "DisplayKeyComboBox";
            DisplayKeyComboBox.Size = new Size(137, 28);
            DisplayKeyComboBox.TabIndex = 3;
            DisplayKeyComboBox.Text = "UTCTick2Time";
            DisplayKeyComboBox.SelectedIndexChanged += DisplayKeyComboBox_SelectedIndexChanged;
            // 
            // DisplayKeyLabel
            // 
            DisplayKeyLabel.AutoSize = true;
            DisplayKeyLabel.Location = new Point(389, 0);
            DisplayKeyLabel.Name = "DisplayKeyLabel";
            DisplayKeyLabel.Size = new Size(98, 20);
            DisplayKeyLabel.TabIndex = 2;
            DisplayKeyLabel.Text = "DisplayKeyAs";
            // 
            // displayValueAsLabel
            // 
            displayValueAsLabel.AutoSize = true;
            displayValueAsLabel.Location = new Point(818, 0);
            displayValueAsLabel.Name = "displayValueAsLabel";
            displayValueAsLabel.Size = new Size(110, 20);
            displayValueAsLabel.TabIndex = 4;
            displayValueAsLabel.Text = "DisplayValueAs";
            // 
            // displayValueComboBox
            // 
            displayValueComboBox.FormattingEnabled = true;
            displayValueComboBox.Items.AddRange(new object[] { "String", "Digital" });
            displayValueComboBox.Location = new Point(961, 3);
            displayValueComboBox.Name = "displayValueComboBox";
            displayValueComboBox.Size = new Size(143, 28);
            displayValueComboBox.TabIndex = 5;
            displayValueComboBox.Text = "String";
            displayValueComboBox.SelectedIndexChanged += displayValueAsComboBox_SelectedIndexChanged;
            // 
            // rightSplitContainer
            // 
            rightSplitContainer.Dock = DockStyle.Fill;
            rightSplitContainer.Location = new Point(1422, 3);
            rightSplitContainer.Name = "rightSplitContainer";
            rightSplitContainer.Orientation = Orientation.Horizontal;
            // 
            // rightSplitContainer.Panel1
            // 
            rightSplitContainer.Panel1.Controls.Add(valueShowTableLayoutPanel);
            // 
            // rightSplitContainer.Panel2
            // 
            rightSplitContainer.Panel2.Controls.Add(toolTableLayoutPanel);
            rightSplitContainer.Size = new Size(474, 855);
            rightSplitContainer.SplitterDistance = 624;
            rightSplitContainer.TabIndex = 1;
            // 
            // valueShowTableLayoutPanel
            // 
            valueShowTableLayoutPanel.ColumnCount = 1;
            valueShowTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            valueShowTableLayoutPanel.Controls.Add(rightTopTableLayoutPanel, 0, 0);
            valueShowTableLayoutPanel.Controls.Add(ValueShowTextBox, 0, 1);
            valueShowTableLayoutPanel.Dock = DockStyle.Fill;
            valueShowTableLayoutPanel.Location = new Point(0, 0);
            valueShowTableLayoutPanel.Name = "valueShowTableLayoutPanel";
            valueShowTableLayoutPanel.RowCount = 2;
            valueShowTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            valueShowTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            valueShowTableLayoutPanel.Size = new Size(474, 624);
            valueShowTableLayoutPanel.TabIndex = 0;
            // 
            // rightTopTableLayoutPanel
            // 
            rightTopTableLayoutPanel.ColumnCount = 3;
            rightTopTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            rightTopTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            rightTopTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            rightTopTableLayoutPanel.Controls.Add(TextModeComboBox, 2, 0);
            rightTopTableLayoutPanel.Controls.Add(TextModeLabel, 1, 0);
            rightTopTableLayoutPanel.Dock = DockStyle.Fill;
            rightTopTableLayoutPanel.Location = new Point(3, 3);
            rightTopTableLayoutPanel.Name = "rightTopTableLayoutPanel";
            rightTopTableLayoutPanel.RowCount = 1;
            rightTopTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            rightTopTableLayoutPanel.Size = new Size(468, 44);
            rightTopTableLayoutPanel.TabIndex = 14;
            // 
            // TextModeComboBox
            // 
            TextModeComboBox.FormattingEnabled = true;
            TextModeComboBox.Items.AddRange(new object[] { "Text", "JSON", "XML" });
            TextModeComboBox.Location = new Point(330, 3);
            TextModeComboBox.Name = "TextModeComboBox";
            TextModeComboBox.Size = new Size(135, 28);
            TextModeComboBox.TabIndex = 2;
            TextModeComboBox.Text = "JSON";
            TextModeComboBox.SelectedIndexChanged += TextModeComboBox_SelectedIndexChanged;
            // 
            // TextModeLabel
            // 
            TextModeLabel.AutoSize = true;
            TextModeLabel.Location = new Point(190, 0);
            TextModeLabel.Name = "TextModeLabel";
            TextModeLabel.Size = new Size(48, 20);
            TextModeLabel.TabIndex = 1;
            TextModeLabel.Text = "Mode";
            // 
            // toolTableLayoutPanel
            // 
            toolTableLayoutPanel.ColumnCount = 1;
            toolTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            toolTableLayoutPanel.Dock = DockStyle.Fill;
            toolTableLayoutPanel.Location = new Point(0, 0);
            toolTableLayoutPanel.Name = "toolTableLayoutPanel";
            toolTableLayoutPanel.RowCount = 2;
            toolTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            toolTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            toolTableLayoutPanel.Size = new Size(474, 227);
            toolTableLayoutPanel.TabIndex = 0;
            // 
            // mainStatusStrip
            // 
            mainStatusStrip.ImageScalingSize = new Size(20, 20);
            mainStatusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            mainStatusStrip.Location = new Point(0, 916);
            mainStatusStrip.Name = "mainStatusStrip";
            mainStatusStrip.Size = new Size(1899, 26);
            mainStatusStrip.TabIndex = 16;
            mainStatusStrip.Text = "mainStatusStrip";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(50, 20);
            toolStripStatusLabel.Text = "Ready";
            // 
            // RocksDBBrowser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1899, 942);
            Controls.Add(mainTableLayoutPanel);
            Controls.Add(shortCutToolStrip);
            Controls.Add(menuStrip);
            Controls.Add(mainStatusStrip);
            MainMenuStrip = menuStrip;
            Name = "RocksDBBrowser";
            Text = "RocksDBBrowser";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            shortCutToolStrip.ResumeLayout(false);
            shortCutToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            mainTableLayoutPanel.ResumeLayout(false);
            midlleTableLayoutPanel.ResumeLayout(false);
            middleToptableLayoutPanel.ResumeLayout(false);
            middleToptableLayoutPanel.PerformLayout();
            rightSplitContainer.Panel1.ResumeLayout(false);
            rightSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)rightSplitContainer).EndInit();
            rightSplitContainer.ResumeLayout(false);
            valueShowTableLayoutPanel.ResumeLayout(false);
            valueShowTableLayoutPanel.PerformLayout();
            rightTopTableLayoutPanel.ResumeLayout(false);
            rightTopTableLayoutPanel.PerformLayout();
            mainStatusStrip.ResumeLayout(false);
            mainStatusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openFolderToolStripMenuItem;
        private RichTextBox richTextBox1;
        private DataGridView dataGrid;
        private TreeView folderTreeView;
        private TextBox ValueShowTextBox;
        private TableLayoutPanel mainTableLayoutPanel;
        private TableLayoutPanel midlleTableLayoutPanel;
        private SplitContainer rightSplitContainer;
        private TableLayoutPanel valueShowTableLayoutPanel;
        private TableLayoutPanel toolTableLayoutPanel;
        private ToolStrip toolStrip1;
        private ToolStripButton openFolderToolStripButton;
        private ToolStrip shortCutToolStrip;
        private TableLayoutPanel middleToptableLayoutPanel;
        private Label KeyTypeLabel;
        private ComboBox KeyDataTypeComboBox;
        private Label DisplayKeyLabel;
        private ComboBox DisplayKeyComboBox;
        private TableLayoutPanel rightTopTableLayoutPanel;
        private ComboBox TextModeComboBox;
        private Label TextModeLabel;
        private StatusStrip mainStatusStrip;
        private ToolStripStatusLabel toolStripStatusLabel;
        private Label displayValueAsLabel;
        private ComboBox displayValueComboBox;
    }
}