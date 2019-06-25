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
    public partial class Prefeitura : ContentPage
    {
        private List<PrefeituraModel> lista { get; set; }
        public Prefeitura()
        {
            InitializeComponent();

            lista = new List<PrefeituraModel>();

            Task<string> request = GetInfoPrefeitura();

            request.Wait();

            string content = request.Result;

            if (!string.IsNullOrEmpty(content))
            {
                BaseModel b = JsonConvert.DeserializeObject<BaseModel>(content);
                b.dados.ForEach(dado =>
                {
                    PrefeituraModel lp = new PrefeituraModel()
                    {
                        Nome = dado.Nome,
                        Cargo = dado.Cargo,
                        Email = dado.Email,
                        Tel = dado.Tel,
                        Telefone = dado.Telefone,
                        ImagemUri = new System.Uri(dado.Imagem)
                    };
                    lista.Add(lp);
                });
            }

            BindingContext = new PrefeituraViewModel(lista);
        }

        public async Task<string> GetInfoPrefeitura()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    string Url = "http://aplicativo.campobom.rs.gov.br/conecta_cb/public/getInfoPrefeitura";
                    var request = new HttpRequestMessage(HttpMethod.Get, Url);
                    var response = await client.SendAsync(request).ConfigureAwait(false);
                    if (response.IsSuccessStatusCode)
                        return await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    else
                        return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        private void OnMenuItemTapped(object sender, ItemTappedEventArgs e) { }

        private async void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            listagem.SelectedItem = null;
        }
    }
}