using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateRPN
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("введите выражение: ");
                try
                {
                    Console.WriteLine(RNP.Calculate(Console.ReadLine()));
                }
                catch
                {
                    Console.WriteLine("Необходимо вводить только числа и арифметические операторы");
                }
            }
        }
    }
}
