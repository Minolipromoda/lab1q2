using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 10 numbers");
            for (int i = 0; i <10; i++) 
            {
                Console.WriteLine("\n");
                Console.WriteLine($"eneter number {i+1}:");
                int number = Convert.ToInt32(Console.ReadLine());
                string result = (number % 2 == 0) ? "even " : "odd";
                Console.WriteLine($"the number {number} is { result} ");
            }
        }
    }
}
