using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinExer1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());
            Device.SetFlags(new[] { "Shapes_Experimental", "MediaElement_Experimental" });
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
