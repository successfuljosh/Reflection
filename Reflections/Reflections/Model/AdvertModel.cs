using System;
using System.Collections.Generic;
using System.Text;

namespace Reflections.Model
{
   public class AdvertModel
    {
        public string Title { get; set; }
        public AdType AdvertType { get; set; }
        public AdFileType AdvertFileType { get; set; }
        public string FileUrl { get; set; }

    }
    public enum AdType
    {
        Banner,
        FullScreen
    }
    public enum AdFileType
    {
        Image,
        Video
    }
}
