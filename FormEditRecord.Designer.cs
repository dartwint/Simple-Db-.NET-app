namespace EmployeesDbApp
{
    partial class FormEditRecord
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
            dateTimePickerDateOfBirth = new DateTimePicker();
            labelDateOfBirth = new Label();
            labelFirstName = new Label();
            labelLastName = new Label();
            labelSalary = new Label();
            labelEmail = new Label();
            textBoxFirstName = new TextBox();
            textBoxLastName = new TextBox();
            textBoxEmail = new TextBox();
            textBoxSalary = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            buttonPerformOp = new Button();
            labelOpTypeTitle = new Label();
            labelOpTypeName = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dateTimePickerDateOfBirth
            // 
            dateTimePickerDateOfBirth.Anchor =  AnchorStyles.Left | AnchorStyles.Right;
            dateTimePickerDateOfBirth.Location = new Point(125, 183);
            dateTimePickerDateOfBirth.Name = "dateTimePickerDateOfBirth";
            dateTimePickerDateOfBirth.Size = new Size(248, 23);
            dateTimePickerDateOfBirth.TabIndex = 0;
            dateTimePickerDateOfBirth.ValueChanged += dateTimePickerDateOfBirth_ValueChanged;
            // 
            // labelDateOfBirth
            // 
            labelDateOfBirth.AutoSize = true;
            labelDateOfBirth.Dock = DockStyle.Fill;
            labelDateOfBirth.Font = new Font("Segoe UI", 9.75F);
            labelDateOfBirth.Location = new Point(3, 156);
            labelDateOfBirth.Name = "labelDateOfBirth";
            labelDateOfBirth.Size = new Size(116, 77);
            labelDateOfBirth.TabIndex = 1;
            labelDateOfBirth.Text = "Date of birth";
            labelDateOfBirth.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Dock = DockStyle.Fill;
            labelFirstName.Font = new Font("Segoe UI", 9.75F);
            labelFirstName.Location = new Point(3, 0);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(116, 78);
            labelFirstName.TabIndex = 2;
            labelFirstName.Text = "First name";
            labelFirstName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Dock = DockStyle.Fill;
            labelLastName.Font = new Font("Segoe UI", 9.75F);
            labelLastName.Location = new Point(3, 78);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(116, 78);
            labelLastName.TabIndex = 3;
            labelLastName.Text = "Last name";
            labelLastName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelSalary
            // 
            labelSalary.AutoSize = true;
            labelSalary.Dock = DockStyle.Fill;
            labelSalary.Font = new Font("Segoe UI", 9.75F);
            labelSalary.Location = new Point(3, 306);
            labelSalary.Name = "labelSalary";
            labelSalary.Size = new Size(116, 79);
            labelSalary.TabIndex = 4;
            labelSalary.Text = "Salary";
            labelSalary.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Dock = DockStyle.Fill;
            labelEmail.Font = new Font("Segoe UI", 9.75F);
            labelEmail.Location = new Point(3, 233);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(116, 73);
            labelEmail.TabIndex = 5;
            labelEmail.Text = "Email";
            labelEmail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Anchor =  AnchorStyles.Left | AnchorStyles.Right;
            textBoxFirstName.Location = new Point(125, 27);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(248, 23);
            textBoxFirstName.TabIndex = 6;
            textBoxFirstName.TextChanged += textBoxFirstName_TextChanged;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Anchor =  AnchorStyles.Left | AnchorStyles.Right;
            textBoxLastName.Location = new Point(125, 105);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(248, 23);
            textBoxLastName.TabIndex = 7;
            textBoxLastName.TextChanged += textBoxLastName_TextChanged;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Anchor =  AnchorStyles.Left | AnchorStyles.Right;
            textBoxEmail.Location = new Point(125, 258);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(248, 23);
            textBoxEmail.TabIndex = 8;
            textBoxEmail.TextChanged += textBoxEmail_TextChanged;
            // 
            // textBoxSalary
            // 
            textBoxSalary.Anchor =  AnchorStyles.Left | AnchorStyles.Right;
            textBoxSalary.Location = new Point(125, 334);
            textBoxSalary.Name = "textBoxSalary";
            textBoxSalary.Size = new Size(248, 23);
            textBoxSalary.TabIndex = 9;
            textBoxSalary.TextChanged += textBoxSalary_TextChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.4468079F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67.55319F));
            tableLayoutPanel1.Controls.Add(labelFirstName, 0, 0);
            tableLayoutPanel1.Controls.Add(textBoxSalary, 1, 4);
            tableLayoutPanel1.Controls.Add(textBoxFirstName, 1, 0);
            tableLayoutPanel1.Controls.Add(labelSalary, 0, 4);
            tableLayoutPanel1.Controls.Add(textBoxEmail, 1, 3);
            tableLayoutPanel1.Controls.Add(labelLastName, 0, 1);
            tableLayoutPanel1.Controls.Add(labelEmail, 0, 3);
            tableLayoutPanel1.Controls.Add(textBoxLastName, 1, 1);
            tableLayoutPanel1.Controls.Add(labelDateOfBirth, 0, 2);
            tableLayoutPanel1.Controls.Add(dateTimePickerDateOfBirth, 1, 2);
            tableLayoutPanel1.Location = new Point(12, 66);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 77F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 73F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 79F));
            tableLayoutPanel1.Size = new Size(376, 385);
            tableLayoutPanel1.TabIndex = 10;
            // 
            // buttonPerformOp
            // 
            buttonPerformOp.Location = new Point(137, 473);
            buttonPerformOp.Name = "buttonPerformOp";
            buttonPerformOp.Size = new Size(136, 51);
            buttonPerformOp.TabIndex = 11;
            buttonPerformOp.Text = "Perform opearation";
            buttonPerformOp.UseVisualStyleBackColor = true;
            buttonPerformOp.Click += buttonPerformOp_Click;
            // 
            // labelOpTypeTitle
            // 
            labelOpTypeTitle.AutoSize = true;
            labelOpTypeTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point,  204);
            labelOpTypeTitle.Location = new Point(58, 29);
            labelOpTypeTitle.Name = "labelOpTypeTitle";
            labelOpTypeTitle.Size = new Size(117, 21);
            labelOpTypeTitle.TabIndex = 12;
            labelOpTypeTitle.Text = "Operation type:";
            labelOpTypeTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelOpTypeName
            // 
            labelOpTypeName.AutoSize = true;
            labelOpTypeName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point,  204);
            labelOpTypeName.Location = new Point(231, 29);
            labelOpTypeName.Name = "labelOpTypeName";
            labelOpTypeName.Size = new Size(101, 21);
            labelOpTypeName.TabIndex = 13;
            labelOpTypeName.Text = "<typename>";
            labelOpTypeName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormEditRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 536);
            Controls.Add(labelOpTypeName);
            Controls.Add(labelOpTypeTitle);
            Controls.Add(buttonPerformOp);
            Controls.Add(tableLayoutPanel1);
            Name = "FormEditRecord";
            Text = "FormEditRecord";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePickerDateOfBirth;
        private Label labelDateOfBirth;
        private Label labelFirstName;
        private Label labelLastName;
        private Label labelSalary;
        private Label labelEmail;
        private TextBox textBoxFirstName;
        private TextBox textBoxLastName;
        private TextBox textBoxEmail;
        private TextBox textBoxSalary;
        private TableLayoutPanel tableLayoutPanel1;
        private Button buttonPerformOp;
        private Label labelOpTypeTitle;
        private Label labelOpTypeName;
    }
}