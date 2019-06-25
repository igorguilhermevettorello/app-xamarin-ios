using ConectaCampoBom.Models;
using ConectaCampoBom.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConectaCampoBom.ViewModels
{
    public class PrefeituraViewModel
    {
        public IList<PrefeituraModel> Itens { get; private set; }
        public bool Mostrar { get; private set; }

        public PrefeituraViewModel()
        {
            var repo = new PrefeituraService();
            Itens = repo.Itens;
        }

        public PrefeituraViewModel(List<PrefeituraModel> lista)
        {
            var repo = new PrefeituraService(lista);
            Itens = repo.Itens;
            Mostrar = Itens.Count == 0;
        }
    }
}
