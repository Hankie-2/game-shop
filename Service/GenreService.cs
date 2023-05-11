using ShopApplication.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIKitTutorials.Entity;

namespace UIKitTutorials.Service
{
    internal class GenreService
    {
        public Genre GenreById(int id)
        {
            var command = Database.GetCommand("SELECT * FROM genres WHERE id = @id");
            command.Parameters.AddWithValue("@id", NpgsqlTypes.NpgsqlDbType.Integer, id);
            using (var reader = command.ExecuteReader())
            {
                if (reader.Read())
                {

                    var genre = new Genre
                    {
                        Id = reader.GetInt32(reader.GetOrdinal("id")),
                        Name = reader.GetString(reader.GetOrdinal("name"))
                    };
                    return genre;
                }
                reader.Close();
            }

            return null;
        }
    }
}
