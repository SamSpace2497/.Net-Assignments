

namespace Assignment5
{
    internal class Question2
    {
        static void Main2()
        {
            Employee[] Oracle = new Employee[3];
            Oracle[0] = new Employee("Sam", 1000);
            Oracle[1] = new Employee("Dean", 2000);
            Oracle[2] = new Employee("John", 3000);

            List<Employee> Oracle2 = Oracle.ToList();

            foreach(Employee emp in Oracle2)
            {
                Console.WriteLine($"EMPLOYEE : {emp.EmpNo}-{emp.Name}-{emp.Salary}");
            }   
        }
    }
    public class Question3
    {
        public static void Main() 
        {
            List<Employee> CDAC = new List<Employee>();
            CDAC.Add(new Employee("Sam", 1000));
            CDAC.Add(new Employee("Dean", 2000));
            CDAC.Add(new Employee("John", 3000));

            Employee[] CDAC2 = CDAC.ToArray();

            foreach(Employee emp in CDAC2) 
            {
                Console.WriteLine($"EMPLOYEE : {emp.EmpNo}-{emp.Name}-{emp.Salary}");
            
            }  

        }
    }
}
