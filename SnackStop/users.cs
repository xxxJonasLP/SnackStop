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

        public users(int user_id, string first_name, string last_name, string straße, string city, int postal_code, string address, string username, string password, string email, string created_at)
        {
            this.user_id = user_id;
            this.first_name = first_name;
            this.last_name = last_name;
            this.straße = straße;
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
        private string straße;
        private string city;
        private int postal_code;
        private string address;
        private string username;
        private string password;
        private string email;
        private string created_at;

    }
}
