using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApplication.Configuration
{
    internal class Database
    {
        private static DatabaseConfiguration configuration;
        public static NpgsqlConnection connection { get; private set; }

        public static void Connect(DatabaseConfiguration config)
        {
            Reconnect(config);

        }
        public static void Reconnect(DatabaseConfiguration config = null)
        {
            if(config != null)
            {
                configuration = config;
            }
            else
            {
                throw new Exception("Обьект конфигурации не был инициализирован!");
            }

            if(connection != null)
            {
                if(connection.State != System.Data.ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
            connection = new NpgsqlConnection(configuration.GetConnectionString());
            connection.Open();
        }

        public static NpgsqlCommand GetCommand(String sql)
        {
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = connection;
            command.CommandText = sql;
            return command;
        }

    }
}
