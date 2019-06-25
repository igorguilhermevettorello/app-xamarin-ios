using ConectaCampoBom.Models;
using ConectaCampoBom.Util;
using Plugin.Media;
using Plugin.Media.Abstractions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ConectaCampoBom.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Chamado : ContentPage
    { 
        public Stream Imagem { get; set; }

        public Chamado()
        {
            InitializeComponent();
            BindingContext = new DemandaModel();
        }


        public byte[] ReadImage(Stream input)
        {
            byte[] buffer = new byte[100 * 1024];
            using (MemoryStream ms = new MemoryStream())
            {
                int read;
                while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
                {
                    ms.Write(buffer, 0, read);
                }
                return ms.ToArray();
            }
        }

        private async void EnviarChamado(object sender, EventArgs e)
        {
            bool retornoServer = false;
            List<string> erros = new List<string>();
            string Endereco = txtEndereco.Text;
            string Numero = txtNumero.Text;
            string Complemento = txtComplemento.Text;
            string Bairro = txtBairro.Text;
            string Titulo = txtTitulo.Text;
            string Descricao = txtDescricao.Text;
            string Nome = txtNome.Text;
            string Email = txtEmail.Text;
            string Celular = txtCelular.Text;
            string Whatsapp = txtWhatsapp.Text;

            if (string.IsNullOrEmpty(Endereco))
                erros.Add("Campo Endereço é obrigatório");

            if (string.IsNullOrEmpty(Numero))
                erros.Add("Campo Número é obrigatório");

            if (string.IsNullOrEmpty(Complemento))
                erros.Add("Campo Complemento é obrigatório");

            if (string.IsNullOrEmpty(Complemento))
                erros.Add("Campo Complemento é obrigatório");

            if (string.IsNullOrEmpty(Bairro))
                erros.Add("Campo Bairro é obrigatório");

            if (string.IsNullOrEmpty(Titulo))
                erros.Add("Campo Título é obrigatório");

            if (string.IsNullOrEmpty(Nome))
                erros.Add("Campo Nome é obrigatório");

            if (string.IsNullOrEmpty(Nome))
                erros.Add("Campo Nome é obrigatório");

            if (string.IsNullOrEmpty(Email))
                erros.Add("Campo Título é obrigatório");

            if (string.IsNullOrEmpty(Celular))
                erros.Add("Campo Celular é obrigatório");

            if (string.IsNullOrEmpty(Whatsapp))
                erros.Add("Campo Whatsapp é obrigatório");

            if (Imagem.Length <= 0)
                erros.Add("Campo Imagem é obrigatório");

            if (erros.Count() > 0) {
                string action = await DisplayActionSheet("Informação", "Ok", null, erros.ToArray());
            }
            else
            {

                string ServerTitulo = string.Empty;
                string ServerMensagem = string.Empty;

                var modalPage = new Load();
                await Navigation.PushModalAsync(modalPage);
                var url = "http://trocadenotas.com.br/conecta_cb/public/uploadNew";

                try
                {
                    HttpClient client = new HttpClient();
                    MultipartFormDataContent content = new MultipartFormDataContent();
                    ByteArrayContent baContent = new ByteArrayContent(ReadImage(Imagem));
                    IDeviceInformation device = DependencyService.Get<IDeviceInformation>();
                    string deviceIdentifier = device.GetIdentifier();

                    content.Add(baContent, "File", "filename.jpg");
                    content.Add(new StringContent(Endereco), "endereco");
                    content.Add(new StringContent(Numero), "numero");
                    content.Add(new StringContent(Bairro), "bairro");
                    content.Add(new StringContent(Complemento), "complemento");
                    content.Add(new StringContent(Titulo), "titulo");
                    content.Add(new StringContent(Descricao), "descricao");
                    content.Add(new StringContent(Nome), "nome");
                    content.Add(new StringContent(Email), "email");
                    content.Add(new StringContent(Celular), "celular");
                    content.Add(new StringContent(Whatsapp), "whatsapp");
                    content.Add(new StringContent(deviceIdentifier), "serial_celular");

                    //upload MultipartFormDataContent content async and store response in response var
                    var response = await client.PostAsync(url, content);

                    //read response result as a string async into json var
                    var result = response.Content.ReadAsStringAsync().Result;

                    string[] resposta = result.ToString().Split('|');

                    string ret = "true";

                    if (ret.ToLower().Equals(resposta[0].ToString().ToLower()))
                    {
                        retornoServer = true;
                        ServerTitulo = "Sucesso";
                    }    
                    else
                    {
                        ServerTitulo = "Erro";
                    }
                        
                    
                    ServerMensagem = resposta[1];


                }
                catch (Exception ex)
                {
                    ServerTitulo = "Erro";
                    ServerMensagem = "Falha no envio das informações. Tente novamente";
                }
                finally
                {
                    await Navigation.PopModalAsync();
                }

                string alerta = await DisplayActionSheet(ServerTitulo, "Ok", null, ServerMensagem);
                if (retornoServer)
                {
                    Navigation.PopAsync();
                }
            }
        }

        private async void abrirLista(object sender, EventArgs e)
        {
            string[] sampleArray = new string[] { "25 de Julho",
                "4 Colônias","Alto Paulista","Aurora","Barrinha","Bela Vista",
                "Celeste","Centro","Cohab Leste","Cohab Sul","Colina Deuner",
                "Firenze","Genuíno Sampaio","Germano Sampaio","Imigrante Norte",
                "Imigrante Sul","Ind Sul","Ipiranga","Jardim do Sol","Jardim Flores",
                "Jardim Sol","Leão XIII","Loteamento Blumeng","Metzler","Mônaco",
                "Operária","Operário","Paulista","Porto Blos","Primavera",
                "Quatro Colônias","Rio Branco","Santa Lúcia","Santo Antônio",
                "Vila Augusta","Vila Celeste","Vila Gringos","Vila Leopoldina",
                "Vila Nova","Vila Rica","Zona Industrial","Zona Industrial Norte",
                "Zona Industrial Sul","Zona Rural" };

            string action = await DisplayActionSheet("Escolha o bairro", "Cancel", null, sampleArray.ToArray());


            if (action.Equals("Cancel") && string.IsNullOrEmpty(txtBairro.Text))
            {
                txtBairro.Text = string.Empty;
            }
            else
            {
                txtBairro.Text = (action.Equals("Cancel")) ? string.Empty : action;
            }
        }

        private async void TirarFoto(object sender, EventArgs e)
        {
            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
            {
                await DisplayAlert("Nenhuma Câmera", ":( Nenuma Câmera disponível.", "OK");
                return;
            }

            var armazenamento = new StoreCameraMediaOptions()
            {
                SaveToAlbum = true,
                Name = "MinhaFoto.jpg"
            };
            var foto = await CrossMedia.Current.TakePhotoAsync(armazenamento);

            if (foto == null)
                return;

            Imagem = foto.GetStream();
            imgFoto.Source = ImageSource.FromStream(() =>
            {
                var stream = foto.GetStream();
                foto.Dispose();
                return stream;
            });
        }

        private async void SelecionarImagem(object sender, EventArgs e)
        {
            if (CrossMedia.Current.IsTakePhotoSupported)
            {
                var imagem = await CrossMedia.Current.PickPhotoAsync();
                if (imagem != null)
                {
                    Imagem = imagem.GetStream();

                    imgFoto.Source = ImageSource.FromStream(() =>
                    {
                        var stream = imagem.GetStream();
                        imagem.Dispose();
                        return stream;
                    });
                }
            }
        }

        private void OnTapGestureEndereco(object sender, EventArgs e)
        {
            DisplayAlert("serial", "teste: ", "ok");
        }
    }
}