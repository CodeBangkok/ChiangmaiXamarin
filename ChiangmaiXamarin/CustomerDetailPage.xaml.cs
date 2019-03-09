using System;
using System.Collections.Generic;
using ChiangmaiXamarin.Library;
using Xamarin.Forms;

namespace ChiangmaiXamarin
{
    public partial class CustomerDetailPage : ContentPage
    {
        public CustomerDetailPage()
        {
            InitializeComponent();
        }

        public CustomerDetailPage(Customer customer) : this()
        {
            Title = customer.Name;
            myLabel.Text = customer.Name;
        }
    }
}
