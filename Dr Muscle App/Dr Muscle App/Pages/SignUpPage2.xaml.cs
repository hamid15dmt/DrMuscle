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
    public partial class SignUpPage2 : ContentPage
    {
        public SignUpPage2()
        {
            InitializeComponent();
        }

        private void Login_btn_clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SignUpPage3());
        }
    }
}