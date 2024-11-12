
using gestion_boutique_c_.Data.Entities;

namespace gestion_boutique_c_.Services.List
{
    public interface IDetteService
    {
        List<Dette> FindAll();
        Dette FindById(int id);
        void Save(Dette dette);
        void Delete(int id);
        void Update(Dette dette); 

    }
}
