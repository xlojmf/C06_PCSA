using D00_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace D10_CollectionsGeneric_Dictornary
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Utility.SetUnicodeConsole();

            var cities = new Dictionary<string, string>(){
            {"UK", "London, Manchester, Birmingham"},
             {"USA", "Chicago, New York, Washington"},
             {"India", "Mumbai, New Delhi, Pune"}
            };
            
            Console.WriteLine(cities["UK"]); //prints value of UK key
            Console.WriteLine(cities["USA"]);//prints value of USA key
                                             //Console.WriteLine(cities["France"]); // run-time exception: Key does not exist

            //use ContainsKey() to check for an unknown key
            if (cities.ContainsKey("France"))
            {
                Console.WriteLine(cities["France"]);
            }

            //use TryGetValue() to get a value of unknown key
            string result;

            if (cities.TryGetValue("France", out result))
            {
                Console.WriteLine(result);
            }

            //use ElementAt() to retrieve key-value pair using index
            for (int i = 0; i < cities.Count; i++)
            {
                Console.WriteLine("Key: {0}, Value: {1}",
                                                        cities.ElementAt(i).Key,
                                                        cities.ElementAt(i).Value);
            }


            // key / value
            // A01N01 - Armazem Producao
            // A02S12 - Armazem Qualidade

            #region Dictionary: criar e inserir os valores iniciais
            Dictionary<string, string> listCountries = new Dictionary<string, string>()
            {
                {"PT", "Portugal"},
                {"ES", "Espanha"},
                {"BR", "Brasil"},
                {"VE", "Venezuela"}
            };

            listCountries.Add("MZ", "Moçambique");


            #endregion

            #region Dictionary: listar
            Listar(listCountries);
            #endregion

            #region Dictionary: pesquisar chave
            string key = "AN";

            #endregion
            Inserir(listCountries, key);

            Listar(listCountries);

            Utility.TerminateConsole();

        }

        static void Listar(Dictionary<string, string> listCountries)
        {
            /*
            for (int i = 0; i < listCountries.Count; i++)
            {
                Console.WriteLine($"Key: {listCountries.ElementAt(i).Key}, Value: {listCountries.ElementAt(i).Value}");
            }
            */

            foreach (KeyValuePair<string, string> item in listCountries)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }

        }

        static void Inserir(Dictionary<string, string> listCountries, string key)
        {
            if (!listCountries.ContainsKey(key))
            {               
                listCountries.Add(key, "Bulgaria");
            }

            //string newvalue= key.ToUpper() + "01";
        }

    }
}
