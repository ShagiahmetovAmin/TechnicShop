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
using TechnicShop;
using System.IO;
using TechnicShop.Pages;
using TechnicShop.Components;

namespace TechnicShop
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Navigation.mainWindow = this;
            InitializeComponent();
            //ДОБАВЛЕНИЕ В бд бинарного кода к картинке
            //var path = @"C:\Users\222117\Desktop\"; - указываем, где хранится папка
            //foreach(var i in App.db.Product.ToArray()) - прогоняем каждый объект
            //{
            //    var fullPath = path + i.MainImagePath.Trim();
            //    var imageByte = File.ReadAllBytes(fullPath);
            //    i.MainImage = imageByte;
            //}
            //App.db.SaveChanges(); - сохраняем изменения

            Navigation.NextPageLoad(new PageComponent(new ListPage()));

        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            
            Navigation.NextPageLoad((new PageComponent(new LoginPage())));
        }

    }
}
