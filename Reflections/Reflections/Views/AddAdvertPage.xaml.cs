using Plugin.Media;
using Plugin.Media.Abstractions;
using Reflections.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Reflections.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddAdvertPage : ContentPage
    {
        MediaFile file;
        string adExt;
        public AddAdvertPage()
        {
            InitializeComponent();

            selectAdImageButton.IsVisible = false;
            adImage.IsVisible = false;
            selectAdVideoButton.IsVisible = false;
            videoName.IsVisible = false;

            adTypePicker.ItemsSource = Enum.GetValues(typeof(Model.AdType));
        }

        private async void SendButton_Clicked(object sender, EventArgs e)
        {
            try
            {
                //do the if checks
                loading.IsRunning = true;
                var filename = titleEntry.Text + adTypePicker.SelectedItem.ToString() + filePicker.SelectedItem.ToString() + "AdvertPost" + DateTime.Now.Millisecond + adExt;
                var AdUrl = await App.Online_Db.StoreImage_ReturnUrl(file.GetStream(), filename);

                AdvertModel adModel = new AdvertModel
                {
                    Title = titleEntry.Text,
                    AdvertFileType = (AdFileType)Enum.Parse(typeof(AdFileType), filePicker.SelectedItem.ToString()),
                    AdvertType = (AdType)Enum.Parse(typeof(AdType), adTypePicker.SelectedItem.ToString()),
                    FileUrl = AdUrl
                };

                await App.Online_Db.AddAdverts(adModel);
                await DisplayAlert("Success", "Adverts posted successfully", "OK");
                loading.IsRunning = false;

                //await Navigation.PopModalAsync(true);
                //await DisplayAlert("page pop", "one", "OK");
                //await Navigation.PopAsync(true);

                //Back to Home Page
                App.Current.MainPage = new NavigationPage(new HomeTabPage())
                {
                    BarBackgroundColor = Constants.navBarColor
                };
            }
            catch
            {
                await DisplayAlert("Error", "Pls check network connectivity", "OK");
                loading.IsRunning = false;
            }
        }

        private void AdTypePicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var adType_selected = (AdType)adTypePicker.SelectedItem;
            if (adType_selected == AdType.Banner)
            {
                filePicker.ItemsSource = new string[] { AdFileType.Image.ToString() };

            }
            else 
                filePicker.ItemsSource = Enum.GetValues(typeof(AdFileType));

            selectAdImageButton.IsVisible = false;
            adImage.IsVisible = false;
            selectAdVideoButton.IsVisible = false;
            videoName.IsVisible = false;
        }

        private void FilePicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var filetypeSelected = (AdFileType)filePicker.SelectedIndex;
            if (filetypeSelected== AdFileType.Image)
            {
                adExt = ".jpg";
                selectAdImageButton.IsVisible = true;
                adImage.IsVisible = true;
                selectAdVideoButton.IsVisible = false;
                videoName.IsVisible = false;
            }
            else
            {
                adExt = ".mp4";
                selectAdImageButton.IsVisible = false;
                adImage.IsVisible = false;
                selectAdVideoButton.IsVisible = true;
                videoName.IsVisible = true;
            }
        }

        private async void SelectAdImageButton_Clicked(object sender, EventArgs e)
        {
            await CrossMedia.Current.Initialize();
            try
            {

                file = await Plugin.Media.CrossMedia.Current.PickPhotoAsync(new Plugin.Media.Abstractions.PickMediaOptions
                {
                    PhotoSize = Plugin.Media.Abstractions.PhotoSize.Small
                });
                if (file == null)
                    return;

                loading.IsRunning = true;


                adImage.Source = ImageSource.FromStream(() =>
                {
                    var imgStream = file.GetStream();
                    return imgStream;
                });

                loading.IsRunning = false;

                //var imgname = titleEntry.Text + datePicker.Date.ToString("ddMMMyyyy");
                //ImgUrl = await App.Online_Db.storeImage_ReturnUrl(file.GetStream(), imgname);
                //await DisplayAlert("h", "Image Loaded", "OK");

            }
            catch (Exception ex)
            {
                Debug.Write(ex.Message);
            }
        }

        private void SelectAdVideoButton_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Hello", "Work in Progress", "OK");
        }
    }
}