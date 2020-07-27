using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinExer1
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Basic_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Basic());
        }

        private void LayoutOptions_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LayoutOptions());

        }

        private void Sample_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Sample());

        }

        private void Grid_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Grid());

        }
    }
}
