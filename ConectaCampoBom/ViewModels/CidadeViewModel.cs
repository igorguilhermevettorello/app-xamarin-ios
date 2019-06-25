using ConectaCampoBom.Models;
using ConectaCampoBom.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConectaCampoBom.ViewModels
{
    public class CidadeViewModel
    {
        public IList<CidadeModel> Items { get; private set; }

        public CidadeViewModel()
        {
            var repo = new CidadeService();
            Items = repo.Cidades;
        }
    }
}
