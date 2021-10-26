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
    /// Логика взаимодействия для UserProfile.xaml
    /// </summary>
    public partial class UserProfile : Window
    {
        public UserProfile()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if(tbLogin.Text.Length==0 || tbPassword.Text.Length==0)
            {
                MessageBox.Show("Error", "Error", MessageBoxButton.OK);
            }
            else
            {
                var result = MessageBox.Show("Вы хотите поменять логин и пароль?", "Подтверждение", MessageBoxButton.YesNo);
                if(result == MessageBoxResult.Yes)
                {
                    Class.dbEditor(tbLogin.Text, tbPassword.Text);
                    MessageBox.Show("Успех", "Успех", MessageBoxButton.OK);
                    this.Close();
                }
            }
        }
    }
}
