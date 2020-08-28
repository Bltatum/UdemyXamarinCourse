using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace UdemyHelloWorld
{
    public partial class GreetPage : ContentPage
    {
        public GreetPage()
        {
            InitializeComponent();

                slider.Value = 0.5;
            //Which platform is being used.
            //if else vs switch

            //if (Device.RuntimePlatform == Device.iOS)
            //    Padding = new Thickness(0, 20, 0, 0);
            //else
            //    Padding = new Thickness(10, 20, 0, 0);

            //switch (Device.RuntimePlatform)
            //{
            //    case Device.iOS:
            //        this.Padding = new Thickness(0, 50, 0, 0);
            //        break;
            //    case Device.Android:
            //        this.Padding = new Thickness(10, 20, 0, 0);
            //        break;
            //}

            //var x = new OnPlatform<Thickness>
            //{
            //    Android = new Thickness(0),
            //    iOS = new Thickness(0, 20, 0, 0)
            //};

            //Padding = x;
        }


    }
}
 