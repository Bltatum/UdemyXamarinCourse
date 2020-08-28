using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace UdemyHelloWorld
{
    public partial class QuotesPage : ContentPage
    {
        private int _index = 0;
        private string[] _quotes = new string[]
        {
            "Life is like a box of chocolates.",
            "Run Forest Run.",
            "Is he Smart?.",
            "But Lt. Dan You aint got no legs."
        };
        public QuotesPage()
        {
            InitializeComponent();
            currentQuote.Text = _quotes[_index];

        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            _index++;
            if (_index >= _quotes.Length)
                _index = 0;

            currentQuote.Text = _quotes[_index];
        }
    }
}
