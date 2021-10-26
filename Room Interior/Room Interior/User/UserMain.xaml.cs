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
    /// Логика взаимодействия для UserMain.xaml
    /// </summary>
    public partial class UserMain : Window
    {
        public UserMain()
        {
            InitializeComponent();
        }

        private void ProfileButton_Click(object sender, RoutedEventArgs e)
        {
            UserProfile up = new UserProfile();
            up.ShowDialog();
        }

        private void btnListProduct_Click(object sender, RoutedEventArgs e)
        {
            frmMainUser.Navigate(new UserPageProduct());
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

        private void btnListBasket_Click(object sender, RoutedEventArgs e)
        {
            frmMainUser.Navigate(new UserPageBasket());
        }
    }
}
