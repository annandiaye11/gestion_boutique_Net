using gestion_boutique_c_.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_boutique_c_.Data.Repository.List.Impl
{
    internal class DetteRepositoryListImpl : IDetteRepositoryList
    {
        private readonly List<Dette> dettes = new List<Dette>();

        public void Delete(int id)
        {
            Dette? detteToRemove = dettes.Find(x => x.Id == id);
            if (detteToRemove != null) dettes.Remove(detteToRemove);
        }

        public void Insert(Dette item)
        {
            dettes.Add(item);
        }

        public List<Dette> SelectAll()
        {
            return dettes;
        }

        public Dette SelectById(int id)
        {
            return dettes.Find(d => d.Id == id)!;
        }

        public void Update(Dette item)
        {
            int pos = dettes.FindIndex(cl => cl.Id == item.Id);
            if (pos != -1)
                dettes[pos] = item;
        }
    }
}
