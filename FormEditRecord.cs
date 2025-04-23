using EmployeesDbApp.DbModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeesDbApp
{
    public partial class FormEditRecord : Form
    {
        public event Action<Employee>? OnOpPerformRequested;

        public enum OperationType
        {
            Insert, Update
        }

        public FormEditRecord(OperationType operationType)
        {
            InitializeComponent();

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
            OnOpPerformRequested?.Invoke(new Employee()
            {
                FirstName = textBoxFirstName.Text,
                LastName = textBoxLastName.Text,
                Email = textBoxEmail.Text,
                DateOfBirth = DateOnly.FromDateTime(dateTimePickerDateOfBirth.Value),
                Salary = decimal.Parse(textBoxSalary.Text)
            });
        }
    }
}
