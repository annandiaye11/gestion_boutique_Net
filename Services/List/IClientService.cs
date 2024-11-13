
using gestion_boutique_c_.Data.Entities;

namespace gestion_boutique_c_.Services.List
{
    public interface IClientService
    {
        List<Client> FindAll();
        Client FindById(int id);
        void Save(Client client);
        void Delete(int id);
        void Update(Client client); 
        Client? FindBySurname(string surname);

    }
}
