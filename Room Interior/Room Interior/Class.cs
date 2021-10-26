using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Room_Interior.Helper;

namespace Room_Interior
{
    class Class
    {
        public static MainWindow mw = new MainWindow();
        public static Manager.ManagerMain manwin = new Manager.ManagerMain();
        public static User.UserMain userMain = new User.UserMain();
        
        public static Admin.AdminMain am = new Admin.AdminMain();
        public static Room_Interior.Helper.RoomInteriorEntities1 db = new Helper.RoomInteriorEntities1();
        public static Helper.Product productSave = new Helper.Product();
        public static Helper.User userSave = new Helper.User();

        public static void dbEditor(string login, string password)
        {
            var key = Class.userSave.IdUser;
            var item = Class.db.User.Find(key);
            item.Login = login;
            item.Password = password;
            Class.db.SaveChanges();
        }

        public static void dbEditorProduct(string name, int category, decimal price, string material, string description)
        { 
            var key =Class.productSave.IdProduct;
            var item = Class.db.Product.Find(key);

            item.NameProduct = name;
            item.IdCategory = category;
            item.Price = price;
            item.Material = material;
            item.Description = description;
            
            Class.db.SaveChanges();

        }



    }
}
