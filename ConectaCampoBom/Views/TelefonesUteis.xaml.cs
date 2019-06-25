using ConectaCampoBom.Base;
using ConectaCampoBom.Models;
using ConectaCampoBom.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ConectaCampoBom.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TelefonesUteis : ContentPage
	{
        private List<TelefoneModel> lista { get; set; }

        public TelefonesUteis()
		{
			InitializeComponent();
            
            Task<string> request = GetInfoTelefones();

            request.Wait();

            string content = request.Result;

            lista = new List<TelefoneModel>();

            if (!string.IsNullOrEmpty(content))
            {
                TelefonesBaseJson b = JsonConvert.DeserializeObject<TelefonesBaseJson>(content);

                b.Dados.ForEach(dado =>
                {
                    TelefoneModel em = new TelefoneModel()
                    {
                        Id = dado.Id,
                        Descricao = dado.Descricao,
                        Telefone = dado.Telefone,
                        Discagem = dado.Discagem
                    };
                    lista.Add(em);
                });
            }

            BindingContext = new TelefoneViewModel(lista);

        }

        public async Task<string> GetInfoTelefones()
        {
            using (var client = new HttpClient())
            {
                string Url = "http://aplicativo.campobom.rs.gov.br/conecta_cb/public/listarTelefones";
                var request = new HttpRequestMessage(HttpMethod.Get, Url);
                var response = await client.SendAsync(request).ConfigureAwait(false);
                if (response.IsSuccessStatusCode)
                    return await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                else
                    return null;
            }
        }

        private void OnMenuItemTapped(object sender, ItemTappedEventArgs e)
        {
            var item = e.Item as TelefoneModel;
            Device.OpenUri(new Uri("tel:"+item.Discagem));
            
        }

        private async void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            TelefoneListView.SelectedItem = null;
        }
    }
}