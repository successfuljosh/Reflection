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
    public partial class AddPostPage : ContentPage
    {
        string ImgUrl;
        MediaFile file;
        public AddPostPage()
        {
            InitializeComponent();

            typePicker.ItemsSource = Enum.GetNames(typeof(Model.Type));
        }

        private async void PostButton_Clicked(object sender, EventArgs e)
        {//do the if checks
            loading.IsRunning = true;
            var imgname = typePicker.SelectedItem.ToString() + titleEntry.Text + datePicker.Date.ToString("ddMMMyyyy");
            ImgUrl = await App.Online_Db.storeImage_ReturnUrl(file.GetStream(), imgname);

            ReflectionModel refModel = new ReflectionModel
            {
                Author = authorEntry.Text,
                ImagesUrl = ImgUrl,
                Title = titleEntry.Text,
                PostContent = postContentEditor.Text,
                PostDate = datePicker.Date,
                PostType = (Model.Type)Enum.Parse(typeof(Model.Type), typePicker.SelectedItem.ToString()),

            };

            await App.Online_Db.AddReflection(refModel);
            await DisplayAlert("Success", "Reflection posted successfully", "OK");
            loading.IsRunning = false;

            await Navigation.PopModalAsync(true);
            await DisplayAlert("page pop", "one", "OK");
            await Navigation.PopAsync(true);
        }

        private async void SelectImageButton_Clicked(object sender, EventArgs e)
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
                postImage.Source = ImageSource.FromStream(() =>
                  {
                      var imgStream = file.GetStream();
                      return imgStream;
                  });
                //var imgname = titleEntry.Text + datePicker.Date.ToString("ddMMMyyyy");
                //ImgUrl = await App.Online_Db.storeImage_ReturnUrl(file.GetStream(), imgname);
                //await DisplayAlert("h", "Image Loaded", "OK");
            }
            catch(Exception ex)
            {
                Debug.Write(ex.Message);
            }
        }
    }
}