namespace _03._Task_3
{
    class Client
    {
        public string Name { get; set; }
        public string Region { get; set; }
        public string SalesPerson { get; set; }
        public bool VIPclient { get; set; }

        public Client(string name, string region, string salesPerson, bool isVIP)
        {
            Name = name;
            Region = region;
            SalesPerson = salesPerson;
            VIPclient = isVIP;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of clients: ");
            int n = int.Parse(Console.ReadLine());

            List<Client> clients = new List<Client>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Client №{i + 1}:");
                Console.Write("Enter client name: ");
                string name = Console.ReadLine();
                Console.Write("Enter region: ");
                string region = Console.ReadLine();
                Console.Write("Sales Person: ");
                string salesPerson = Console.ReadLine();
                Console.Write("Is client VIP or not? Enter true or false: ");
                bool isVIP = bool.Parse(Console.ReadLine());

                Client client = new Client(name, region, salesPerson, isVIP);
                clients.Add(client);
            }

            Console.WriteLine();
            Console.WriteLine("All clients:");
            foreach (Client client in clients)
            {
                Console.WriteLine($"Name: {client.Name}, Region: {client.Region}, Sales Representative: {client.SalesPerson}, VIP: {client.VIPclient}");
            }

            Console.WriteLine();
            Console.WriteLine("Enter sales person name to see VIP clients:");
            string salesPersonName = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine($"VIP clients for sales person -> {salesPersonName}:");
            foreach (Client client in clients)
            {
                if (client.SalesPerson == salesPersonName && client.VIPclient)
                {
                    Console.WriteLine($"VIP client name: {client.Name}");
                }
            }
        }
    }
}
