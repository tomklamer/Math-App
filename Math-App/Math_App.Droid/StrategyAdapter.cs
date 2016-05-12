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
using Math_App.Solutions;

namespace Math_App.Droid
{
    public class StrategyAdapter : ArrayAdapter<ICheckStrategy>
    {

        public StrategyAdapter(Context context, List<ICheckStrategy> strats) : base(context, 0, strats)
        {
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            // Get the data item for this position
            ICheckStrategy strat = GetItem(position);
            // Check if an existing view is being reused, otherwise inflate the view
            if (convertView == null)
            {
                convertView = LayoutInflater.From(Context).Inflate(Resource.Layout.Listview2, parent, false);
            }
            // Lookup view for data population
            TextView title = (TextView)convertView.FindViewById(Resource.Id.title);
            TextView extra = (TextView)convertView.FindViewById(Resource.Id.extra);
            // Populate the data into the template view using the data object
            title.Text = strat.ReturnTitle();
            // Return the completed view to render on screen

            if(position == 0)
            {
                convertView.SetBackgroundResource(Resource.Color.accent_light);
                title.SetTextColor(Android.Graphics.Color.White);
                extra.SetTextColor(Android.Graphics.Color.White);
            }

            return convertView;
        }
    }
}