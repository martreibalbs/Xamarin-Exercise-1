using Android.Content;
using Android.Support.CustomTabs;
using Xamarin.Forms;
using XamarinExer1.DependencyService;
using XamarinExer1.Droid.DependencyService;

[assembly: Dependency(typeof(BrowserImplement))]
namespace XamarinExer1.Droid.DependencyService
{
    class BrowserImplement : IBrowserDependency
    {
        Context context = Android.App.Application.Context;
        public void OpenUrl(string url)
        {
            CustomTabsIntent.Builder builder = new CustomTabsIntent.Builder();
            CustomTabsIntent customTabsIntent = builder.Build();
            customTabsIntent.LaunchUrl(context, Android.Net.Uri.Parse(url));
        
        }
    }
}