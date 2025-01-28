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

        public products(int product_id, string name, string description, string price, int stock_quanity, int total_purchased)
        {
            this.product_id = product_id;
            this.name = name;
            this.description = description;
            this.price = price;
            this.stock_quanity = stock_quanity;
            this.total_purchased = total_purchased;
        }

        private int product_id;
        private string name;
        private string description;
        private string price;
        private int stock_quanity;
        private int total_purchased; //glaube int ist bissn small

        public int Product_id { get => product_id; set => product_id = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public string Price { get => price; set => price = value; }
        public int Stock_quanity { get => stock_quanity; set => stock_quanity = value; }
        public int Total_purchased { get => total_purchased; set => total_purchased = value; }
    }
}
