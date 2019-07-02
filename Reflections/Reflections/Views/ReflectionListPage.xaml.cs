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
    public partial class ReflectionListPage : ContentPage
    {
        IEnumerable<ReflectionModel> getReflections;
        Model.Type PostType;

        public ReflectionListPage(Model.Type postType)
        {
            InitializeComponent();
            //getReflections = App.Data.GetReflections.Where(x => x.PostType == postType);

            PostType = postType;

            Title = postType + " Reflections";

        }
        async protected override void OnAppearing()
        {
            base.OnAppearing();



            ////device informations
            //await DisplayAlert("Device Name", DeviceObjs.Name, "OK");
            //await DisplayAlert("Device Platform", DeviceObjs.PlatformOS, "OK");
            //await DisplayAlert("Device Id", DeviceObjs.DeviceID, "OK");
            //await DisplayAlert("Device type", DeviceObjs.Type, "OK");
            //await DisplayAlert("Device Idiom", DeviceObjs.Idiom, "OK");
            //await DisplayAlert("Device Time", DeviceObjs.AppLaunchTime.ToString(), "OK");

            try
            {
                ReflectionListView.IsRefreshing = true;
                getReflections = await App.Online_Db.GetAllReflections();
                getReflections = getReflections.Where(x => x.PostType == PostType);
                ReflectionListView.ItemsSource = getReflections;
                ReflectionListView.IsRefreshing = false;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Exception", ex.Message, "OK");
            }

        }
        private async void ReflectionListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //   await DisplayAlert("Clicked", "selected", "ok");
            // DailyListView.SelectedItem = null;
            var re = e.SelectedItem as ReflectionModel;
            await Navigation.PushAsync(new ReflectionViewPage(re));

        }

        private async void ReflectionListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {

            //   await DisplayAlert("Clicked", "tapped", "ok");
            //await Navigation.PushAsync(new DailyViewPage());
            //  DailyListView.SelectedItem = null;
        }

        private void SearchBar_SearchButtonPressed(object sender, EventArgs e)
        {

        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            string searchWord = searchBar.Text.ToLower();
            if (!string.IsNullOrEmpty(searchWord))
            {
                var searchResult = getReflections.Where(x => x.Title.ToLower().Contains(searchWord));
                if (searchResult == null)
                    searchResult = getReflections.Where(x => x.Author.ToLower().Contains(searchWord));
                ReflectionListView.ItemsSource = searchResult;
            }
            else
            {
                ReflectionListView.ItemsSource = getReflections;
            }
        }

        private async void ReflectionListView_Refreshing(object sender, EventArgs e)
        {
            ReflectionListView.IsRefreshing = true;
            getReflections = await App.Online_Db.GetAllReflections();
            getReflections = getReflections.Where(x => x.PostType == PostType);
            ReflectionListView.ItemsSource = getReflections;
            ReflectionListView.IsRefreshing = false;
        }
    }
}