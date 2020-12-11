using Covid19TestingApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Covid19TestingApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrationPage : ContentPage
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }
        private void To_LocPrefPage(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(name.Text) || string.IsNullOrEmpty(email.Text) || string.IsNullOrEmpty(phone.Text) || string.IsNullOrEmpty(address.Text) || string.IsNullOrEmpty(healthCoverage.Text))
            {
                DisplayAlert("Incomplete Form", "Please enter all fields", "OK");
            } else
            {
                User newUser = new User();
                newUser.name = name.Text;
                newUser.email = email.Text;
                newUser.phoneNumber = phone.Text;
                newUser.address = address.Text;
                newUser.healthCoverage = healthCoverage.Text;
                Navigation.PushAsync(new LocationPreferencePage(newUser));
            }
            
        }
    }
}