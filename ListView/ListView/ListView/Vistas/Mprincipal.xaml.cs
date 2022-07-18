using ListView.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListView.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Mprincipal : ContentPage
    {
        public IList<ListV> Datos { get; private set; }
        public Mprincipal()
        {
            InitializeComponent();

            Datos = new List<ListV>();

            Datos.Add(new ListV
            { 
                nombre = "Jose",
                apellido = "pedro"
            });

            Datos.Add(new ListV
            {
                nombre = "Carlos",
                apellido = "pedro"
            });

            Datos.Add(new ListV
            {
                nombre = "Ale",
                apellido = "pedro"
            });

            Datos.Add(new ListV
            {
                nombre = "Pablo",
                apellido = "pedro"
            });

            BindingContext = this;

        }
    }
}