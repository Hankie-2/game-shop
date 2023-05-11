using ShopApplication.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIKitTutorials.Entity;

namespace UIKitTutorials.Service
{
    internal class PublisherService
    {
        public Publisher PublisherById(int id)
        {
            var command = Database.GetCommand("SELECT * FROM publishers WHERE id = @id");
            command.Parameters.AddWithValue("@id", NpgsqlTypes.NpgsqlDbType.Integer, id);
            using (var reader = command.ExecuteReader())
            {
                if (reader.Read())
                {

                    var publisher = new Publisher
                    {
                        Id = reader.GetInt32(reader.GetOrdinal("id")),
                        Name = reader.GetString(reader.GetOrdinal("name")),
                        Country = reader.GetString(reader.GetOrdinal("country")),
                        Website = reader.GetString(reader.GetOrdinal("website"))
                    };
                    return publisher;
                }
                reader.Close();
            }

            return null;
        }
    }
}
