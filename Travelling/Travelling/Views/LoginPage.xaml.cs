using FFImageLoading.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Travelling.Controls;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Travelling.Views;

namespace Travelling.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : GradientContentPage
    {
        private readonly DisplayInfo _metrics;
        private readonly int _formsWidth;
        private readonly int _formsHeight;

        private bool _initialized = false;
        private bool _starsAdded = false;
        private List<VisualElement> _stars = new List<VisualElement>();

        public LoginPage()
        {
            InitializeComponent();

            _metrics = DeviceDisplay.MainDisplayInfo;
            _formsWidth = Convert.ToInt32(_metrics.Width / _metrics.Density);
            _formsHeight = Convert.ToInt32(_metrics.Height / _metrics.Density);

        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            if (!_initialized)
            {
                /*
                await Task.WhenAll(
                    WelcomeLabel.TranslateTo(_formsWidth, 0, 0, null),
                    PosyLabel.TranslateTo(_formsWidth, 0, 0, null),
                    FormLayout.TranslateTo(0, _formsHeight, 0, null),
                    CalculateButton.TranslateTo(0, _formsHeight, 0, null),
                    IntroLabel.TranslateTo(_formsWidth, 0, 0, null)
                );*/

                //PositionStars();
                //RotateStars();

                /*
                await Task.WhenAll(
                    WelcomeLabel.TranslateTo(0, 0, 400, Easing.CubicInOut),
                    PosyLabel.TranslateTo(0, 0, 450, Easing.CubicInOut),
                    IntroLabel.TranslateTo(0, 0, 500, Easing.CubicInOut),
                    FormLayout.TranslateTo(0, 0, 550, Easing.CubicInOut),
                    CalculateButton.TranslateTo(0, 0, 550, Easing.CubicInOut)
                );*/

                _initialized = true;
            }
        }

        private void PositionStars()
        {
            if (!_starsAdded)
            {
                var random = new Random();


                for (int j = 0; j < 5; j++)
                {
                    var starField = new Grid();

                    for (int i = 0; i < 20; i++)
                    {
                        var size = random.Next(3, 7);
                        var star = new CachedImage() { Source = "star.png", Opacity = 0.3, HeightRequest = size, WidthRequest = size, HorizontalOptions = LayoutOptions.Start, VerticalOptions = LayoutOptions.Start, TranslationX = random.Next(0, _formsWidth), TranslationY = random.Next(0, _formsHeight) };
                        starField.Children.Add(star);
                    }

                    _stars.Add(starField);

                    MainGrid.Children.Insert(0, starField);
                }
            }
        }

        private async Task RotateStars()
        {
            var rotateTasks = new List<Task>();
            var random = new Random();

            foreach (var star in _stars)
            {
                var rate = random.Next(240000, 300000);
                rotateTasks.Add(RotateElement(star, (uint)rate, new CancellationToken()));
            }

            await Task.WhenAll(rotateTasks);
        }

        private void RememberPwd_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {

        }

        private void RegisterButton_Clicked(object sender, EventArgs e)
        {

        }

        private void LoginButton_Clicked(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            Navigation.PushModalAsync(mainPage);
        }
    }
}