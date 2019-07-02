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
    public partial class DailyViewPage : ContentPage
    {
        public DailyViewPage(ReflectionModel reflection)
        {
            InitializeComponent();
            PostTitle.Text = reflection.Title;
            PostAuthorDate.Text = reflection.Author_Date;
            PostImage.Source = reflection.ImagesUrl;
            PostContent.Text = reflection.PostContent;







            List<somethinges> things = new List<somethinges>
            {
                new somethinges{Title="This", Author="That"},
                   new somethinges{Title="This", Author="That"},
                        new somethinges{Title="This", Author="That"},
                   new somethinges{Title="This", Author="That"},
                      new somethinges{Title="This", Author="That"},
                   new somethinges{Title="This", Author="That"},
                        new somethinges{Title="This", Author="That"},
                   new somethinges{Title="This", Author="That"},
                          new somethinges{Title="This", Author="That"},
                   new somethinges{Title="This", Author="That"},
                        new somethinges{Title="This", Author="That"}

            };
          //  carousel.ItemsSource = things.AsEnumerable();
        }
    }
    class somethinges
    {
        public string Title { get; set; }
        public string Author { get; set; }
    }
}