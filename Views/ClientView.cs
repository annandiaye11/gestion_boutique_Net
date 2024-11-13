using gestion_boutique_c_.Data.Entities;
using System.Globalization;
using System.IO.Pipes;

namespace gestion_boutique_c_.Views
{
    public abstract class ClientView
    {

        public static void ListClients(List<Client> clients) 
        {
            foreach (var client in clients) 
            {
                Console.WriteLine(client);
            }
        }

        public static void ListDetteClients(Client client)
        {
            foreach (var dette in client.Dettes)
            {
                Console.WriteLine(dette);
            }
        }

        public static Client CreateClient()
        {
            Console.Write("Surname : ");
            string surname = Console.ReadLine()!;
            Console.Write("Tel : ");
            string tel = Console.ReadLine()!;
            Console.Write("Adresse : ");
            string adresse = Console.ReadLine()!;
            Client client = new() { Surname = surname, Telephone = tel, Adresse = adresse };
                do
                {
                    // ajouter une dette au client
                    Console.Write("Voulez vous  ajouter une dette au client ? (o/n) ");
                    string answer = Console.ReadLine()!;
                if (answer.ToLower() == "o")
                {
                    float montant;
                    do
                    {

                        Console.Write("Le montant de la dette : ");
                        montant = float.Parse(Console.ReadLine()!);
                        if (montant <= 0)
                        {
                            Console.WriteLine("Montant invalide");
                        }
                    }
                    while (montant <= 0);
                    Dette dette = new()
                    {
                        Montant = montant,
                    };
                    client.AddDette(dette);
                }
                else
                {
                    break;
                }
            }
            while (true);
            return client;
        }

        public static void UpdateClient(Client client) 
        {
            Console.Write("Nouveau surname : ");
            string newSurname = Console.ReadLine();
            Console.Write("Noubeau telephone : ");
            string newTel = Console.ReadLine();
            Console.Write("Nouvelle adresse : ");
            string newAdresse = Console.ReadLine();
            client.Surname = newSurname;
            client.Telephone = newTel;
            client.Adresse = newAdresse;
            Console.WriteLine("Le client a été modifié.");
        }
        public static int DeleteClient() 
        { 
            Console.Write("Voulez vous  supprimer un client ? (o/n) " );
            string answer = Console.ReadLine();
            if (answer.ToLower() == "o") 
            {
                Console.Write("Entrez l'id du client à supprimer :");
                return Convert.ToInt32(Console.ReadLine());
            }
            return 0;
        }

        public static int SaisirId()
        {
            Console.WriteLine("Id du client ?");
            return Convert.ToInt32(Console.ReadLine());
        }
        
       
    }
}
