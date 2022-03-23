using MagicGradients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Fishing
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OnboardingPage : ContentPage
    {
        public OnboardingPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await FadeBox.FadeTo(1, 1000);
         
           await Navigation.PopModalAsync(false);
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            MyRadialGradient.RadiusX = this.Width * e.NewValue;
        }
    }
}