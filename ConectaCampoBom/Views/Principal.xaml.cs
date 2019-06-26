using ConectaCampoBom.Util;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ConectaCampoBom.Views
{
    public partial class Principal : ContentPage
    {
        public bool Teste { get; set; } = false;

        public Principal()
        {
            InitializeComponent();
        }

        public void OnTapGestureRecognizerTapped(object sender, EventArgs args) { }

        public void OnTapGestureTappedMenuPrefeitura(object sender, EventArgs args)
        {
            try
            {
                var modalPage = new Load();
                Navigation.PushModalAsync(modalPage);
                Navigation.PushAsync(new Prefeitura());
                Navigation.PopModalAsync();
            }
            catch (Exception ex)
            {
                string Message = ex.Message;
                string StackTrace = ex.StackTrace;
                Console.WriteLine(Message + "|" + StackTrace);
            }
        }

        public void OnTapGestureTappedMenuCidade(object sender, EventArgs args)
        {
            try
            {
                var modalPage = new Load();
                Navigation.PushModalAsync(modalPage);
                Navigation.PushAsync(new Cidade());
                Navigation.PopModalAsync();
            }
            catch (Exception ex)
            {
                string Message = ex.Message;
                string StackTrace = ex.StackTrace;
                Console.WriteLine(Message + "|" + StackTrace);
            }
        }

        public void OnTapGestureTappedMenuEmpregos(object sender, EventArgs args)
        {
            try
            {
                var modalPage = new Load();
                Navigation.PushModalAsync(modalPage);
                Navigation.PushAsync(new Empregos());
                Navigation.PopModalAsync();
            }
            catch (Exception ex)
            {
                string Message = ex.Message;
                string StackTrace = ex.StackTrace;
                Console.WriteLine(Message + "|" + StackTrace);
            }
        }

        public void OnTapGestureTappedMenuNoticias(object sender, EventArgs args)
        {
            try
            {
                var modalPage = new Load();
                Navigation.PushModalAsync(modalPage);
                Navigation.PushAsync(new Noticias());
                Navigation.PopModalAsync();
            }
            catch (Exception ex)
            {
                string Message = ex.Message;
                string StackTrace = ex.StackTrace;
                Console.WriteLine(Message + "|" + StackTrace);
            }
        }

        public void OnTapGestureTappedMenuDeuCerto(object sender, EventArgs args)
        {
            try
            {
                var modalPage = new Load();
                Navigation.PushModalAsync(modalPage);
                Navigation.PushAsync(new DeuCerto());
                Navigation.PopModalAsync();
            }
            catch (Exception ex)
            {
                string Message = ex.Message;
                string StackTrace = ex.StackTrace;
                Console.WriteLine(Message + "|" + StackTrace);
            }
        }

        public void OnTapGestureTappedMenuSuaVoz(object sender, EventArgs args)
        {
            try
            {
                var modalPage = new Load();
                Navigation.PushModalAsync(modalPage);
                Navigation.PushAsync(new SuaVoz());
                Navigation.PopModalAsync();
            }
            catch (Exception ex)
            {
                string Message = ex.Message;
                string StackTrace = ex.StackTrace;
                Console.WriteLine(Message + "|" + StackTrace);
            }
        }

        public void OnTapGestureTappedFacebook(object sender, EventArgs args)
        {
            Device.OpenUri(new Uri("http://facebook.com.br/prefeituradecampobom"));
        }
        
    }
}
