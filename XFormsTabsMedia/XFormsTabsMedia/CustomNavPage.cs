using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFormsTabsMedia
{
    public class CustomNavPage : NavigationPage
    {
        public CustomNavPage(Page root) : base(root)
        {
            BarBackgroundColor = Color.FromHex("547799");
            BarTextColor = Color.White;
        }
    }
}
