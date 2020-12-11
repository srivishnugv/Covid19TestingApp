using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Covid19TestingApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void To_RegistrationPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegistrationPage());
        }
    }
}
