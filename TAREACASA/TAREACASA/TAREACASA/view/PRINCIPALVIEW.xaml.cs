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
        public async void Button3_Clicked(object sender, EventArgs e)

        {
            await Application.Current.MainPage.Navigation.PopModalAsync();
        }
    }
}