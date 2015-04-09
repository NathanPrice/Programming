using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_class
{
    class Inventory
    {
        private string item_name = null;
        private string description = null;
        private string quanity = null;
        private string unit_price = null;
        private string retail_price = null;


        public string Retail_Price
        {
            get { return retail_price; }
            set { retail_price = value; }
        }

       


        public Inventory(string item, string desc, string quant, string uprice) {

            item_name = item;
            description = desc;
            quanity = quant;
            unit_price = uprice;
        
        
        }

        public string Item_Name
        {
            set { item_name = value;}
            get { return item_name; }

        }

        public void setItemName(string item)
        {
            item_name = item;
        }

        public string getItemName()
        {
            return item_name;
        }

        public void setDescription(string desc)
        {
            description = desc;
        }

        public string getDescription()
        {
            return description;
        }

        public void setQuanity(string amount)
        {
            quanity = amount;
        }

        public string getQuanity()
        {
            return quanity;
        }

        public void setUnitPrice(string unit)
        {
            unit_price = unit;
        }

        public string getUnitPrice()
        {
            return unit_price;
        }

        public void setRetailPrice(string retail)
        {
            retail_price = retail;
        }

        public string getRetailPrice()
        {
            return retail_price;
        }
    }
}
