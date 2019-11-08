using System.ComponentModel;
using Xamarin.Forms;
using XFCollectionViewTest.ViewModels;

namespace XFCollectionViewTest.Views
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BindingContext = new MainViewModel();
        }
    }
}
