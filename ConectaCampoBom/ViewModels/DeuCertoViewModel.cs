using ConectaCampoBom.Models;
using ConectaCampoBom.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConectaCampoBom.ViewModels
{
    public class DeuCertoViewModel
    {
        public IList<DeuCertoModel> Itens { get; private set; }

        public bool Mostrar { get; private set; }
        public DeuCertoViewModel()
        {
            var repo = new DeuCertoService();
            Itens = repo.DeuCerto;
            Mostrar = Itens.Count == 0;
        }

        public DeuCertoViewModel(List<DeuCertoModel> lista)
        {
            var repo = new DeuCertoService(lista);
            Itens = repo.DeuCerto;
            Mostrar = Itens.Count == 0;
        }
    }
}
