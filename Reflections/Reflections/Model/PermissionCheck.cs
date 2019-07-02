using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Reflections.Model
{
   public class PermissionCheck
    {
        public async Task<bool> Check()
        {
            //try
            //{
                var status =await CrossPermissions.Current.CheckPermissionStatusAsync(Permission.Storage);
                if (status != PermissionStatus.Granted)
                {
                    if (await CrossPermissions.Current.ShouldShowRequestPermissionRationaleAsync(Permission.Storage))
                    {
                
                    //   await DisplayAlert("Need location", "Gunna need that location", "OK");
                    }

                    var results = await CrossPermissions.Current.RequestPermissionsAsync(new[] { Permission.Storage });
                    status = results[Permission.Storage];

                }

                if (status == PermissionStatus.Granted)
                {
                    return true;
                    //var results = await CrossGeolocator.Current.GetPositionAsync(10000);
                    //LabelGeolocation.Text = "Lat: " + results.Latitude + " Long: " + results.Longitude;
                }
                else if (status != PermissionStatus.Unknown)
                {
                    return false;
                }

           return true;
            //catch (Exception ex)
            //{

            //    LabelGeolocation.Text = "Error: " + ex;
            //}
        }
    }
}
