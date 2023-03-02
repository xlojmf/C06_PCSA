using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D11_Collections_IEnumerable
{
    public class EvenNumber
    {

        public static IList<int> CreateEvenNumbersList(int quantity) 
        {

            List<int> evenNumbersList = new List<int>(quantity);

            int currentNumber = 0;

                while(evenNumbersList.Count <= quantity) 
                {
                    if( ++currentNumber % 2 == 0) { 
                    evenNumbersList.Add(currentNumber);
                    }
                }              

            return evenNumbersList;
        
        }



        public  IEnumerable<int> CreateEvenIEnumerable(int quantity) 
        {

            int currentNumber = 0;

            while(++currentNumber <= quantity)
            {
                if (currentNumber %2==0) 
                {
                    yield return currentNumber; // mostra o proximo valor  da iteração
                }
            }


            
        }

    }
}
