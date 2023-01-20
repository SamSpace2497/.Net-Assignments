using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace Assignment4
{
    internal class Question1
    {
        static void Main1()
        {
            Console.WriteLine("Enter No of Batches...");
            int Batches = Convert.ToInt32(Console.ReadLine());
            
            int[][] YCP = new int[Batches][];

            for(int i = 0; i < YCP.Length; i++)
            {
                Console.WriteLine($"Enter No of Students for Batch {i + 1} : ");
                int Students= Convert.ToInt32(Console.ReadLine());
                YCP[i] = new int[Students]; 
                for (int j = 0; j < YCP[i].Length; j++)
                {
                    Console.WriteLine($"Enter Marks for Student {j + 1} : ");
                    int Marks = Convert.ToInt32(Console.ReadLine());
                    YCP[i][j] = Marks;  
                }
                Console.WriteLine(" ");
            }
            
            for(int i = 0; i < YCP.Length; i++)
            {
                Console.WriteLine($"--------------------------Batch {i+1}----------------------------");
                for(int j = 0; j < YCP[i].Length; j++)
                {
                    Console.WriteLine($"\t \t Student {j + 1} has {YCP[i][j]} Marks...");
                }
                Console.WriteLine("-------------------------------------------------------------");
            }

        }
    }
}
