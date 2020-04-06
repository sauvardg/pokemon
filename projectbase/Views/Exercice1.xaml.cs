using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace projectbase
{
    public partial class Exercice1 : ContentPage
    {
        public Exercice1()
        {
            InitializeComponent();
            BindingContext = new Exercice1ViewModel();
        }
    }
}
