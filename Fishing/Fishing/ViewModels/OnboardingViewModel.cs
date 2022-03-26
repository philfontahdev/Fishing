using Fishing.Models;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Text;


namespace Fishing.ViewModels
{
    public class OnboardingViewModel : BaseViewModel
    {
        private ObservableRangeCollection<OnboardingModel> items;

        public ObservableRangeCollection<OnboardingModel> Items { get => items; 
            set => SetProperty(ref items, value); }

        public OnboardingViewModel()
        {
            items = new ObservableRangeCollection<OnboardingModel> {
                new OnboardingModel{
                    Title = "Discover nature and catch fish",
                    Content ="Crazyhound shark with pipefish snake eel.The cracking, heart pumping at ",
                    Image = "dauter.png"

                 }, new OnboardingModel{
                     Title = "Find new fishing spots",
                     Content ="Bonnethead at puffer fish  pipefish octopus threadfin.Floating ",
                     Image = "mathieu.jpg"

                 }, new OnboardingModel{
                     Title = "who is fishing near me",
                     Content ="Gold damsel fauset snail, in snake eel sea coral grouper. M",
                     Image = "womanfish.jpg"

                 }, new OnboardingModel{
                     Title = "Find new fishing spots",
                     Content ="Bonnethead at puffer fish  pipefish octopus threadfin.Floating ",
                     Image = "mathieu.jpg"

                 }
            };
        }

        
    }
}
