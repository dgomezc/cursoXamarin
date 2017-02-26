using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            Cities.Add(new CityViewModel { Name = "New York", Detail = "El detalle de New York" });
            Cities.Add(new CityViewModel { Name = "Paris", Detail = "El detalle de Paris" });
        }
    }


}
