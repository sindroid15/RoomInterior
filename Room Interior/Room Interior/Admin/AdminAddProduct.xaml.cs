using System;
using Room_Interior.Helper;
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
using Microsoft.Win32;

namespace Room_Interior.Admin
{
    /// <summary>
    /// Логика взаимодействия для AdminAddProduct.xaml
    /// </summary>
    public partial class AdminAddProduct : Window
    {
        List<string> listCat = new List<string>();
        int idProduct;
        public AdminAddProduct(int id): this()
        {
            idProduct = id;
            Product item = Class.db.Product.Where(i => i.IdProduct == id).First();
            tbInputPrice.Text = Convert.ToString(item.Price);
            tbInputMaterialProduct.Text = item.Material;
            tbInputDescription.Text = item.Description;
            tbNameProduct.Text = item.NameProduct;
        }

        void Category()
        {
            RoomInteriorEntities1 db = new RoomInteriorEntities1();
            var listCategory = db.Category.ToList();
            var selectFiltr = cmbChangeCategoryProduct.SelectedIndex;
            if (selectFiltr != 0)
            {
                listCategory = listCategory.Where(i => i.IdCategory == selectFiltr).ToList();
            }
            

        }
        public AdminAddProduct()
        {
            RoomInteriorEntities1 db= new RoomInteriorEntities1();
            InitializeComponent();
            var category = db.Category.ToList();
            foreach (var i in category)
            {
                listCat.Add(i.NameCategory);
            }
            cmbChangeCategoryProduct.ItemsSource = listCat;
        }

        private void cmbChangeCategoryProduct_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Category();
        }

        private void tbNameProduct_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void tbInputPrice_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void tbInputDescription_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void tbInputMaterialProduct_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnSaveProduct_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Вы хотите добавить материал?","Подтверждение",MessageBoxButton.YesNo);

            if (Class.productSave != null)
            {
                Class.dbEditorProduct(tbNameProduct.Text, cmbChangeCategoryProduct.SelectedIndex + 1, decimal.Parse(tbInputPrice.Text), tbInputMaterialProduct.Text, tbInputDescription.Text);
            }
            else
            {
                Class.productSave.NameProduct = tbNameProduct.Text;
                Class.productSave.IdCategory = cmbChangeCategoryProduct.SelectedIndex + 1;
                Class.productSave.Price = decimal.Parse(tbInputPrice.Text);
                Class.productSave.Material = tbInputMaterialProduct.Text;
                Class.productSave.Description = tbInputDescription.Text;
                Class.productSave.PhotoProduct = null;
                Class.db.Product.Add(Class.productSave);
                Class.db.SaveChanges();
                MessageBox.Show("Товар успешно добавлен", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
            }

        }

        private void btnExitWindow_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnImageAdd_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFD = new OpenFileDialog();
            if(openFD.ShowDialog()==true)
            {
                string FileName = openFD.FileName;
                imgImageProduct.Source = new BitmapImage(new Uri(openFD.FileName));
                
            }
        }
    }
}
