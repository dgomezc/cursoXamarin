using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Contador
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();

            boton.Clicked += (s, e) =>  label.Text= string.Format("Botón pulsado {0} veces", ++count);
        }        
    }
}
