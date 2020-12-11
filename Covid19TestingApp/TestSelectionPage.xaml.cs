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
    public partial class TestSelectionPage : ContentPage
    {
        string[] freeLocations = { "    18 San Fernando Ave, San Jose CA, 95192", "    238 Washington Ave, San Ramon CA, 92423", "    712 Alcatraz St, San Francisco CA, 94523" };
        string[] paidLocations = { "    343 Rodeo Drive, Los Angeles CA, 95232", "    931 Miami Steet, San Jose CA, 95192", "    1 Washington Square, San Jose CA, 95192" };
        string[] freeQueue = { "12, 18, 7" };
        string[] paidQueue = { "17, 9, 3" };
        double[] freeDist = { 5.4, 7.9, 21.0 };
        double[] paidDist = { 13.4, 16, 2.2 };
        public TestSelectionPage(User newUser2)
        {
            InitializeComponent();
            if (newUser2.payPreference == "Paid")
            {
                address11.Text = paidLocations[0];
                address2.Text = paidLocations[1];
                address3.Text = paidLocations[2];
                payop1.Text = "Paid";
                payop2.Text = "Paid";
                payop3.Text = "Paid";
               /* people1.Text = paidQueue[0];
                people2.Text = paidQueue[1];
                people3.Text = paidQueue[2];
                travel1.Text = paidDist[0].ToString() + " mi";
                travel2.Text = paidDist[2].ToString() + " mi";
                travel3.Text = paidDist[3].ToString() + " mi";*/
            } else if (newUser2.payPreference == "Free")
            {
                address11.Text = freeLocations[0];
                address2.Text = freeLocations[1];
                address3.Text = freeLocations[2];
                payop1.Text = "Free";
                payop2.Text = "Free";
                payop3.Text = "Free";
                /*people1.Text = freeQueue[0];
                people2.Text = freeQueue[1];
                people3.Text = freeQueue[2];
                travel1.Text = freeDist[0].ToString() + " mi";
                travel2.Text = freeDist[2].ToString() + " mi";
                travel3.Text = freeDist[3].ToString() + " mi";*/
            }
        }

        private void To_VirtualQueuePage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new VirtualQueuePage());
        }

        private void picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            string temp;
            string temp2;/*
            if (picker.SelectedItem.ToString() == "Nearest")
            {
                address11.Text = paidLocations[0];
                address2.Text = paidLocations[1];
                address3.Text = paidLocations[2];
                
            } */ 
            if (picker.SelectedItem.ToString() == "Shortest Wait Time")
            {
                //12,28,7
                address11.Text = paidLocations[2];
                address2.Text = paidLocations[0];
                address3.Text = paidLocations[1];
                people1.Text = "7";
                people2.Text = "12";
                people3.Text = "28";
                
                temp = travel1.Text;
                travel1.Text = travel3.Text;
                temp2 = travel2.Text;
                travel2.Text = temp;
                travel3.Text = temp2;

            }
        }
    }
}