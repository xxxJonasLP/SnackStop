using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnackStop
{
    internal class products
    {
        public products() { }

        public products(int product_id, string name, string description, string price, int stock_quanity, int total_purchased, string country_of_origin)
        {
            this.product_id = product_id;
            this.name = name;
            this.description = description;
            this.price = price;
            this.stock_quanity = stock_quanity;
            this.total_purchased = total_purchased;
            this.country_of_origin = country_of_origin;
        }

        private int product_id;
        private string name;
        private string description;
        private string price;
        private int stock_quanity;
        private int total_purchased; //glaube int ist bissn small
        private string country_of_origin;

        public int Product_id { get => product_id; set => product_id = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public string Price { get => price; set => price = value; }
        public int Stock_quanity { get => stock_quanity; set => stock_quanity = value; }
        public int Total_purchased { get => total_purchased; set => total_purchased = value; }
        public string Country_of_origin { get => country_of_origin; set => country_of_origin = value; }
    }
}
