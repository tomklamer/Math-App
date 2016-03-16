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

namespace Math_App.Droid
{
    [Activity(Label = "RekenApp", Icon = "@drawable/icon")]
    public class FourthPage : Activity
    {

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.FourthPage);

            // Get our Gallery
            CustomGallery gallery = (CustomGallery)FindViewById<CustomGallery>(Resource.Id.gallery);
            // Reference it to our adapter
            gallery.Adapter = new ImageAdapter(this);

            // Create imageclick
            gallery.ItemClick += delegate (object sender, Android.Widget.AdapterView.ItemClickEventArgs e) {
                int x = e.Position;
                Console.WriteLine(x.ToString());
                Intent fifth = new Intent(this, typeof(FifthPage));
                Bundle extras = new Bundle();
                extras.PutInt("index", x);
                extras.PutString("EXTRA_PASSWORD", "my_password");
                fifth.PutExtras(extras);
                StartActivity(fifth);
            };


        }
    }
}

