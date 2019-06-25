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
	public partial class Downloads : ContentPage
	{
        List<DownloadModel> lista { get; set; }

        public Downloads()
		{
			InitializeComponent();

            Task<string> request = GetInfoDownloads();

            request.Wait();

            string content = request.Result;

            lista = new List<DownloadModel>();

            if (!string.IsNullOrEmpty(content))
            {
                DownloadsBaseJson b = JsonConvert.DeserializeObject<DownloadsBaseJson>(content);
                
                b.Dados.ForEach(dado =>
                {
                    DownloadModel em = new DownloadModel()
                    {
                        Id = dado.Id,
                        Descricao = dado.Descricao,
                        Url = dado.Url
                    };
                    lista.Add(em);
                });
            }

            BindingContext = new DownloadsViewModel(lista);
        }

        public async Task<string> GetInfoDownloads()
        {
            using (var client = new HttpClient())
            {
                string Url = "http://aplicativo.campobom.rs.gov.br/conecta_cb/public/listarDownloads";
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
            DownloadModel item = e.Item as DownloadModel;
            Device.OpenUri(new Uri(item.Url));
        }

        private async void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            DownloadListView.SelectedItem = null;
        }
    }
}