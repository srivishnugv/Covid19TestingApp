using Covid19TestingApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Covid19TestingApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LocationPreferencePage : ContentPage
    {
        User newUser = new User();
        public LocationPreferencePage(User newUser2)
        {
            newUser = newUser2;
            InitializeComponent();
        }

        private void To_TestSelectionPage(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(newUser.payPreference))
            {
                newUser.payPreference = "Free";
            }
            Console.WriteLine("paidPreference recorded:" + newUser.payPreference);
            Navigation.PushAsync(new TestSelectionPage(newUser));
        }

        private void picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            newUser.payPreference = picker.SelectedItem.ToString();
        }
    }
}