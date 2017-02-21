//PEGUEI ESTE EXEMPLO EM:
//I GOT THIS EXAMPLE IN:
//http://msdn.microsoft.com/pt-br/library/system.configuration.configurationmanager.connectionstrings.aspx
//https://msdn.microsoft.com/en-us/library/system.configuration.configurationmanager.connectionstrings.aspx
//... mas alterei um pouco...
//... but I changed a little ...

//NOTA: É preciso que o "app.config" esteja INCLUÍDO no projeto. Para saber isto, basta ver se o ícone aparece como um folha branca ou 
//      se está colorido (com linhas e uma bolinha parecendo um planetinha Terra).
//'NOTE: The "app.config" must be INCLUDED in the project. To know this, just see if the icon appears as a white sheet or 
//      if it Is colored (with lines And a ball looking Like a planet Earth).

using System;
using System.Configuration;

namespace ConnectionStringsConsoleC
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadConnectionStrings();
            Console.ReadKey();
        }

        /// <summary>
        /// Pega a seção ConnectionStrings.    
        /// Get the ConnectionStrings section.    
        /// Esta função utiliza os ConnectionStrings.
        /// This function uses ConnectionStrings.
        /// Propriedade para ler os connectionStrings.
        /// Propriedade para ler os connectionStrings.
        /// Seção de configuração.
        /// Configuration section.
        /// </summary>
        public static void ReadConnectionStrings()
        {
            // Pega a seção ConnectionStrings.
            // Get the ConnectionStrings section.
            ConnectionStringSettingsCollection connections = ConfigurationManager.ConnectionStrings;
            // Mostrando somente UMA conexão ["Desenvolvimento"]
            // Showing only ONE connection ("Development")
            ConnectionStringSettings connections1 = ConfigurationManager.ConnectionStrings["Desenvolvimento"];
            // -> Depois experimente colocar um nome ERRADO de propósito:
            // -> Then try putting a Wrong Name on purpose:
            //ConnectionStringSettings connections1 = ConfigurationManager.ConnectionStrings["Desenvolvimento1"];

            if (connections1 != null)
            {
            Console.WriteLine();
            Console.WriteLine("SOMENTE UMA CONEXÃO - ONLY ONE CONNECTION: ");
            Console.WriteLine("Nome - Name:       {0}", connections1.Name);
            Console.WriteLine("String de Conexão: {0}", connections1.ConnectionString);
            Console.WriteLine("Nome do Provedor:  {0}", connections1.ProviderName);
            Console.WriteLine();
            Console.WriteLine("---------------------------------------");
            }

            if (connections.Count != 0)
            {
                Console.WriteLine();
                Console.WriteLine("Using the ConnectionStrings Property.");
                Console.WriteLine("Strings de conexão - Connection Strings:");
                Console.WriteLine();

                // Pega os elementos da coleção.
                foreach (ConnectionStringSettings connection in connections)
                {
                    string name = connection.Name;
                    string provider = connection.ProviderName;
                    string connectionString = connection.ConnectionString;

                    Console.WriteLine("Nome - Name:       {0}", name);
                    Console.WriteLine("Connection String: {0}", connectionString);
                    Console.WriteLine("Provider:          {0}", provider);
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("No connection string is defined. - No connection string is defined.");
                Console.WriteLine();
            }
        }
    }
}