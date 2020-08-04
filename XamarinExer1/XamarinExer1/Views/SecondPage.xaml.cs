using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinExer1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SecondPage : ContentPage
    {
        public SecondPage()
        {
            InitializeComponent();
            t1.Elapsed += Change;
        }


        public static readonly BindableProperty DisplayTextProperty = BindableProperty.Create(nameof(DisplayText),
            typeof(string), typeof(MainPage), "I am a Xamarin Developer");

        public string DisplayText
        {
            get { return (string)GetValue(DisplayTextProperty); }
            set { SetValue(DisplayTextProperty, value); }
        }

        readonly List<string> Texts = new List<string>()
        {
            "I am a Xamarin Developer",
            "We create cross platform mobile application",
            "Your Idea, Our Execution, Together We can Change The World!"
        };

        int tapCount;

        void OnTapGestureRecognizerTapped(object sender, EventArgs args)
        {
            DisplayText = Texts[tapCount++ % 3];
        }

        public static readonly BindableProperty TextChangeProperty = BindableProperty.Create(nameof(TextChange),
            typeof(bool), typeof(MainPage), false);

        public bool TextChange
        {
            get { return (bool)GetValue(TextChangeProperty); }
            set { SetValue(TextChangeProperty, value); }
        }

        public static readonly BindableProperty TextProperty = BindableProperty.Create(nameof(Text),
            typeof(string), typeof(MainPage), default(string));

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public static readonly BindableProperty ColorsProperty = BindableProperty.Create(nameof(Colors),
            typeof(Color), typeof(MainPage), default(Color));

        public Color Colors
        {
            get { return (Color)GetValue(ColorsProperty); }
            set { SetValue(ColorsProperty, value); }
        }

        Timer t1 = new Timer(10000);
        void Change(object sender, ElapsedEventArgs e)
        {

            t1.Stop();
            TextChange = false;

        }
        void OnSwiped(object sender, SwipedEventArgs e)
        {


            switch (e.Direction)
            {
                case SwipeDirection.Left:

                    Colors = Color.Red;
                    break;
                case SwipeDirection.Right:

                    Colors = Color.Blue;
                    break;
                case SwipeDirection.Up:
                    Colors = Color.Green;
                    break;
                case SwipeDirection.Down:
                    Colors = Color.Yellow;
                    break;
            }
            Text = "" + e.Direction.ToString();
            TextChange = true;

            t1.Stop();
            t1.Start();
        }

    }

}