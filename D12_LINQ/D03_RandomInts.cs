using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D12_LINQ
{
    internal class RandomInts
    {

        public static List<int> CreateIntList()
        {
            List<int> randomList = new List<int>();
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                int randomNumber = random.Next(0, 51);
                randomList.Add(randomNumber);
            }

            return randomList;
        }

        public static void ListNumbers(List<int> randomList)
        {
            var biggerThanTen = randomList.Where(num => num >= 10);

            foreach (var number in biggerThanTen)
            {
                Console.WriteLine(number);
            }
        }



    }
}
