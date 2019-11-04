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
    public partial class FlyoutHeader : ContentPage
    {
        public FlyoutHeader()
        {
            InitializeComponent();
        }


        async protected override void OnAppearing()
        {
            base.OnAppearing();

            double offset = -1000;

            /*
            foreach (View view in stackLayout.Children)
            {
                view.TranslationX = offset;
                offset *= +1;
            }

            foreach (View view in stackLayout.Children)
            {
                await Task.WhenAny(view.TranslateTo(0, 0, 1000, Easing.SpringOut), Task.Delay(100));
            }
            */

            this.TranslationX = offset;
            for (int i = 0; i < 100; i++)
            {
                offset *= +1;
            }
            for (int i = 0; i < 100; i++)
            {
                await Task.WhenAny(this.TranslateTo(0, 0, 1000, Easing.SpringOut), Task.Delay(100));
            }
        }

        async protected override void OnDisappearing()
        {
            base.OnAppearing();

            double offset = -1000;

            /*
            foreach (View view in stackLayout.Children)
            {
                view.TranslationX = offset;
                offset *= +1;
            }

            foreach (View view in stackLayout.Children)
            {
                await Task.WhenAny(view.TranslateTo(0, 0, 1000, Easing.SpringOut), Task.Delay(100));
            }
            */

            this.TranslationX = X;
            for (int i = 0; i < 100; i++)
            {
                offset *= -1;
            }
            for (int i = 0; i < 100; i++)
            {
                await Task.WhenAny(this.TranslateTo(-1000, 0, 1000, Easing.SpringOut), Task.Delay(100));
            }
        }
    }
}