using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Github_Testing
{
    [Activity(Label = "SecondActivity", NoHistory = true)]
    public class SecondActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Second);

            var GoBackFromSecond = FindViewById<Button>(Resource.Id.GoBackFromSecond);

            GoBackFromSecond.Click += (s, e) =>
            {
                Intent GoToMain = new Intent(this, typeof(MainActivity));
                StartActivity(typeof(MainActivity));
            };
        }
    }
}