using Componentes.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Componentes.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuInicial : ContentPage
    {
        public IList<Mcomidas> Comidas { get; private set;} 
        public MenuInicial()
        {
            InitializeComponent();
            Comidas = new List<Mcomidas>();
            Comidas.Add(new Mcomidas
            { 
                nombre="Tortas",
                precio="$ 14"
            });

            Comidas.Add(new Mcomidas
            {
                nombre = "Tacos",
                precio = "$ 19"
            });

            Comidas.Add(new Mcomidas
            {
                nombre = "Tortilla",
                precio = "$ 16"
            });
            BindingContext = this;
        }


    }
}