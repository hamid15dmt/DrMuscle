using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Dr_Muscle_App.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUpPage3 : ContentPage
    {
        public SignUpPage3()
        {
            InitializeComponent();
        }

        private void Login_btn_clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new SignUpPage1());
        }
    }
}