using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppS2PrlB_Deber
{
    public partial class MainPage : ContentPage
    {
        public MainPage(string usuario)
        {
            InitializeComponent();
            lblUsuario.Text = usuario;
        }

        private void btnCalcula_Clicked(object sender, EventArgs e)
        {
            try
            {
                double seguimiento1 = Convert.ToDouble(txtSeguimiento1.Text) * 0.3;
                double examen1 = Convert.ToDouble(txtExamen1.Text) * 0.2;
                double seguimiento2 = Convert.ToDouble(txtSeguimiento2.Text) * 0.3;
                double examen2 = Convert.ToDouble(txtExamen2.Text) * 0.2;
                double parcial1 = seguimiento1 + examen1;
                txtParcial1.Text = Convert.ToString(parcial1);
                double parcial2 = seguimiento2 + examen2;
                txtParcial2.Text = Convert.ToString(parcial2);
                double final = parcial1 + parcial2;
                if (final >= 7)
                {
                    DisplayAlert("Mensaje informativo","APROBADO","OK");
                }else if (final >=5 && final <= 6.9)
                {
                    DisplayAlert("Mensaje informativo", "COMPLEMENTARIO", "OK");
                }else if (final <5)
                {
                    DisplayAlert("Mensaje informativo", "REPROBADO", "OK");
                }

            }
            catch(Exception ex)
            {
                DisplayAlert("Error ", ex.Message, "OK");
            }
        }
    }
}
