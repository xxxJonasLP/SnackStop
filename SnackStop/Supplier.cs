using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnackStop
{
    internal class Supplier
    {
        public Supplier() { }

        public Supplier(int user_id, string first_name, string last_name, string city, int postal_code, string address, string email, string tel)
        {
            this.user_id = user_id;
            this.first_name = first_name;
            this.last_name = last_name;
            this.city = city;
            this.postal_code = postal_code;
            this.address = address;
            this.email = email;
            this.tel = tel;
        }

        private int user_id;
        private string first_name;
        private string last_name;
        private string city;
        private int postal_code;
        private string address;
        private string email;
        private string tel;

        public int User_id { get => user_id; set => user_id = value; }
        public string First_name { get => first_name; set => first_name = value; }
        public string Last_name { get => last_name; set => last_name = value; }
        public string City { get => city; set => city = value; }
        public int Postal_code { get => postal_code; set => postal_code = value; }
        public string Address { get => address; set => address = value; }
        public string Email { get => email; set => email = value; }
        public string Tel { get => tel; set => tel = value; }
    }
}
