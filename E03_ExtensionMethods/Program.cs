using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E03_ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string textForContact01 = "C";
            string textForContact02 = "Ola";

            Console.WriteLine(textForContact01.ConcaterParaMaiusculas("Sharp"));
            Console.WriteLine(textForContact02.ConcaterParaMaiusculas("Milena"));

            int n = 2;
            string x = "10";
            Console.WriteLine(n.FormatarParaEuro());
            Console.WriteLine(x.FormatarParaEuro());

            Console.ReadKey();

        }
    }
}
