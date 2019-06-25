using ConectaCampoBom.Models;
using ConectaCampoBom.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConectaCampoBom.ViewModels
{
    public class SimboloViewModel
    {
        public IList<SimboloModel> Itens { get; private set; }

        public bool Mostrar { get; private set; }

        public SimboloViewModel()
        {
            var repo = new SimboloService();
            Itens = repo.Simbolos;
            Mostrar = Itens.Count == 0;
        }

        public SimboloViewModel(List<SimboloModel> lista)
        {
            var repo = new SimboloService(lista);
            Itens = repo.Simbolos;
            Mostrar = Itens.Count == 0;
        }
    }
}
