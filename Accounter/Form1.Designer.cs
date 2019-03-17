namespace Accounter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            this.menuPanel = new System.Windows.Forms.Panel();
            this.menuLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.exitHighlightPanel = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.reportButton = new System.Windows.Forms.Button();
            this.summaryButton = new System.Windows.Forms.Button();
            this.reportHighlightPanel = new System.Windows.Forms.Panel();
            this.summaryHighlightPanel = new System.Windows.Forms.Panel();
            this.importButton = new System.Windows.Forms.Button();
            this.importHighlightPanel = new System.Windows.Forms.Panel();
            this.statusPanel = new System.Windows.Forms.Panel();
            this.importPanel = new System.Windows.Forms.Panel();
            this.importGroupBox = new System.Windows.Forms.GroupBox();
            this.importTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.importSaveButton = new System.Windows.Forms.Button();
            this.importCancelButton = new System.Windows.Forms.Button();
            this.summaryPanel = new System.Windows.Forms.Panel();
            this.summaryGroupBox = new System.Windows.Forms.GroupBox();
            this.transactionListView = new System.Windows.Forms.ListView();
            this.dateColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.typeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.partnerColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.categoryColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sumColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.reportPanel = new System.Windows.Forms.Panel();
            this.reportGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.categoryReport = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.reportDateTime = new System.Windows.Forms.DateTimePicker();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.summaryFromDateTime = new System.Windows.Forms.DateTimePicker();
            this.summaryToDateTime = new System.Windows.Forms.DateTimePicker();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuPanel.SuspendLayout();
            this.menuLayoutPanel.SuspendLayout();
            this.importPanel.SuspendLayout();
            this.importGroupBox.SuspendLayout();
            this.importTableLayoutPanel.SuspendLayout();
            this.summaryPanel.SuspendLayout();
            this.summaryGroupBox.SuspendLayout();
            this.reportPanel.SuspendLayout();
            this.reportGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.menuPanel.Controls.Add(this.menuLayoutPanel);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(115, 749);
            this.menuPanel.TabIndex = 0;
            this.menuPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.menuPanel_Paint);
            // 
            // menuLayoutPanel
            // 
            this.menuLayoutPanel.ColumnCount = 2;
            this.menuLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.08696F));
            this.menuLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.91304F));
            this.menuLayoutPanel.Controls.Add(this.exitHighlightPanel, 1, 3);
            this.menuLayoutPanel.Controls.Add(this.exitButton, 0, 3);
            this.menuLayoutPanel.Controls.Add(this.reportButton, 0, 2);
            this.menuLayoutPanel.Controls.Add(this.summaryButton, 0, 1);
            this.menuLayoutPanel.Controls.Add(this.reportHighlightPanel, 1, 2);
            this.menuLayoutPanel.Controls.Add(this.summaryHighlightPanel, 1, 1);
            this.menuLayoutPanel.Controls.Add(this.importButton, 0, 0);
            this.menuLayoutPanel.Controls.Add(this.importHighlightPanel, 1, 0);
            this.menuLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.menuLayoutPanel.Name = "menuLayoutPanel";
            this.menuLayoutPanel.RowCount = 4;
            this.menuLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.menuLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.menuLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.menuLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.menuLayoutPanel.Size = new System.Drawing.Size(115, 749);
            this.menuLayoutPanel.TabIndex = 4;
            this.menuLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // exitHighlightPanel
            // 
            this.exitHighlightPanel.BackColor = System.Drawing.Color.Gold;
            this.exitHighlightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exitHighlightPanel.Location = new System.Drawing.Point(102, 564);
            this.exitHighlightPanel.Name = "exitHighlightPanel";
            this.exitHighlightPanel.Size = new System.Drawing.Size(10, 182);
            this.exitHighlightPanel.TabIndex = 9;
            this.exitHighlightPanel.Visible = false;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.exitButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exitButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.exitButton.Location = new System.Drawing.Point(3, 564);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(93, 182);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // reportButton
            // 
            this.reportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.reportButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportButton.FlatAppearance.BorderSize = 0;
            this.reportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportButton.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.reportButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.reportButton.Location = new System.Drawing.Point(3, 377);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(93, 181);
            this.reportButton.TabIndex = 7;
            this.reportButton.Text = "Report";
            this.reportButton.UseVisualStyleBackColor = false;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // summaryButton
            // 
            this.summaryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.summaryButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.summaryButton.FlatAppearance.BorderSize = 0;
            this.summaryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.summaryButton.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.summaryButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.summaryButton.Location = new System.Drawing.Point(3, 190);
            this.summaryButton.Name = "summaryButton";
            this.summaryButton.Size = new System.Drawing.Size(93, 181);
            this.summaryButton.TabIndex = 6;
            this.summaryButton.Text = "Summary";
            this.summaryButton.UseVisualStyleBackColor = false;
            this.summaryButton.Click += new System.EventHandler(this.summaryButton_Click);
            // 
            // reportHighlightPanel
            // 
            this.reportHighlightPanel.BackColor = System.Drawing.Color.Gold;
            this.reportHighlightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportHighlightPanel.Location = new System.Drawing.Point(102, 377);
            this.reportHighlightPanel.Name = "reportHighlightPanel";
            this.reportHighlightPanel.Size = new System.Drawing.Size(10, 181);
            this.reportHighlightPanel.TabIndex = 5;
            this.reportHighlightPanel.Visible = false;
            // 
            // summaryHighlightPanel
            // 
            this.summaryHighlightPanel.BackColor = System.Drawing.Color.Gold;
            this.summaryHighlightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.summaryHighlightPanel.Location = new System.Drawing.Point(102, 190);
            this.summaryHighlightPanel.Name = "summaryHighlightPanel";
            this.summaryHighlightPanel.Size = new System.Drawing.Size(10, 181);
            this.summaryHighlightPanel.TabIndex = 3;
            // 
            // importButton
            // 
            this.importButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.importButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.importButton.FlatAppearance.BorderSize = 0;
            this.importButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importButton.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.importButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.importButton.Location = new System.Drawing.Point(3, 3);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(93, 181);
            this.importButton.TabIndex = 0;
            this.importButton.Text = "Import";
            this.importButton.UseVisualStyleBackColor = false;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // importHighlightPanel
            // 
            this.importHighlightPanel.BackColor = System.Drawing.Color.Gold;
            this.importHighlightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.importHighlightPanel.Location = new System.Drawing.Point(102, 3);
            this.importHighlightPanel.Name = "importHighlightPanel";
            this.importHighlightPanel.Size = new System.Drawing.Size(10, 181);
            this.importHighlightPanel.TabIndex = 1;
            this.importHighlightPanel.Visible = false;
            // 
            // statusPanel
            // 
            this.statusPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.statusPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusPanel.Location = new System.Drawing.Point(115, 649);
            this.statusPanel.Name = "statusPanel";
            this.statusPanel.Size = new System.Drawing.Size(1255, 100);
            this.statusPanel.TabIndex = 1;
            // 
            // importPanel
            // 
            this.importPanel.Controls.Add(this.importGroupBox);
            this.importPanel.Location = new System.Drawing.Point(147, 12);
            this.importPanel.Name = "importPanel";
            this.importPanel.Size = new System.Drawing.Size(625, 132);
            this.importPanel.TabIndex = 2;
            // 
            // importGroupBox
            // 
            this.importGroupBox.Controls.Add(this.importTableLayoutPanel);
            this.importGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.importGroupBox.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.importGroupBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.importGroupBox.Location = new System.Drawing.Point(0, 0);
            this.importGroupBox.Name = "importGroupBox";
            this.importGroupBox.Size = new System.Drawing.Size(625, 132);
            this.importGroupBox.TabIndex = 0;
            this.importGroupBox.TabStop = false;
            this.importGroupBox.Text = "Import";
            // 
            // importTableLayoutPanel
            // 
            this.importTableLayoutPanel.ColumnCount = 2;
            this.importTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.importTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.importTableLayoutPanel.Controls.Add(this.importSaveButton, 0, 1);
            this.importTableLayoutPanel.Controls.Add(this.importCancelButton, 1, 1);
            this.importTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.importTableLayoutPanel.Location = new System.Drawing.Point(3, 21);
            this.importTableLayoutPanel.Name = "importTableLayoutPanel";
            this.importTableLayoutPanel.RowCount = 2;
            this.importTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.importTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.importTableLayoutPanel.Size = new System.Drawing.Size(619, 108);
            this.importTableLayoutPanel.TabIndex = 3;
            // 
            // importSaveButton
            // 
            this.importSaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.importSaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importSaveButton.Location = new System.Drawing.Point(229, 77);
            this.importSaveButton.Name = "importSaveButton";
            this.importSaveButton.Size = new System.Drawing.Size(77, 28);
            this.importSaveButton.TabIndex = 1;
            this.importSaveButton.Text = "Save";
            this.importSaveButton.UseVisualStyleBackColor = true;
            // 
            // importCancelButton
            // 
            this.importCancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.importCancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importCancelButton.Location = new System.Drawing.Point(312, 77);
            this.importCancelButton.Name = "importCancelButton";
            this.importCancelButton.Size = new System.Drawing.Size(77, 28);
            this.importCancelButton.TabIndex = 2;
            this.importCancelButton.Text = "Cancel";
            this.importCancelButton.UseVisualStyleBackColor = true;
            // 
            // summaryPanel
            // 
            this.summaryPanel.Controls.Add(this.summaryGroupBox);
            this.summaryPanel.Location = new System.Drawing.Point(132, 170);
            this.summaryPanel.Name = "summaryPanel";
            this.summaryPanel.Size = new System.Drawing.Size(290, 163);
            this.summaryPanel.TabIndex = 3;
            // 
            // summaryGroupBox
            // 
            this.summaryGroupBox.Controls.Add(this.tableLayoutPanel2);
            this.summaryGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.summaryGroupBox.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.summaryGroupBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.summaryGroupBox.Location = new System.Drawing.Point(0, 0);
            this.summaryGroupBox.Name = "summaryGroupBox";
            this.summaryGroupBox.Size = new System.Drawing.Size(290, 163);
            this.summaryGroupBox.TabIndex = 0;
            this.summaryGroupBox.TabStop = false;
            this.summaryGroupBox.Text = "Summary";
            this.summaryGroupBox.Enter += new System.EventHandler(this.summaryGroupBox_Enter);
            // 
            // transactionListView
            // 
            this.transactionListView.AllowColumnReorder = true;
            this.transactionListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.dateColumnHeader,
            this.typeColumnHeader,
            this.partnerColumnHeader,
            this.categoryColumnHeader,
            this.sumColumnHeader});
            this.tableLayoutPanel2.SetColumnSpan(this.transactionListView, 4);
            this.transactionListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transactionListView.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.transactionListView.FullRowSelect = true;
            this.transactionListView.GridLines = true;
            this.transactionListView.Location = new System.Drawing.Point(3, 57);
            this.transactionListView.Name = "transactionListView";
            this.transactionListView.Size = new System.Drawing.Size(278, 103);
            this.transactionListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.transactionListView.TabIndex = 0;
            this.transactionListView.UseCompatibleStateImageBehavior = false;
            this.transactionListView.View = System.Windows.Forms.View.Details;
            this.transactionListView.SelectedIndexChanged += new System.EventHandler(this.transactionListView_SelectedIndexChanged);
            // 
            // dateColumnHeader
            // 
            this.dateColumnHeader.Text = "Date";
            this.dateColumnHeader.Width = 100;
            // 
            // typeColumnHeader
            // 
            this.typeColumnHeader.Text = "Type";
            this.typeColumnHeader.Width = 100;
            // 
            // partnerColumnHeader
            // 
            this.partnerColumnHeader.Text = "Partner Name";
            this.partnerColumnHeader.Width = 200;
            // 
            // categoryColumnHeader
            // 
            this.categoryColumnHeader.DisplayIndex = 4;
            this.categoryColumnHeader.Text = "Category";
            this.categoryColumnHeader.Width = 100;
            // 
            // sumColumnHeader
            // 
            this.sumColumnHeader.DisplayIndex = 3;
            this.sumColumnHeader.Text = "Sum";
            this.sumColumnHeader.Width = 100;
            // 
            // reportPanel
            // 
            this.reportPanel.Controls.Add(this.reportGroupBox);
            this.reportPanel.Location = new System.Drawing.Point(454, 186);
            this.reportPanel.Name = "reportPanel";
            this.reportPanel.Size = new System.Drawing.Size(334, 158);
            this.reportPanel.TabIndex = 4;
            // 
            // reportGroupBox
            // 
            this.reportGroupBox.Controls.Add(this.tableLayoutPanel1);
            this.reportGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportGroupBox.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.reportGroupBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.reportGroupBox.Location = new System.Drawing.Point(0, 0);
            this.reportGroupBox.Name = "reportGroupBox";
            this.reportGroupBox.Size = new System.Drawing.Size(334, 158);
            this.reportGroupBox.TabIndex = 0;
            this.reportGroupBox.TabStop = false;
            this.reportGroupBox.Text = "Report";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.categoryReport, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.reportDateTime, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 21);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(328, 134);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // categoryReport
            // 
            this.categoryReport.CheckBoxes = true;
            this.tableLayoutPanel1.SetColumnSpan(this.categoryReport, 2);
            this.categoryReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryReport.Location = new System.Drawing.Point(3, 34);
            this.categoryReport.Name = "categoryReport";
            this.categoryReport.Size = new System.Drawing.Size(322, 97);
            this.categoryReport.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selected month";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // reportDateTime
            // 
            this.reportDateTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportDateTime.Location = new System.Drawing.Point(167, 3);
            this.reportDateTime.Name = "reportDateTime";
            this.reportDateTime.Size = new System.Drawing.Size(158, 25);
            this.reportDateTime.TabIndex = 2;
            this.reportDateTime.ValueChanged += new System.EventHandler(this.reportDateTime_ValueChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.Controls.Add(this.transactionListView, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.summaryFromDateTime, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.summaryToDateTime, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 21);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(284, 139);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 54);
            this.label2.TabIndex = 1;
            this.label2.Text = "From";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "To";
            // 
            // summaryFromDateTime
            // 
            this.summaryFromDateTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.summaryFromDateTime.Location = new System.Drawing.Point(31, 3);
            this.summaryFromDateTime.Name = "summaryFromDateTime";
            this.summaryFromDateTime.Size = new System.Drawing.Size(107, 25);
            this.summaryFromDateTime.TabIndex = 3;
            this.summaryFromDateTime.ValueChanged += new System.EventHandler(this.summaryFromDateTime_ValueChanged);
            // 
            // summaryToDateTime
            // 
            this.summaryToDateTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.summaryToDateTime.Location = new System.Drawing.Point(172, 3);
            this.summaryToDateTime.Name = "summaryToDateTime";
            this.summaryToDateTime.Size = new System.Drawing.Size(109, 25);
            this.summaryToDateTime.TabIndex = 4;
            this.summaryToDateTime.ValueChanged += new System.EventHandler(this.summaryToDateTime_ValueChanged);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(919, 71);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            dataPoint1.Label = "my0";
            series1.Points.Add(dataPoint1);
            series1.XValueMember = "gg";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.summaryPanel);
            this.Controls.Add(this.importPanel);
            this.Controls.Add(this.reportPanel);
            this.Controls.Add(this.statusPanel);
            this.Controls.Add(this.menuPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuPanel.ResumeLayout(false);
            this.menuLayoutPanel.ResumeLayout(false);
            this.importPanel.ResumeLayout(false);
            this.importGroupBox.ResumeLayout(false);
            this.importTableLayoutPanel.ResumeLayout(false);
            this.summaryPanel.ResumeLayout(false);
            this.summaryGroupBox.ResumeLayout(false);
            this.reportPanel.ResumeLayout(false);
            this.reportGroupBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel statusPanel;
        private System.Windows.Forms.TableLayoutPanel menuLayoutPanel;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.Button summaryButton;
        private System.Windows.Forms.Panel reportHighlightPanel;
        private System.Windows.Forms.Panel summaryHighlightPanel;
        private System.Windows.Forms.Panel importHighlightPanel;
        private System.Windows.Forms.Panel exitHighlightPanel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Panel importPanel;
        private System.Windows.Forms.Panel summaryPanel;
        private System.Windows.Forms.Panel reportPanel;
        private System.Windows.Forms.GroupBox importGroupBox;
        private System.Windows.Forms.GroupBox summaryGroupBox;
        private System.Windows.Forms.GroupBox reportGroupBox;
        private System.Windows.Forms.ListView transactionListView;
        private System.Windows.Forms.ColumnHeader dateColumnHeader;
        private System.Windows.Forms.ColumnHeader typeColumnHeader;
        private System.Windows.Forms.ColumnHeader partnerColumnHeader;
        private System.Windows.Forms.ColumnHeader sumColumnHeader;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TableLayoutPanel importTableLayoutPanel;
        private System.Windows.Forms.Button importSaveButton;
        private System.Windows.Forms.Button importCancelButton;
        private System.Windows.Forms.ColumnHeader categoryColumnHeader;
        private System.Windows.Forms.TreeView categoryReport;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DateTimePicker reportDateTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker summaryFromDateTime;
        private System.Windows.Forms.DateTimePicker summaryToDateTime;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

