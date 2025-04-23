using EmployeesDbApp;
using EmployeesDbApp.DbModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace EmployeesDBApp
{
    public partial class FormMain : Form
    {
        private ApplicationDbContext? _dbContext;

        [GeneratedRegex(@"^(0|[1-9]\d*)$")]
        private static partial Regex NumberRegex();

        [GeneratedRegex(@"^\d*$")]
        private static partial Regex DigitsRegex();

        private bool IsValidInput(TextBox textBox, char input, Regex regex)
        {
            if (char.IsControl(input)) return true;

            string newText = textBox.Text.Insert(textBox.SelectionStart, input.ToString());
            return regex.IsMatch(newText);
        }

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            groupBoxCRUD.Enabled = false;
            dataGridView1.Enabled = false;
            dataGridView1.ReadOnly = true;

            textBoxRecordsCount.Text = "30";
        }

        private void buttonInitialize_Click(object sender, EventArgs e)
        {
            FormConnection formConnection = new FormConnection();
            formConnection.OnConnectionEstablished += OnConnectionEstablished;
            formConnection.ShowDialog();
        }

        private void OnConnectionEstablished(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;

            groupBoxCRUD.Enabled = true;
            dataGridView1.Enabled = true;

            var records = _dbContext?.Employees.Take(0).ToList();
            dataGridView1.DataSource = records;
            dataGridView1.Columns["EmployeeID"].ReadOnly = true;
        }

        private void OnCRUDOperationStart()
        {
            groupBoxCRUD.Enabled = false;
            dataGridView1.ReadOnly = true;
        }

        private void OnCRUDOperationFinish()
        {
            groupBoxCRUD.Enabled = true;
            dataGridView1.ReadOnly = false;
        }

        private void buttonReadNRecords_Click(object sender, EventArgs e)
        {
            if (textBoxRecordsCount.Text.Length == 0)
            {
                MessageBox.Show("You should enter records number", "Input validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!NumberRegex().IsMatch(textBoxRecordsCount.Text))
            {
                MessageBox.Show("You should enter valid number of records", "Input validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var records = _dbContext?.Employees.Take(Int32.Parse(textBoxRecordsCount.Text)).ToList();
            dataGridView1.DataSource = records;
        }

        private void buttonReadRecordWithId_Click(object sender, EventArgs e)
        {
            if (textBoxIdFilter.Text.Length == 0)
            {
                MessageBox.Show("You should enter id", "Input validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!NumberRegex().IsMatch(textBoxIdFilter.Text))
            {
                MessageBox.Show("You should enter valid id", "Input validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var record = _dbContext?.Employees.Where(e => e.EmployeeID == Int32.Parse(textBoxIdFilter.Text)).ToList();
            dataGridView1.DataSource = record;
        }

        private void buttonAddRecord_Click(object sender, EventArgs e)
        {
            FormEditRecord formEditRecord = new FormEditRecord(FormEditRecord.OperationType.Insert);
            formEditRecord.ShowDialog();
        }

        private void buttonUpdateRecord_Click(object sender, EventArgs e)
        {
            FormEditRecord formEditRecord = new FormEditRecord(FormEditRecord.OperationType.Update);
            formEditRecord.ShowDialog();
        }

        private void buttonDeleteRecord_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            _dbContext?.Dispose();
        }

        private void textBoxBlockInvalidKeyPress(object sender, KeyPressEventArgs e)
        {
            if (sender is TextBox tb && !IsValidInput(tb, e.KeyChar, NumberRegex()))
            {
                e.Handled = true;
            }
        }
    }
}
