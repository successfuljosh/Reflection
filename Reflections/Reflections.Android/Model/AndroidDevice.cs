using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Gms.Common;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Reflections.Droid.Model;
using Reflections.Model;

[assembly: Xamarin.Forms.Dependency(typeof(AndroidDevice))]
namespace Reflections.Droid.Model
{
    class AndroidDevice : IDevice
    {
        private static int RequestCodeEmail = 1;

        public string GetDeviceID()
        {
            return Android.Provider.Settings.Secure.GetString(Android.App.Application.Context.ContentResolver, Android.Provider.Settings.Secure.AndroidId);
        }


    }
}