
using System.Linq;

namespace Assignment5

{
    internal class Question1
    {
        static void Main1()
        {
            SortedList<int, Employee> TCS = new SortedList<int, Employee>();
            
            bool flag = false;
            while (flag != true)
            {
                Console.WriteLine("-----------------------------------------------------------");
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Enter Choice....");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Show Employees");
                Console.WriteLine("3. Highest Salaried Employee");
                Console.WriteLine("4. Show Employee Based on Employee Number");
                Console.WriteLine("5. Show'N'th Employee");
                Console.WriteLine("6. Break ");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("-----------------------------------------------------------");
                int Choice = Convert.ToInt32(Console.ReadLine());
                switch (Choice)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter Employee Key...");
                            int key = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Enter Employee Name...");
                            String? Name = Console.ReadLine();

                            Console.WriteLine("Enter Employee Salary...");
                            decimal Salary = Convert.ToDecimal(Console.ReadLine());

                            
                            TCS.Add(key, new Employee { Name = Name, Salary = Salary });

                        }
                        break;

                    case 2:
                        {
                            foreach (KeyValuePair<int,Employee> employee in TCS)
                            {
                                Console.WriteLine($"-----------------------EMPLOYEE {employee.Key}--------------------------");
                                Console.WriteLine(employee.Value.ToString());
                                Console.WriteLine("-----------------------------------------------------------");
                            }
                            Console.WriteLine(" ");
                        }
                        break;
                    case 3:
                        {
                            decimal highest = 0;
                            Employee temp = new Employee();
                            foreach (KeyValuePair<int, Employee> employee in TCS)
                            {
                                if (highest < employee.Value.Salary)
                                {
                                    highest = employee.Value.Salary;
                                    temp = employee.Value;
                                }
                            }
                            Console.WriteLine("-----------------------------------------------------------");
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine($"Employee With Highest Salary :({temp.EmpNo}-{temp.Name}-Rs.{temp.Salary})");
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.WriteLine("-----------------------------------------------------------");
                        }
                        break;
                    case 4:
                        {
                            Action<int> o1 = (EmpNo) =>
                            {
                                foreach (KeyValuePair<int, Employee> employee in TCS)
                                {
                                    if (employee.Value.EmpNo == EmpNo)
                                    {
                                        Console.WriteLine("-----------------------------------------------------------");
                                        Console.WriteLine($"Employee : {employee.Value.ToString()}");
                                        Console.WriteLine("-----------------------------------------------------------");
                                    }
                                }
                            };
                            Console.WriteLine("Enter Employee Number to search...");
                            int findemp = Convert.ToInt32(Console.ReadLine());
                            o1(findemp);
                        }
                        break;
                    case 5:
                        {
                            Console.WriteLine("Enter Nth Employee to search...");
                            int num = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("-----------------------------------------------------------");
                            Console.WriteLine($"Employee : {TCS.ElementAt(num).ToString()}");
                            Console.WriteLine("-----------------------------------------------------------");
                        }
                        break;
                    case 6:
                        flag = true;
                        break;
                }
            }     
        }
    }
    public class Employee
    {
        private static int index = 0;
        private readonly int empNo;
        public int EmpNo
        {
            get
            {
                return empNo;
            }
        }
        public string? Name
        {
            get; set;
        }
        public decimal Salary
        {
            get;
            set;
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

