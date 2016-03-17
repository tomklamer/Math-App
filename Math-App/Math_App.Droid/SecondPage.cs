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

namespace Math_App.Droid
{
    [Activity(Label = "RekenApp", Icon = "@drawable/icon")]
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
                Console.WriteLine(equations[x].partEquation);
                Console.WriteLine(equations[x].sign);
                Console.WriteLine(equations[x].partAnswer);
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