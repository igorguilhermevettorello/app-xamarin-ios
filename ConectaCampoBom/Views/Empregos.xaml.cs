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
	public partial class Empregos : ContentPage
	{
        public Empregos ()
		{
            InitializeComponent ();

            Task<string> request = GetInfoPrefeitura();
            
            request.Wait();
            
            string content = request.Result;

            List<EmpregoModel> lista = new List<EmpregoModel>();

            if (!string.IsNullOrEmpty(content))
            {
                EmpregosBaseJson b = JsonConvert.DeserializeObject<EmpregosBaseJson>(content);
                b.Dados.ForEach(dado =>
                {
                    EmpregoModel em = new EmpregoModel()
                    {
                        Id = dado.Id,
                        NomeEmpresa = dado.NomeEmpresa,
                        CargoOferecido = dado.CargoOferecido,
                        DescricaoCargo = dado.DescricaoCargo,
                        Telefone = dado.Telefone,
                        Email = dado.Email,
                        Site = dado.Site,
                        SerialCelular = dado.SerialCelular,
                        Ativo = dado.Ativo,
                        Deleted = dado.Deleted,
                        Vaga = dado.Vaga,
                        Numero = dado.Numero
                    };
                    lista.Add(em);
                });
            }

            BindingContext = new EmpregoViewModel(lista);

        }

        public async Task<string> GetInfoPrefeitura()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    string Url = "http://aplicativo.campobom.rs.gov.br/conecta_cb/public/listarVagas";
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
            ContatosListView.SelectedItem = null;
        }
    }
}