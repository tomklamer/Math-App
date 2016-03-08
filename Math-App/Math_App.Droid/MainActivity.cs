using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Math_App.Droid
{
    [Activity(Label = "RekenApp", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            Button button = FindViewById<Button>(Resource.Id.button1);
            button.Click += delegate
            {
                //button.Text = string.Format("{0} user clicks!", 20);
                var second = new Intent(this, typeof(SecondPage));
                second.PutExtra("ActivityData", "Data from FirstActivity: ");
                StartActivity(typeof(SecondPage));
            };
        }


    }
}


