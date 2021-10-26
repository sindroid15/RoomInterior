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

namespace Room_Interior.Manager
{
    /// <summary>
    /// Логика взаимодействия для ManagerPageUserOrder.xaml
    /// </summary>
    public partial class ManagerPageUserOrder : Page
    {
        public ManagerPageUserOrder()
        {
            InitializeComponent();
            LvUser.ItemsSource = Class.db.User.ToList();
            LvOrder.ItemsSource = Class.db.Order.ToList();
        }

        private void btnBackFrm_Click(object sender, RoutedEventArgs e)
        {
            Content = null;
        }

        private void lvUser_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void lvOrder_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
