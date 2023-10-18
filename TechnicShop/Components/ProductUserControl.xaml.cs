using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Xml.Linq;

namespace TechnicShop.Components
{
    /// <summary>
    /// Логика взаимодействия для ProductUserControl.xaml
    /// </summary>
    public partial class ProductUserControl : UserControl
    {
        public ProductUserControl(Image image, string name, double evaluation, double otzov,decimal oldprice, string price, Visibility oldpriceVis)
        {
            InitializeComponent();
            Imgsource = image;
            NameTb.Text = name;
            EvaluationTb.Text = evaluation.ToString();
            OtzovTb.Text = otzov.ToString();
            PriceTb.Text = price;
            OldPriceTb.Text = oldprice.ToString("0");
            OldPriceTb.Visibility = oldpriceVis;
        }
    }
}
