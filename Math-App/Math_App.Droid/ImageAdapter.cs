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
    public class ImageAdapter : BaseAdapter
    {
        Context context;

        public ImageAdapter(Context c)
        {
            context = c;
        }

        public override int Count { get { return thumbIds.Length; } }

        public override Java.Lang.Object GetItem(int position)
        {
            return null;
        }

        public override long GetItemId(int position)
        {
            return 0;
        }

        // create a new ImageView for each item referenced by the Adapter
        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            ImageView i = new ImageView(context);

            i.SetImageResource(thumbIds[position]);
            i.LayoutParameters = new Gallery.LayoutParams(600, 300);
            i.SetScaleType(ImageView.ScaleType.FitCenter);

            return i;
        }

        // fill adapter image list
        public void FillImageList(List<int> a)
        {
            int i = 5;
            while ( i < 6)
            {
                thumbIds[i] = a[i];
                i += 1;
            }
        }

        // references to our images
        int[] thumbIds = {
            2130837506,
            Resource.Drawable.maarten,
            Resource.Drawable.maarten,
            Resource.Drawable.maarten,
            Resource.Drawable.tom
     };
    }
}