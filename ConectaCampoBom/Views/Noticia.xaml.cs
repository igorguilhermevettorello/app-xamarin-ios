using ConectaCampoBom.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ConectaCampoBom.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Noticia : ContentPage
	{
        private string Texto { get; set; } = string.Empty;
		public Noticia (NoticiaModel noticia)
		{
			InitializeComponent ();

            string html = @"<!doctype html>
                            <html lang='pt-BR'>
                              <head>
                                <meta charset='utf-8'>
                                <meta name = 'viewport' content='width=device-width, initial-scale=1, shrink-to-fit=no'>
                            	
                                <style>
                                  html, body {
                                    height: 100%;
                                    background-color: Transparent;
                                  }
                                  
                                  .p-noticia-data-hora {
                                    color: rgba(255, 255, 255, 1) !important;
                                    font-size: 11px;
                                    text-align: center;
                                  }
                            
                                  .p-noticia-titulo {
                                    color: rgba(255, 255, 255, 1) !important;
                                    line-height: 1.2;
                                    font-size: 24px;
                                    font-weight: bold;
                                    text-align: center;
                                    text-shadow: 1px 1px 0px rgba(0,0,0,0.3);
                                  }
                            
                                  .div-noticia {
                                    text-align: center;
                                  }
                                  
                                  .p-reportagem {
                                    color: rgba(255, 255, 255, 1) !important;
                                    font-size: 13px;
                                    font-weight: bold;
                                    text-align: justify;
                                  }
                                  
                                  .img-noticia {
                                    border: 2px solid rgba(255, 255, 255, 1);
                                    border-radius: 5px;
                                    width: 100%;
                                    margin-top: 10px;
                                    margin-bottom: 15px;
                                  }

                                  p span, p table, p span table {
                                    color: rgba(255, 255, 255, 1) !important;
                                  }

                                  table {
                                    border-collapse: collapse;
                                  }
                                  table tr td {
                                    border: 1px solid rgba(255, 255, 255, 1); 
                                  }
                                </style>
                              </head>
                              <body>
                                <p class='p-noticia-data-hora'>" + noticia.DataHora + @"</p>
                                <p class='p-noticia-titulo'>" + noticia.Titulo + @"</p>
                                <div class='div-noticia'>
                                  <img class='img-noticia' src='" + noticia.Imagem + @"' />
                                </div>
                                <p class='p-reportagem' style='color:white;'>" + noticia.Reportagem + @"</p>
                              </body>
                            </html>";      

            var htmlSource = new HtmlWebViewSource();
            htmlSource.Html = html; 
            navegador.Source = htmlSource;
        }

        private void PagOnNavigating(object sender, WebNavigatingEventArgs e) { }

        private void PagOnNavigated(object sender, WebNavigatedEventArgs e) { }
    }
}