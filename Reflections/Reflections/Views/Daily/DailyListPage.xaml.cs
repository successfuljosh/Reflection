using Reflections.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Reflections.Views.Daily
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DailyListPage : ContentPage
    {
        IEnumerable<ReflectionModel> dailyReflections;
        public DailyListPage()
        {
            InitializeComponent();

            dailyReflections = App.Data.GetReflections.Where(x => x.PostType == Model.Type.Daily);
          
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            DailyListView.ItemsSource = dailyReflections;
        }
        private async void DailyListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //   await DisplayAlert("Clicked", "selected", "ok");
            // DailyListView.SelectedItem = null;
            var re = e.SelectedItem as ReflectionModel;
            await Navigation.PushAsync(new DailyViewPage(re));
          
        }

        private async void DailyListView_ItemTapped(object sender, ItemTappedEventArgs e)
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
                var searchResult = dailyReflections.Where(x => x.Title.ToLower().Contains(searchWord));
                if (searchResult == null)
                    searchResult = dailyReflections.Where(x => x.Author.ToLower().Contains(searchWord));
                DailyListView.ItemsSource = searchResult;
            }
            else
            {
                DailyListView.ItemsSource = dailyReflections;
            }
        }
    }
    class something
    {
        public string Title { get; set; }
        public string Author { get; set; }
    }
}