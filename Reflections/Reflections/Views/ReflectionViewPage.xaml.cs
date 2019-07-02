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
    public partial class ReflectionViewPage : ContentPage
    {
        public ReflectionViewPage(ReflectionModel reflection)
        {
            InitializeComponent();
            this.Title =reflection.PostType + " Reflection";
            PostTitle.Text = reflection.Title;
            PostAuthorDate.Text = reflection.Author_Date;
            PostImage.Source = reflection.ImagesUrl;
            PostContent.Text = reflection.PostContent;
        }
    }
}