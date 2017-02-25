using TipCalc.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TipCalc.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TipCalcView : ContentPage
    {
        public TipCalcView()
        {
            InitializeComponent();
            BindingContext = new TipCalcViewModel();
        }
    }
}
