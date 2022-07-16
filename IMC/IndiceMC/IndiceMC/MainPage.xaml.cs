using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace IndiceMC
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPeso.Text) && !string.IsNullOrEmpty(txtAltura.Text))
            {
                calcularIMC();
            }
            else
            {
                DisplayAlert("AVISO!!", "Favor de ingresar los valores", "OK");
            }

        }

        private void calcularIMC()
        {
            double altura = Convert.ToDouble(txtAltura.Text);
            double peso = Convert.ToDouble(txtPeso.Text);
            if (altura >0 && peso>0)
            {
                double resultado = peso / Math.Pow(altura, 2);
                string mensaje = "";

                if (resultado < 18.5)
                {
                    mensaje = "Tienes bajo peso!! \n Resultado:" + resultado;
                }
                else if (resultado >= 18.5 && resultado <= 24.9)
                {
                    mensaje = "Tu peso es normal! \n Resultado:" + resultado;
                }
                else
                {
                    mensaje = "Tienes sobrepeso 😥 \n Resultado:" + resultado;
                }
                DisplayAlert("Resultado", mensaje, "OK");
            }
            else
            {
                DisplayAlert("AVISO!!","Datos incorrectos","OK");
            }
            txtAltura.Text = "";
            txtPeso.Text = "";
        }
    }
}
