using ConectaCampoBom.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ConectaCampoBom.Services
{
    public class PrefeituraService
    {
        public ObservableCollection<PrefeituraModel> Itens { get; private set; }

        public PrefeituraService()
        {
            Itens = new ObservableCollection<PrefeituraModel>();
        }

        public PrefeituraService(List<PrefeituraModel> lista)
        {
            Itens = new ObservableCollection<PrefeituraModel>();
            lista.ForEach(e =>
            {
                Itens.Add(e);
            });
        }
    }
}
