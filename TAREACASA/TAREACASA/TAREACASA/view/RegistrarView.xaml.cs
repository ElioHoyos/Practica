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
    public partial class RegistrarView : ContentPage
    {
        public RegistrarView()
        {
            InitializeComponent();
        }
              public async void Button1_Clicked(object sender, EventArgs e)
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new PRINCIPALVIEW());
        }
    }
}
