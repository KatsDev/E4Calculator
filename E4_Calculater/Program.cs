using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4_Calculater
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter amount of numbers to sum:");
            int numToSum = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            string newSum = "";
            int i = 0;
            StringCalculator SC = new StringCalculator();
            do
            {
                Console.WriteLine("Enter a number:");
                newSum = Console.ReadLine();
                if (newSum.Contains("-"))
                {
                    Console.WriteLine("Enter a number:");
                }
                else
                {
                    sum = sum + SC.Add(newSum.ToString());
                    Console.WriteLine(sum);
                }
                i++;
            } while (i < numToSum);
            Console.ReadKey();
        }
    }
}
