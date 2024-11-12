using gestion_boutique_c_.Data.Entities;
using gestion_boutique_c_.Data.Repository.List;
namespace gestion_boutique_c_.Services.List.Impl
{
    public class ClientServiceImpl : IClientService
    {

        private readonly IClientRepositoryList clientRepository;

        public ClientServiceImpl(IClientRepositoryList clientRepository) 
        { 
            this.clientRepository = clientRepository;
        }
        public void Delete(int id)
        {
            clientRepository.Delete(id);
        }

        public List<Client> FindAll()
        {
            return clientRepository.SelectAll();
        }

        public Client FindById(int id)
        {
            return clientRepository.SelectById(id);
        }

        public void Save(Client client)
        {
            clientRepository.Insert(client);
        }

        public void Update(Client client)
        {
            clientRepository.Update(client);
        }
    }
}
