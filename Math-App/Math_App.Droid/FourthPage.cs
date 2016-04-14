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
using Android.Content.PM;

namespace Math_App.Droid
{
    [Activity(Label = "RekenApp", ScreenOrientation = ScreenOrientation.Portrait, Icon = "@drawable/icon")]
    public class FourthPage : Activity
    {

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.FourthPage);

            // Set answer/equation textview
            TextView answer = (TextView)FindViewById<TextView>(Resource.Id.page4_answer);
            TextView equation = (TextView)FindViewById<TextView>(Resource.Id.page4_equation);
            answer.Text = Intent.GetStringExtra("answer");
            equation.Text = Intent.GetStringExtra("equation");

            // Get our Gallery
            CustomGallery gallery = (CustomGallery)FindViewById<CustomGallery>(Resource.Id.gallery);

            // Reference it to our adapter
            gallery.Adapter = new ImageAdapter(this, new List<int> {
                2130837506,
                Resource.Drawable.maarten,
                Resource.Drawable.maarten,
                Resource.Drawable.maarten,
                Resource.Drawable.tom
            });            

            // Get Level textfield
            TextView level = (TextView)FindViewById<TextView>(Resource.Id.textLevel);
            level.Text = "Strategy" + " " + "Level1";   

            // Create imageclick
            gallery.ItemClick += delegate (object sender, Android.Widget.AdapterView.ItemClickEventArgs e)
            {
                int x = gallery.SelectedItemPosition;
                Console.WriteLine(x.ToString());
                Intent fifth = new Intent(this, typeof(FifthPage));
                Bundle extras = new Bundle();
                extras.PutInt("index", x);
                extras.PutString("answer", Intent.GetStringExtra("answer"));
                extras.PutString("equation", Intent.GetStringExtra("equation"));
                fifth.PutExtras(extras);
                StartActivity(fifth);

            };

            // Get Buttons
            ImageButton back = (ImageButton)FindViewById<ImageButton>(Resource.Id.imageButton1);
            ImageButton next = (ImageButton)FindViewById<ImageButton>(Resource.Id.imageButton2);

            // Get ImageViews
            ImageView image1 = (ImageView)FindViewById<ImageView>(Resource.Id.imageView1);
            ImageView image2 = (ImageView)FindViewById<ImageView>(Resource.Id.imageView2);
            ImageView image3 = (ImageView)FindViewById<ImageView>(Resource.Id.imageView3);
            ImageView image4 = (ImageView)FindViewById<ImageView>(Resource.Id.imageView4);
            ImageView image5 = (ImageView)FindViewById<ImageView>(Resource.Id.imageView5);

        // Item selected change events
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

            ImageButton previousButton = (ImageButton)FindViewById<ImageButton>(Resource.Id.imageButton1);
            previousButton.Click += delegate {
                if(gallery.SelectedItemPosition != 0)
                {
                    gallery.SetSelection(gallery.SelectedItemPosition + -1);
                }
            };

            ImageButton nextButton = (ImageButton)FindViewById<ImageButton>(Resource.Id.imageButton2);
            nextButton.Click += delegate{
                if(gallery.SelectedItemPosition != 4)
                {
                    gallery.SetSelection(gallery.SelectedItemPosition + 1);
                }
            };
        }
    }
}

