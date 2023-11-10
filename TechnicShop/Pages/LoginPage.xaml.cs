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
using TechnicShop.Components;
using TechnicShop;

namespace TechnicShop.Pages
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
            if (PasswPb.Password.ToString() == "0000")
            {
                App.adminsh = true;
            }
            else
            {
                App.adminsh = false;
            }

        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Navigation.NextPageLoad(new PageComponent(new ListPage()));
        }

        private void MailTb_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (MailTb.Text.Length != 0)
            {
                GoShopBtn.IsEnabled = true;
            }
            else 
            { 
                GoShopBtn.IsEnabled = false; 
            }
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MailTb.Clear();
            PasswPb.Clear();
        }
    }
}
