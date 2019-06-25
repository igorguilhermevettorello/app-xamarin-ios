using System;
namespace ConectaCampoBom.Models
{
    public class MenuModel
    {
        public string Titulo { get; set; } = string.Empty;
        public Type Page { get; set; }
        public string Pagina { get; set; } = string.Empty;

        public string Telefone { get; set; } = string.Empty;
        public string TelefoneDescricao { get; set; } = string.Empty;
        public string TelefoneNumero { get; set; } = string.Empty;
    }
}
