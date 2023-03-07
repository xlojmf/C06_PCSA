using D00_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Utility.SetUnicodeConsole();
            Dictionary<int, Cliente> clientes = Cliente.CreateClientDictionary();
            List<Cidade> cities = Cidade.CreateCidadesList();

            Utility.WriteTitle("Clientes Londres");
            Cliente.ListForEach(Cliente.ClientNamesLondres(clientes));
            
            Utility.WriteTitle("Clientes Lisboa ou Madrid");
            Cliente.ListForEach(Cliente.ClientNamesOr(clientes));

            Utility.WriteTitle("Listagem Clientes Nome - Idade");
            Cliente.OldClients(clientes);

            Utility.WriteTitle("Listagem Clientes Nome - Pais");
            Cidade.GetClientNameAndCountry(clientes, cities);

            Utility.WriteTitle("Numero clientes em Londres");
            Cliente.GetNumberOfLondonClients(clientes);

            Utility.WriteTitle("Cliente mais novo em Londres");
            Cliente.GetYoungestLondonClientName(clientes);

            Utility.TerminateConsole();
        }
    }
}
