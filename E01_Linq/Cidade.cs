using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_Linq
{
    public class Cidade
    {

        public string City { get; set; }
        public string Country { get; set; }
        public Cidade() { }

        public Cidade(string city, string country)
        {
            City = city;
            Country = country;
        }


        public static List<Cidade> CreateCidadesList()
        {
            var cidadesList = new List<Cidade>
            {
                new Cidade("Porto", "Portugal"),
                new Cidade("Londres", "Inglaterra"),
                new Cidade("Paris", "França"),
                new Cidade("Madrid", "Espanha")
            };

            return cidadesList;
        }

        // not using
        public static void GetClientNameAndCountryQuery(Dictionary<int, Cliente> clientDictionary, List<Cidade> cidadesList)
        {
            var clientNameAndCountry = from client in clientDictionary.Values
                                       join cidade in cidadesList on client.City equals cidade.City
                                       select new { ClientName = client.Name, cidade.Country };

            foreach (var item in clientNameAndCountry)
            {
                Console.WriteLine($"{item.ClientName} - {item.Country}");
            }
        }

        public static void GetClientNameAndCountry(Dictionary<int, Cliente> clientDictionary, List<Cidade> cidadesList)
        {
            var clientNameAndCountry = clientDictionary.Values.Join(cidadesList,
                client => client.City,
                cidade => cidade.City,
                (client, cidade) => new { ClientName = client.Name, cidade.Country });

            foreach (var item in clientNameAndCountry)
            {
                Console.WriteLine($"{item.ClientName} - {item.Country}");
            }
        }

    }
}
