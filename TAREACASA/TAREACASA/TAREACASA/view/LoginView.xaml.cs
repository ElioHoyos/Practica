using System;
using System.Collections.Generic;
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
            String sCorreo = txtCorreo.Text;
            String sContraseña = txtContraseña.Text;

            if ((sCorreo == "Juan@gmail.com") && (sContraseña == "juan"))
            {
                Navigation.PushAsync(new PRINCIPALVIEW());
            }
            else
            {
                lblResultado.Text = "El correo o contraseña son incorrectos!";

            }
        }
    }
}