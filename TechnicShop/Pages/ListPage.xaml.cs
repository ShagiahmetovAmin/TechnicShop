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

namespace TechnicShop
{
    /// <summary>
    /// Логика взаимодействия для ListPage.xaml
    /// </summary>
    public partial class ListPage : Page
    {
        public ListPage()
        {
            InitializeComponent();
            var newinf = App.db.Product.ToList();
            foreach(var item in newinf)
            {
                ServiceWrapPanel.Children.Add( new ProductUserControl(item));
            }
            if(App.adminsh != false)
            {
                AdminFuc.Visibility = Visibility.Visible;
            }
        }
    }
}
