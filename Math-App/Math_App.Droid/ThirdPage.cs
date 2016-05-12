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
using Math_App.Models;
using Android.Content.PM;
using Math_App.Solutions;
using Android.Views.Animations;

namespace Math_App.Droid
{
    [Activity(Label = "RekenApp", ScreenOrientation = ScreenOrientation.Portrait, Icon = "@drawable/icon")]
    public class Thirdpage : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.ThirdPage);

            // Construct the data source
            List<ICheckStrategy> arrayOfUsers = new List<ICheckStrategy>();
            // Create the adapter to convert the array to views
            StrategyAdapter adapter = new StrategyAdapter(this, arrayOfUsers);
            // Attach the adapter to a ListView
            ListView listView = (ListView)FindViewById(Resource.Id.grid);
            listView.Adapter = adapter;
            // set animation
            Animation anim = AnimationUtils.LoadAnimation(this, Resource.Layout.Fade_in);
            listView.StartAnimation(anim);

            // create equation class
            List<ICheckStrategy> strats = new List<ICheckStrategy>();

            // Get intent data
            Intent intent = this.Intent;
            string sign = intent.GetStringExtra("sign");
            string partAnswer = intent.GetStringExtra("partAnswer");
            string partEquation = intent.GetStringExtra("partEquation");
            string solution = intent.GetStringExtra("solution");
            string equation = intent.GetStringExtra("equation");
            string a = intent.GetStringExtra("a");
            string b = intent.GetStringExtra("b");
            var nb = intent.GetIntExtra("index", -1);

            // Get Strategy types
            CalculationTypeAnalyzer an = new CalculationTypeAnalyzer();
            List<ICheckStrategy> lijst;
            if (an.GetCalcType(sign, a, b).getSolutions() != null)
            {
                lijst = an.GetCalcType(sign, a, b).getSolutions();

                // Put Strategy info in view
                for (int i = 0; i < lijst.Count; i++)
                {
                    adapter.Add(lijst[i]);
                }
            }                 

            // Put Strategies info in view
            TextView textview0 = (TextView)FindViewById(Resource.Id.page3_equation);
            textview0.Text = partEquation;
            TextView textview1 = (TextView)FindViewById(Resource.Id.page3_answer);
            textview1.Text = partAnswer;

            // item click -> navigate to next page
            ListView gridje = (ListView)FindViewById(Resource.Id.grid);
            gridje.ItemClick += (object sender, Android.Widget.AdapterView.ItemClickEventArgs e) =>
            {
                Console.WriteLine(e.ToString());
                Intent fourth = new Intent(this, typeof(ViewFlipperActivity));
                Bundle extras = new Bundle();
                extras.PutString("answer", partAnswer);
                extras.PutString("equation", partEquation);
                extras.PutString("equation", partEquation);
                fourth.PutExtras(extras);
                StartActivity(fourth);
            };
        }
    }
}