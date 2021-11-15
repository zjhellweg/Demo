using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HellwegActivity11
{
    public partial class EmployeeForm : Form
    {

        public Dictionary<int, ProductionWorker> Employees = new Dictionary<int, ProductionWorker>();
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void EmployeePayBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void ClearFeilds()
        {
            EmployeeNameBox.Text = "";
            EmployeeNumberBox.Text = "";
            EmployeePayBox.Text = "";
            ShiftBox.Text = "";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (EmployeeNameBox.Text.Equals(""))
            {
                MessageBox.Show("Please Enter a Value into the Name Feild");
                return;
            }

            if (EmployeeNumberBox.Text.Equals(""))
            {
                MessageBox.Show("Please Enter a Value into the Employee Number Feild");
                return;
            }

            if (EmployeePayBox.Text.Equals(""))
            {
                MessageBox.Show("Please Enter a Value into the Employee Pay Feild");
                return;
            }

            if (ShiftBox.Text.Equals("Night Shift") || ShiftBox.Text.Equals("Day Shift"))
            {
                int index = Employees.Count;
                String Name, Number;
                Double Pay = Double.Parse(EmployeePayBox.Text);
                int Shift = 0;
                if(ShiftBox.Text.Equals("Night Shift"))
                {
                    Shift = 2;
                } else
                {
                    Shift = 1;
                }
                Name = EmployeeNameBox.Text;
                Number = EmployeeNumberBox.Text;
                Employees[index] = new ProductionWorker(Name, Number, Shift, Pay);

                Employees[index].ReturnValue();

                EmployeesBox.Items.Clear();
                EmployeesBox.Items.Add("All added Employees");
                for (int i = 0; i < Employees.Count; i++)
                {
                    EmployeesBox.Items.Add(Employees[i].ReturnValue());
                }
                ClearFeilds();

            } 
            else
            {
                MessageBox.Show("Please only use night shift or day shift for the Employee Shift Feild.");
            }
        }
    }
}
