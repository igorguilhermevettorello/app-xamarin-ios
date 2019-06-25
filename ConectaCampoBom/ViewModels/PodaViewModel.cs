using ConectaCampoBom.Models;
using ConectaCampoBom.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConectaCampoBom.ViewModels
{
    public class PodaViewModel
    {
        public IList<PodaModel> Itens { get; private set; }
        public bool Mostrar { get; private set; }

        public PodaViewModel()
        {
            var repo = new PodaService();
            Itens = repo.Podas;
            Mostrar = Itens.Count == 0;
        }

        public PodaViewModel(List<PodaModel> lista)
        {
            var repo = new PodaService(lista);
            Itens = repo.Podas;
            Mostrar = Itens.Count == 0;
        }
    }
}
