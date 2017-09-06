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

            if (Device.RuntimePlatform == Device.iOS)
            {
                Icon = new FileImageSource { File = "wishlist_tab.png" };
            }

            this.Title = "Tab2";
        }
    }
}