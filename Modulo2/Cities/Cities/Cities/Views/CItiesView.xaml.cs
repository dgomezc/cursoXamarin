using Cities.ViewModels;
using Xamarin.Forms;

namespace Cities.Views
{
    public partial class CitiesView : ContentPage
    {
        public CitiesView()
        {
            InitializeComponent();
            BindingContext = new CitiesViewModel();
        }
    }    
}
