using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D12_LINQ
{
    public class Name
    {

        // de uma lista generica de strings com 10 nomes linq para retirar retirar todos os numedos = 

        public static List<string> CreateNamesList()
        {
            List<string> names = new List<string>() { "Alice", "Bobo", "Charlie", "Dave", "Emily", "Frank", "Grace", "Harry", "Isabella", "Jack" };
            return names;
        }

        public static void ParseNamesList(List<string> names) 
        {

            List<string> filteredNames = names.Where(n => n.Length > names.Min(x => x.Length)).ToList();

            foreach (string name in filteredNames)
            { 
                Console.WriteLine(name);
            }

        }

        public static void ParseNamesListQuery(List<string> names)
        {

            List<string> filteredNames = (from n in names
                                          where n.Length > (from x in names select x.Length).Min()
                                          select n).ToList();

            foreach (string name in filteredNames)
            {
                Console.WriteLine(name);
            }

        }

    }
}
