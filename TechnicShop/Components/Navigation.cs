using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace TechnicShop.Components
{
    static class Navigation
    {
        static List<PageComponent> comp = new List<PageComponent>();
        public static MainWindow mainWindow { get; set; }
        public static void ClearHistory()
        {
            comp.Clear();
        }

        public static void NextPageLoad(PageComponent pageComponent)
        {
            comp.Add(pageComponent);
            Update(pageComponent);
        }

        public static void BackPage()
        {
            if(comp.Count > 1)
            {
                comp.RemoveAt(comp.Count - 1);
                Update(comp[comp.Count - 1]);
            }
        }

        public static void Update(PageComponent pageComponent)
        {
            mainWindow.Information.Navigate(pageComponent.Page);
        }

    }
    class PageComponent
    {
        public Page Page;
        public PageComponent(Page page)
        {
            Page = page;
        }
    }
}
