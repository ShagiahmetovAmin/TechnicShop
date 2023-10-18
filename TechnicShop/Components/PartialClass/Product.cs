using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TechnicShop.Components
{
    public partial class Product
    {
        public Visibility OldPriceVis 
        {
            get
            {
                if(Discount == 0)
                    return Visibility.Collapsed;
                else
                    return Visibility.Visible;
            }
        }
        public string Priceprod
        {
            get
            {
                if (Discount == 0)return $"{Cost:0} Р";
                else return $"{(double)Cost - (double)Cost * (double)Discount / 100:0} Р";
            }
        }
        public double CountOtz
        {
            get { return Feedback.Where(x => x.ProductId == Id).Count();}
        }
         public double AvgEvolv
         {
            get 
            { 
                if(Feedback.Count() == 0)
                {
                    return 0;
                }
                else
                return Feedback.Average(x => x.Evaluation);
            }
         }
    }
}
