using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinExer1.ViewModels;

namespace XamarinExer1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FirstPage : ContentPage
    {
        bool isClick;
        public FirstPage()
        {
            InitializeComponent();
            BindingContext = new AddContactViewModel();
    

        }
        private void EditSave_Clicked(object sender, EventArgs e)
        {
            if (isClick)
            {
                isClick = false;
                EditSave.Text = "Edit";
                Name.IsEnabled = false;
                Address.IsEnabled = false;
                Email.IsEnabled = false;
                PhoneNumber.IsEnabled = false;
            }
            else
            {
                isClick = true;
                EditSave.Text = "Save";
                Name.IsEnabled = true;
                Address.IsEnabled = true;
                Email.IsEnabled = true;
                PhoneNumber.IsEnabled = true;
            }
        }
    }
}