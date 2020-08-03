using System;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using Xamarin.Forms;
using XamarinExer1.DependencyService;

namespace XamarinExer1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ThirdPage : ContentPage
    {
        public ThirdPage()
        {
            InitializeComponent();
        }

        private async void OpenWeb_Clicked(object sender, EventArgs e)
        {
            var service = Xamarin.Forms.DependencyService.Get<IBrowserDependency>();

            await Browser.OpenAsync(service.webSite(), BrowserLaunchMode.SystemPreferred);
        }
    }
}