using ShopApplication.Configuration;
using ShopApplication.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIKitTutorials.Entity;

namespace UIKitTutorials.Service
{
    internal class GameService
    {


        private PublisherService publisherService = new PublisherService();
        private GenreService genreService = new GenreService();
        public Game GameGetById(int id)
        {
            var command = Database.GetCommand("SELECT games.id,games.title, games.description, games.release_date, games.price, publishers.name AS publisher_name, publishers.country AS publisher_country, publishers.website AS publisher_website, genres.name AS genre_name, games.rating\r\nFROM games\r\nJOIN publishers ON games.publisher_id = publishers.id\r\nJOIN genres ON games.genre_id = genres.id WHERE games.id = @id");
            command.Parameters.AddWithValue("@id", NpgsqlTypes.NpgsqlDbType.Integer, id);
            using (var reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    var game = new Game
                    {
                        Id = reader.GetInt32(reader.GetOrdinal("id")),
                        Title = reader.GetString(reader.GetOrdinal("title")),
                        Description = reader.GetString(reader.GetOrdinal("description")),
                        ReleaseDate = reader.GetDateTime(reader.GetOrdinal("release_date")),
                        Price = reader.GetDecimal(reader.GetOrdinal("price")),
                        PusblisherName = reader.GetString(reader.GetOrdinal("publisher_name")),
                        PublisherWebsite = reader.GetString(reader.GetOrdinal("publisher_website")),
                        PublisherCountry = reader.GetString(reader.GetOrdinal("publisher_country")),
                        Genre = reader.GetString(reader.GetOrdinal("genre_name")),
                        Rating = reader.IsDBNull(reader.GetOrdinal("rating")) ? 0 : reader.GetDecimal(reader.GetOrdinal("rating"))
                    };
                    return game;
                }
                reader.Close();
            }

            return null;
        }

        public List<Game> GetAll()
        {
            var command = Database.GetCommand("SELECT games.id,games.title, games.description, games.release_date, games.price, publishers.name AS publisher_name, publishers.country AS publisher_country, publishers.website AS publisher_website, genres.name AS genre_name, games.rating\r\nFROM games\r\nJOIN publishers ON games.publisher_id = publishers.id\r\nJOIN genres ON games.genre_id = genres.id");
            var games = new List<Game>();
            using(var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var game = new Game
                    {
                        Id = reader.GetInt32(reader.GetOrdinal("id")),
                        Title = reader.GetString(reader.GetOrdinal("title")),
                        Description = reader.GetString(reader.GetOrdinal("description")),
                        ReleaseDate = reader.GetDateTime(reader.GetOrdinal("release_date")),
                        Price = reader.GetDecimal(reader.GetOrdinal("price")),
                        PusblisherName = reader.GetString(reader.GetOrdinal("publisher_name")),
                        PublisherWebsite = reader.GetString(reader.GetOrdinal("publisher_website")),
                        PublisherCountry = reader.GetString(reader.GetOrdinal("publisher_country")),
                        Genre = reader.GetString(reader.GetOrdinal("genre_name")),
                        Rating = reader.IsDBNull(reader.GetOrdinal("rating")) ? 0 : reader.GetDecimal(reader.GetOrdinal("rating"))
                    };
                    games.Add(game);
                }
            }
            return games;
        }
    }
}
