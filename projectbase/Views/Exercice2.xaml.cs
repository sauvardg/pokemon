using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace projectbase
{
    public partial class Exercice2 : ContentPage
    {
        public Exercice2()
        {
            InitializeComponent();
            BindingContext = new Exercice2ViewModel();
        }
    }
}
