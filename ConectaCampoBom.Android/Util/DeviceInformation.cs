using ConectaCampoBom.Droid.Util;
using ConectaCampoBom.Util;
using Xamarin.Forms;
using static Android.Media.Audiofx.BassBoost;

[assembly: Xamarin.Forms.Dependency(typeof(DeviceInformation))]

namespace ConectaCampoBom.Droid.Util
{
    public class DeviceInformation : IDeviceInformation
    {
        public string GetIdentifier()
        {
            return global::Android.OS.Build.Serial;
        }
    }
}