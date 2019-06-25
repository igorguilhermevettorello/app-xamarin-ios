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
	public partial class SimbolosMunicipais : ContentPage
	{
		public SimbolosMunicipais()
		{
            InitializeComponent();

            List<SimboloModel> lista = new List<SimboloModel>();
            lista.Add(new SimboloModel()
            {
                Descricao = string.Empty
            });

            BindingContext = new SimboloViewModel(lista);
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
            SimboloListView.SelectedItem = null;
        }
    }
}