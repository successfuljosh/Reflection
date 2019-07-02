using System;
using System.Collections.Generic;
using System.Text;

namespace Reflections.Model
{

  public  class ReflectionModel
    {
        public string Title { get; set; }
        public Type PostType { get; set; }
        public DateTime PostDate { get; set; }
        public string PostContent { get; set; }
        public string Author { get; set; }
        //public List<string> ImagesUrl { get; set; }
        public string ImagesUrl { get; set; }
        public string Author_Date => Author + " on " + PostDate.ToString("ddd, dd-MMM-yyyy");

    }

    public enum Type
    {
        Daily,
        Weekly,
        Monthly,
        Solemnity,
        Feast_Days,
        Inspirational_Articles
    }
}
