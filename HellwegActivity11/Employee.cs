using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellwegActivity11
{
    public class Employee
    {
        public Employee(String Name, String Number)
        {
            EmployeeName = Name;
            EmployeeNumber = Number;
        }

        public Employee()
        {
            EmployeeName = "";
            EmployeeNumber = "0000";
        }


        public String EmployeeName { get; set; }

        public String EmployeeNumber { get; set; }
    }

    public class ProductionWorker : Employee
    {
        public ProductionWorker(String Name, String Number, int Shift, double Pay)
        {
            EmployeeName = Name;
            EmployeeNumber = Number;
            WorkerShift = Shift;
            WorkerPay = Pay;
        }

        public int WorkerShift { get; set; }

        public double WorkerPay { get; set; }

        public String ReturnValue()
        {
            String WorkershiftString = "";
            if(WorkerShift == 1)
            {
                WorkershiftString = "Day Shift";
            } else
            {
                WorkershiftString = "Night Shift";
            }

            return (String.Format("{0} is employee number {1}, and makes {2}$ on the {3}", EmployeeName, EmployeeNumber, WorkerPay, WorkershiftString));
        }

        public String ReturnString { get { return ReturnValue(); } }
    }
}
