using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace RadioKameleon
{
    public partial class Main : ContentPage
    {
        public Main()
        {
            InitializeComponent();
            MyWebView.Source = new HtmlWebViewSource() {BaseUrl = "http://radiokameleon.ba/" };
        }
    }
}
