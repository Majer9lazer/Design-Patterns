using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Lesson7.Command
{
    class Calculator
    {
        public void Sum(int a, int b)
        {
            Console.WriteLine("Summing");
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
        }

        public void Minus(int a, int b)
        {
            Console.WriteLine("Minusing");
            Console.WriteLine("{0} + {1} = {2}", a, b, a - b);
        }

        public void Divide(int a, int b)
        {
            Console.WriteLine("Dividing");
            Console.WriteLine("{0} + {1} = {2}", a, b, a / b);
        }

        public void Multiply(int a, int b)
        {
            Console.WriteLine("Multiplying");
            Console.WriteLine("{0} + {1} = {2}", a, b, a * b);
        }

    }
}
