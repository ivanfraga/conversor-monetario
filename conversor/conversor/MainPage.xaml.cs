using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace conversor
{
    public partial class MainPage : ContentPage
    {
        String money_type;
        //Monedas a convertir
        double money_change, dollar, result;
        public MainPage()
        {
            InitializeComponent();
        }

        //procesos de conversión

        //Dolar - P.Mexicanos

        public void Pmexi(object sender, EventArgs e)
        {
            money_type = " P.Mexicanos";
            money_change = 20.37;
            validar();
        }
        public void Pcolo(object sender, EventArgs e)
        {
            money_type = " P.Colombianos";
            money_change = 4289.67;
            validar();
        }
        public void Speru(object sender, EventArgs e)
        {
            money_type = " S.Peruanos";
            money_change = 3.93;
            validar();
        }
        public void Yjapo(object sender, EventArgs e)
        {
            money_type = " Y.Japoneses";
            money_change = 133.25;
            validar();
        }
        public void Ychin(object sender, EventArgs e)
        {
            money_type = " Y.Chinos";
            money_change = 6.74;
            validar();
        }
        public void Calcular()
        {
            dollar = Convert.ToDouble(txtdolar.Text);
            result = dollar * money_change;
            reslbl.Text = result.ToString() + money_type;
        }



        public void validar()
        {
            if (!String.IsNullOrEmpty(txtdolar.Text))
            {
                Calcular();
            }
            else
            {
                DisplayAlert("Error mijo", "ingresa una cantidad", "De one");
            }

        }

    }
}
