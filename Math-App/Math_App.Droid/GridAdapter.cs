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

namespace Math_App.Droid
{
    public class GridAdapter : ArrayAdapter<StrategyInfo>
    {

        public GridAdapter(Context context, List<StrategyInfo> list) : base(context, 0, list)
        {
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            // Get the data item for this position
            StrategyInfo StrategyInfo = GetItem(position);
            // Check if an existing view is being reused, otherwise inflate the view
            if (convertView == null)
            {
                convertView = LayoutInflater.From(Context).Inflate(Resource.Layout.Gridview, parent, false);
            }

            // Lookup view for data population
            TextView title = (TextView)convertView.FindViewById(Resource.Id.GridTitle);
            TextView answer = (TextView)convertView.FindViewById(Resource.Id.GridAnswer);
            TextView Equation = (TextView)convertView.FindViewById(Resource.Id.GridEquation);

            // Populate the data into the template view using the data object
            title.Text = StrategyInfo.title;
            answer.Text = StrategyInfo.answer;
            Equation.Text = StrategyInfo.equation;

            convertView.SetBackgroundColor(Android.Graphics.Color.Black);
            title.SetTextColor(Android.Graphics.Color.White);
            answer.SetTextColor(Android.Graphics.Color.White);
            Equation.SetTextColor(Android.Graphics.Color.White);

            // Return the completed view to render on screen
            return convertView;
        }
    }
}