using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_boutique_c_.Data.Entities
{
    internal class Dette
    {
<<<<<<< Updated upstream
=======
        public int Id { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public float Montant { get; set; }
        public Client Client { get; set; }

        public override string ToString()
        {
            return $"Dette n°{Id}, du {Date:dd/MM/yyyy} pour {Montant}";
        }
>>>>>>> Stashed changes
    }
}
