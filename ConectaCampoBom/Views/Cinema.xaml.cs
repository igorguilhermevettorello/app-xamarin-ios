using ConectaCampoBom.Base;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ConectaCampoBom.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Cinema : ContentPage
	{
		public Cinema ()
		{
			InitializeComponent ();

            Task<string> request = GetInfoCinema();

            request.Wait();

            string content = request.Result;

            if (!string.IsNullOrEmpty(content))
            {   
                CinemasBaseJson item = JsonConvert.DeserializeObject<CinemasBaseJson>(content);
                
                string html = @"<!doctype html>
                                <html lang='pt-BR'>
                                    <head>
                                        <meta charset='utf-8'>
                                        <meta name='viewport' content='width=device-width, initial-scale=1, shrink-to-fit=no'>
	
                                        <style>
                                            html, body {
                                                height: 100%;
                                            }

                                            table {
                                                width: 100%
                                                margin: 10px;
                                            }

                                            .td-spacing-10 {
                                                height: 15px;
                                            }

                                            .div-cinema-filme {
                                                padding: 3px;
                                                background: white;
                                                border-radius: 3px;
                                                box-shadow: 0px 2px 7px rgba(0,0,0,0.5);
                                            }

                                            .div-cinema-filme p {
                                                background: -webkit-linear-gradient(rgba(119, 195, 83, 1), rgba(34, 127, 187, 1));
                                                -webkit-background-clip: text;
                                                -webkit-text-fill-color: transparent;
                                                text-align: center;
                                                font-weight: bold;
                                            }
                                        </style>
                                    </head>
                                    <body>
                                        <table>
                                            <tr valign='top'>
                                                <td>
                                                    <div class='div-cinema-filme' style='margin-right: 3px; height: 100%;' onclick='viewFilme(0)'>
                                                        <img 
                                                            style='width: 100%;'
                                                            title=''
                                                            src='" + item.dados.filmes[0].Filme.cartaz + @"'
                                                            alt='' />
              
                                                        <p style='margin: 0px;'>" + item.dados.filmes[0].Filme.titulo  + @"</p>
                                                    </div>
                                                </td>
                                                <td>
                                                    <div class='div-cinema-filme' style='margin-right: 3px; height: 100%;' onclick='viewFilme(0)'>
                                                        <img 
                                                            style='width: 100%;'
                                                            title=''
                                                            src='" + item.dados.filmes[1].Filme.cartaz + @"'
                                                            alt='' />
              
                                                        <p style='margin: 0px;'>" + item.dados.filmes[1].Filme.titulo + @"</p>
                                                    </div>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td colspan='2'>
                                                    <div style='color: white;'>" + item.dados.cinema.descricao + @"</div>
                                                </td>	
                                            </tr>
                                        </table>
                                    </body>
                                </html>";

                var htmlSource = new HtmlWebViewSource();
                htmlSource.Html = html; 
                navegador.Source = htmlSource;
            }
            else
            {
                var htmlSource = new HtmlWebViewSource();
                htmlSource.Html = @"<!doctype html>
                                    <html lang='pt-BR'>
                                      <head>
                                        <meta charset='utf-8'>
                                        <meta name='viewport' content='width=device-width, initial-scale=1, shrink-to-fit=no'>
	                                    <style>
		                                    html, body, table {
                                                width: 100%
			                                    height: 100%;
			                                    background-color: rgba(34, 127, 186, 1);
			                                    background-image: linear-gradient(rgba(111, 188, 92, 1), rgba(34, 127, 186, 1));
		                                    }
		
		                                    .td-spacing-10 {
			                                    height: 15px;
		                                    }
	                                    </style>
                                      </head>
                                      <body>
	                                    teste
                                      </body>
                                    </html>";
                navegador.Source = htmlSource;
            }
        }

        public async Task<string> GetInfoCinema()
        {
            using (var client = new HttpClient())
            {
                string Url = "http://aplicativo.campobom.rs.gov.br/conecta_cb/public/getInfoCinema";
                var request = new HttpRequestMessage(HttpMethod.Get, Url);
                var response = await client.SendAsync(request).ConfigureAwait(false);
                if (response.IsSuccessStatusCode)
                    return await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                else
                    return null;
            }
        }

        private void PagOnNavigating(object sender, WebNavigatingEventArgs e) { }

        private void PagOnNavigated(object sender, WebNavigatedEventArgs e) { }
    }
}