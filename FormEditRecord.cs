using EmployeesDbApp.DbModel;

namespace EmployeesDbApp
{
    public partial class FormEditRecord : Form
    {
        public event Action<object, OperationType, Employee>? OnOpPerformRequested;
        private Employee _record;
        private OperationType _operationType;

        public enum OperationType
        {
            Insert, Update
        }

        public FormEditRecord(OperationType operationType, Employee employee)
        {
            InitializeComponent();

            _record = employee;
            _operationType = operationType;

            switch (operationType)
            {
                case OperationType.Insert:
                    {
                        labelOpTypeName.Text = "INSERT";
                        break;
                    }
                case OperationType.Update:
                    {
                        labelOpTypeName.Text = "UPDATE";
                        break;
                    }
            }
        }

        private void FormEditRecord_Load(object sender, EventArgs e)
        {
            textBoxFirstName.Text = _record.FirstName;
            textBoxLastName.Text = _record.LastName;
            textBoxSalary.Text = _record.Salary.ToString();
            textBoxEmail.Text = _record.Email;
            dateTimePickerDateOfBirth.Value = _record.DateOfBirth.ToDateTime(TimeOnly.MinValue);
        }

        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerDateOfBirth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSalary_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonPerformOp_Click(object sender, EventArgs e)
        {
            _record.FirstName = textBoxFirstName.Text;
            _record.LastName = textBoxLastName.Text;
            _record.Email = textBoxEmail.Text;
            _record.DateOfBirth = DateOnly.FromDateTime(dateTimePickerDateOfBirth.Value);
            _record.Salary = decimal.Parse(textBoxSalary.Text);

            OnOpPerformRequested?.Invoke(this, _operationType, _record);
        }
    }
}
