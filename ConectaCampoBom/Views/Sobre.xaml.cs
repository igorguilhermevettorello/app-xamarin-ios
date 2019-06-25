using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ConectaCampoBom.Views
{
    public partial class Sobre : ContentPage
    {
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            DisplayAlert("titulo", "mensagem", "ok");
        }

        public Sobre()
        {
            InitializeComponent();
        }
    }
}
