using Room_Interior.Helper;
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

namespace Room_Interior.Admin
{
    /// <summary>
    /// Логика взаимодействия для AdminPageUser.xaml
    /// </summary>
    public partial class AdminPageUser : Page
    {
        public AdminPageUser()
        {
            InitializeComponent();
            RoomInteriorEntities1 db = new RoomInteriorEntities1();
            LvUser.ItemsSource = db.User.ToList();
            
        }

        private void btnBackFrm_Click(object sender, RoutedEventArgs e)
        {
            Content = null;
        }

        private void LvUser_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
