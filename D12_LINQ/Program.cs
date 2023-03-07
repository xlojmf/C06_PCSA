using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace D12_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            string[] ola = D01_HelloWord.HelloWorldMethodSyntax();

            foreach (string n in ola) {
            Console.WriteLine(n);
            }

            string[] ola1 = D01_HelloWord.HelloWorldMethod();

            foreach (string n in ola1)
            {
                Console.WriteLine(n);
            }

            List<string> names= Name.CreateNamesList();
            Name.ParseNamesList(names);
            
            Name.ParseNamesListQuery(names);*/


            List<int> numbers= RandomInts.CreateIntList();
            RandomInts.ListNumbers(numbers);

            Console.ReadKey();

        }
    }
}
