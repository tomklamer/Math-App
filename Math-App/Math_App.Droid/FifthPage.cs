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
using Android.Graphics;
using System.Xml;
using System.Reflection;
using System.IO;
using System.Xml.Serialization;
using Math_App.Xml;

namespace Math_App.Droid
{
    [Activity(Label = "RekenApp", Icon = "@drawable/icon")]
    public class FifthPage : Activity

    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.FifthPage);

            ImageView imageview = (ImageView)FindViewById<ImageView>(Resource.Id.imageview1);
            int level = Intent.GetIntExtra("index", -1);

            imageview.SetImageResource(Resource.Drawable.maarten);
            imageview.SetScaleType(ImageView.ScaleType.FitCenter);

            TextView nameandlevel = FindViewById<TextView>(Resource.Id.nameAndLevel);
            TextView explanation = FindViewById<TextView>(Resource.Id.explanation);
            explanation.MovementMethod = new ScrollingMovementMethod();          

            string explantiontext = "Lorum ipsum Lorum ipsum Lorum ipsumLorum ipsum Lorum ipsum Lorum ipsum Lorum ipsum"
                + "Lorum ipsum Lorum ipsum Lorum ipsum Lorum ipsum Lorum ipsum Lorum ipsum Lorum ipsum Lorum ipsum Lorum ipsum"
                + " Lorum ipsum Lorum ipsumvLorum ipsum Lorum ipsum Lorum ipsumv Lorum ipsum Lorum ipsum"
                + " Lorum ipsum Lorum ipsum Lorum ipsum Lorum ipsum Lorum ipsum Lorum ipsum BOE";
            nameandlevel.Text = "Strategy name - Level " + level;
            explanation.Text = explantiontext;            

        }
    }
}