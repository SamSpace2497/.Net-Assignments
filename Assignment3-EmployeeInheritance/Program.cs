
namespace assignment3
{
    internal class Program
    {
        static void Main()
        {
            Employee o = new Manager("Shubham", 1, "QC Manager", 15800);
            Console.WriteLine(o.ShowEmp());
            Console.WriteLine($"NETSAL of {o.Name}: {o.GetNetSalary()}");
            Console.WriteLine("---------------------------------------------------------------------");
            Employee o1 = new GeneralManager("Sam", 2, "Deputy General Manager", 17820m, "Extra Leaves");
            Console.WriteLine(o1.ShowEmp());
            Console.WriteLine($"NETSAL of {o1.Name}: {o1.GetNetSalary()}");
            Console.WriteLine("---------------------------------------------------------------------");
            Employee o2 = new CEO("Dean", 3, 20890m);
            Console.WriteLine(o2.ShowEmp());
            Console.WriteLine($"NETSAL of {o2.Name}: {o2.GetNetSalary()}");
        }
    }
    public abstract class Employee
    {
        static private int countEmp;
        private string? name;
        public string? Name
        {
            set
            {
                if (value == null || value.Length == 0)
                {
                    Console.WriteLine("Invalid Name...");
                    throw new InvalidDataException();
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
            get { return empNo; }
        }
        protected decimal basic;
        public abstract decimal Basic
        {
            get;
            set;
        }
        private short deptNo;
        public short DeptNo
        {
            set
            {
                if (value > 0)
                {
                    deptNo = value;
                }
                else
                {
                    Console.WriteLine("Invalid Department Number...");
                    throw new InvalidDataException();
                }
            }
            get { return deptNo; }
        }
        public Employee(String Name = "Default Name", short DeptNo = 1, decimal Basic= 15000)
        {
            countEmp++;
            this.empNo = countEmp;
            this.Name = Name;
            this.DeptNo = DeptNo;
            this.Basic = Basic;
        }
        public abstract decimal GetNetSalary();
        public virtual string? ShowEmp()
        {
            return $"EMPNO : {EmpNo}, NAME : {Name}, DEPT : {DeptNo}";
        }
    }
    public interface IDbFunctions
    {
        void Insert();
        void Update();
        void Delete();
        void Display();
    }
    public class Manager : Employee, IDbFunctions
    {
        private string? designation;
        public string? Designation
        {
            set
            {
                if (value == null || value.Length == 0)
                {
                    Console.WriteLine("Invalid Name...");
                    throw new InvalidDataException();
                }
                else
                {
                    designation = value;
                }
            }
            get { return designation; }
        }
        public override decimal Basic
        {
            set
            {
                if (value >= 15000 && value <= 20000)
                {
                    basic = value;
                }
                else
                {
                    try
                    {
                        throw new InvalidDataException();

                    }
                    catch
                    {
                        Console.WriteLine("Invalid Basic Salary...");
                        basic = 15000;
                    }
                }
            }
            get
            {
                return basic;
            }
        }
        public Manager(String Name = "Default Name", short DeptNo = 1, string Designation = "DGM", decimal Basic = 15000m) : base(Name, DeptNo, Basic)
        {
            this.Designation = Designation;
        }
        
        public override decimal GetNetSalary()
        {
            decimal Gross = Basic + 0.16m * Basic + 0.06m * Basic + 0.06m * Basic;        //Gross = Basic + HRA + LTA + Special Allowance
            decimal Deductions = 0.07m * Basic + 0.07m * Basic + 0.07m * Basic;        //Deductions = EPF + Tax + Insurance Premium
            return Gross - Deductions;
        }
        public override string? ShowEmp()
        {
            return base.ShowEmp() + $", BASE PAY : {Basic}, DESIGNATION : {Designation}";
        }
        public void Insert()
        {
            Console.WriteLine("Managers Insert...");
        }
        public void Update()
        {
            Console.WriteLine("Managers Update...");
        }
        public void Delete()
        {
            Console.WriteLine("Managers Delete...");
        }
        public void Display()
        {
            Console.WriteLine("Managers Display...");
        }
    }
    public class GeneralManager : Manager, IDbFunctions
    {
        public string? Perks
        {
            set; get;
        }
        public override decimal Basic
        {
            set
            {
                Console.WriteLine(value);
                if (value >= 17500m && value <= 20000m)
                {
                    basic = value;
                }
                else
                {
                    try
                    {
                        throw new InvalidDataException();
                    }
                    catch (InvalidDataException)
                    {
                        Console.WriteLine("Invalid Basic Salary...");
                        basic = 17500;
                    }
                }
            }
            get
            {
                return basic;
            }
        }
        public GeneralManager(string Name = "Default Name", short DeptNo = 1, String Designation = "DGM", decimal Basic = 17500m, String Perks = "Free") : base(Name, DeptNo, Designation, Basic)
        { 
            this.Perks = Perks;
        }
        public override decimal GetNetSalary()
        {
            decimal Gross = Basic + 0.17m * Basic + 0.07m * Basic + 0.07m * Basic;        //Gross = Basic + HRA + LTA + Special Allowance
            decimal Deductions = 0.06m * Basic + 0.06m * Basic + 0.06m * Basic;        //Deductions = EPF + Tax + Insurance Premium
            return Gross - Deductions;
        }
        public override string? ShowEmp()
        {
            return base.ShowEmp() + $", PERKS : {Perks} ";
        }
        public new void Insert()
        {
            Console.WriteLine("General Managers Insert...");
        }
        public new void Update()
        {
            Console.WriteLine("General Managers Update...");
        }
        public new void Delete()
        {
            Console.WriteLine("General Managers Delete...");
        }
        public new void Display()
        {
            Console.WriteLine("General Managers Display...");
        }
    }
    public class CEO : Employee, IDbFunctions
    {
        public override decimal Basic
        {
            get { return basic; }
            set
            {
                if (value >= 20000m && value <= 25000m)
                {
                    basic = value;
                }
                else
                {
                    try
                    {
                        throw new InvalidDataException();
                    }
                    catch
                    {
                        Console.WriteLine("Invalid Basic Salary...");
                        basic = 20000;
                    }                  
                }
            }
        }
        public CEO(String Name = "Default Name", short DeptNo = 1, decimal Basic = 20000) : base(Name, DeptNo, Basic)
        {
           
        }
        public sealed override decimal GetNetSalary()
        {
            decimal Gross = Basic + 0.18m * Basic + 0.08m * Basic + 0.08m * Basic;        //Gross = Basic + HRA + LTA + Special Allowance
            decimal Deductions = 0.05m * Basic + 0.05m * Basic + 0.05m * Basic;        //Deductions = EPF + Tax + Insurance Premium
            return Gross - Deductions;
        }
        public override string? ShowEmp()
        {
            return base.ShowEmp() + ($", BASE PAY : {Basic}");
        }
        public void Insert()
        {
            Console.WriteLine("CEO Insert...");
        }
        public void Update()
        {
            Console.WriteLine("CEO Display...");
        }

        public void Delete()
        {
            Console.WriteLine("CEO Delete...");
        }
        public void Display()
        {
            Console.WriteLine("CEO Display...");
        }
    }

}