using ConectaCampoBom.Models;
using ConectaCampoBom.ViewModels;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ConectaCampoBom.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Cidade : ContentPage
	{
        private List<MenuModel> lista { get; set; }

        public Cidade ()
		{
			InitializeComponent ();
            BindingContext = new CidadeViewModel();
        }

        private async void OnMenuItemTapped(object sender, ItemTappedEventArgs e)
        {
            var modalPage = new Load();
            await Navigation.PushModalAsync(modalPage);

            var item = (CidadeModel)e.Item;
            if (item.Descricao.Equals("História da Cidade"))
                await Navigation.PushAsync(new HistoriaDaCidade());
            if (item.Descricao.Equals("Símbolos Municipais"))
                await Navigation.PushAsync(new SimbolosMunicipais());
            if (item.Descricao.Equals("Dados Gerais"))
                await Navigation.PushAsync(new DadosGerais());
            if (item.Descricao.Equals("Downloads"))
                await Navigation.PushAsync(new Downloads());
            if (item.Descricao.Equals("Cinema"))
                await Navigation.PushAsync(new Cinema());
            if (item.Descricao.Equals("Podas"))
                await Navigation.PushAsync(new Podas());
            if (item.Descricao.Equals("Telefones Úteis"))
                await Navigation.PushAsync(new TelefonesUteis());

            await Navigation.PopModalAsync();
        }

        private async void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            MenuListView.SelectedItem = null;
        }
    }
}