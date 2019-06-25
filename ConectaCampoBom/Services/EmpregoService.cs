using ConectaCampoBom.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ConectaCampoBom.Services
{
    public class EmpregoService
    {
        public ObservableCollection<EmpregoModel> Empregos { get; private set; }

        public EmpregoService()
        {
            Empregos = new ObservableCollection<EmpregoModel>();
        }

        public EmpregoService(List<EmpregoModel> lista)
        {
            Empregos = new ObservableCollection<EmpregoModel>();
            lista.ForEach(e => 
            {
                Empregos.Add(e);
            });
        }
    }
}
