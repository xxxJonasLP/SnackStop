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

        public Supplier(int user_id, string first_name, string last_name, string city, int postal_code, string address, string email, int tel)
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
        private int tel;

    }
}
