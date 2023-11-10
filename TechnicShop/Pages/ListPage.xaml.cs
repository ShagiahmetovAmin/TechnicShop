using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            foreach (var item in newinf)
            {
                ServiceWrapPanel.Children.Add(new ProductUserControl(item));
            }
            if (App.adminsh == true)
            {
                AdminFuc.Visibility = Visibility.Visible;
                Navigation.Update(new PageComponent(new ListPage()));
            }
            else AdminFuc.Visibility = Visibility.Collapsed;
            Refresh();
        }

        private void ProductSort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Refresh();
        }

        private void DiscountProd_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Refresh();
        }


        private void Refresh()
        {
            IEnumerable<Product> products = App.db.Product;
            if (ProductSort.SelectedIndex != 0)
            {
                if (ProductSort.SelectedIndex == 1)
                {
                    products = products.OrderBy(x => x.Cost);
                }
                else products = products.OrderByDescending(x => x.Cost);
            }
            if(DiscountProd.SelectedIndex != 0)
            {
                switch (DiscountProd.SelectedIndex)
                {
                    case 1:
                        products = products.Where(x => x.Discount >= 0 && x.Discount < 5);
                        products = products.OrderBy(x => x.Discount);
                        break;
                    case 2:
                        products = products.Where(x => x.Discount >= 5 && x.Discount < 15);
                        products = products.OrderBy(x => x.Discount);
                        break;
                    case 3:
                        products = products.Where(x => x.Discount >= 15 && x.Discount < 30);
                        products = products.OrderBy(x => x.Discount);
                        break;
                    case 4:
                        products = products.Where(x => x.Discount >= 30 && x.Discount < 70);
                        products = products.OrderBy(x => x.Discount);
                        break;
                    case 5:
                        products = products.Where(x => x.Discount >= 70 && x.Discount < 100);
                        products = products.OrderBy(x => x.Discount);
                        break;
                }
            }
            ServiceWrapPanel.Children.Clear();
            foreach (var product in products)
            {
                ServiceWrapPanel.Children.Add(new ProductUserControl(product));
            }
        }

        
    }
}
