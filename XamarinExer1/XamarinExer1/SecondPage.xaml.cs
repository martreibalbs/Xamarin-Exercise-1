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
    public partial class SecondPage : ContentPage
    {
        int tapCount = 0;
        public SecondPage()
        {
            InitializeComponent();
        }

        public void OnTapGestureRecognizerTapped(object sender, EventArgs args)
        {
            var labelTap = (Label)sender;


            if (tapCount == 0)
            {
                labelTap.Text = "We create cross platform mobile application";
                tapCount++;

            }
            else if (tapCount == 1)
            {
                labelTap.Text = "Your Idea, Our Execution, Together We can Change The World!";
                tapCount++;
            }
            else
            {
                labelTap.Text = "I am a Xamarin Developer";
                tapCount = 0;
            }
        }


        void OnSwiped(object sender, SwipedEventArgs e)
        {
            Device.StartTimer(TimeSpan.FromSeconds(30), () =>
            {
                Device.BeginInvokeOnMainThread(() =>
                {
                    Swiped.Text = "";

                });

                return false;
            });


            switch (e.Direction)
            {
                case SwipeDirection.Left:
                    Swiped.Text = "Left";
                    Swiped.TextColor = Color.Red;
                    break;
                case SwipeDirection.Right:
                    Swiped.Text = "Right";
                    Swiped.TextColor = Color.Blue;
                    break;
                case SwipeDirection.Up:
                    Swiped.Text = "Up";
                    Swiped.TextColor = Color.Lime;
                    break;
                case SwipeDirection.Down:
                    Swiped.Text = "Down";
                    Swiped.TextColor = Color.Yellow;
                    break;
            }

        }

    }
}