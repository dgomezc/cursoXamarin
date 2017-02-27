using Cities.Resources;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Cities.ViewModels
{
    public class CitiesViewModel
    {
        public CitiesViewModel()
        {
            InitalizeCities();
        }

        public ObservableCollection<CityViewModel> Cities { get; set; }

        private void InitalizeCities()
        {
            Cities = new ObservableCollection<CityViewModel>();

            Cities.Add(
                new CityViewModel
                {
                    Name = "New York",
                    Detail = CitiesResource.NuevaYorkDetalle,
                    Image = ImageSource.FromResource("Cities.Images.Cities.NewYork.png")
                });

            Cities.Add(
                new CityViewModel
                {
                    Name = "Paris",
                    Detail = CitiesResource.ParisDetalle,
                    Image = ImageSource.FromResource("Cities.Images.Cities.Paris.png")
                });

            Cities.Add(
                new CityViewModel
                {
                    Name = "Roma",
                    Detail = CitiesResource.RomaDetalle,
                    Image = ImageSource.FromResource("Cities.Images.Cities.Roma.png")
                });

            Cities.Add(
                new CityViewModel
                {
                    Name = "San Francisco",
                    Detail = CitiesResource.SanFranciscoDetalle,
                    Image = ImageSource.FromResource("Cities.Images.Cities.SanFrancisco.png")
                });

            Cities.Add(
                new CityViewModel
                {
                    Name = "Seattle",
                    Detail = CitiesResource.SeattleDetalle,
                    Image = ImageSource.FromResource("Cities.Images.Cities.Seattle.png")
                });

            Cities.Add(
                new CityViewModel
                {
                    Name = "Sevilla",
                    Detail = CitiesResource.SevillaDetalle,
                    Image = ImageSource.FromResource("Cities.Images.Cities.Sevilla.png")
                });
        }
    }
}
