using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Btn.Vistas
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnSecun_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PrimeraPag());
        }

        private void btnHola_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Btn Hola","Hola","OK");
        }

        private void btnCalc_Clicked(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtN1.Text) && !string.IsNullOrEmpty(txtN2.Text))
            {
                calcu();
            }
            else
            {
                DisplayAlert("Datos incorrectos","Verificar","OK");
            }
        }

        private void calcu()
        {
            double v1 = Convert.ToDouble(txtN1.Text);
            double v2 = Convert.ToDouble(txtN2.Text);

            double resultado = v1 + v2;

            DisplayAlert("Resultado", "R=" + resultado, "OK");
            txtN1.Text = "";
            txtN2.Text = "";
        }
    }
}
