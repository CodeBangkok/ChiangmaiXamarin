using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ChiangmaiXamarin.Library;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace ChiangmaiXamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            myButton.Clicked += MyButton_Clicked;
            myListView.ItemTapped += MyListView_ItemTapped;
        }

        protected async override void OnAppearing()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://chiangmaiapi.azurewebsites.net");

            var response = await client.GetAsync("api/values");
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var json = await response.Content.ReadAsStringAsync();
                var customers = JsonConvert.DeserializeObject<List<Customer>>(json);
                myListView.ItemsSource = customers;
            }
        }

        async void MyButton_Clicked(object sender, EventArgs e)
        {
            myLabel.Text = myEntry.Text;

            Application.Current.Properties["Name"] = myEntry.Text;

            await myButton.RotateTo(360, 1000);
            await myButton.RotateTo(0, 1000);
        }

        void MyListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var customer = e.Item as Customer;

            Navigation.PushAsync(new CustomerDetailPage(customer));
        }

    }
}
