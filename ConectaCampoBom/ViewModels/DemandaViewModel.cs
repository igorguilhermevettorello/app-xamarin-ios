using ConectaCampoBom.Models;
using ConectaCampoBom.Services;
using System.Collections.Generic;

namespace ConectaCampoBom.ViewModels
{
    public class DemandaViewModel
    {
        public IList<DemandaModel> Itens { get; private set; }
        public bool Mostrar { get; private set; }
        public DemandaViewModel()
        {
            var repo = new DemandaService();
            Itens = repo.Demandas;
            Mostrar = Itens.Count == 0;
        }

        public DemandaViewModel(List<DemandaModel> lista)
        {
            var repo = new DemandaService(lista);
            Itens = repo.Demandas;
            Mostrar = Itens.Count == 0;
        }
    }
}
