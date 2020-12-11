using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZeroFiveBit.Utils;

namespace Covid19TestingApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TestingPage : ContentPage
    {
        static Countdown countdown;
        public TestingPage()
        {
            InitializeComponent();
            countdown = new Countdown();
            countdown.StartUpdating(300);
            cdLabel.SetBinding(Label.TextProperty,
                new Binding("RemainTime", BindingMode.Default, new CountdownConverter()));
            cdLabel.BindingContext = countdown;

            Device.StartTimer(TimeSpan.FromMinutes(5), () =>
            {
                Navigation.PushAsync(new MainPage());
                return false; // True = Repeat again, False = Stop the timer
            });
        }

        private void To_MainPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}