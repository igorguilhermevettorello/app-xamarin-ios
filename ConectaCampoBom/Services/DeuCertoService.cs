using ConectaCampoBom.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ConectaCampoBom.Services
{
    public class DeuCertoService
    {
        public ObservableCollection<DeuCertoModel> DeuCerto { get; private set; }

        public DeuCertoService()
        {
            DeuCerto = new ObservableCollection<DeuCertoModel>();
        }

        public DeuCertoService(List<DeuCertoModel> lista)
        {
            DeuCerto = new ObservableCollection<DeuCertoModel>();
            lista.ForEach(e =>
            {
                DeuCerto.Add(e);
            });
        }
    }
}
