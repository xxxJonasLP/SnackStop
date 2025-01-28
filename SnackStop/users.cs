using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnackStop
{
    internal class users
    {
        public users() { }

        public users(int user_id, string first_name, string last_name,  string city, int postal_code, string address, string username, string password, string email, string created_at)
        {
            this.user_id = user_id;
            this.first_name = first_name;
            this.last_name = last_name;
            this.city = city;
            this.postal_code = postal_code;
            this.address = address;
            this.username = username;
            this.password = password;
            this.email = email;
            this.created_at = created_at;
        }

        private int user_id;
        private string first_name;
        private string last_name;
        private string city;
        private int postal_code;
        private string address;
        private string username;
        private string password;
        private string email;
        private string created_at;

        public int User_id { get => user_id; set => user_id = value; }
        public string First_name { get => first_name; set => first_name = value; }
        public string Last_name { get => last_name; set => last_name = value; }
        public string City { get => city; set => city = value; }
        public int Postal_code { get => postal_code; set => postal_code = value; }
        public string Address { get => address; set => address = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }
        public string Created_at { get => created_at; set => created_at = value; }
    }
}
