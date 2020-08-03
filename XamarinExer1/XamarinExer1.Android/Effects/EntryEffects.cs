using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XamarinExer1.Droid.Effects;

[assembly: ResolutionGroupName("Xamarin1")]
[assembly: ExportEffect(typeof(EntryEffect), "EntryEffects")]
namespace XamarinExer1.Droid.Effects
{
    public class EntryEffect : PlatformEffect
    {

        protected override void OnAttached()
        {

            if (Control != null)
            {
                Control.SetBackgroundResource(Resource.Drawable.card);
            }

        }
        protected override void OnDetached()
        {

        }
    }
}