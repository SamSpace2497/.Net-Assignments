using System.Security.Cryptography;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee obj1= new Employee(1, "Amol", 123456, 10);
            Employee obj2 = new Employee(1, "Amol", 123456);
            Employee obj3 = new Employee(1, "Amol");
            Employee obj4 = new Employee(1);
            Employee obj5 = new Employee();
            Console.WriteLine(obj1.Display());
            Console.WriteLine(obj2.Display());
            Console.WriteLine(obj3.Display());
            Console.WriteLine(obj4.Display());
            Console.WriteLine(obj5.Display());

        }
    }
    public class Employee
    {
        private string? name;
        public string? Name
        {
            set
            {
                if (value == null || value.Length == 0)
                {
                    Name = string.Empty;
                    Console.WriteLine("Invalid Name...");
                }
                else
                {
                    name = value;
                }
            }
            get { return name; }
        }
        private int empNo;
        public int EmpNo
        {
            set
            {
                if (value > 0)
                {
                    empNo = value;
                }
                else
                {
                    Console.WriteLine("Invalid Employee Number...");
                    EmpNo = 101;
                }
            }
            get { return empNo; }
        }
        private decimal basic;
        public decimal Basic
        {
            set
            {
                if(value >= 100000  && value <= 200000)
                {
                    basic = value;
                } else
                {
                    Console.WriteLine("Invalid Basic Salary...");
                    Basic = 100000;
                }
            }
            get { return basic; }
        }
        private short deptNo;
        public short DeptNo
        {
            set
            {
                if(value > 0)
                {
                    deptNo = value;
                } else
                {
                    Console.WriteLine("Invalid Department Number...");
                    DeptNo= 1;
                }
            }
            get { return deptNo; }
        }
        public Employee()
        {
            this.EmpNo = 101;
            this.Name = "Default Name";
            this.Basic = 100000;
            this.DeptNo = 1;
        }
        public Employee(int EmpNo = 101, String Name = "Default Name", decimal Basic = 100000, short DeptNo = 1 )
        {
            this.EmpNo = EmpNo;
            this.Name = Name;
            this.Basic = Basic;         
            this.DeptNo = DeptNo;
        }

        public decimal GetNetSalary(decimal Basic)
        {
            decimal Gross = Basic + 0.17m * Basic + 0.08m * Basic + 0.08m * Basic; //Gross = Basic + HRA + LTA + Special Allowance
            decimal Deductions = 0.05m * Basic + 0.05m * Basic + 0.05m * Basic;        //Deductions = EPF + Tax + Insurance Premium
            return Gross - Deductions;
        }

        public string? Display()
        {
            return " [ EMPNO : " + EmpNo + " NAME : " + Name + " BASIC : " + Basic + " DEPT : " + DeptNo + " ]";
        }
    }
}