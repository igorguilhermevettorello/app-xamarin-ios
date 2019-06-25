using System;

using Xamarin.Forms;

namespace ConectaCampoBom.Views
{
    public class PessoasFisicas : ContentPage
    {
        public PessoasFisicas()
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

