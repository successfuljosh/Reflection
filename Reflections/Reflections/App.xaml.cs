using Reflections.DataSource;
using Reflections.Model;
using Reflections.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Reflections
{
    public partial class App : Application
    {
        public static DailyData Data;
        public static FirebaseDb Online_Db;
        public static Device_AppDb_Push Device_AppDb_;
        public App()
        {
            InitializeComponent();

            Data = new DailyData();

            Online_Db = new FirebaseDb();

            Device_AppDb_ = new Device_AppDb_Push("Reflections");

            MainPage = new NavigationPage(new HomeTabPage())
            {
                BarBackgroundColor = Constants.navBarColor
            };
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
