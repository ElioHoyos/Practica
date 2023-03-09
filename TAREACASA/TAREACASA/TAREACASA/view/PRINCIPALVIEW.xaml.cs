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
    public partial class PRINCIPALVIEW : ContentPage
    {
        public PRINCIPALVIEW()
        {
            InitializeComponent();
        }

        private async void Boton2_Clicked(object sender, EventArgs e)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new LoginView());
        }
    }
}