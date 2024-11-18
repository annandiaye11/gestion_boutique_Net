
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_boutique_c_.Data.Entities
{

    public class Client
    {
        private int id;
        private string surname;
        private String telephone;
        private String adresse;
        private static int count;

        public Client()
        {
            count++;
            id = count;
        }
        public int Id { get => id; set => id = value; }
        public  string Surname { get => surname; set => surname = value; }
        public string Telephone { get => telephone; set => telephone = value; }
        public string Adresse { get => adresse; set => adresse = value; }

        public List<Dette> Dettes { get; } = new List<Dette>();
        public void AddDette( Dette dette)
        {
            Dettes.Add(dette);
            dette.Id = Dettes.Count;
            dette.Client = this;
        }
        public override string ToString()
        {
            return "Client[" + 
                "id=" + id + 
                ", surnom='" + surname + '\'' + 
                ", telephone='" + telephone + '\'' +
                ", adresse='" + adresse + ']';
        }
    }


}
