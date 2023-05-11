using ShopApplication.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIKitTutorials.Entity;

namespace UIKitTutorials.Service
{
    internal class PurchaseService
    {
        public List<Purchase> GetAllById(int id)
        {
            var command = Database.GetCommand("SELECT p.id, g.title as title, g.price as price, p.purchase_date as date, p.game_id " +
                "FROM purchases p " +
                "JOIN games g ON g.id = p.game_id " +
                "WHERE p.user_id = @id");
            command.Parameters.AddWithValue("@id", NpgsqlTypes.NpgsqlDbType.Integer, id);

            var purchases = new List<Purchase>();
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var purchase = new Purchase
                    {
                        Id = reader.GetInt32(reader.GetOrdinal("id")),
                        Title = reader.GetString(reader.GetOrdinal("title")),
                        PurchaseDate = reader.GetDateTime(reader.GetOrdinal("date")),
                        Price = reader.GetDecimal(reader.GetOrdinal("price")),
                        GameId = reader.GetInt32(reader.GetOrdinal("game_id"))
                    };
                    purchases.Add(purchase);
                }
            }
            return purchases;
        }

        public bool Create(int userId, int gameId)
        {
            var command = Database.GetCommand("INSERT INTO purchases(user_id,game_id,purchase_date) VALUES(@user,@game,@date)");
            command.Parameters.AddWithValue("@user", NpgsqlTypes.NpgsqlDbType.Integer, userId);
            command.Parameters.AddWithValue("@game", NpgsqlTypes.NpgsqlDbType.Integer, gameId);
            command.Parameters.AddWithValue("@date", NpgsqlTypes.NpgsqlDbType.Date, DateTime.Now);
            var result = command.ExecuteNonQuery();
            return result == 1;
        }
        public List<Purchase> GetAll()
        {
            using (var command = Database.GetCommand("SELECT p.id, g.title as title, g.price as price, p.purchase_date as date, p.game_id " +
                "FROM purchases p " +
                "JOIN games g ON g.id = p.game_id"))
            {
                var purchases = new List<Purchase>();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var purchase = new Purchase
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("id")),
                            Title = reader.GetString(reader.GetOrdinal("title")),
                            PurchaseDate = reader.GetDateTime(reader.GetOrdinal("date")),
                            Price = reader.GetDecimal(reader.GetOrdinal("price")),
                            GameId = reader.GetInt32(reader.GetOrdinal("game_id"))
                        };
                        purchases.Add(purchase);
                    }
                }
                return purchases;
            }
        }
    }
}
