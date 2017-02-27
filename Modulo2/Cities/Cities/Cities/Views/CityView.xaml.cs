using Cities.ViewModels;

using Xamarin.Forms;

namespace Cities.Views
{
    public partial class CityView : ContentPage
    {
        public CityView(CityViewModel cityViewModel)
        {
            InitializeComponent();
            BindingContext = cityViewModel;
        }
    }
}
