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
using System.Windows.Shapes;


namespace Room_Interior.User
{
    /// <summary>
    /// Логика взаимодействия для UserAddProductBasket.xaml
    /// </summary>
    public partial class UserAddProductBasket : Window
    {
        List<string> listCat = new List<string>();
        List<string> listProd = new List<string>();

        void Category()
        {
            var listCategory = Class.db.Category.ToList();
            var selectFiltr = cmbChangeCategoryProduct.SelectedIndex;
            if (selectFiltr != 0)
            {
                listCategory = listCategory.Where(i => i.IdCategory == selectFiltr).ToList();
            }
        }
        void Product()
        {
            var listProduct = Class.db.Product.ToList();
            var selectProd = cmbNameProduct.SelectedIndex;
            if(selectProd!=0)
            {
                listProduct = listProduct.Where(i => i.IdProduct == selectProd).ToList();
            }
        }
        public UserAddProductBasket()
        {
            InitializeComponent();
            var category = Class.db.Category.ToList();
            var product = Class.db.Product.ToList();
            foreach (var i in category)
            {
                listCat.Add(i.NameCategory);
            }

            foreach(var i in product)
            {
                listProd.Add(i.NameProduct);

            }
            cmbChangeCategoryProduct.ItemsSource = listCat;
            cmbNameProduct.ItemsSource = listProd;
        }

        private void cmbChangeCategoryProduct_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Category();
        }

        private void cmbNameProduct_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Product();
        }

        private void btnAddBasket_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("", "", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                Helper.Basket bas = new Helper.Basket();
                bas.IdProduct = Int32.Parse(cmbNameProduct.Text);
            }
        }

        private void btnExitWindow_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
