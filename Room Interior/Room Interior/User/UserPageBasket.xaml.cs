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

namespace Room_Interior.User
{
    /// <summary>
    /// Логика взаимодействия для UserPageBasket.xaml
    /// </summary>
    public partial class UserPageBasket : Page
    {
        public UserPageBasket()
        {
            InitializeComponent();
            lvBasket.ItemsSource = Class.db.Order.ToList();
            lvProduct.ItemsSource = Class.db.Product.ToList();
        }

        private void btnBackFrm_Click(object sender, RoutedEventArgs e)
        {
            Content = null;
        }

        private void lvBasket_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void lvProduct_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
