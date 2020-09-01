using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace UdemyHelloWorld
{
    public partial class PlatformSpecificImages : ContentPage
    {
        public PlatformSpecificImages()
        {
            InitializeComponent();

            // btn.ImageSource = ImageSource.FromFile("clock.png");

            //OR to specify defices...

            //var clockIcon = "";

            //    switch(Device.RuntimePlatform)
            //{
            //    case Device.iOS: clockIcon = "clock.png";
            //        break;

            //    case Device.Android: clockIcon = "clock.png";
            //        break;
            //}
            //btn.ImageSource = ImageSource.FromFile(clockIcon);
        }
    }
}
