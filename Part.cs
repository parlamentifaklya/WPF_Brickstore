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

        

        public string ItemID { get; set; }
        public string ItemName { get; set; }
        public string ColorName { get; set; }
        public string CategoryName { get; set; }
        public int Qty { get; set; }
    }
}
