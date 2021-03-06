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
using Android.Views.Animations;

namespace Math_App.Droid
{
    public class EquationsAdapter : ArrayAdapter<Equation> {

        public EquationsAdapter(Context context, List<Equation> Equations) : base(context, 0, Equations)
        {
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {

            // Get the data item for this position
            Equation Equation = GetItem(position);
            // Check if an existing view is being reused, otherwise inflate the view
            if (convertView == null)
            {
                convertView = LayoutInflater.From(Context).Inflate(Resource.Layout.Listview, parent, false);
            }
            // Lookup view for data population
            ImageView ivIcon = (ImageView)convertView.FindViewById(Resource.Id.Image);
            TextView tvName = (TextView)convertView.FindViewById(Resource.Id.tvName);
            TextView tvHome = (TextView)convertView.FindViewById(Resource.Id.tvHome);
            // Populate the data into the template view using the data object
            tvName.Text = Equation.partEquation;
            tvHome.Text = Equation.partAnswer;

            string sign = Equation.sign;
            switch (sign)
            {
                case "+":
                    ivIcon.SetImageResource(Resource.Drawable.Plus);
                    break;
                case "-":
                    ivIcon.SetImageResource(Resource.Drawable.Min);
                    break;
                case "x":
                    ivIcon.SetImageResource(Resource.Drawable.Mul);
                    break;
                case "�":
                    ivIcon.SetImageResource(Resource.Drawable.Div);
                    break;
            }
            // Return the completed view to render on screen
            return convertView;
        }
    }
}