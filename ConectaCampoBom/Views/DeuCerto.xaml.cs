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
	public partial class DeuCerto : ContentPage
	{
        private List<DeuCertoModel> lista { get; set; }

        public DeuCerto()
		{
			InitializeComponent();

            Task<string> request = GetInfoDeuCerto();

            request.Wait();

            string content = request.Result;

            lista = new List<DeuCertoModel>();

            if (!string.IsNullOrEmpty(content))
            {
                DeuCertoBaseJson b = JsonConvert.DeserializeObject<DeuCertoBaseJson>(content);

                b.Dados.ForEach(dado =>
                {
                    DeuCertoModel em = new DeuCertoModel()
                    {
                        Id = dado.id,
                        Endereco = dado.endereco,
                        Numero = dado.numero,
                        Bairro = dado.bairro,
                        DescricaoDeuCerto = dado.descricao_deu_certo,
                        ImagemAntes = new System.Uri(dado.imagem),
                        ImagemDepois = new System.Uri(dado.imagem_deu_certo),
                    };

                    string endereco = em.Endereco;
                    if (!string.IsNullOrEmpty(em.Numero))
                        endereco = endereco + ", " + em.Numero;

                    if (!string.IsNullOrEmpty(em.Bairro))
                        endereco = endereco + " - " + em.Bairro;

                    em.EnderecoDemanda = endereco;

                    lista.Add(em);
                });
            }

            BindingContext = new DeuCertoViewModel(lista);
        }

        public async Task<string> GetInfoDeuCerto()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    string Url = "http://aplicativo.campobom.rs.gov.br/conecta_cb/public/listarDeuCerto";
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
            DeuCertoListView.SelectedItem = null;
        }
    }
}