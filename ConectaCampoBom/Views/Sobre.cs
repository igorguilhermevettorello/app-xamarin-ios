using System;

using Xamarin.Forms;

namespace ConectaCampoBom.Views
{
    public class Sobre : ContentPage
    {
        public Sobre()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

