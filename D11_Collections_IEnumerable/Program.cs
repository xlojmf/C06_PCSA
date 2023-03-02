using D00_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D11_Collections_IEnumerable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();
            
            // tlist
            Console.WriteLine(EvenNumber.CreateEvenNumbersList(4).Count);

            //ienumerable

            EvenNumber lista = new EvenNumber();

            IEnumerable<int> list = lista.CreateEvenIEnumerable(4);

            foreach (int i in list) 
            {
                Console.WriteLine(i);
            }

            Utility.TerminateConsole();
        }
    }
}
