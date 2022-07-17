using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Picker
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Listafruta();
        }

        private void Listafruta()
        {
            var listaFruta = new List<string>();
            listaFruta.Add("Manzana");
            listaFruta.Add("Naranga");
            listaFruta.Add("Mango");
            listaFruta.Add("Platano");
            listaFruta.Add("Piña");

            picker1.ItemsSource = listaFruta;
            lb1.SetBinding(Label.TextProperty,new Binding("SelectedItem",source:picker1));
        }
    }
}
