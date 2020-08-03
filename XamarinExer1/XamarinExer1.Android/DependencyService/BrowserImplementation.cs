using Xamarin.Forms;
using XamarinExer1.DependencyService;
using XamarinExer1.Droid.DependencyService;

[assembly: Dependency(typeof(BrowserImplementation))]
namespace XamarinExer1.Droid.DependencyService
{
    class BrowserImplementation : IBrowserDependency
    {
        public string webSite()
        {
            return "https://google.com";
        }
    }
}