using Android.Content;
using Android.Graphics;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XamarinExer1.Droid;

[assembly: ExportRenderer(typeof(Entry), typeof(UIDesignEntryRenderer))]
namespace XamarinExer1.Droid
{
    public class UIDesignEntryRenderer:EntryRenderer
    {
        public UIDesignEntryRenderer(Context context): base(context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if(Control!=null)
            {
                Control.SetBackgroundColor(Android.Graphics.Color.Transparent);
                Control.SetTextColor(Android.Graphics.Color.White);
                Control.SetPadding(40, 30, 40, 30);
            }
        }
    }
}