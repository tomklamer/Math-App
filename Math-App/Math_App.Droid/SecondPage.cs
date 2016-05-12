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
using Math_App.TempStorage;
using Math_App.StaticObjects;
using Android.Content.PM;
using Android.Views.Animations;

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
            // set animation
            Animation anim = AnimationUtils.LoadAnimation(this, Resource.Layout.Fade_in);
            listView.StartAnimation(anim);

            // Get data from bundle
            Intent intent = this.Intent;
            var calc = intent.GetStringExtra("calculation");

            // Do calculation operations
            MainEquation curEquation = new MainEquation();
            Console.WriteLine(StringAnalyzer.AddStrings(calc));
            curEquation.setString(StringAnalyzer.AddStrings(calc));
            curEquation.buildBrackets();

            // create equation class
            List<Equation> equations = new List<Equation>();

            // copy equations list and create equation class
            for (int i = 0; i < curEquation.getEquationsStrings().Count; i++)
            {
                equations.Add( new Equation(curEquation.getSolution().ToString(), 
                                            curEquation.getString(), 
                                            curEquation.getEquationsStrings()[i], 
                                            curEquation.getEquationsSolution()[i],
                                            curEquation.equationsToShow[i].a,
                                            curEquation.equationsToShow[i].b,
                                            curEquation.equationsToShow[i].sign));
            }

            // Set Answer and calculation
            TextView answer = (TextView)FindViewById(Resource.Id.answer);
            TextView calculation = (TextView)FindViewById(Resource.Id.calculation);
            answer.Text = curEquation.getSolution().ToString();
            calculation.Text = calc;

            // Fill adapter
            for (int i = 0; i < equations.Count; i++)
            {
                adapter.Add(equations[i]);
            }

            // item click -> navigate to next page
            TextView textView = (TextView)FindViewById(Resource.Id.textView1);
            listView.ItemClick += (object sender, Android.Widget.AdapterView.ItemClickEventArgs e) =>
            {
                int x = e.Position;
                Intent third = new Intent(this, typeof(Thirdpage));
                Bundle extras = new Bundle();
                extras.PutInt("index", x);
                extras.PutString("sign", equations[x].sign.ToString());
                extras.PutString("partAnswer", equations[x].partAnswer);
                extras.PutString("partEquation", equations[x].partEquation);
                extras.PutString("solution", equations[x].completeAnswer);
                extras.PutString("equation", equations[x].completeEquation);
                extras.PutString("a", equations[x].a);
                extras.PutString("b", equations[x].b);
                third.PutExtras(extras);
                StartActivity(third);
            };
        }
    }           
}