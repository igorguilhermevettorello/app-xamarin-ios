using ConectaCampoBom.Models;
using ConectaCampoBom.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConectaCampoBom.ViewModels
{
    public class HistoriaViewModel
    {
        public IList<HistoriaModel> Itens { get; private set; }
        public bool Mostrar { get; private set; }
        public HistoriaViewModel()
        {
            var repo = new HistoriaService();
            Itens = repo.Historias;
        }

        public HistoriaViewModel(List<HistoriaModel> lista)
        {
            var repo = new HistoriaService(lista);
            Itens = repo.Historias;
            Mostrar = Itens.Count == 0;
        }

        public HistoriaViewModel(List<HistoriaModel> lista, int height)
        {
            var repo = new HistoriaService(lista);
            Itens = repo.Historias;
            Mostrar = Itens.Count == 0;
        }
    }
}
