using ConectaCampoBom.Models;
using System.Collections.ObjectModel;

namespace ConectaCampoBom.Services
{
    public class ContatoService
    {
        public ObservableCollection<Contato> TodosContatos { get; private set; }

        public ContatoService()
        {
            TodosContatos = new ObservableCollection<Contato> {
                new Contato { Nome = "Jose Macoratti abc abc abc abc abc abc abc abc abc abc abc abc abc abc abc abc abc abc abc abc abc abc abc abc abc abc abc abc abc abc abc abc abc abc abc abc abc abc abc abc abc abc abc abc abc abc abc abc v abc abc abc abc", Email = "egestas@anequeNullam.co.uk" },
                new Contato { Nome = "Maria Julia", Email = "a.tortor@Sed.net" },
                new Contato { Nome = "Osmar Bueno", Email = "tristique@faucibusutnulla.net" },
                new Contato { Nome = "Yuri Lima", Email = "montes.nascetur.ridiculus@fringillaest.ca" },
                new Contato { Nome = "Leonardo Silveira", Email = "imperdiet.ullamcorper@Quisque.com" },
                new Contato { Nome = "Nadir Figueiredo", Email = "adipiscing@anteipsum.ca" },
                new Contato { Nome = "Emely Soares", Email = "aliquet.molestie.tellus@Nam.net" },
                new Contato { Nome = "Jose Macoratti", Email = "egestas@anequeNullam.co.uk" },
                new Contato { Nome = "Maria Julia", Email = "a.tortor@Sed.net" },
                new Contato { Nome = "Osmar Bueno", Email = "tristique@faucibusutnulla.net" },
                new Contato { Nome = "Yuri Lima", Email = "montes.nascetur.ridiculus@fringillaest.ca" },
                new Contato { Nome = "Leonardo Silveira", Email = "imperdiet.ullamcorper@Quisque.com" },
                new Contato { Nome = "Nadir Figueiredo", Email = "adipiscing@anteipsum.ca" },
                new Contato { Nome = "Emely Soares", Email = "aliquet.molestie.tellus@Nam.net" },
                new Contato { Nome = "Jose Macoratti", Email = "egestas@anequeNullam.co.uk" },
                new Contato { Nome = "Maria Julia", Email = "a.tortor@Sed.net" },
                new Contato { Nome = "Osmar Bueno", Email = "tristique@faucibusutnulla.net" },
                new Contato { Nome = "Yuri Lima", Email = "montes.nascetur.ridiculus@fringillaest.ca" },
                new Contato { Nome = "Leonardo Silveira", Email = "imperdiet.ullamcorper@Quisque.com" },
                new Contato { Nome = "Nadir Figueiredo", Email = "adipiscing@anteipsum.ca" },
                new Contato { Nome = "Emely Soares", Email = "aliquet.molestie.tellus@Nam.net" }
            };
        }
    }
}
