using Android.App;
using Android.Widget;
using Android.OS;

namespace Github_Testing
{
    [Activity(Icon = "@drawable/ic_launcher", Label = "MAGIC 8BALL",
       MainLauncher = true, Theme = "@android:style/Theme.Material.NoActionBar",
         ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
        }
    }
}

