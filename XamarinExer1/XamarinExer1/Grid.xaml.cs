using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinExer1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Grid : ContentPage
    {
        bool isText;
        
        public Grid()
        {
            InitializeComponent();
        }

        private void ClickmeBtn_Clicked(object sender, EventArgs e)
        {


            if (isText)
            {
                isText = false;
                clickme.Text = "I am a Xamarin Developer";
            }
            else
            {
                isText = true;
                clickme.Text = "Xamarin.Forms is an open source cross-platform framework from Microsoft for building iOS, Android, & Windows apps with .NET from a single shared codebase.";
            }

        }

     
    }
}