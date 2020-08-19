using Android.Content;
using Android.Graphics;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XamarinExer1.Droid;

[assembly: ExportRenderer(typeof(Label),typeof(UIDesignLabelRenderer))]
namespace XamarinExer1.Droid
{
    public class UIDesignLabelRenderer:LabelRenderer
    {
        public UIDesignLabelRenderer(Context context):base(context)
        {

        }
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
            if(Control!=null)
            {
            }
        }
    }
}