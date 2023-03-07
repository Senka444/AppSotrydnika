using App1.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public UserAuth CurrentUser { get; set; }
        public MainPage()
        {
            CurrentUser = new UserAuth();

            InitializeComponent();
        }

        private async void Sign_In(object sender, EventArgs e)
        {
            /*var client = new WebClient();
            client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
            var result = client.UploadString("API user reg", JsonConvert.SerializeObject(CurrentUser));*/

 

            await Navigation.PushAsync(new Main());

        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}
