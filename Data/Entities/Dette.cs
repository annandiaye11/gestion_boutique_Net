using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_boutique_c_.Data.Entities
{
    public class Dette
    {
        public int Id { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public int Montant { get; set; }
        public Client Client { get; set; }
         
    }
}
