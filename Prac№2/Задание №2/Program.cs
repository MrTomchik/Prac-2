using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            bool sit = true;
            int chislo = 1;
            Seth set = new Seth(chislo);
            while (sit == true)
            {
                Console.WriteLine("Введите число " + chislo);
                chislo = Convert.ToInt16(Console.ReadLine());
                sit = set.SetNumber(chislo);
                chislo++;
                if (chislo == 0) { chislo = 1; sit = true; }
            }
            Console.ReadKey(true);
        }
    }
}
