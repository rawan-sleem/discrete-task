
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perfect_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //read two numbers
            Console.WriteLine("please enter number1:");
            int number1=int.Parse(Console.ReadLine());

            Console.WriteLine("please enter number2:");
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("perfect number"+number1+"&"+number2);

            for (int i = number1; i <= number2; i++)
            {
                int sum = 0;
                for (int r = 1; r < i; r++)
                {
                    if (i % r == 0)
                        sum = sum + r;
                }
                if (sum==i)
                    Console.WriteLine(i);

                
            }
        }

    }
}
