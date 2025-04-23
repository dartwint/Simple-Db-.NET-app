using EmployeesDbApp;
using EmployeesDbApp.DbModel;
using System.Text.RegularExpressions;

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

        private bool HasValidValue(TextBox textBox, Regex? regex = null)
        {
            if (textBox == null) 
                return true;

            if (textBox.Text.Length == 0)
                return false;

            if (regex != null && !regex.IsMatch(textBox.Text))
                return false;

            return true;
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

        //private void OnCRUDOperationStart()
        //{
        //    groupBoxCRUD.Enabled = false;
        //    dataGridView1.ReadOnly = true;
        //}

        //private void OnCRUDOperationFinish()
        //{
        //    groupBoxCRUD.Enabled = true;
        //    dataGridView1.ReadOnly = false;
        //}

        private void buttonReadNRecords_Click(object sender, EventArgs e)
        {
            if (!HasValidValue(textBoxRecordsCount, NumberRegex()))
            {
                MessageBox.Show("You should enter valid records number", "Input validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var records = _dbContext?.Employees.Take(Int32.Parse(textBoxRecordsCount.Text)).ToList();
            dataGridView1.DataSource = records;
        }

        private void buttonReadRecordWithId_Click(object sender, EventArgs e)
        {
            if (!HasValidValue(textBoxIdFilter, NumberRegex()))
            {
                MessageBox.Show("You should enter valid id for search", "Input validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var record = _dbContext?.Employees.Where(e => e.EmployeeID == Int32.Parse(textBoxIdFilter.Text)).ToList();
            dataGridView1.DataSource = record;
        }

        private void buttonAddRecord_Click(object sender, EventArgs e)
        {
            FormEditRecord formEditRecord = new FormEditRecord(FormEditRecord.OperationType.Insert, Employee.CreateDefault());
            formEditRecord.OnOpPerformRequested += OnEditOpPerformRequested;
            formEditRecord.ShowDialog();
        }

        private void buttonUpdateRecord_Click(object sender, EventArgs e)
        {
            if (!HasValidValue(textBoxUpdateId, NumberRegex()))
            {
                MessageBox.Show("You should enter valid id for update", "Input validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Int32.Parse(textBoxUpdateId.Text);
            var record = _dbContext?.Employees.Where(e => e.EmployeeID == id).FirstOrDefault();
            if (record == null)
            {
                MessageBox.Show($"No such record with id = {id} for update", "Update request", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                FormEditRecord formEditRecord = new FormEditRecord(FormEditRecord.OperationType.Update, record);
                formEditRecord.OnOpPerformRequested += OnEditOpPerformRequested;
                formEditRecord.ShowDialog();
            }
        }

        private void buttonDeleteRecord_Click(object sender, EventArgs e)
        {
            if (!HasValidValue(textBoxDeleteId, NumberRegex()))
            {
                MessageBox.Show("You should enter valid id for delete", "Input validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var record = _dbContext?.Employees.Where(e => e.EmployeeID == Int32.Parse(textBoxDeleteId.Text)).FirstOrDefault();
            if (record != null)
            {
                _dbContext?.Employees.Remove(record);
                _dbContext?.SaveChanges();

                ResetDataGridView();
            }
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

        private void ResetDataGridView()
        {
            dataGridView1.DataSource = null;
        }

        private void OnEditOpPerformRequested(object sender, FormEditRecord.OperationType operationType, Employee employee)
        {
            if (sender is FormEditRecord formEditRecord)
            {
                formEditRecord.OnOpPerformRequested -= OnEditOpPerformRequested;
                formEditRecord.Close();
            }

            if (operationType == FormEditRecord.OperationType.Insert)
            {
                _dbContext?.Employees.Add(employee);
            }

            _dbContext?.SaveChanges(true);
        }
    }
}
