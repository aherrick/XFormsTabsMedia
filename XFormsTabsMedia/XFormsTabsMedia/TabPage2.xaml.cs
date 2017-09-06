using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XFormsTabsMedia
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabPage2 : ContentPage
    {
        public TabPage2()
        {
            InitializeComponent();

            this.Icon = "wishlist_tab";
            this.Title = "Tab2";
        }
    }
}