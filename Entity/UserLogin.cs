using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApplication.Entity
{
    internal class UserLogin
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public string Role { get; set; }
        public SqlDecimal Wallet { get; set; }
        public DateTime CreatedAt { get; set; }

        private static UserLogin user;
        
        private UserLogin(int id, string name,string password,string username,string role,SqlDecimal wallet,DateTime createdAt)
        {
            this.Id = id;  
            this.Name = name;
            this.Password = password;
            this.Username = username;
            this.Role = role;
            this.Wallet = wallet;
            this.CreatedAt = createdAt;
        }

        public static UserLogin Instance(int id, string name, string password, string username, string role, SqlDecimal wallet, DateTime createdAt)
        {
            if(user == null)
            {
                user = new UserLogin(id,name,password,username,role,wallet,createdAt);
            }
            return user;
        }
        public static void resetInfo()
        {
            user = null;
        }
        public static UserLogin getUser()
        {
            return user;
        }

    }
}
