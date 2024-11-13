using gestion_boutique_c_.Core.Repo;
using gestion_boutique_c_.Data.Entities;

namespace gestion_boutique_c_.Data.Repository.List
{
    public interface IClientRepositoryList : IRepository<Client>
    {
       Client? FindBySurname(string surname);
    }
}
