using System;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using XamarinExer1;
using XamarinExer1.Droid;
using System.ComponentModel;
using Android.Content;

[assembly: Xamarin.Forms.ExportRenderer(typeof(CustomButton), typeof(CustomButtonRenderer))]
namespace XamarinExer1.Droid
{
    public class CustomButtonRenderer : ButtonRenderer
    {
        public CustomButtonRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);

            var button = this.Control;
            button.SetAllCaps(false);

        }
        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
        }
    }
}