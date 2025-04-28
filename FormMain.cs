using EmployeesDbApp;
using EmployeesDbApp.DbModel;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace EmployeesDBApp
{
    public partial class FormMain : Form
    {
        private ApplicationDbContext? _dbContext;

        private ContextMenuStrip? _contextMenuStrip1;

        private BindingList<Employee> _employeesBList;

        [GeneratedRegex(@"^(0|[1-9]\d*)$")]
        private static partial Regex NumberRegex();

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

            _employeesBList = new BindingList<Employee>();

            InitializeContextMenu();
        }

        private void InitializeContextMenu()
        {
            _contextMenuStrip1 = new ContextMenuStrip();
            _contextMenuStrip1.Items.Add("Delete", null, DeleteItem_Click);

            dataGridView1.ContextMenuStrip = _contextMenuStrip1;
        }

        private void DeleteItem_Click(object? sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = (Employee) dataGridView1.SelectedRows[0].DataBoundItem;
                _employeesBList.Remove(selectedRow);
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            groupBoxCRUD.Enabled = false;
            dataGridView1.Enabled = false;
            buttonAddRow.Enabled = false;
            buttonSaveChangesToDb.Enabled = false;
            dataGridView1.AllowUserToAddRows = false;

            textBoxRecordsCount.Text = "30";

            dataGridView1.ContextMenuStrip = _contextMenuStrip1;
        }

        private void buttonSaveChangesToDb_Click(object sender, EventArgs e)
        {
            if (_dbContext == null)
                return;

            try
            {
                dataGridView1.EndEdit();

                _dbContext.SaveChanges();

                MessageBox.Show("Changes saved successfully.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while saving changes:\n{ex.Message}", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hit = dataGridView1.HitTest(e.X, e.Y);
                if (hit.RowIndex >= 0)
                {
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[hit.RowIndex].Selected = true;
                    dataGridView1.CurrentCell = dataGridView1.Rows[hit.RowIndex].Cells[0];
                }
            }
        }

        private void buttonAddRow_Click(object sender, EventArgs e)
        {
            if (_dbContext == null)
                return;

            var newEmployee = Employee.CreateDefault();
            _employeesBList.Add(newEmployee);

            int rowIndex = dataGridView1.Rows.Count - 1;
            if (rowIndex >= 0)
            {
                dataGridView1.CurrentCell = dataGridView1.Rows[rowIndex].Cells[0];
                dataGridView1.BeginEdit(true);
            }
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
            buttonAddRow.Enabled = true;
            buttonSaveChangesToDb.Enabled = true;

            _dbContext?.Employees.Load();
            var data = _dbContext?.Employees.Local.ToBindingList();
            if (data != null)
            {
                _employeesBList = data;
                dataGridView1.DataSource = _employeesBList;
            }

            dataGridView1.Columns["EmployeeID"].ReadOnly = true;
        }

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

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_dbContext != null && _dbContext.ChangeTracker.HasChanges())
            {
                var result = MessageBox.Show(
                    "There are unsaved changes. Do you really want to exit without saving?",
                    "Unsaved Changes",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].DataPropertyName is not string propertyName)
                return;

            var employeeType = typeof(Employee);
            var property = employeeType.GetProperty(propertyName);
            if (property == null)
                return;

            var value = e.FormattedValue?.ToString();

            // Check [Required]
            var requiredAttribute = property.GetCustomAttributes(typeof(RequiredAttribute), true).FirstOrDefault();
            if (requiredAttribute != null && string.IsNullOrWhiteSpace(value))
            {
                dataGridView1.Rows[e.RowIndex].ErrorText = $"{propertyName} is required.";
                e.Cancel = true;
                return;
            }

            // Check [MaxLength]
            var maxLengthAttribute = property.GetCustomAttributes(typeof(MaxLengthAttribute), true).FirstOrDefault() as MaxLengthAttribute;
            if (maxLengthAttribute != null && value != null && value.Length > maxLengthAttribute.Length)
            {
                dataGridView1.Rows[e.RowIndex].ErrorText = $"{propertyName} must be at most {maxLengthAttribute.Length} characters.";
                e.Cancel = true;
                return;
            }

            // Validate data types
            if (property.PropertyType == typeof(decimal))
            {
                if (!decimal.TryParse(value, out _))
                {
                    dataGridView1.Rows[e.RowIndex].ErrorText = $"{propertyName} must be a decimal number.";
                    e.Cancel = true;
                    return;
                }
            }
            else if (property.PropertyType == typeof(DateOnly))
            {
                if (!DateOnly.TryParse(value, out var date))
                {
                    dataGridView1.Rows[e.RowIndex].ErrorText = $"{propertyName} must be a valid date.";
                    e.Cancel = true;
                    return;
                }

                if (date > DateOnly.FromDateTime(DateTime.Today))
                {
                    dataGridView1.Rows[e.RowIndex].ErrorText = $"{propertyName} cannot be in the future.";
                    e.Cancel = true;
                    return;
                }
            }
            else if (property.PropertyType == typeof(int))
            {
                if (!int.TryParse(value, out _))
                {
                    dataGridView1.Rows[e.RowIndex].ErrorText = $"{propertyName} must be an integer.";
                    e.Cancel = true;
                    return;
                }
            }

            dataGridView1.Rows[e.RowIndex].ErrorText = "";
        }
    }
}
