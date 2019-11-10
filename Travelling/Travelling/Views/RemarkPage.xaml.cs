using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Travelling.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RemarkPage : ContentPage
    {
        public RemarkPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            XLYJSC xLYJSC = new XLYJSC();
            Navigation.PushModalAsync(xLYJSC);
        }
    }
}