using D00_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// queue first in first out (fifo)
namespace D08_CollectionsGeneric_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Utility.SetUnicodeConsole();

            Queue<int> callerIds = new Queue<int>();


            for (int i = 0;i < 6; i++)
            {
                callerIds.Enqueue(i);
            }
            callerIds.Enqueue(10);
            callerIds.Enqueue(15);
            
            foreach (int id in callerIds)
                Console.Write(id); //prints 1234...


            // dequeue

            int countInts = callerIds.Count;

            for (int i = 0; i < countInts; i++) { 
                Console.Write(callerIds.Dequeue());             
            }


            Utility.TerminateConsole();

        }

    }
}

