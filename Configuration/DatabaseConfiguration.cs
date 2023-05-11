using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;
using Newtonsoft.Json;

namespace ShopApplication.Configuration
{
    internal class DatabaseConfiguration
    {
        private string fileName = "./app.json";
        public String host { get; set; }
        public String port { get; set; }
        public String username { get; set; }
        public String databaseName { get; set; }
        public String databasePassword { get; set; }
    
        public DatabaseConfiguration(String fileName = "./app.json") 
        {
            this.fileName = fileName;
            try {

                FileStream file = File.OpenRead(fileName);
                if(file != null)
                {
                    
                    byte[] bytes = new byte[file.Length+1];
                    int fileBytes = file.Read(bytes, 0, bytes.Length);
                    file.Close();

                    if(fileBytes == 0 || bytes.Length != fileBytes)
                    {
                        Default();
                        Save();
                        return;
                    }
                    DatabaseConfiguration conf = JsonConvert.DeserializeObject<DatabaseConfiguration>(Encoding.Default.GetString(bytes));
                    if(conf!= null) { 
                        host= conf.host;
                        port= conf.port;
                        username= conf.username;
                        databaseName= conf.databaseName;
                        databasePassword= conf.databasePassword;
                    }
                    else
                    {
                        MessageBox.Show("Файл конфигурации имеет неверный формат", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                    }
                }
                else
                {
                    Default();
                    Save();
                }
            }catch(Exception e)
            {
                MessageBox.Show(e.Message,"Внимание!", MessageBoxButton.OK,MessageBoxImage.Error);
                Default();
                Save();
            }

        }
        private void Default()
        {
            host = "127.0.0.1";
            port = "5432";
            username = "postgres";
            databasePassword = "root";
            databaseName = "game-shop";
        }

        private void Save()
        {
            try
            {
                string jsonObject = JsonConvert.SerializeObject(this);
                byte[] bytes = Encoding.Default.GetBytes(jsonObject);
                FileStream file = File.OpenWrite(fileName);
                file.Write(bytes,0,bytes.Length);
                file.Close();
            }catch(Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public string GetConnectionString()
        {
            return string.Format(
                "Server={0};Port={1};User Id={2};Password={3};Database={4}", host, port, username, databasePassword, databaseName);
        }

    }
}
