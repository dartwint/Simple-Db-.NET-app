using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeesDbApp.ConnectionSetup;
using EmployeesDBApp;

namespace EmployeesDbApp
{
    public partial class FormConnection : Form
    {
        public event Action<ApplicationDbContext>? OnConnectionEstablished;

        public FormConnection()
        {
            InitializeComponent();
        }

        private void FormConnection_Load(object sender, EventArgs e)
        {
            var config = DbConfigManager.LoadConfig();
            textBoxHost.Text = config.Host;
            textBoxPort.Text = config.Port;
            textBoxUsername.Text = config.User;
            textBoxPassword.Text = config.Password;
        }

        private async void buttonTestConnection_Click(object sender, EventArgs e)
        {
            DbConfigManager.SaveConfig(new DbConfig(textBoxHost.Text, textBoxPort.Text, textBoxUsername.Text, textBoxPassword.Text));

            labelConnectionStatus.Text = "Testing";
            labelConnectionStatus.ForeColor = Color.Blue;

            var dbContext = await ConnectionService.TestDatabaseConnectionAsync();
            if (dbContext != null)
            {
                labelConnectionStatus.Text = "OK";
                labelConnectionStatus.ForeColor = Color.Green;

                OnConnectionEstablished?.Invoke(dbContext);
            }
            else
            {
                labelConnectionStatus.Text = "Error";
                labelConnectionStatus.ForeColor = Color.Red;
            }
        }

        private void buttonResetHost_Click(object sender, EventArgs e)
        {
            textBoxHost.Text = DbConfig.Default.Host;
        }

        private void buttonResetPort_Click(object sender, EventArgs e)
        {
            textBoxPort.Text = DbConfig.Default.Port;
        }

        private void buttonResetUsername_Click(object sender, EventArgs e)
        {
            textBoxUsername.Text = DbConfig.Default.User;
        }

        private void buttonResetPassword_Click(object sender, EventArgs e)
        {
            textBoxPassword.Text = DbConfig.Default.Password;
        }
    }
}
