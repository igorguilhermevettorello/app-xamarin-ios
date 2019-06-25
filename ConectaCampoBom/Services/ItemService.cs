using System;
using System.Collections.ObjectModel;
using ConectaCampoBom.Models;
using ConectaCampoBom.Views;

namespace ConectaCampoBom.Services
{
    public class ItemService
    {
        public ItemService()
        {
        }

        private static ObservableCollection<MenuModel> menuLista { get; set; }

        public static ObservableCollection<MenuModel> GetMenu()
        {
            //menuLista.Add(new MenuModel() { Titulo = "Início", Descricao = "abc", Imagem = "pinguim.jpeg", Page = typeof(Inicio) });
            //menuLista.Add(new MenuModel() { Titulo = "Ajuda", Descricao = "def", Imagem = "pinguim.jpeg", Page = typeof(Ajuda) });
            //menuLista.Add(new MenuModel() { Titulo = "Avaliar", Descricao = "ghi", Imagem = "pinguim.jpeg", Page = typeof(Avaliar) });
            //menuLista.Add(new MenuModel() { Titulo = "Sobre", Descricao = "jlm", Imagem = "pinguim.jpeg", Page = typeof(Sobre) });

            menuLista.Add(new MenuModel() { Titulo = "Início", Page = typeof(Inicio) });
            menuLista.Add(new MenuModel() { Titulo = "Ajuda", Page = typeof(Ajuda) });
            menuLista.Add(new MenuModel() { Titulo = "Avaliar", Page = typeof(Avaliar) });
            menuLista.Add(new MenuModel() { Titulo = "Sobre", Page = typeof(Sobre) });
            return menuLista;
        }
    }
}
