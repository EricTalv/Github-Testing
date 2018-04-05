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
    [Activity(Label = "FirstActivity", NoHistory = true)]
    public class FirstActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.First);

            var GoBackFromFirst = FindViewById<Button>(Resource.Id.GoBackFromFirst);

            GoBackFromFirst.Click += (s, e) =>
            {
                Intent GoToMain = new Intent(this, typeof(MainActivity));
                StartActivity(typeof(MainActivity));
            };

        }
    }
}