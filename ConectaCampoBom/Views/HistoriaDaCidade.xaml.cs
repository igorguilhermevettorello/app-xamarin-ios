using ConectaCampoBom.Base;
using ConectaCampoBom.Models;
using ConectaCampoBom.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ConectaCampoBom.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HistoriaDaCidade : ContentPage
	{
        List<HistoriaModel> lista { get; set; }        
        public HistoriaDaCidade()
		{
			InitializeComponent();

            Task<string> request = GetInfoHistoria();

            request.Wait();

            string content = request.Result;

            lista = new List<HistoriaModel>();

            if (!string.IsNullOrEmpty(content))
            {
                HistoriasBaseJson b = JsonConvert.DeserializeObject<HistoriasBaseJson>(content);
                string descricao = Regex.Replace(b.Dados.Descricao, @"<[^>]*>", String.Empty);
                descricao = Regex.Replace(descricao, @"&nbsp;", String.Empty);
                
                lista.Add(new HistoriaModel()
                {
                    Descricao = descricao
                });
            }

            BindingContext = new HistoriaViewModel(lista);
        }

        public async Task<string> GetInfoHistoria()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    string Url = "http://aplicativo.campobom.rs.gov.br/conecta_cb/public/getHistoriaCidade";
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
            HistoriaListView.SelectedItem = null;
        }
    }
}