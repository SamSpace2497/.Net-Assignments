using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class Question2
    {
        static void Main()
        {
            Console.WriteLine("Enter No of Employees...");
            int TotalEmp = Convert.ToInt32(Console.ReadLine());
            Employee[] employees = new Employee[TotalEmp];

            for (int i = 0; i < employees.Length; i++)                          //Add Employees In Array
            {
                employees[i] = new Employee();

                Console.WriteLine("Enter Employee Name...");
                employees[i].Name = Console.ReadLine();

                Console.WriteLine("Enter Employee Salary...");
                employees[i].Salary = Convert.ToDecimal(Console.ReadLine());

            }
            foreach (Employee employee in employees)                          //Display Employees From Array
            {
                Console.WriteLine($"-----------------------EMPLOYEE {employee.EmpNo}--------------------------");
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine(employee.ToString());
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("-----------------------------------------------------------");

            }
            Console.WriteLine(" ");

            //Employee With Highest Sal With 2 For Loops
            /*decimal highest = 0;                                               
            for (int i = 0; i < employees.Length; i++)
            {
                if (highest < employees[i].Salary)
                {
                    highest = employees[i].Salary;
                }
            }
            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i].Salary == highest)
                {

                    Console.WriteLine("-----------------------------------------------------------");
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"Employee With Highest Salary :({employees[i].EmpNo}-{employees[i].Name}-Rs.{employees[i].Salary})");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine("-----------------------------------------------------------");
                }
            }*/

            //Finding highest sal using Variable declared in Employee Class
            /*for (int i = 0; i < employees.Length; i++)                              
            {
                if (employees[i].Salary == Employee.highest)
                {

                    Console.WriteLine("-----------------------------------------------------------");
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"Employee With Highest Salary :({employees[i].EmpNo}-{employees[i].Name}-Rs.{employees[i].Salary})");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine("-----------------------------------------------------------");
                }
            }*/

            //Finding Highest sal using single for loop
            decimal highest = 0;                                              
            Employee temp = new Employee();
            for (int i = 0; i < employees.Length; i++)
            {
                if (highest < employees[i].Salary)
                {
                    highest = employees[i].Salary;
                    temp = employees[i];
                }
            }
            Console.WriteLine("-----------------------------------------------------------");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"Employee With Highest Salary :({temp.EmpNo}-{temp.Name}-Rs.{temp.Salary})");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("-----------------------------------------------------------");

            //Finding Employee through employee number by using Delegate
            Action<int> o1 = (EmpNo) =>                                       
            {
                for (int i = 0; i < employees.Length; i++)
                {
                    if (employees[i].EmpNo == EmpNo)
                    {
                        Console.WriteLine("-----------------------------------------------------------");
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine($"Employee :{employees[i].EmpNo}-{employees[i].Name}-Rs.{employees[i].Salary}");
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.WriteLine("-----------------------------------------------------------");
                    }
                }
            };
            o1(2);
        }
    }
    public class Employee
    {
        private static int index = 0;
        private readonly int empNo;
        //public static decimal highest = 0;
        public int EmpNo
        {
            get
            {
                return empNo;
            }
        }
        public string Name
        {
            get; set;
        }
        private decimal salary;
        public decimal Salary
        {
            get { return salary; }
            set
            {
                salary = value;
                /*if (highest < salary)
                {
                    highest = Salary;
                }*/
            }
        }
        public Employee(String Name = "No Name", decimal Salary = 0)
        {
            index++;
            empNo = index;
            this.Name = Name;
            this.Salary = Salary;
        }
        public override String ToString()
        {
            return $"EMPLOYEE : {EmpNo}, NAME : {Name}, SALARY : Rs.{Salary}";
        }
    }
}

