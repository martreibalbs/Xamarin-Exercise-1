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
        public Grid()
        {
            InitializeComponent();
            grid2.IsVisible = false;
        }

        private void ClickmeBtn_Clicked(object sender, EventArgs e)
        {
            if (grid1.IsVisible == true)
            {
                grid1.IsVisible = false;
                grid2.IsVisible = true;
            }
            else
            {
                grid1.IsVisible = true;
                grid2.IsVisible = false;
            }
           
                
            
        }

     
    }
}