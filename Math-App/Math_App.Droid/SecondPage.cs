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
    public class SecondPage : Activity

    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.SecondPage);

            // Construct the data source
            List<Equation> arrayOfUsers = new List<Equation>();
            // Create the adapter to convert the array to views
            EquationsAdapter adapter = new EquationsAdapter(this, arrayOfUsers);
            // Attach the adapter to a ListView
            ListView listView = (ListView)FindViewById(Resource.Id.listView1);
            listView.Adapter = adapter;

            //Add item to adapter
            Equation newUser = new Equation("Nathan", "San Diego");
            Equation newUser1 = new Equation("Nathan", "San Diego");
            Equation newUser2 = new Equation("Nathan", "San Diego");
            Equation newUser3 = new Equation("Nathan", "San Diego");
            Equation newUser4 = new Equation("Nathan", "San Diego");
            Equation newUser5 = new Equation("Nathan", "San Diego");
            Equation newUser6 = new Equation("Nathan", "San Diego");
            Equation newUser7 = new Equation("Nathan", "San Diego");
            adapter.Add(newUser);
            adapter.Add(newUser1);
            adapter.Add(newUser2);
            adapter.Add(newUser3);
            adapter.Add(newUser4);
            adapter.Add(newUser5);
            adapter.Add(newUser6);
            adapter.Add(newUser7);

            // item click -> navigate to next page
            TextView textView = (TextView)FindViewById(Resource.Id.textView1);
            listView.ItemClick += (object sender, Android.Widget.AdapterView.ItemClickEventArgs e) =>
            {
                int x = e.Position;
                Intent third = new Intent(this, typeof(Thirdpage));
                Bundle extras = new Bundle();
                extras.PutInt("index", x);
                extras.PutString("EXTRA_PASSWORD","my_password");
                third.PutExtras(extras);
                StartActivity(third);
            };
        }
    }           
}