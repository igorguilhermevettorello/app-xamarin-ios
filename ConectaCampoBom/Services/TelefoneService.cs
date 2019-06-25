using ConectaCampoBom.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ConectaCampoBom.Services
{
    public class TelefoneService
    {
        public ObservableCollection<TelefoneModel> Telefones { get; private set; }

        public TelefoneService()
        {
            Telefones = new ObservableCollection<TelefoneModel>();
        }

        public TelefoneService(List<TelefoneModel> lista)
        {
            Telefones = new ObservableCollection<TelefoneModel>();
            lista.ForEach(e =>
            {
                Telefones.Add(e);
            });
        }
    }
}
