using gestion_boutique_c_.Data.Entities;
using Npgsql;

namespace gestion_boutique_c_.Data.Repository.List.Impl
{
    public class ClientRepositoryBdImplt : IClientRepositoryList
    {
        private readonly string connectionString = "Server=localhost;Port=5432;Database=gestion_boutique_net;User ID=app;Password=root;";
        /*
        private readonly string connectionString = "Host=localhost;Port=5432;Database=gestion_boutique_net;Username=app;Password=root;";
        */

         public List<Client> SelectAll()
        {
            List<Client> clients = new List<Client>();
            using ( NpgsqlConnection  conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM client";
                using ( NpgsqlCommand  cmd = new NpgsqlCommand(query, conn))
                {
                    using ( NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var client = new Client
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("id")),
                                Surname = reader.GetString(reader.GetOrdinal("surname")),
                                Telephone = reader.GetString(reader.GetOrdinal("telephone")),
                                Adresse = reader.GetString(reader.GetOrdinal("adresse")),
                            };
                            clients.Add(client);
                        }
                    }
                }
            }

            return clients;
        }

        public Client? SelectById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Client item)
        {
            throw new NotImplementedException();
        }

        public void Insert(Client item)
        {
            using (NpgsqlConnection  conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO client (id, surname, telephone, adresse) VALUES (@id, @surname, @telephone, @adresse)";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", item.Id);
                    cmd.Parameters.AddWithValue("@surname", item.Surname); 
                    cmd.Parameters.AddWithValue("@telephone", item.Telephone);
                    cmd.Parameters.AddWithValue("@adresse", item.Adresse);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Client Inserted");
                    
                }
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Client? FindBySurname(string surname)
        {
            throw new NotImplementedException();
        }
    }
}
