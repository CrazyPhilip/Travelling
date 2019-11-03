﻿using Android.Content;
using Travelling.Controls;
using Travelling.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(MyEntry), typeof(MyEntryRenderer))]
namespace Travelling.Droid
{
    class MyEntryRenderer : EntryRenderer
    {
        public MyEntryRenderer(Context context) : base(context)
        {
        }
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.SetBackgroundColor(global::Android.Graphics.Color.Transparent);
                Control.SetPadding(0, 0, 0, 0);
                Control.SetLines(1);
                //Control.SetShadowLayer(10, 5, 5, global::Android.Graphics.Color.LightGray);
            }
        }
    }
}
