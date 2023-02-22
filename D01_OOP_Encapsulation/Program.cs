using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;


namespace D01_OOP_Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
         Course z= new Course();
         z.ReadCourse();
         z.ListCourse();
         Console.ReadKey();   
         Utility.TerminateConsole();
        }
    }
}
