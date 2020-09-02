using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace UdemyHelloWorld
{
    public partial class ImagesExercise : ContentPage
    {
        private int _currentImage = 1;
        public ImagesExercise()
        {
            InitializeComponent();

            _currentImage = 1;

            LoadImage();
        }

        void LoadImage()
        {
            image.Source = new UriImageSource
            {
                Uri = new Uri(String.Format("https://lorempixel.com/1920/1080/city/{0}", _currentImage)),
                CachingEnabled = false
            };
        }

        void Previous_Clicked(System.Object sender, System.EventArgs e)
        {
            _currentImage--;
            if (_currentImage == 0)
                _currentImage = 10;

            LoadImage();
        }

        void Next_Clicked(System.Object sender, System.EventArgs e)
        {
            _currentImage++;
            if (_currentImage == 11)
                _currentImage = 1;

            LoadImage();
        }
    }
}
