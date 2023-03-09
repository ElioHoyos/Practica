using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TAREACASA.view
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginView : ContentPage
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            String sUsuario = txtUsuario.Text;
            String sContraseña = txtContraseña.Text;

            if ((sUsuario == "DannySk") && (sContraseña == "dany24edu22"))
            {
                Navigation.PushAsync(new PRINCIPALVIEW());
            }
            else
            {
                lblresultado.Text = "La contraseña o Usuario son incorrectos";
            }  
        }
    }
}