using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Travelling.Models;
using Travelling.ViewModels;

namespace Travelling.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        HomeViewModel homeViewModel = new HomeViewModel();

        public HomePage()
        {
            InitializeComponent();

            homeViewModel.JourneyList = new List<JourneyInfo>
            {
                new JourneyInfo{ Title="成都都市漫游记", Time="23min", Avatar="a5.png", Cover="chengdu.png" },
                new JourneyInfo{ Title="广州经典1日游72h", Time="1h", Avatar="a5.png", Cover="guangzhou.png" },
                new JourneyInfo{ Title="1秒穿越回唐朝--西安必打卡", Time="23min", Avatar="a3.png", Cover="datang.png" },
                new JourneyInfo{ Title="北京地道72h", Time="1h", Avatar="a4.png", Cover="didao72h.png" },
                new JourneyInfo{ Title="成都都市漫游记", Time="23min", Avatar="a5.png", Cover="chengdu.png" },
            };

            BindingContext = homeViewModel;
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {

        }

        private void MenuButton_Clicked(object sender, EventArgs e)
        {
            FlyoutHeader flyoutHeader = new FlyoutHeader();
            Navigation.PushModalAsync(flyoutHeader, false);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}