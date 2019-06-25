using ConectaCampoBom.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ConectaCampoBom.Services
{
    public class NoticiaService
    {
        public ObservableCollection<NoticiaModel> Noticias { get; private set; }

        public NoticiaService()
        {
            Noticias = new ObservableCollection<NoticiaModel>();
        }

        public NoticiaService(List<NoticiaModel> lista)
        {
            Noticias = new ObservableCollection<NoticiaModel>();
            lista.ForEach(e =>
            {
                Noticias.Add(e);
            });
        }
    }
}
