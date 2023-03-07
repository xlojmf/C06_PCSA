using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_Linq
{
    public class Cliente
    {

        public string Name { get; set; }
        public string City { get; set; }
        public int Age { get; set; }


        public Cliente() { }

        public Cliente(string name, string city, int age)
        {
            Name = name;
            City = city;
            Age = age;
        }

        public static Dictionary<int, Cliente> CreateClientDictionary()
        {
            Dictionary<int, Cliente> clientDictionary = new Dictionary<int, Cliente>();

            Cliente client1 = new Cliente("Amália", "Porto", 35);
            Cliente client2 = new Cliente("John", "Londres", 35);
            Cliente client3 = new Cliente("Charles", "Londres", 53);
            Cliente client4 = new Cliente("Lucy", "Paris", 21);
            Cliente client5 = new Cliente("Javi", "Madrid", 14);

            clientDictionary.Add(incID(), client1);
            clientDictionary.Add(incID(), client2);
            clientDictionary.Add(incID(), client3);
            clientDictionary.Add(incID(), client4);
            clientDictionary.Add(incID(), client5);

            return clientDictionary;
        }

        private static int clientId = 1;
        private static int incID()
        {
            return clientId++;
        }

        public static List<string> ClientNamesLondres(Dictionary<int, Cliente> clientDictionary)
        {
            return clientDictionary.Values.Where(client => client.City == "Londres").Select(client => client.Name).ToList();
        }

        public static List<string> ClientNamesOr(Dictionary<int, Cliente> clientDictionary)
        {
            return clientDictionary.Values.Where(client => client.City == "Lisboa" || client.City == "Madrid").Select(client => client.Name).ToList(); ;
        }

        public static void OldClients(Dictionary<int, Cliente> clientDictionary)
        {
            List<Cliente> olderClients = clientDictionary.Values.Where(client => client.Age > 18).OrderBy(client => client.Age).ToList();

            foreach (var client in olderClients)
            {
                Console.WriteLine($"{client.Name} - {client.Age}");
            }
        }

        public static void GetNumberOfLondonClients(Dictionary<int, Cliente> clientDictionary)
        {
            int numberOfLondonClients = clientDictionary.Values.Count(client => client.City == "Londres");

            Console.WriteLine($"Número de clientes em Londres é: {numberOfLondonClients}");
        }

        public static void GetYoungestLondonClientName(Dictionary<int, Cliente> clientDictionary)
        {
            string clientName = clientDictionary.Values.Where(client => client.City == "Londres")
                                                        .OrderBy(client => client.Age)
                                                        .Select(client => client.Name)
                                                        .FirstOrDefault() ?? "não encontramos nenhum cliente em londres";

            Console.WriteLine($"Nome do cliente mais novo em Londres é: {clientName}");
        }

        public static void ListForEach(List<string> messages)
        {
            foreach (string message in messages)
            {
                Console.WriteLine(message);
            }

        }

    }
}
