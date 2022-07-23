using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ConvertidorTemperatura
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btConver_Clicked(object sender, EventArgs e)
        {
            calcular();
        }

        private void calcular()
        {
            if (!String.IsNullOrEmpty(etFah.Text))
            {
                float fah = float.Parse(etFah.Text);
                float cent = (fah - 32f)* 5/9f;
                // redondeo a 1 decimal
                cent = ((float)Math.Floor(cent * 10f) / 10f);
                etCenti.Text = cent.ToString();
                string result = "";
                if (cent<=0)
                {
                    result = "!Congelado¡";
                }else if (cent>0 && cent<=10)
                {
                    result = "!Mucho frio¡";
                }else if (cent>10 && cent<=20)
                {
                    result = "!Está fresco¡";
                }
                else if (cent>20 && cent<=30)
                {
                    result = "!Hace calor¡";
                }
                else
                {
                    result = "!Hace mucho calor¡";
                }
                DisplayAlert("Resultado",result,"OK");

            }
            else
            {
                DisplayAlert("Error", "Ingrese el valor a convertir", "OK");
            }
        }
    }
}
