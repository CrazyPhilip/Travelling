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
    public partial class RankingPage : ContentView
    {
        public RankingPage()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            TuijianView tuijianView = new TuijianView();

            stack.Children.Clear();
            stack.Children.Add(tuijianView);

            boxview1.BackgroundColor = Color.SkyBlue;
            boxview2.BackgroundColor = Color.White;
            bang1.TextColor = Color.SkyBlue;
            bang2.TextColor = Color.Black;
        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            FensiView fensiView = new FensiView();

            stack.Children.Clear();
            stack.Children.Add(fensiView);

            boxview2.BackgroundColor = Color.SkyBlue;
            boxview1.BackgroundColor = Color.White;
            bang2.TextColor = Color.SkyBlue;
            bang1.TextColor = Color.Black;
        }
    }
}