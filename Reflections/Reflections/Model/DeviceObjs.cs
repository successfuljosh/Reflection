using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Reflections.Model
{
 public class DeviceObjs
    {
        public string DeviceID => DependencyService.Get<IDevice>().GetDeviceID();
        public bool IsOnline { get; set; }
        public string SessionId { get; set; }
        public string IPAddress { get; set; }

        public DateTime AppLaunchTime => DateTime.Now;

        //manufacturer + model
        public string Name => DeviceInfo.Manufacturer + " " + DeviceInfo.Model;
        public string Type => DeviceInfo.DeviceType.ToString();
        public string Idiom => DeviceInfo.Idiom.ToString();

        //platform + Version String
        public string PlatformOS => DeviceInfo.Platform + " " + DeviceInfo.VersionString;


    }
    public class Device_AppDb_Push
    {
        public string AppName { get; set; }
        public DeviceObjs DeviceInformations = new DeviceObjs();

        FirebaseClient client = new FirebaseClient("https://appuser-db.firebaseio.com/");
        public Device_AppDb_Push(string appname)
        {
            AppName = appname;
            _ = Db_Push();
        }
        public async Task Db_Push()
        {
            await client
                .Child(AppName)
                .PostAsync<DeviceObjs>(DeviceInformations);
        }
    }




}
