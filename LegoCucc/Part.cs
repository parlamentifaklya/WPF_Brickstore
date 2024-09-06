using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoCucc
{
    internal class Part
    {
        private string itemID;
        private string itemTypeID;
        private string colorID;
        private string itemName;
        private string itemTypeName;
        private string colorName;
        private string categoryID;
        private string categoryName;
        private string status;
        private int qty;
        private float price;
        private string condition;

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
        public string ItemTypeID { get; set; }
        public string ColorID { get; set; }
        public string ItemName { get; set; }
        public string ItemTypeName { get; set; }
        public string ColorName { get; set; }
        public string CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Status { get; set; }
        public int Qty { get; set; }
        public float Price { get; set; }
        public string Condition { get; set; }
    }
}
