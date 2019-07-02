using Reflections.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Reflections.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeTabPage : TabbedPage
    {
        public HomeTabPage()
        {
            InitializeComponent();




            //this.BarTextColor = Color.Yellow;
            //  this.BackgroundColor = Color.Red;
            BarBackgroundColor = Constants.navBarColor;


            //this.Children.Add(new Daily.DailyListPage());
            //this.Children.Add(new ContentPage
            //{
            //    Title = "Weekly Reflections"
            //});
            //this.Children.Add(new ContentPage
            //{
            //    Title = "Monthly Reflections"
            //});
            //this.Children.Add(new ContentPage
            //{
            //    Title = "Solemnity & Feast Days"
            //});
            //this.Children.Add(new ContentPage
            //{
            //    Title = "Inspirational Articles"
            //});
            try
            {

                Children.Add(new ReflectionListPage(Model.Type.Daily));
                Children.Add(new ReflectionListPage(Model.Type.Weekly));
                Children.Add(new ReflectionListPage(Model.Type.Monthly));
                Children.Add(new ReflectionListPage(Model.Type.Solemnity));
                Children.Add(new ReflectionListPage(Model.Type.Feast_Days));
                Children.Add(new ReflectionListPage(Model.Type.Inspirational_Articles));
            }
            catch(Exception ex)
            {
                DisplayAlert("Exception",ex.Message,"OK");
            }
        }

        private void AddReflectionToolbar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LoginPage());
        }

        private void AboutToolbar_Clicked(object sender, EventArgs e)
        {

        }
    }
}