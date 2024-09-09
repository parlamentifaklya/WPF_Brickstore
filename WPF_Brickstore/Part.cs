using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Brickstore
{
    internal class Part
    {
        private string itemID;
        private string itemName;
        private string colorName;
        private string categoryName;
        private int qty;

        /*public Part(string itemID, string itemTypeID, string colorID, string itemName, string itemTypeName,
                    string colorName, string categoryID, string categoryName, string status,
                    int qty, float price, string condition)
        {
            this.itemID = itemID;
            this.itemTypeID = itemTypeID;
            this.colorID = colorID;
            this.itemName = itemName;
            this.itemTypeName = itemTypeName;
            this.colorName = colorName;
            this.categoryID = categoryID;
            this.categoryName = categoryName;
            this.status = status;
            this.qty = qty;
            this.price = price;
            this.condition = condition;
        }*/

        public string ItemID { get; set; }
        public string ItemName { get; set; }
        public string ColorName { get; set; }
        public string CategoryName { get; set; }
        public int Qty { get; set; }
    }
}
