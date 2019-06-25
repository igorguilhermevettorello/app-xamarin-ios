using ConectaCampoBom.Base;
using ConectaCampoBom.Models;
using ConectaCampoBom.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ConectaCampoBom.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Podas : ContentPage
    {
        List<PodaModel> lista { get; set; }

        public Podas()
        {
            InitializeComponent();

            Task<string> request = GetInfoDownloads();

            request.Wait();

            string content = request.Result;

            lista = new List<PodaModel>();

            if (!string.IsNullOrEmpty(content))
            {
                PodasBaseJson b = JsonConvert.DeserializeObject<PodasBaseJson>(content);

                b.Dados.ForEach(dado =>
                {
                    PodaModel em = new PodaModel()
                    {
                        Id = dado.Id,
                        Descricao = dado.Descricao,
                        Bairro = dado.Bairro,
                        Poda = dado.Poda
                    };
                    lista.Add(em);
                });
            }

            BindingContext = new PodaViewModel(lista);
        }

        public async Task<string> GetInfoDownloads()
        {
            using (var client = new HttpClient())
            {
                string Url = "http://aplicativo.campobom.rs.gov.br/conecta_cb/public/listarPodas";
                var request = new HttpRequestMessage(HttpMethod.Get, Url);
                var response = await client.SendAsync(request).ConfigureAwait(false);
                if (response.IsSuccessStatusCode)
                    return await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                else
                    return null;
            }
        }

        private void OnMenuItemTapped(object sender, ItemTappedEventArgs e) { }

        private async void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            PodaListView.SelectedItem = null;
        }
    }
}