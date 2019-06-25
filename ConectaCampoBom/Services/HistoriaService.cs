using ConectaCampoBom.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ConectaCampoBom.Services
{
    public class HistoriaService
    {
        public ObservableCollection<HistoriaModel> Historias { get; private set; }
        
        public HistoriaService()
        {
            Historias = new ObservableCollection<HistoriaModel>();
        }

        public HistoriaService(List<HistoriaModel> lista)
        {
            Historias = new ObservableCollection<HistoriaModel>();
            lista.ForEach(e =>
            {
                Historias.Add(e);
            });
        }
    }
}
