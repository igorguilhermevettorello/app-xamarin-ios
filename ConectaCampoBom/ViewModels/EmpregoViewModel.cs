using ConectaCampoBom.Models;
using ConectaCampoBom.Services;
using System.Collections.Generic;

namespace ConectaCampoBom.ViewModels
{
    public class EmpregoFooter
    {
        public string Descricao { get; set; }
    }

    public class EmpregoViewModel
    {
        public IList<EmpregoModel> Itens { get; private set; }
        public bool Mostrar { get; private set; }

        public EmpregoViewModel()
        {
            var repo = new EmpregoService();
            Itens = repo.Empregos;
            Mostrar = Itens.Count == 0;
        }

        public EmpregoViewModel(List<EmpregoModel> lista)
        {
            var repo = new EmpregoService(lista);
            Itens = repo.Empregos;
            Mostrar = Itens.Count == 0;
        }
    }
}
