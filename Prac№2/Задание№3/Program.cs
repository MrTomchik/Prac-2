using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shifr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Перевод текста в шифр");
            string text = Convert.ToString(Console.ReadLine());
            shifr CaesarCipher = new shifr(text);
            Console.WriteLine(shifr.Encryption(text));
            string crypt = shifr.Encryption(text);
            Console.WriteLine(shifr.Decryption(crypt));
            Console.ReadKey(true);
        }
    }
}
