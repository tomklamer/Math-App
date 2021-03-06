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
using Android.Util;
using Java.Lang;

namespace Math_App.Droid
{
    public class CustomGallery : Gallery
    {
        public int SelectedIndexChanged { get; internal set; }

        public CustomGallery(Context context)
            : base(context)
        {

        }

        public CustomGallery(Context context, IAttributeSet attrs)
            : base(context, attrs)
        {

        }

        public CustomGallery(Context context, IAttributeSet attrs, int defStyleAttr)
            : base(context, attrs, defStyleAttr)
        {

        }

        public CustomGallery(Context context, IAttributeSet attrs, int defStyleAttr, int defStyleRes)
            : base(context, attrs, defStyleAttr, defStyleRes)
        {

        }

        public CustomGallery(IntPtr javaReference, JniHandleOwnership transfer)
            : base(javaReference, transfer)
        {

        }

        public override bool OnFling(MotionEvent e1, MotionEvent e2, float velocityX, float velocityY)
        {          

            //limit the max speed in either direction
            if (velocityX > 1600.0f)
            {
                velocityX = 1600.0f;
            }
            else if (velocityX < -1600.0f)
            {
                velocityX = -1600.0f;
            }
            
            return base.OnFling(e1, e2, velocityX, velocityY);
        }
    }
}