using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите b");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите c");
            double c = Convert.ToDouble(Console.ReadLine());
            SqEquation Solve = new SqEquation(a, b, c);
            Solve.CalculateRoots();
            Console.ReadKey(true);
        }

    }
}