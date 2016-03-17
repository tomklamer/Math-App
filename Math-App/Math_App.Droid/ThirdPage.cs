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
            List<StrategyInfo> arrayOfUsers = new List<StrategyInfo>();
            // Create the adapter to convert the array to views
            GridAdapter adapter = new GridAdapter(this, arrayOfUsers);
            // Attach the adapter to a ListView
            GridView grid = (GridView)FindViewById(Resource.Id.grid);
            grid.Adapter = adapter;

            //Add item to adapter
            StrategyInfo newUser = new StrategyInfo("Nathan", "San Diego", "San Diego", "San Diego");
            StrategyInfo newUser1 = new StrategyInfo("Nathan", "San Diego", "San Diego", "San Diego");
            StrategyInfo newUser2 = new StrategyInfo("Nathan", "San Diego", "San Diego", "San Diego");
            StrategyInfo newUser3 = new StrategyInfo("Nathan", "San Diego", "San Diego", "San Diego");
            StrategyInfo newUser4 = new StrategyInfo("Nathan", "San Diego", "San Diego", "San Diego");
            StrategyInfo newUser5 = new StrategyInfo("Nathan", "San Diego", "San Diego", "San Diego");
            StrategyInfo newUser6 = new StrategyInfo("Nathan", "San Diego", "San Diego", "San Diego");
            StrategyInfo newUser7 = new StrategyInfo("Nathan", "San Diego", "San Diego", "San Diego");
            StrategyInfo newUser8 = new StrategyInfo("Nathan", "San Diego", "San Diego", "San Diego");
            StrategyInfo newUser9 = new StrategyInfo("Nathan", "San Diego", "San Diego", "San Diego");
            StrategyInfo newUser10 = new StrategyInfo("Nathan", "San Diego", "San Diego", "San Diego");
            StrategyInfo newUser11 = new StrategyInfo("Nathan", "San Diego", "San Diego", "San Diego");
            StrategyInfo newUser12 = new StrategyInfo("Nathan", "San Diego", "San Diego", "San Diego");
            StrategyInfo newUser13 = new StrategyInfo("Nathan", "San Diego", "San Diego", "San Diego");
            StrategyInfo newUser14 = new StrategyInfo("Nathan", "San Diego", "San Diego", "San Diego");
            StrategyInfo newUser15 = new StrategyInfo("Nathan", "San Diego", "San Diego", "San Diego");
            adapter.Add(newUser);
            adapter.Add(newUser1);
            adapter.Add(newUser2);
            adapter.Add(newUser3);
            adapter.Add(newUser4);
            adapter.Add(newUser5);
            adapter.Add(newUser6);
            adapter.Add(newUser7);
            adapter.Add(newUser8);
            adapter.Add(newUser9);
            adapter.Add(newUser10);
            adapter.Add(newUser11);
            adapter.Add(newUser12);
            adapter.Add(newUser13);
            adapter.Add(newUser14);
            adapter.Add(newUser15);

            Intent intent = this.Intent;
            var text = intent.GetStringExtra("EXTRA_PASSWORD");
            var nb = intent.GetIntExtra("index", -1);

            TextView textview = (TextView)FindViewById(Resource.Id.textView3);

            textview.Text = nb.ToString();

            // item click -> navigate to next page
            GridView gridje = (GridView)FindViewById(Resource.Id.grid);
            gridje.ItemClick += (object sender, Android.Widget.AdapterView.ItemClickEventArgs e) =>
            {
                int x = e.Position;
                Intent fourth = new Intent(this, typeof(FourthPage));
                Bundle extras = new Bundle();
                extras.PutInt("index", x);
                extras.PutString("EXTRA_PASSWORD", "my_password");
                fourth.PutExtras(extras);
                StartActivity(fourth);
            };
        }
    }
}