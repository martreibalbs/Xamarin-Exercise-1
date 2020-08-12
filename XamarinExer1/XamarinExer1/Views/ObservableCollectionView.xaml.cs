using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinExer1.ObservableCollection;

namespace XamarinExer1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ObservableCollectionView : ContentPage
    {
        public ObservableCollectionView()
        {
            InitializeComponent();
            BindingContext = new ObservableCollectionViewModel();
        }
    }
}