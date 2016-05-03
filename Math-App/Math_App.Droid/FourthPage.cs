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
using Android.Text.Method;
using Math_App.Xml;
using System.Reflection;
using System.IO;
using Android.Content.PM;

namespace Math_App.Droid
{

    [Activity(Label = "RekenApp", MainLauncher = true, ScreenOrientation = ScreenOrientation.Portrait, Icon = "@drawable/icon")]
    public class ViewFlipperActivity : Activity
    {

        private ViewFlipper _flipper;
        private Button btnPrev, btnNext;
        private TextView info, titel, info2, titel2, info3, titel3, info4, titel4;
        private ImageView image, image2, image3, image4;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.FourthPage);

            // Prefix
            var resourcePrefix = "Math_App.Droid.";

            // Create stream with path
            var assembly = typeof(MainActivity).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream(resourcePrefix + "Strategies.xml"); ;

            // Read Xml file & create strategy object
            StrategyXmlObject strat = new StrategyXmlObject();
            strat = ReaderXml.ReadFile(stream, "Optellen naar analogie");

            _flipper = FindViewById<ViewFlipper>(Resource.Id.viewFlipper);

            btnNext = FindViewById<Button>(Resource.Id.btnNext);
            btnPrev = FindViewById<Button>(Resource.Id.btnPrev);

            titel = FindViewById<TextView>(Resource.Id.nameAndLevel);
            titel.Text = strat.Level1.title;
            info = FindViewById<TextView>(Resource.Id.explanation);
            info.Text = strat.Level1.text;

            //image = FindViewById<ImageView>(Resource.Id.img);
            //int id = Resources.GetIdentifier(strat.Level1.image, "drawable", "Math_App.Droid");
            //image.SetImageResource(id);

            titel2 = FindViewById<TextView>(Resource.Id.nameAndLevel2);
            titel2.Text = strat.Level2.title;
            info2 = FindViewById<TextView>(Resource.Id.explanation2);
            info2.Text = strat.Level2.text;

            //image2 = FindViewById<ImageView>(Resource.Id.img2);
            //int id2 = Resources.GetIdentifier(strat.Level2.image, "drawable", "Math_App.Droid");
            //image2.SetImageResource(id2);

            titel3 = FindViewById<TextView>(Resource.Id.nameAndLevel3);
            titel3.Text = strat.Level3.title;
            info3 = FindViewById<TextView>(Resource.Id.explanation3);
            info3.Text = strat.Level3.text;

            //image3 = FindViewById<ImageView>(Resource.Id.img3);
            //int id3 = Resources.GetIdentifier(strat.Level3.image, "drawable", "Math_App.Droid");
            //image3.SetImageResource(id3);

            titel4 = FindViewById<TextView>(Resource.Id.nameAndLevel4);
            titel4.Text = strat.Level4.title;
            info4 = FindViewById<TextView>(Resource.Id.explanation4);
            info4.Text = strat.Level4.text;

            //image4 = FindViewById<ImageView>(Resource.Id.img4);
            //int id4 = Resources.GetIdentifier(strat.Level4.image, "drawable", "Math_App.Droid");
            //image4.SetImageResource(id4);


            // Use button clicks to cycle through views
            btnNext.Click += (sender, e) => {
                // Use custom animations
                _flipper.SetOutAnimation(this, Resource.Layout.Slideout_top);
                _flipper.SetInAnimation(this, Resource.Layout.Slidein_bot);
                // Use Android built-in animations
                //_flipper.SetInAnimation(this, Android.Resource.Animation.SlideInLeft);      
                //_flipper.SetOutAnimation(this, Android.Resource.Animation.SlideOutRight);
                _flipper.ShowNext();
            };
            btnPrev.Click += (sender, e) => {
                // Use custom animations
                _flipper.SetOutAnimation(this, Resource.Layout.Slideout_bot);
                _flipper.SetInAnimation(this, Resource.Layout.Slidein_top);
                // Use Android built-in animations
                //_flipper.SetInAnimation(this, Android.Resource.Animation.SlideInLeft);
                //_flipper.SetOutAnimation(this, Android.Resource.Animation.SlideOutRight);
                _flipper.ShowPrevious();
            };

        }
    }
}