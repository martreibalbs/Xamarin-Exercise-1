﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinExer1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UIDesign : ContentPage
    {
        public UIDesign()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {

        }
    }
}