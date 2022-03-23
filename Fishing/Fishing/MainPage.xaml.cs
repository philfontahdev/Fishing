using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Fishing
{
    public partial class MainPage : ContentPage
    {
        Page onboardingpage;
        public MainPage()
        {
            InitializeComponent();
            if(ShouldShowOnboarding() == true)
            {
                App.Current.ModalPopping += Current_ModalPopping;
                onboardingpage = new OnboardingPage();
                Navigation.PushModalAsync(onboardingpage,false);
            }
        }

        private void Current_ModalPopping(object sender, ModalPoppingEventArgs e)
        {
            if (e.Modal == onboardingpage)
            {
                FadeBox.FadeTo(0, 1000);
                onboardingpage = null;
                App.Current.ModalPopping -= Current_ModalPopping;
            }
        }

        private bool ShouldShowOnboarding()
        {
            return true;
            /*if(VersionTracking.IsFirstLaunchEver)
            {
                return true;
            }else
            {
                return false;
            }*/
        }
    }
}
