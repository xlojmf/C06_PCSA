using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E04_LoginLocalMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string username = LocalMethods.GetData("Insert username");
            string password = LocalMethods.GetData("Insert password");

            LocalMethods.ParentMethod(username, password);

            Console.ReadKey();
        }
    }
}
