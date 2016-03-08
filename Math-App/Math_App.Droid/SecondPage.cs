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
    public class SecondPage : Activity

    {
        string[] range;
        ArrayAdapter adapter;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.SecondPage);

            ListView listView = (ListView)FindViewById(Resource.Id.listView1);

            range = new string[]{
              "mono",
              "monodroid",
              "monotouch",
              "monorail",
              "monodevelop",
              "monotone",
              "monopoly",
              "monomodal",
              "mononucleosis"
            };

            adapter = new ArrayAdapter<String>(this, Android.Resource.Layout.SimpleListItem1, range);
            listView.Adapter = adapter;
        }
    }           
}