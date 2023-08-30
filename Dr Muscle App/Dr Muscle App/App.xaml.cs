using Dr_Muscle_App.Pages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Dr_Muscle_App
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new SignUpPage1());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
