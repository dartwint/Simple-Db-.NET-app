namespace EmployeesDBApp
{
    partial class FormMain
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
            buttonInitialize = new Button();
            dataGridView1 = new DataGridView();
            groupBoxCRUD = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            buttonUpdateRecord = new Button();
            textBoxUpdateId = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            buttonDeleteRecord = new Button();
            textBoxDeleteId = new TextBox();
            splitContainer1 = new SplitContainer();
            flowLayoutPanel1 = new FlowLayoutPanel();
            buttonReadNRecords = new Button();
            labelReadRecordsNPart1 = new Label();
            textBoxRecordsCount = new TextBox();
            labelReadRecordsNPart2 = new Label();
            labelReadOpMisc = new Label();
            textBoxIdFilter = new TextBox();
            buttonReadRecordWithId = new Button();
            buttonAddRecord = new Button();
            labelDataPreview = new Label();
            ((System.ComponentModel.ISupportInitialize) dataGridView1).BeginInit();
            groupBoxCRUD.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonInitialize
            // 
            buttonInitialize.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point,  204);
            buttonInitialize.Location = new Point(281, 12);
            buttonInitialize.Name = "buttonInitialize";
            buttonInitialize.Size = new Size(126, 43);
            buttonInitialize.TabIndex = 0;
            buttonInitialize.Text = "Configure connection";
            buttonInitialize.UseVisualStyleBackColor = true;
            buttonInitialize.Click += buttonInitialize_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(234, 118);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(706, 483);
            dataGridView1.TabIndex = 2;
            // 
            // groupBoxCRUD
            // 
            groupBoxCRUD.Controls.Add(tableLayoutPanel1);
            groupBoxCRUD.Font = new Font("Segoe UI", 10F);
            groupBoxCRUD.Location = new Point(12, 24);
            groupBoxCRUD.Name = "groupBoxCRUD";
            groupBoxCRUD.Size = new Size(192, 583);
            groupBoxCRUD.TabIndex = 7;
            groupBoxCRUD.TabStop = false;
            groupBoxCRUD.Text = "CRUD opearations";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 3);
            tableLayoutPanel1.Controls.Add(splitContainer1, 0, 0);
            tableLayoutPanel1.Controls.Add(buttonAddRecord, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 21);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 67.31302F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 32.68698F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 97F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(186, 559);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(buttonUpdateRecord, 0, 0);
            tableLayoutPanel3.Controls.Add(textBoxUpdateId, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 364);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 36.17021F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 63.82979F));
            tableLayoutPanel3.Size = new Size(180, 94);
            tableLayoutPanel3.TabIndex = 10;
            // 
            // buttonUpdateRecord
            // 
            buttonUpdateRecord.Dock = DockStyle.Fill;
            buttonUpdateRecord.Location = new Point(3, 3);
            buttonUpdateRecord.Name = "buttonUpdateRecord";
            buttonUpdateRecord.Size = new Size(174, 28);
            buttonUpdateRecord.TabIndex = 3;
            buttonUpdateRecord.Text = "Update";
            buttonUpdateRecord.UseVisualStyleBackColor = true;
            buttonUpdateRecord.Click += buttonUpdateRecord_Click;
            // 
            // textBoxUpdateId
            // 
            textBoxUpdateId.Anchor =  AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxUpdateId.Location = new Point(3, 37);
            textBoxUpdateId.Name = "textBoxUpdateId";
            textBoxUpdateId.PlaceholderText = "Employee ID";
            textBoxUpdateId.Size = new Size(174, 25);
            textBoxUpdateId.TabIndex = 9;
            textBoxUpdateId.KeyPress += textBoxBlockInvalidKeyPress;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(buttonDeleteRecord, 0, 0);
            tableLayoutPanel2.Controls.Add(textBoxDeleteId, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 464);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 43.47826F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 56.52174F));
            tableLayoutPanel2.Size = new Size(180, 92);
            tableLayoutPanel2.TabIndex = 9;
            // 
            // buttonDeleteRecord
            // 
            buttonDeleteRecord.Anchor =  AnchorStyles.Left | AnchorStyles.Right;
            buttonDeleteRecord.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point,  204);
            buttonDeleteRecord.Location = new Point(3, 6);
            buttonDeleteRecord.Name = "buttonDeleteRecord";
            buttonDeleteRecord.Size = new Size(174, 28);
            buttonDeleteRecord.TabIndex = 4;
            buttonDeleteRecord.Text = "Delete";
            buttonDeleteRecord.UseVisualStyleBackColor = true;
            buttonDeleteRecord.Click += buttonDeleteRecord_Click;
            // 
            // textBoxDeleteId
            // 
            textBoxDeleteId.Anchor =  AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxDeleteId.Location = new Point(3, 43);
            textBoxDeleteId.Name = "textBoxDeleteId";
            textBoxDeleteId.PlaceholderText = "Employee ID";
            textBoxDeleteId.Size = new Size(174, 25);
            textBoxDeleteId.TabIndex = 5;
            textBoxDeleteId.KeyPress += textBoxBlockInvalidKeyPress;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(flowLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(textBoxIdFilter);
            splitContainer1.Panel2.Controls.Add(buttonReadRecordWithId);
            splitContainer1.Size = new Size(180, 226);
            splitContainer1.SplitterDistance = 119;
            splitContainer1.TabIndex = 9;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(buttonReadNRecords);
            flowLayoutPanel1.Controls.Add(labelReadRecordsNPart1);
            flowLayoutPanel1.Controls.Add(textBoxRecordsCount);
            flowLayoutPanel1.Controls.Add(labelReadRecordsNPart2);
            flowLayoutPanel1.Controls.Add(labelReadOpMisc);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(180, 119);
            flowLayoutPanel1.TabIndex = 12;
            // 
            // buttonReadNRecords
            // 
            buttonReadNRecords.AutoSize = true;
            buttonReadNRecords.Dock = DockStyle.Fill;
            buttonReadNRecords.Location = new Point(3, 3);
            buttonReadNRecords.Name = "buttonReadNRecords";
            buttonReadNRecords.Size = new Size(177, 29);
            buttonReadNRecords.TabIndex = 5;
            buttonReadNRecords.Text = "Read";
            buttonReadNRecords.UseVisualStyleBackColor = true;
            buttonReadNRecords.Click += buttonReadNRecords_Click;
            // 
            // labelReadRecordsNPart1
            // 
            labelReadRecordsNPart1.Anchor =  AnchorStyles.Left | AnchorStyles.Right;
            labelReadRecordsNPart1.AutoSize = true;
            labelReadRecordsNPart1.Font = new Font("Segoe UI", 9F);
            labelReadRecordsNPart1.Location = new Point(3, 35);
            labelReadRecordsNPart1.Name = "labelReadRecordsNPart1";
            labelReadRecordsNPart1.Size = new Size(177, 15);
            labelReadRecordsNPart1.TabIndex = 11;
            labelReadRecordsNPart1.Text = "first";
            labelReadRecordsNPart1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBoxRecordsCount
            // 
            textBoxRecordsCount.Location = new Point(3, 53);
            textBoxRecordsCount.Name = "textBoxRecordsCount";
            textBoxRecordsCount.PlaceholderText = "number of records";
            textBoxRecordsCount.Size = new Size(174, 25);
            textBoxRecordsCount.TabIndex = 9;
            textBoxRecordsCount.KeyPress += textBoxBlockInvalidKeyPress;
            // 
            // labelReadRecordsNPart2
            // 
            labelReadRecordsNPart2.AutoSize = true;
            labelReadRecordsNPart2.Dock = DockStyle.Fill;
            labelReadRecordsNPart2.Font = new Font("Segoe UI", 9F);
            labelReadRecordsNPart2.Location = new Point(3, 81);
            labelReadRecordsNPart2.Name = "labelReadRecordsNPart2";
            labelReadRecordsNPart2.Size = new Size(177, 15);
            labelReadRecordsNPart2.TabIndex = 10;
            labelReadRecordsNPart2.Text = "records";
            labelReadRecordsNPart2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelReadOpMisc
            // 
            labelReadOpMisc.AutoSize = true;
            labelReadOpMisc.Dock = DockStyle.Fill;
            labelReadOpMisc.Location = new Point(3, 96);
            labelReadOpMisc.Name = "labelReadOpMisc";
            labelReadOpMisc.Size = new Size(177, 19);
            labelReadOpMisc.TabIndex = 9;
            labelReadOpMisc.Text = "OR";
            labelReadOpMisc.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxIdFilter
            // 
            textBoxIdFilter.Location = new Point(3, 43);
            textBoxIdFilter.Name = "textBoxIdFilter";
            textBoxIdFilter.PlaceholderText = "Employee ID";
            textBoxIdFilter.Size = new Size(174, 25);
            textBoxIdFilter.TabIndex = 8;
            textBoxIdFilter.KeyPress += textBoxBlockInvalidKeyPress;
            // 
            // buttonReadRecordWithId
            // 
            buttonReadRecordWithId.Location = new Point(3, 3);
            buttonReadRecordWithId.Name = "buttonReadRecordWithId";
            buttonReadRecordWithId.Size = new Size(174, 34);
            buttonReadRecordWithId.TabIndex = 10;
            buttonReadRecordWithId.Text = "Read with Id";
            buttonReadRecordWithId.UseVisualStyleBackColor = true;
            buttonReadRecordWithId.Click += buttonReadRecordWithId_Click;
            // 
            // buttonAddRecord
            // 
            buttonAddRecord.Anchor =  AnchorStyles.Left | AnchorStyles.Right;
            buttonAddRecord.Location = new Point(3, 288);
            buttonAddRecord.Name = "buttonAddRecord";
            buttonAddRecord.Size = new Size(180, 28);
            buttonAddRecord.TabIndex = 2;
            buttonAddRecord.Text = "Create";
            buttonAddRecord.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonAddRecord.UseVisualStyleBackColor = true;
            buttonAddRecord.Click += buttonAddRecord_Click;
            // 
            // labelDataPreview
            // 
            labelDataPreview.AutoSize = true;
            labelDataPreview.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point,  204);
            labelDataPreview.Location = new Point(515, 83);
            labelDataPreview.Name = "labelDataPreview";
            labelDataPreview.Size = new Size(173, 25);
            labelDataPreview.TabIndex = 8;
            labelDataPreview.Text = "Employees preview";
            labelDataPreview.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 658);
            Controls.Add(labelDataPreview);
            Controls.Add(groupBoxCRUD);
            Controls.Add(dataGridView1);
            Controls.Add(buttonInitialize);
            Name = "FormMain";
            Text = "FormMain";
            FormClosed += FormMain_FormClosed;
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize) dataGridView1).EndInit();
            groupBoxCRUD.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonInitialize;
        private DataGridView dataGridView1;
        private GroupBox groupBoxCRUD;
        private Button buttonAddRecord;
        private Button buttonUpdateRecord;
        private Button buttonDeleteRecord;
        private TableLayoutPanel tableLayoutPanel1;
        private Button buttonReadNRecords;
        private Label labelReadRecordsNPart2;
        private Label labelReadRecordsNPart1;
        private FlowLayoutPanel flowLayoutPanel1;
        private SplitContainer splitContainer1;
        private Button buttonReadRecordWithId;
        private Label labelReadOpMisc;
        private TextBox textBoxRecordsCount;
        private TextBox textBoxIdFilter;
        private Label labelDataPreview;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox textBoxDeleteId;
        private TableLayoutPanel tableLayoutPanel3;
        private TextBox textBoxUpdateId;
    }
}
