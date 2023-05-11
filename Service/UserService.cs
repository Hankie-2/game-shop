using Npgsql;
using ShopApplication.Configuration;
using ShopApplication.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApplication.Service
{
    internal class UserService
    {
        private readonly NpgsqlConnection _connection;

        public UserService(NpgsqlConnection connection)
        {
            _connection = connection;
        }

        public List<User> GetAll()
        {
            var users = new List<User>();
            var sql = "SELECT * FROM users";
            using (var command = new NpgsqlCommand(sql, _connection))
            {
                _connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var user = new User
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("id")),
                            Name = reader.GetString(reader.GetOrdinal("name")),
                            Username = reader.GetString(reader.GetOrdinal("username")),
                            Password = reader.GetString(reader.GetOrdinal("password")),
                            Role = reader.GetString(reader.GetOrdinal("role")),
                            CreatedAt = reader.GetDateTime(reader.GetOrdinal("created_at")),
                            Wallet = reader.GetDecimal(reader.GetOrdinal("wallet"))
                        };
                        users.Add(user);
                    }
                }
            }
            return users;
        }

        public bool Create(string name,string username, string password)
        {
            var command = Database.GetCommand("INSERT INTO users(name,username,password,created_at,wallet,role) VALUES(@name,@username,@password,now(),5000,'CLIENT')");
            command.Parameters.AddWithValue("@name", NpgsqlTypes.NpgsqlDbType.Varchar, name);
            command.Parameters.AddWithValue("@username", NpgsqlTypes.NpgsqlDbType.Varchar, username);
            command.Parameters.AddWithValue("@password", NpgsqlTypes.NpgsqlDbType.Varchar, password);
            var result = command.ExecuteNonQuery();
            return result == 1;
        }

        public Boolean DeductMoneyById(int id, decimal price)
        {
            Console.WriteLine("Работает метод DeductMoneyById");
            Console.WriteLine("id: " + id.ToString());
            Console.WriteLine("price: " + price.ToString());

            var checkCommand = Database.GetCommand("SELECT wallet >= @price AS enough_money FROM users WHERE id = @id");
            checkCommand.Parameters.AddWithValue("@price", NpgsqlTypes.NpgsqlDbType.Numeric, price);
            checkCommand.Parameters.AddWithValue("@id", NpgsqlTypes.NpgsqlDbType.Integer, id);

            try
            {
                var enoughMoney = (bool)checkCommand.ExecuteScalar();
                Console.WriteLine(enoughMoney);

                if (enoughMoney)
                {
                    var updateCommand = Database.GetCommand("UPDATE users SET wallet = wallet - @price WHERE id = @id");
                    updateCommand.Parameters.AddWithValue("@price", NpgsqlTypes.NpgsqlDbType.Numeric, price);
                    updateCommand.Parameters.AddWithValue("@id", NpgsqlTypes.NpgsqlDbType.Integer, id);

                    var result = updateCommand.ExecuteNonQuery();
                    return result == 1;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка в методе DeductMoneyById: " + ex.Message);
                Console.WriteLine("StackTrace: " + ex.StackTrace);
                return false;
            }
        }



        public User UserGetByUsernameAndPassword(string username, string password)
        {
            var command = Database.GetCommand("SELECT * FROM users WHERE username = @username AND password = @password");
            command.Parameters.AddWithValue("@username", NpgsqlTypes.NpgsqlDbType.Varchar, username);
            command.Parameters.AddWithValue("@password", NpgsqlTypes.NpgsqlDbType.Varchar, password);
            using (var reader = command.ExecuteReader())
            {
                if (reader.Read())
                {

                    var user = new User
                    {
                        Id = reader.GetInt32(reader.GetOrdinal("id")),
                        Name = reader.GetString(reader.GetOrdinal("name")),
                        Username = reader.GetString(reader.GetOrdinal("username")),
                        Password = reader.GetString(reader.GetOrdinal("password")),
                        Role = reader.GetString(reader.GetOrdinal("role")),
                        CreatedAt = reader.GetDateTime(reader.GetOrdinal("created_at")),
                        Wallet = reader.GetDecimal(reader.GetOrdinal("wallet"))
                    };
                    return user;
                }
                reader.Close();
            }

                return null;
        }

        public User UserGetByUsername(string username)
        {
            var command = Database.GetCommand("SELECT * FROM users WHERE username = @username");
            command.Parameters.AddWithValue("@username", NpgsqlTypes.NpgsqlDbType.Varchar, username);
            using (var reader = command.ExecuteReader())
            {
                if (reader.Read())
                {

                    var user = new User
                    {
                        Id = reader.GetInt32(reader.GetOrdinal("id")),
                        Name = reader.GetString(reader.GetOrdinal("name")),
                        Username = reader.GetString(reader.GetOrdinal("username")),
                        Password = reader.GetString(reader.GetOrdinal("password")),
                        Role = reader.GetString(reader.GetOrdinal("role")),
                        CreatedAt = reader.GetDateTime(reader.GetOrdinal("created_at")),
                        Wallet = reader.GetDecimal(reader.GetOrdinal("wallet"))
                    };
                    return user;
                }
                reader.Close();
            }
            
            return null;
        }

    }
}
