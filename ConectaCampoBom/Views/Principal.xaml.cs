﻿using ConectaCampoBom.Util;
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

        public async void OnTapGestureTappedMenuPrefeitura(object sender, EventArgs args)
        {
            try
            {
                var modalPage = new Load();
                await Navigation.PushModalAsync(modalPage);
                await Navigation.PushAsync(new Prefeitura());
                await Navigation.PopModalAsync();
            }
            catch (Exception ex)
            {
                string Message = ex.Message;
                string StackTrace = ex.StackTrace;
                Console.WriteLine(Message + "|" + StackTrace);
            }
        }

        public async void OnTapGestureTappedMenuCidade(object sender, EventArgs args)
        {
            try
            {
                var modalPage = new Load();
                await Navigation.PushModalAsync(modalPage);
                await Navigation.PushAsync(new Cidade());
                await Navigation.PopModalAsync();
            }
            catch (Exception ex)
            {
                string Message = ex.Message;
                string StackTrace = ex.StackTrace;
                Console.WriteLine(Message + "|" + StackTrace);
            }
        }

        public async void OnTapGestureTappedMenuEmpregos(object sender, EventArgs args)
        {
            try
            {
                var modalPage = new Load();
                await Navigation.PushModalAsync(modalPage);
                await Navigation.PushAsync(new Empregos());
                await Navigation.PopModalAsync();
            }
            catch (Exception ex)
            {
                string Message = ex.Message;
                string StackTrace = ex.StackTrace;
                Console.WriteLine(Message + "|" + StackTrace);
            }
        }

        public async void OnTapGestureTappedMenuNoticias(object sender, EventArgs args)
        {
            try
            {
                var modalPage = new Load();
                await Navigation.PushModalAsync(modalPage);
                await Navigation.PushAsync(new Noticias());
                await Navigation.PopModalAsync();
            }
            catch (Exception ex)
            {
                string Message = ex.Message;
                string StackTrace = ex.StackTrace;
                Console.WriteLine(Message + "|" + StackTrace);
            }
        }

        public async void OnTapGestureTappedMenuDeuCerto(object sender, EventArgs args)
        {
            try
            {
                var modalPage = new Load();
                await Navigation.PushModalAsync(modalPage);
                await Navigation.PushAsync(new DeuCerto());
                await Navigation.PopModalAsync();
            }
            catch (Exception ex)
            {
                string Message = ex.Message;
                string StackTrace = ex.StackTrace;
                Console.WriteLine(Message + "|" + StackTrace);
            }
        }

        public async void OnTapGestureTappedMenuSuaVoz(object sender, EventArgs args)
        {
            try
            {
                var modalPage = new Load();
                await Navigation.PushModalAsync(modalPage);
                await Navigation.PushAsync(new SuaVoz());
                //await Navigation.PushAsync(new Chamado());
                await Navigation.PopModalAsync();
            }
            catch (Exception ex)
            {
                string Message = ex.Message;
                string StackTrace = ex.StackTrace;
                Console.WriteLine(Message + "|" + StackTrace);
            }
        }

        public async void OnTapGestureTappedFacebook(object sender, EventArgs args)
        {
            Device.OpenUri(new Uri("http://facebook.com.br/prefeituradecampobom"));
        }
        
    }
}