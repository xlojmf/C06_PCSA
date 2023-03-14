using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D14_AdvancedExtension
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = 10;

            Console.WriteLine(n.MyAdd(2,3));
            Console.WriteLine(n.MySubtract(2));
            Console.WriteLine(n.MyMultiply(2));
            Console.WriteLine(n.MyDivide(2));

            Console.ReadKey();

        }
    }
}
