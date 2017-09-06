using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFormsTabsMedia
{
    public class RootTabsPage : TabbedPage
    {
        public RootTabsPage()
        {
            Title = "XFormsTabsMedia";

            NavigationPage.SetBackButtonTitle(this, "");

            this.Children.Add(new TabPage1());
            this.Children.Add(new TabPage2());
        }
    }
}
