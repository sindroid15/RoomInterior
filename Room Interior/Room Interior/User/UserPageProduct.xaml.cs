using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Room_Interior.Helper;

namespace Room_Interior.User
{
    /// <summary>
    /// Логика взаимодействия для UserPageProduct.xaml
    /// </summary>
    public partial class UserPageProduct : Page
    {
        List<Product> listProduct = new List<Product>();
        private int numPage = 0;
        List<string> listSort = new List<string>()
            {
                "Наименование (по возрастанию)",
                "Наименование (по убыванию)",
                "Стоимость (по возрастанию)",
                "Стоимость (по убыванию)"
            };
        List<string> listFiltr = new List<string>();
        void Filtr()
        {
            var listProduct = Class.db.Product.ToList();
            var selectSort = cmbSortingPrice.SelectedIndex;
            switch (selectSort)
            {
                case 0:
                    listProduct = listProduct.OrderBy(i => i.NameProduct).ToList();
                    break;
                case 1:
                    listProduct = listProduct.OrderByDescending(i => i.NameProduct).ToList();
                    break;
                case 2:
                    listProduct = listProduct.OrderBy(i => i.Price).ToList();
                    break;
                case 3:
                    listProduct = listProduct.OrderByDescending(i => i.Price).ToList();
                    break;
                default:
                    listProduct = listProduct.OrderBy(i => i.IdProduct).ToList();
                    break;
            }
            var selectFiltr = cmbFiltrationCategory.SelectedIndex;
            if (selectFiltr != 0)
            {
                listProduct = listProduct.Where(i => i.IdCategory == selectFiltr).ToList();
            }
            listProduct = listProduct.Skip(10 * numPage).Take(10).ToList();
            lvProduct.ItemsSource = listProduct;

        }

        public UserPageProduct()
        {
            InitializeComponent();
            lvProduct.ItemsSource = Class.db.Product.ToList();
            var category = Class.db.Category.ToList();
            foreach(var i in category)
            {
                listFiltr.Add(i.NameCategory);

            }
            listFiltr.Insert(0, "All categories");
            cmbFiltrationCategory.ItemsSource = listFiltr;
            cmbFiltrationCategory.SelectedIndex = 0;
            cmbSortingPrice.ItemsSource = listSort;
            cmbSortingPrice.SelectedIndex = 0;
        }

        private void btnBackFrm_Click(object sender, RoutedEventArgs e)
        {
            Content = null;
        }

        private void txbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            listProduct = listProduct.Where(i => i.NameProduct.ToLower().Contains(txbSearch.Text.ToLower())).ToList();

        }

        private void cmbFiltrationCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Filtr();
        }

        private void cmbSortingPrice_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Filtr();
        }

        private void btnLastPage_Click(object sender, RoutedEventArgs e)
        {
            if(numPage>0)
            {
                numPage--;
                tbckPage.Text = (numPage + 1).ToString();
            }
            Filtr();
        }

        private void btnNextPage_Click(object sender, RoutedEventArgs e)
        {
            if(listProduct.Count>0)
            {

            }numPage++;
            tbckPage.Text = (numPage + 1).ToString();
            Filtr();
        }

        private void btnEditProductBasket_Click(object sender, RoutedEventArgs e)
        {
            UserAddProductBasket uapb = new UserAddProductBasket();
            uapb.ShowDialog();
        }

        private void lvProduct_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Filtr();
        }
    }
}
