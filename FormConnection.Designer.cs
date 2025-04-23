namespace EmployeesDbApp
{
    partial class FormConnection
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
            textBoxHost = new TextBox();
            labelHost = new Label();
            labelPort = new Label();
            tableLayoutPanelConnectionData = new TableLayoutPanel();
            labelUsername = new Label();
            labelPassword = new Label();
            textBoxPassword = new TextBox();
            textBoxUsername = new TextBox();
            textBoxPort = new TextBox();
            buttonResetHost = new Button();
            buttonResetPort = new Button();
            buttonResetUsername = new Button();
            buttonResetPassword = new Button();
            buttonTestConnection = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            labelConnectionStatusTitle = new Label();
            labelConnectionStatus = new Label();
            tableLayoutPanelConnectionData.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxHost
            // 
            textBoxHost.Anchor =  AnchorStyles.Left | AnchorStyles.Right;
            textBoxHost.Location = new Point(126, 22);
            textBoxHost.Name = "textBoxHost";
            textBoxHost.PlaceholderText = "localhost";
            textBoxHost.Size = new Size(277, 23);
            textBoxHost.TabIndex = 0;
            // 
            // labelHost
            // 
            labelHost.AutoSize = true;
            labelHost.Dock = DockStyle.Fill;
            labelHost.Font = new Font("Segoe UI", 11.25F);
            labelHost.Location = new Point(3, 0);
            labelHost.Name = "labelHost";
            labelHost.Size = new Size(117, 68);
            labelHost.TabIndex = 1;
            labelHost.Text = "Host";
            labelHost.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelPort
            // 
            labelPort.AutoSize = true;
            labelPort.Dock = DockStyle.Fill;
            labelPort.Font = new Font("Segoe UI", 11.25F);
            labelPort.Location = new Point(3, 68);
            labelPort.Name = "labelPort";
            labelPort.Size = new Size(117, 133);
            labelPort.TabIndex = 2;
            labelPort.Text = "Port";
            labelPort.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanelConnectionData
            // 
            tableLayoutPanelConnectionData.ColumnCount = 3;
            tableLayoutPanelConnectionData.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.3347282F));
            tableLayoutPanelConnectionData.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.6652756F));
            tableLayoutPanelConnectionData.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 28F));
            tableLayoutPanelConnectionData.Controls.Add(labelPort, 0, 1);
            tableLayoutPanelConnectionData.Controls.Add(textBoxHost, 1, 0);
            tableLayoutPanelConnectionData.Controls.Add(labelHost, 0, 0);
            tableLayoutPanelConnectionData.Controls.Add(labelUsername, 0, 2);
            tableLayoutPanelConnectionData.Controls.Add(labelPassword, 0, 3);
            tableLayoutPanelConnectionData.Controls.Add(textBoxPassword, 1, 3);
            tableLayoutPanelConnectionData.Controls.Add(textBoxUsername, 1, 2);
            tableLayoutPanelConnectionData.Controls.Add(textBoxPort, 1, 1);
            tableLayoutPanelConnectionData.Controls.Add(buttonResetHost, 2, 0);
            tableLayoutPanelConnectionData.Controls.Add(buttonResetPort, 2, 1);
            tableLayoutPanelConnectionData.Controls.Add(buttonResetUsername, 2, 2);
            tableLayoutPanelConnectionData.Controls.Add(buttonResetPassword, 2, 3);
            tableLayoutPanelConnectionData.Location = new Point(3, 3);
            tableLayoutPanelConnectionData.Name = "tableLayoutPanelConnectionData";
            tableLayoutPanelConnectionData.RowCount = 4;
            tableLayoutPanelConnectionData.RowStyles.Add(new RowStyle(SizeType.Percent, 34.0425529F));
            tableLayoutPanelConnectionData.RowStyles.Add(new RowStyle(SizeType.Percent, 65.95744F));
            tableLayoutPanelConnectionData.RowStyles.Add(new RowStyle(SizeType.Absolute, 86F));
            tableLayoutPanelConnectionData.RowStyles.Add(new RowStyle(SizeType.Absolute, 106F));
            tableLayoutPanelConnectionData.Size = new Size(435, 394);
            tableLayoutPanelConnectionData.TabIndex = 3;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Dock = DockStyle.Fill;
            labelUsername.Font = new Font("Segoe UI", 11.25F);
            labelUsername.Location = new Point(3, 201);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(117, 86);
            labelUsername.TabIndex = 3;
            labelUsername.Text = "Username";
            labelUsername.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Dock = DockStyle.Fill;
            labelPassword.Font = new Font("Segoe UI", 11.25F);
            labelPassword.Location = new Point(3, 287);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(117, 107);
            labelPassword.TabIndex = 4;
            labelPassword.Text = "Password";
            labelPassword.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor =  AnchorStyles.Left | AnchorStyles.Right;
            textBoxPassword.Location = new Point(126, 329);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PlaceholderText = "masterkey";
            textBoxPassword.Size = new Size(277, 23);
            textBoxPassword.TabIndex = 7;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Anchor =  AnchorStyles.Left | AnchorStyles.Right;
            textBoxUsername.Location = new Point(126, 232);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.PlaceholderText = "postgres";
            textBoxUsername.Size = new Size(277, 23);
            textBoxUsername.TabIndex = 6;
            // 
            // textBoxPort
            // 
            textBoxPort.Anchor =  AnchorStyles.Left | AnchorStyles.Right;
            textBoxPort.Location = new Point(126, 123);
            textBoxPort.Name = "textBoxPort";
            textBoxPort.PlaceholderText = "5432";
            textBoxPort.Size = new Size(277, 23);
            textBoxPort.TabIndex = 5;
            // 
            // buttonResetHost
            // 
            buttonResetHost.Anchor = AnchorStyles.Left;
            buttonResetHost.BackColor = Color.Transparent;
            buttonResetHost.BackgroundImage = Properties.Resources.ResetImage;
            buttonResetHost.BackgroundImageLayout = ImageLayout.Stretch;
            buttonResetHost.FlatAppearance.BorderSize = 0;
            buttonResetHost.FlatStyle = FlatStyle.Flat;
            buttonResetHost.Location = new Point(409, 22);
            buttonResetHost.Name = "buttonResetHost";
            buttonResetHost.Size = new Size(22, 23);
            buttonResetHost.TabIndex = 8;
            buttonResetHost.UseVisualStyleBackColor = false;
            buttonResetHost.Click += buttonResetHost_Click;
            // 
            // buttonResetPort
            // 
            buttonResetPort.Anchor = AnchorStyles.Left;
            buttonResetPort.BackColor = Color.Transparent;
            buttonResetPort.BackgroundImage = Properties.Resources.ResetImage;
            buttonResetPort.BackgroundImageLayout = ImageLayout.Stretch;
            buttonResetPort.FlatAppearance.BorderSize = 0;
            buttonResetPort.FlatStyle = FlatStyle.Flat;
            buttonResetPort.Image = Properties.Resources.ResetImage;
            buttonResetPort.Location = new Point(409, 123);
            buttonResetPort.Name = "buttonResetPort";
            buttonResetPort.Size = new Size(22, 23);
            buttonResetPort.TabIndex = 9;
            buttonResetPort.UseVisualStyleBackColor = false;
            buttonResetPort.Click += buttonResetPort_Click;
            // 
            // buttonResetUsername
            // 
            buttonResetUsername.Anchor = AnchorStyles.Left;
            buttonResetUsername.BackColor = Color.Transparent;
            buttonResetUsername.BackgroundImage = Properties.Resources.ResetImage;
            buttonResetUsername.BackgroundImageLayout = ImageLayout.Stretch;
            buttonResetUsername.FlatAppearance.BorderSize = 0;
            buttonResetUsername.FlatStyle = FlatStyle.Flat;
            buttonResetUsername.Image = Properties.Resources.ResetImage;
            buttonResetUsername.Location = new Point(409, 232);
            buttonResetUsername.Name = "buttonResetUsername";
            buttonResetUsername.Size = new Size(22, 23);
            buttonResetUsername.TabIndex = 10;
            buttonResetUsername.UseVisualStyleBackColor = false;
            buttonResetUsername.Click += buttonResetUsername_Click;
            // 
            // buttonResetPassword
            // 
            buttonResetPassword.Anchor = AnchorStyles.Left;
            buttonResetPassword.BackColor = Color.Transparent;
            buttonResetPassword.BackgroundImage = Properties.Resources.ResetImage;
            buttonResetPassword.BackgroundImageLayout = ImageLayout.Stretch;
            buttonResetPassword.FlatAppearance.BorderSize = 0;
            buttonResetPassword.FlatStyle = FlatStyle.Flat;
            buttonResetPassword.Image = Properties.Resources.ResetImage;
            buttonResetPassword.Location = new Point(409, 329);
            buttonResetPassword.Name = "buttonResetPassword";
            buttonResetPassword.Size = new Size(22, 23);
            buttonResetPassword.TabIndex = 11;
            buttonResetPassword.UseVisualStyleBackColor = false;
            buttonResetPassword.Click += buttonResetPassword_Click;
            // 
            // buttonTestConnection
            // 
            buttonTestConnection.Anchor =  AnchorStyles.Left | AnchorStyles.Right;
            buttonTestConnection.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point,  204);
            buttonTestConnection.Location = new Point(3, 196);
            buttonTestConnection.Name = "buttonTestConnection";
            buttonTestConnection.Size = new Size(194, 83);
            buttonTestConnection.TabIndex = 5;
            buttonTestConnection.Text = "Save and test connection";
            buttonTestConnection.UseVisualStyleBackColor = true;
            buttonTestConnection.Click += buttonTestConnection_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(tableLayoutPanelConnectionData);
            flowLayoutPanel1.Controls.Add(tableLayoutPanel1);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(652, 413);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(buttonTestConnection, 0, 2);
            tableLayoutPanel1.Controls.Add(labelConnectionStatusTitle, 0, 0);
            tableLayoutPanel1.Controls.Add(labelConnectionStatus, 0, 1);
            tableLayoutPanel1.Location = new Point(444, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 51.8518524F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 48.1481476F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 312F));
            tableLayoutPanel1.Size = new Size(200, 394);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // labelConnectionStatusTitle
            // 
            labelConnectionStatusTitle.Anchor =  AnchorStyles.Left | AnchorStyles.Right;
            labelConnectionStatusTitle.AutoSize = true;
            labelConnectionStatusTitle.Font = new Font("Segoe UI", 12F);
            labelConnectionStatusTitle.Location = new Point(3, 10);
            labelConnectionStatusTitle.Name = "labelConnectionStatusTitle";
            labelConnectionStatusTitle.Size = new Size(194, 21);
            labelConnectionStatusTitle.TabIndex = 6;
            labelConnectionStatusTitle.Text = "Connection status";
            labelConnectionStatusTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelConnectionStatus
            // 
            labelConnectionStatus.Anchor =  AnchorStyles.Left | AnchorStyles.Right;
            labelConnectionStatus.AutoSize = true;
            labelConnectionStatus.Font = new Font("Segoe UI", 12F);
            labelConnectionStatus.Location = new Point(3, 51);
            labelConnectionStatus.Name = "labelConnectionStatus";
            labelConnectionStatus.Size = new Size(194, 21);
            labelConnectionStatus.TabIndex = 7;
            labelConnectionStatus.Text = "none";
            labelConnectionStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormConnection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 413);
            Controls.Add(flowLayoutPanel1);
            Name = "FormConnection";
            Text = "FormConnection";
            Load += FormConnection_Load;
            tableLayoutPanelConnectionData.ResumeLayout(false);
            tableLayoutPanelConnectionData.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelHost;
        private TextBox textBoxHost;
        private Label labelPort;
        private TableLayoutPanel tableLayoutPanelConnectionData;
        private Label labelUsername;
        private Label labelPassword;
        private TextBox textBoxPort;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Button buttonResetHost;
        private Button buttonResetPort;
        private Button buttonResetUsername;
        private Button buttonResetPassword;
        private Button buttonTestConnection;
        private FlowLayoutPanel flowLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label labelConnectionStatusTitle;
        private Label labelConnectionStatus;
    }
}