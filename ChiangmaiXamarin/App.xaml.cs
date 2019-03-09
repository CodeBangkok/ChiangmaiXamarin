using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace ChiangmaiXamarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var np = new NavigationPage(new MainPage());
            np.Title = "Page 1";
            np.Icon = "tab1";

            var tp = new TabbedPage();
            tp.Children.Add(np);

            np = new NavigationPage(new Tab2Page());
            np.Title = "Page 2";
            np.Icon = "tab2";
            tp.Children.Add(np);

            tp.Children.Add(new Tab3Page());


            var mp = new MasterDetailPage();
            mp.Master = new MenuPage();
            mp.Detail = tp;

            //if (DeviceInfo.Idiom == DeviceIdiom.Phone)
            //{

            //}                    

            MainPage = mp;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
