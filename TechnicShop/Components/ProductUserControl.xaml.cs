using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
using System.Xml.Linq;

namespace TechnicShop.Components
{
    /// <summary>
    /// Логика взаимодействия для ProductUserControl.xaml
    /// </summary>
    public partial class ProductUserControl : UserControl
    {
        Product product;
        public ProductUserControl(Product _product)
        {
            
            InitializeComponent();
            product = _product;
            ProductImage.Source = GetImage(product.MainImage);
            NameTb.Text = product.Title;
            EvaluationTb.Text = product.AvgEvolv.ToString();
            OtzovTb.Text = product.CountOtz.ToString();
            PriceTb.Text = product.Priceprod.ToString();
            OldPriceTb.Text = product.Cost.ToString("0");
            OldPriceTb.Visibility = product.OldPriceVis;
            if(App.adminsh == true)
            {
                AdmRedDelVis.Visibility = Visibility.Collapsed;
            }
        }

        public BitmapImage GetImage(byte[] byteimage)
        {
            BitmapImage bitmapImg = new BitmapImage();
            try
            {
                if (product.MainImage != null)
                {
                    MemoryStream byteStr = new MemoryStream(byteimage);
                    bitmapImg.BeginInit();
                    bitmapImg.StreamSource = byteStr;
                    bitmapImg.EndInit();
                    
                }
                else
                {
                    bitmapImg = new BitmapImage(new Uri(@"\Resources\dayson.jpg", UriKind.Relative));
                }
                
            }
            catch
            {
                MessageBox.Show("Error");
            }
            return bitmapImg;
        }
    }
}
