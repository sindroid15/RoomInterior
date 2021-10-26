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

namespace Room_Interior.Manager
{
    /// <summary>
    /// Логика взаимодействия для ManagerMain.xaml
    /// </summary>
    public partial class ManagerMain : Window
    {
        public ManagerMain()
        {
            InitializeComponent();
        }

        private void btnListProduct_Click(object sender, RoutedEventArgs e)
        {
            frmMainManager.Navigate(new Manager.ManagerPageProduct());
        }

        private void btnListUserOrder_Click(object sender, RoutedEventArgs e)
        {
            frmMainManager.Navigate(new Manager.ManagerPageUserOrder());
        }

        private void btnListExitProfile_Click(object sender, RoutedEventArgs e)
        {
            Class.mw.Show();
            this.Close();
        }

        private void btnListCloseApp_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
