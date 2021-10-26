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
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Room_Interior.Helper;

namespace Room_Interior
{
    /// <summary>
    /// Логика взаимодействия для Auth_Page.xaml
    /// </summary>
    public partial class Auth : Page
    {
        public Auth()
        {
            InitializeComponent();
            
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            

            RoomInteriorEntities1 db = new RoomInteriorEntities1();

            var userModel = db.User.FirstOrDefault
                (i => i.Login == txbLogin.Text & i.Password == psbPassword.Password);
            if (psbPassword.Password == psbPasswordRepeat.Password)
            {
                if (userModel == null)
                {
                    MessageBox.Show("пользовательне не найден, повторите попытку", "Пользователь не найден", MessageBoxButton.OK);

                }
                else
                {
                    Class.userSave = userModel;
                    switch (userModel.IdRole)
                    {
                        case 1:
                            {
                                Admin.AdminMain aM = new Admin.AdminMain();
                                aM.Show();
                                Application.Current.MainWindow.Close();
                                break;
                            }
                        case 2:
                            {
                                Manager.ManagerMain mM = new Manager.ManagerMain();
                                mM.Show();
                                Application.Current.MainWindow.Close();
                                break;
                            }
                        case 3:
                            {
                                User.UserMain uM = new User.UserMain();
                                uM.Show();
                                Application.Current.MainWindow.Close();
                                break;
                            }
                        default:
                            MessageBox.Show("Что-то пошло не так", "ОЙ", MessageBoxButton.OK);
                            break;

                    }
                }


            }
            else
            {
                MessageBox.Show("Пароль не совпадает, повторите попытку", "Ошибка ввода пароля", MessageBoxButton.OK);
            }
        }
    }
}
