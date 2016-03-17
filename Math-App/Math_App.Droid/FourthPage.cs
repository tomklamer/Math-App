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

            // Get Level textfield
            TextView level = (TextView)FindViewById<TextView>(Resource.Id.textLevel);
            level.Text = "Strategy" + " " + "Level1";   

            // Create imageclick
            gallery.ItemClick += delegate (object sender, Android.Widget.AdapterView.ItemClickEventArgs e)
            {
                int x = e.Position;
                Console.WriteLine(x.ToString());
                Intent fifth = new Intent(this, typeof(FifthPage));
                Bundle extras = new Bundle();
                extras.PutInt("index", x);
                extras.PutString("EXTRA_PASSWORD", "my_password");
                fifth.PutExtras(extras);
                StartActivity(fifth);
            };

            // Get ImageViews
            ImageView image1 = (ImageView)FindViewById<ImageView>(Resource.Id.imageView1);
            ImageView image2 = (ImageView)FindViewById<ImageView>(Resource.Id.imageView2);
            ImageView image3 = (ImageView)FindViewById<ImageView>(Resource.Id.imageView3);
            ImageView image4 = (ImageView)FindViewById<ImageView>(Resource.Id.imageView4);
            ImageView image5 = (ImageView)FindViewById<ImageView>(Resource.Id.imageView5);

            gallery.ItemSelected += (object sender, Android.Widget.AdapterView.ItemSelectedEventArgs e ) =>
            {
                Console.WriteLine(gallery.SelectedItemId.ToString());
                switch (gallery.SelectedItemPosition.ToString())
                {
                    case "0":
                        level.Text = "Strategy" + " " + "Level1";

                        image2.SetBackgroundColor(Android.Graphics.Color.Transparent);
                        image3.SetBackgroundColor(Android.Graphics.Color.Transparent);
                        image4.SetBackgroundColor(Android.Graphics.Color.Transparent);
                        image5.SetBackgroundColor(Android.Graphics.Color.Transparent);

                        image1.SetBackgroundColor(Android.Graphics.Color.Black);
                        break;
                    case "1":
                        level.Text = "Strategy" + " " + "Level2";

                        image1.SetBackgroundColor(Android.Graphics.Color.Transparent);
                        image3.SetBackgroundColor(Android.Graphics.Color.Transparent);
                        image4.SetBackgroundColor(Android.Graphics.Color.Transparent);
                        image5.SetBackgroundColor(Android.Graphics.Color.Transparent);

                        image2.SetBackgroundColor(Android.Graphics.Color.Black);
                        break;
                    case "2":
                        level.Text = "Strategy" + " " + "Level3";

                        image1.SetBackgroundColor(Android.Graphics.Color.Transparent);
                        image2.SetBackgroundColor(Android.Graphics.Color.Transparent);
                        image4.SetBackgroundColor(Android.Graphics.Color.Transparent);
                        image5.SetBackgroundColor(Android.Graphics.Color.Transparent);

                        image3.SetBackgroundColor(Android.Graphics.Color.Black);
                        break;
                    case "3":
                        level.Text = "Strategy" + " " + "Level4";

                        image1.SetBackgroundColor(Android.Graphics.Color.Transparent);
                        image2.SetBackgroundColor(Android.Graphics.Color.Transparent);
                        image3.SetBackgroundColor(Android.Graphics.Color.Transparent);
                        image5.SetBackgroundColor(Android.Graphics.Color.Transparent);

                        image4.SetBackgroundColor(Android.Graphics.Color.Black);
                        break;
                    case "4":
                        level.Text = "Strategy" + " " + "Level5";

                        image1.SetBackgroundColor(Android.Graphics.Color.Transparent);
                        image2.SetBackgroundColor(Android.Graphics.Color.Transparent);
                        image3.SetBackgroundColor(Android.Graphics.Color.Transparent);
                        image4.SetBackgroundColor(Android.Graphics.Color.Transparent);

                        image5.SetBackgroundColor(Android.Graphics.Color.Black);
                        break;
                };
            };
        }
    }
}

