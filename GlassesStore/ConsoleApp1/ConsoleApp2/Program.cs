using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input value a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("input value b: ");
            int b = int.Parse(Console.ReadLine());
            say();
            Console.WriteLine("---------------------");
            say10rounds();
            Console.WriteLine("---------------------");
            Console.WriteLine(Plus(a,b));
            Console.WriteLine("---------------------");
            Console.WriteLine(Minus(a,b));
            Console.WriteLine("---------------------");
            Console.WriteLine(Multiply(a,b));
            Console.WriteLine("---------------------");
            Console.WriteLine(Divide(a,b));
            Console.WriteLine("---------------------");
            Console.ReadLine();
        }

        private static int Plus(int a,int b)
        {
            int result = a + b;
            return result;
        }
        private static int Minus(int a, int b)
        {
            int result = a - b;
            return result;
        }
        private static int Multiply(int a, int b)
        {
            int result = a * b;
            return result;
        }
        private static int Divide(int a, int b)
        {
            int result = a / b;
            return result;
        }
        private static void say()
        {
            Console.WriteLine("HI!");
        }
        private static void say10rounds()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("hello world!");
            }

        }
    }
}
