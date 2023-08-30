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
    public partial class SignUpPage1 : ContentPage
    {
        public SignUpPage1()
        {
            InitializeComponent();
        }


        private void Login_btn_clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SignUpPage2());
        }
    }
}