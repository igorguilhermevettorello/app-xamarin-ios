using ConectaCampoBom.Models;
using ConectaCampoBom.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConectaCampoBom.ViewModels
{
    public class TelefoneViewModel
    {
        public IList<TelefoneModel> Itens { get; private set; }

        public TelefoneViewModel()
        {
            var repo = new TelefoneService();
            Itens = repo.Telefones;
        }

        public TelefoneViewModel(List<TelefoneModel> lista)
        {
            var repo = new TelefoneService(lista);
            Itens = repo.Telefones;
        }
    }
}
