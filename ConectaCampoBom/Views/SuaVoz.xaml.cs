using ConectaCampoBom.Base;
using ConectaCampoBom.Models;
using ConectaCampoBom.Util;
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
    public partial class SuaVoz : ContentPage
    {
        List<DemandaModel> lista { get; set; }
        public SuaVoz()
        {
            InitializeComponent();

            IDeviceInformation device = DependencyService.Get<IDeviceInformation>();
            string deviceIdentifier = device.GetIdentifier();

            Task<string> request = GetInfoDemandas(deviceIdentifier);

            request.Wait();

            string content = request.Result;

            lista = new List<DemandaModel>();

            if (!string.IsNullOrEmpty(content))
            {
                DemandasBaseJson b = JsonConvert.DeserializeObject<DemandasBaseJson>(content);

                foreach (DadoDemandasBaseJson dado in b.dados)
                {
                    DemandaModel demanda = new DemandaModel()
                    {
                        Id = dado.id,
                        Titulo = dado.titulo,
                        Imagem = dado.imagem,
                        DataHora = dado.data_hora,
                        Nome = dado.nome,
                        Endereco = dado.endereco,
                        Numero = dado.numero,
                        Bairro = dado.bairro,
                        DescricaoSuaVoz = dado.descricao_sua_voz,
                        ImagemDemanda = new System.Uri(dado.imagem)
                    };
                    demanda.SetNumeroDescricaoSolicitacao();
                    demanda.SetDescricaoMensagem();
                    demanda.SetDescricaoEndereco();
                    lista.Add(demanda);
                }
            }

            BindingContext = new DemandaViewModel(lista);
        }

        public async Task<string> GetInfoDemandas(string serial)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    string Url = "http://aplicativo.campobom.rs.gov.br/conecta_cb/public/demandas/" + serial;
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
            DemandasListView.SelectedItem = null;
        }

        private async void AcessarChamado(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Chamado());
        }
    }
}