using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace Github_Testing
{
    [Activity(Icon = "@drawable/ic_launcher", Label = "MAGIC 8BALL",
       MainLauncher = true, Theme = "@android:style/Theme.Material.NoActionBar",
         ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait, NoHistory = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var GoToFirst = FindViewById<Button>(Resource.Id.GoToFirst);
            var GoToSecond = FindViewById<Button>(Resource.Id.GoToSecond);

            GoToFirst.Click += (s ,e) => 
            {
                Intent GoToFirstAct = new Intent(this, typeof(FirstActivity));
                StartActivity(typeof(FirstActivity));
            };

            GoToSecond.Click += (s, e) =>
            {
                Intent GoToSecondAct = new Intent(this, typeof(SecondActivity));
                StartActivity(typeof(SecondActivity));
            };

        }
    }
}

