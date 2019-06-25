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
	public partial class Noticias : ContentPage
	{
        private List<NoticiaModel> lista { get; set; }
        private int pages { get; set; } = 1;

        public Noticias()
		{
			InitializeComponent();

            Task<string> request = GetInfoTelefones();

            request.Wait();

            string content = request.Result;

            lista = new List<NoticiaModel>();

            if (!string.IsNullOrEmpty(content))
            {
                NoticiasBaseJson b = JsonConvert.DeserializeObject<NoticiasBaseJson>(content);

                foreach (Dado dado in b.dados)
                {
                    NoticiaModel noticia = new NoticiaModel()
                    {
                        Id = dado.id,
                        Titulo = dado.titulo,
                        Imagem = dado.imagem,
                        Reportagem = dado.reportagem,
                        DataHora = dado.data_hora
                    };
                    lista.Add(noticia);
                }
            }

            BindingContext = new NoticiasViewModel(lista);
        }

        public async Task<string> GetInfoTelefones()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    string Url = "http://aplicativo.campobom.rs.gov.br/conecta_cb/public/listagemNoticias/" + pages;
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

        private async void OnMenuItemTapped(object sender, ItemTappedEventArgs e)
        {
            var modalPage = new Load();
            await Navigation.PushModalAsync(modalPage);
            var item = e.Item as NoticiaModel;
            await Navigation.PushAsync(new Noticia(item));
            await Navigation.PopModalAsync();
        }

        private async void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            NoticiaListView.SelectedItem = null;
        }
    }
}