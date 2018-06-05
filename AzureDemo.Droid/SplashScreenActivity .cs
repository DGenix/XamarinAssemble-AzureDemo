
using Android.App;
using MvvmCross.Platforms.Android.Views;

namespace AzureDemo.Droid
{
    [Activity(Label = "@string/app_name", MainLauncher = true, NoHistory = true, Icon = "@mipmap/ic_launcher")]
    public class SplashScreenActivity : MvxSplashScreenActivity
    {
        public SplashScreenActivity()
            : base(Resource.Layout.SplashScreen)
        {
        }
    }
}