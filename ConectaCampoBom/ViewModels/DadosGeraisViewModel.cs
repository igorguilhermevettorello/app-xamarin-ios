using ConectaCampoBom.Models;
using ConectaCampoBom.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConectaCampoBom.ViewModels
{
    public class DadosGeraisViewModel
    {
        public IList<DadosGeraisModel> Itens { get; private set; }

        public DadosGeraisViewModel()
        {
            var repo = new DadosGeraisService();
            Itens = repo.DadosGerais;
        }

        public DadosGeraisViewModel(List<DadosGeraisModel> lista)
        {
            var repo = new DadosGeraisService(lista);
            Itens = repo.DadosGerais;
        }
    }
}
