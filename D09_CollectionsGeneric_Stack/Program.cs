using D00_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// stack lifo Last In First Out
namespace D09_CollectionsGeneric_Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utility.SetUnicodeConsole();

            Stack<int> myStack = new Stack<int>();

            for (int i = 0; i < 6; i++)
            {
                myStack.Push(i);
            }
            myStack.Push(10);
            myStack.Push(15);

            foreach (int item in myStack) { 
                Console.Write(item + ",");
            }

            int count = myStack.Count;

            for (int i = 0;i < count; i++)
            {
                Console.Write(myStack.Pop());              
            }


            Utility.TerminateConsole();

        }
    }
}
