using PizzaShared;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace PizzaRepository
{
    public class InventoryRepository : IInventoryRepository
    {
        public async Task<IEnumerable<Inventory>> GetAll()
        {
            List<Inventory> data = new List<Inventory>();
            
            string connection = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=Database;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False";

            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();

                SqlCommand com = new SqlCommand("select * from inventory", con);
                
                using(var reader = await com.ExecuteReaderAsync())
                {
                    while(await reader.ReadAsync())
                    {
                        Inventory i = new Inventory();
                        i.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                        i.Name = reader.GetString(reader.GetOrdinal("Name"));
                        i.Description = reader.GetString(reader.GetOrdinal("Description"));
                        i.Value = reader.GetDecimal(reader.GetOrdinal("Value"));

                        data.Add(i);
                    }
                }

            }

            return data;
        }
    }
}
