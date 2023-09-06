using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public class Operators
    {
        public static void Parcer()
        {
            double sum1 = 0;
            double sum2 = 0;
            double x;
            double y;
            Console.Write("Enter the digit of the initial value of Х?: ");
            double number1 = double.Parse(Console.ReadLine());
            Console.Write("Enter the digit of the final value of x?: ");
            double number2 = double.Parse(Console.ReadLine());

            if (number1 < number2)
            {
                 x = number1;
                 y = number2;
            }
            else
            {
                 x = number2;
                 y = number1;
            }


            for (double i = x; i <= y; i++)
            {
                if (i % 2 == 0)
                {
                    sum1 += i;
                }

                else
                {
                    sum2 += i;
                } 
            }
            Console.WriteLine($" {sum1} even");
            Console.WriteLine($" {sum2} not even ");
        }
    }
}
