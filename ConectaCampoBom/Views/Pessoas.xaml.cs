using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ConectaCampoBom.Views
{
    public partial class Pessoas : ContentPage
    {
        public Pessoas()
        {
            InitializeComponent();
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PessoasFisicas());
        }
    }
}
