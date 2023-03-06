using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D12_LINQ
{
    internal class D01_HelloWord
    {

        public static string[] HelloWorldMethodSyntax() 
        {

            string[] words = new string[]
            {
                "t-sql",
                "hello",
                "wonderfull",
                "linq",
                "beatifull",
                "world"
            };

            var hello1 = from word in words
                         where word.Count() == 5
                         select word.ToUpper();

         

           
            return hello1.ToArray();
        }

        public static string[] HelloWorldMethod() 
        {
            string[] words = new string[]
{
                "t-sql",
                "hello",
                "wonderfull",
                "linq",
                "beatifull",
                "world"
};

            var hello = words.Where(n => n.Count() == 5)
                             .Select(n => n.ToUpper())
                             .OrderByDescending(n => n);

            return hello.ToArray();
        }

        


    }
}
