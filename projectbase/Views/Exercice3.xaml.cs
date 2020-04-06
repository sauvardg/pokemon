using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace projectbase
{
    public partial class Exercice3 : ContentPage
    {
        public Exercice3()
        {
            InitializeComponent();
            BindingContext = new Exercice3ViewModel();
        }
    }
}
