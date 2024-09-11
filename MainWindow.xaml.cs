using Microsoft.Win32;
using System.IO;
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

namespace WPF_Brickstore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Part> parts = new List<Part>();
        OpenFileDialog ofd = new OpenFileDialog();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenFile_Click(object sender, RoutedEventArgs e)
        {
            Nullable<bool> result = ofd.ShowDialog();
            XDocument xaml = XDocument.Load(ofd.FileName);

            foreach (var item in xaml.Descendants("Item"))
            {
                string itemid = item.Element("ItemID").Value;
                string itemname = item.Element("ItemName").Value;
                string colorname = item.Element("ColorName").Value;
                string categoryname = item.Element("CategoryName").Value;
                int qty = int.Parse(item.Element("Qty").Value);

                Part legoPiece = new Part
                {
                    ItemID = itemid,
                    ItemName = itemname,
                    ColorName = colorname,
                    CategoryName = categoryname,
                    Qty = qty
                };

                parts.Add(legoPiece);
            }
            LegoDataGrid.ItemsSource = parts;
        }

        private void FilterTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string itemIdFilter = ItemIdFilterTextBox.Text.ToLower();
            string itemNameFilter = ItemNameFilterTextBox.Text.ToLower();

            var filteredParts = parts.Where(p =>
                p.ItemID.ToLower().Contains(itemIdFilter) &&
                p.ItemName.ToLower().Contains(itemNameFilter)).ToList();

            LegoDataGrid.ItemsSource = filteredParts;
        }
    }
}