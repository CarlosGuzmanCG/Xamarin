using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalculadoraBasica
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btSuma_Clicked(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(etN1.Text) && !string.IsNullOrEmpty(etN2.Text))
            {
                double n1 = Convert.ToDouble(etN1.Text);
                double n2 = Convert.ToDouble(etN2.Text);

                double resultado = n1 + n2;

                DisplayAlert("Resultado", resultado.ToString(),"Ok" );

            }
            else
            {
                DisplayAlert("AVISO","Ingrese los datos","OK");
            }
        }

        private void btResta_Clicked(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(etN1.Text) && !string.IsNullOrEmpty(etN2.Text))
            {
                double n1 = Convert.ToDouble(etN1.Text);
                double n2 = Convert.ToDouble(etN2.Text);

                double resultado = n1 - n2;

                DisplayAlert("Resultado", resultado.ToString(), "Ok");

            }
            else
            {
                DisplayAlert("AVISO", "Ingrese los datos", "OK");
            }
        }

        private void btMult_Clicked(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(etN1.Text) && !string.IsNullOrEmpty(etN2.Text))
            {
                double n1 = Convert.ToDouble(etN1.Text);
                double n2 = Convert.ToDouble(etN2.Text);

                double resultado = n1 * n2;

                DisplayAlert("Resultado", resultado.ToString(), "Ok");

            }
            else
            {
                DisplayAlert("AVISO", "Ingrese los datos", "OK");
            }
        }

        private void btDivi_Clicked(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(etN1.Text) && !string.IsNullOrEmpty(etN2.Text))
            {
                double n1 = Convert.ToDouble(etN1.Text);
                double n2 = Convert.ToDouble(etN2.Text);

                if (n2>0)
                {
                    double resultado = n1 / n2;

                    DisplayAlert("Resultado", resultado.ToString(), "Ok");
                }
                else
                {
                    DisplayAlert("Resultado", "Ingrese un número diferente", "Ok");
                }

            }
            else
            {
                DisplayAlert("AVISO", "Ingrese los datos", "OK");
            }
        }

        private void btLimpiar_Clicked(object sender, EventArgs e)
        {
            etN1.Text = "";
            etN2.Text = "";
        }
    }
}
