using gestion_boutique_c_.Data.Entities;


namespace gestion_boutique_c_.Data.Repository.List.Impl
{
    public class ClientRepositoryListImpl : IClientRepositoryList
    {

        private readonly List<Client> clients = new List<Client>();
        public void Delete(int id)
        {
            Client? clientToRemove = clients.Find(x => x.Id == id);
            if (clientToRemove != null) clients.Remove(clientToRemove);
        }

        public void Insert(Client item)
        {
            clients.Add(item);
        }

        public List<Client> SelectAll()
        {
            return clients;
        }

        public Client SelectById(int id)
        {
            foreach (var client in  clients)
            {
                if (client.Id == id) return client;
            }
            return null;
        }

        public Client? FindBySurname(string surname)
        {
            return clients.Find(cl => cl.Surname.ToLower() == surname.ToLower());
        }

        public void Update(Client item)
        {
            int pos = clients.FindIndex(cl => cl.Id == item.Id);
            if (pos != -1)
                clients[pos] = item;
        }
    }
}
