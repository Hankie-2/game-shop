using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApplication.Entity
{
    internal class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public string Role { get; set; }
        public SqlDecimal Wallet { get; set; }
        public DateTime CreatedAt { get; set; }
        public User() { }

        public User(int id,string name, string username, string password, string role)
        {
            Name = name;
            Id = id;
            Password = password;
            Username = username;
            Role = role;
            CreatedAt = DateTime.Now;
            Wallet = 5000;
        }
        public User(string name,string username, string password, string role) 
        {
            Name = name;
            Password = password;
            Username = username;
            Role = role;
            CreatedAt = DateTime.Now;
            Wallet = 5000;
        }
        public User(string name, string username, string password, DateTime createdAt,SqlDecimal wallet, string role)
        {
            Name = name;
            Password = password;
            Username = username;
            Role = role;
            CreatedAt = DateTime.Now;
            Wallet = 5000;
        }
    }
}
