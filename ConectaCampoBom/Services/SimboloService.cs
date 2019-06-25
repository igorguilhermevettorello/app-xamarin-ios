using ConectaCampoBom.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ConectaCampoBom.Services
{
    public class SimboloService
    {
        public ObservableCollection<SimboloModel> Simbolos { get; private set; }


        public SimboloService()
        {
            Simbolos = new ObservableCollection<SimboloModel>();
        }

        public SimboloService(List<SimboloModel> lista)
        {
            Simbolos = new ObservableCollection<SimboloModel>();
            lista.ForEach(e =>
            {
                Simbolos.Add(e);
            });
        }
    }
}
