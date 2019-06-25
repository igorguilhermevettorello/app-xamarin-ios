using ConectaCampoBom.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ConectaCampoBom.Services
{
    public class DemandaService
    {
        public ObservableCollection<DemandaModel> Demandas { get; private set; }

        public DemandaService()
        {
            Demandas = new ObservableCollection<DemandaModel>();
        }

        public DemandaService(List<DemandaModel> lista)
        {
            Demandas = new ObservableCollection<DemandaModel>();
            lista.ForEach(e =>
            {
                Demandas.Add(e);
            });
        }
    }
}
