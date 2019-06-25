using ConectaCampoBom.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ConectaCampoBom.Services
{
    public class PodaService
    {
        public ObservableCollection<PodaModel> Podas { get; private set; }

        public PodaService()
        {
            Podas = new ObservableCollection<PodaModel>();
        }

        public PodaService(List<PodaModel> lista)
        {
            Podas = new ObservableCollection<PodaModel>();
            lista.ForEach(e =>
            {
                Podas.Add(e);
            });
        }
    }
}
