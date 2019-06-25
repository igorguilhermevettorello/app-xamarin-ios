using ConectaCampoBom.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ConectaCampoBom.Services
{
    public class DadosGeraisService
    {
        public ObservableCollection<DadosGeraisModel> DadosGerais { get; private set; }

        public DadosGeraisService()
        {
            DadosGerais = new ObservableCollection<DadosGeraisModel>();
        }

        public DadosGeraisService(List<DadosGeraisModel> lista)
        {
            DadosGerais = new ObservableCollection<DadosGeraisModel>();
            lista.ForEach(e =>
            {
                DadosGerais.Add(e);
            });
        }
    }
}
