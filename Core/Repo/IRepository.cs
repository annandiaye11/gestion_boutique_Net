using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_boutique_c_.Core.Repo
{
    public interface IRepository <T>
    {
        List<T> SelectAll ();
        T SelectById (int id);
        void Update (T item);
        void Insert (T item);
        void Delete (int id);
    }
}
