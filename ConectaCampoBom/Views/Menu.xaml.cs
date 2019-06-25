using System;
using System.Collections.Generic;
using ConectaCampoBom.Models;
using Xamarin.Forms;

namespace ConectaCampoBom.Views
{
    public partial class Menu : MasterDetailPage
    {
        private List<MenuModel> lista { get; set; }

        public Menu()
        {
            InitializeComponent();
            lista = new List<MenuModel>();
            lista.Add(new MenuModel() { Titulo = "Início", Page = typeof(Principal) });
            //lista.Add(new MenuModel() { Titulo = "Ajuda", Page = typeof(Ajuda) });
            //lista.Add(new MenuModel() { Titulo = "Avaliar", Page = typeof(Avaliar) });
            lista.Add(new MenuModel() { Titulo = "Sobre", Page = typeof(Sobre) });
            listagem.ItemsSource = lista;
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Principal)));
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pessoas());
        }

        private void OnMenuItemTapped(object sender, ItemTappedEventArgs e)
        {
            var item = (MenuModel) e.Item;
            Type page = item.Page;
            Detail = new NavigationPage((Page)Activator.CreateInstance(page));
            IsPresented = false;
        }

        private async void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            listagem.SelectedItem = null;
        }
    }
}
