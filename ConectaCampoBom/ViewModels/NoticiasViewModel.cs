using ConectaCampoBom.Models;
using ConectaCampoBom.Services;
using System.Collections.Generic;

namespace ConectaCampoBom.ViewModels
{
    public class NoticiasViewModel
    {
        public IList<NoticiaModel> Itens { get; private set; }
        public bool Mostrar { get; private set; }

        public NoticiasViewModel()
        {
            var repo = new NoticiaService();
            Itens = repo.Noticias;
            Mostrar = Itens.Count == 0;
        }

        public NoticiasViewModel(List<NoticiaModel> lista)
        {
            var repo = new NoticiaService(lista);
            Itens = repo.Noticias;
            Mostrar = Itens.Count == 0;
        }
    }
}
