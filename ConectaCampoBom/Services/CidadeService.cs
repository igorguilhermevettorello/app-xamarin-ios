using ConectaCampoBom.Models;
using System.Collections.ObjectModel;

namespace ConectaCampoBom.Services
{
    public class CidadeService
    {
        public ObservableCollection<CidadeModel> Cidades { get; private set; }

        public CidadeService()
        {
            Cidades = new ObservableCollection<CidadeModel>()
            {
                new CidadeModel() { Descricao = "História da Cidade" },
                new CidadeModel() { Descricao = "Símbolos Municipais" },
                new CidadeModel() { Descricao = "Dados Gerais" },
                new CidadeModel() { Descricao = "Downloads" },
                new CidadeModel() { Descricao = "Cinema" },
                new CidadeModel() { Descricao = "Podas" },
                new CidadeModel() { Descricao = "Telefones Úteis" }
            };
        }
    }
}
