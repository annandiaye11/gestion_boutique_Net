using gestion_boutique_c_.Data.Entities;
using gestion_boutique_c_.Data.Repository.List;
namespace gestion_boutique_c_.Services.List.Impl
{
    public class DetteServiceImpl : IDetteService
    {

        private readonly IDetteRepositoryList detteRepository;

        public DetteServiceImpl(IDetteRepositoryList dettetRepository) 
        { 
            this.detteRepository = dettetRepository;
        }
        public void Delete(int id)
        {
            detteRepository.Delete(id);
        }

        public List<Dette> FindAll()
        {
            return detteRepository.SelectAll();
        }

        public Dette FindById(int id)
        {
            return detteRepository.SelectById(id)!;
        }

        public void Save(Dette dette)
        {
            detteRepository.Insert(dette);
        }

        public void Update(Dette dette) 
        {
            detteRepository.Update(dette);
        }
    }
}