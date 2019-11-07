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
    public partial class DetailView : ContentView
    {
        public DetailView(string t, string d, string u)
        {
            InitializeComponent();

            title.Text = t;
            description.Text = d;
            user.Text = u;
        }
    }
}