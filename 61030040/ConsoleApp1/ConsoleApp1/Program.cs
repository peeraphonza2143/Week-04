using System;
namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {

          
                Console.Write("Name :");
                string val1 = Convert.ToString(Console.ReadLine());
                Console.Write("ID :");
                string val2 = Convert.ToString(Console.ReadLine());
                Console.Write("GPA :");
                string val3 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Name : {0}",val1);
            Console.WriteLine("ID : {0}",val2);
            Console.WriteLine("GPA : {0}",val3);
            Console.ReadKey();
           
        }
    }
}