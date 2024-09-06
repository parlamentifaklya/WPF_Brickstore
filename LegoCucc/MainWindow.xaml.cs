using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace LegoCucc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        List<Part> parts = new List<Part>();
        public MainWindow()
        {
            InitializeComponent();
            XDocument xaml = XDocument.Load("brickstore_parts_3180-1-tank-truck.bsx");
            
            foreach (var item in xaml.Descendants("Item"))
            {
                string itemid = item.Element("ItemID").Value;
                string itemtypeid = item.Element("ItemTypeID").Value;
                string colorid = item.Element("ColorID").Value;
                string itemname = item.Element("ItemName").Value;
                string itemtypename = item.Element("ItemTypeName").Value;
                string colorname = item.Element("ColorName").Value;
                string categoryid = item.Element("CategoryID").Value;
                string categoryname = item.Element("CategoryName").Value;
                string status = item.Element("Status").Value;
                int qty = int.Parse(item.Element("Qty").Value);

                float price;
                try
                {
                    price = float.Parse(item.Element("Price").Value);
                }
                catch 
                {
                    price = 0;
                }
                
                string condition = item.Element("Condition").Value;
                
                Part legoPiece = new Part
                {
                    ItemID = itemid,
                    ItemTypeID = itemtypeid,
                    ColorID = colorid,
                    ItemName = itemname,
                    ItemTypeName = itemname,
                    ColorName = colorname,
                    CategoryID = categoryid,
                    CategoryName = categoryname,
                    Status = status,
                    Qty = qty,
                    Price = price,
                    Condition = condition
                };

               parts.Add(legoPiece);
            }
            asd.ItemsSource = parts;
        }
    }
}