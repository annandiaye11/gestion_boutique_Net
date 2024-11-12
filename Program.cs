using gestion_boutique_c_.Data.Entities;
using gestion_boutique_c_.Data.Repository.List;
using gestion_boutique_c_.Data.Repository.List.Impl;
using gestion_boutique_c_.Services.List;
using gestion_boutique_c_.Services.List.Impl;
using gestion_boutique_c_.Views;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;

internal class Program
{
    private static void Main(string[] args)
    {
        IClientRepositoryList clientRepositoryList = new ClientRepositoryListImpl();
        IClientService clientService = new ClientServiceImpl(clientRepositoryList);

        int choice;
        do
        {
            choice = Menu();
            switch (choice) 
            {
                case 1:
                    Client client = ClientView.CreateClient();
                    clientService.Save(client);
                    break;
                case 2:
                    ClientView.ListClients(clientService.FindAll());
                    break;
                case 3:
                    ClientView.ListClients(clientService.FindAll());
                    Client client1 = clientService.FindById(ClientView.SaisirId());
                    if (client1 != null)
                    {
                        ClientView.UpdateClient(client1);
                        clientService.Update(client1);
                    }
                    break;
                case 4:
                    ClientView.ListClients(clientService.FindAll());
                    Client client2 = clientService.FindById(ClientView.SaisirId());
                    if (client2 != null)
                    {
                        clientService.Delete(client2.Id);
                    }
                    break;
                case 0:
                    Console.WriteLine("Bye-Bye");
                    break;
                default:
                    Console.WriteLine("Choix invalid");
                    break;
            }


        }
        while (choice != 0);

    }

    public static int Menu()
    {
        Console.WriteLine("1. Creer un client");
        Console.WriteLine("2. Afficher tous les clients");
        Console.WriteLine("3. Modifier un client");
        Console.WriteLine("4. Supprimer un clients");
        Console.WriteLine("0. Quitter");
        Console.WriteLine("Faite un choix :");
        return Convert.ToInt32(Console.ReadLine());

    }
}