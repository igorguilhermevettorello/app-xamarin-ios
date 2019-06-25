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
	public partial class DadosGerais : ContentPage
	{
        List<DadosGeraisModel> lista { get; set; }

        public DadosGerais()
		{
			InitializeComponent();

            //Task<string> request = GetInfoDadosGerais();
            //
            //request.Wait();
            //
            //string content = request.Result;
            //
            //lista = new List<DadosGeraisModel>();
            //
            //if (!string.IsNullOrEmpty(content))
            //{
            //    DadosGeraisBaseJson b = JsonConvert.DeserializeObject<DadosGeraisBaseJson>(content);
            //
            //    string descricao = @"Uma cidade que conserva a sua beleza natural e hospitaleira no nome. Assim é Campo Bom, um lugar que servia de paragem para tropeiros que vinham dos Altos de Cima da Serra em direção à Capital, e que recebeu deles o nome em homenagem aos seus belos campos verdes.Em 1824 chegaram aqui os primeiros colonos alemães e a partir de então a cidade começou a receber pessoas de todas as partes.Como o distrito criara vida própria e não parava de crescer, em 31 de janeiro de 1959 era criado o município de Campo Bom.Cidade pequena, mas de grande capacidade e que deixa sua marca de pioneirismo em várias áreas";
            //
            //    //string descricao = b.Dados.Descricao;
            //
            //    lista.Add(new DadosGeraisModel()
            //    {
            //        //Descricao = "<html>" +
            //        //            "<body style='background-color:transparent; color:black;'>" +
            //        //            "<p>" +
            //        //            "<button onclick='teste()'>teste</button>" +
            //        //            "</p>" +
            //        //            "<p style='font-size: 15px; font-weight: bolder; text-shadow: 1px 1px 0px rgba(0,0,0,0.3);'>" +
            //        //            "História da cidade" +
            //        //            "</p>" +
            //        //            "<p style='text-align: justify;font-size: 13px;background-color:transparent;'>" 
            //        //            + b.Dados.Descricao + 
            //        //            "</p>" +
            //        //            "<script>function teste() {var height =  Math.max(+document.documentElement.offsetHeight,+document.body.offsetHeight);alert(height);}</script>" +
            //        //            "</body>" +
            //        //            "</html>"
            //        Descricao = descricao
            //    });
            //}
            
            lista = new List<DadosGeraisModel>();
            lista.Add(new DadosGeraisModel()
            {
                Descricao = "teste"
            });

            BindingContext = new DadosGeraisViewModel(lista);
        }

        public async Task<string> GetInfoDadosGerais()
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

        private void OnMenuItemTapped(object sender, ItemTappedEventArgs e) { }

        private async void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            DadosGeraisListView.SelectedItem = null;
        }
    }
}