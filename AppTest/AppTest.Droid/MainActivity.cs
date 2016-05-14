using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using ZXing.Mobile;
using Acr.UserDialogs;

namespace AppTest.Droid
{
    [Activity(Label = "AppTest", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            MobileBarcodeScanner.Initialize(Application);
            //ZXing.Net.Mobile.Forms.Android.Platform.Init();
            UserDialogs.Init(this);
            Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
        }
    }
}

