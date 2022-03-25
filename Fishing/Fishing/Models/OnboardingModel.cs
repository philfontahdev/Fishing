using System;
using System.Collections.Generic;
using System.Text;

namespace Fishing.Models
{
    public class OnboardingModel
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Image { get; set; }

        public OnboardingModel()
        {

        }

        public OnboardingModel(string title, string content, string image)
        {
            Title = title;
            Content = content;
            Image = image;
        }
    }
}
