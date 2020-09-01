using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace UdemyHelloWorld
{
    public partial class ImagePage : ContentPage
    {
        public ImagePage()
        {
            InitializeComponent();
            //from Internet..
            //var imageSource = new UriImageSource { Uri = new Uri("http://lorempixel.com/1920/1080/sports/7/") };
            //imageSource.CachingEnabled = false;

            //image.Source = imageSource;

            // from imbedded resource. right click image file and change to embedded resource. copy file path from properties.
            //image.Source = ImageSource.FromResource("UdemyHelloWorld.Images.backgroundimage.jpeg");

        }
    }
}

//imageSource.CacheValidity = TimeSpan.FromHours(1);
// image.Source = "http://..."
