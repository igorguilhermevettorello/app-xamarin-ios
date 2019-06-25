using System;
using System.Collections.Generic;
using System.Text;

namespace ConectaCampoBom.Models
{
    public class PrefeituraModel
    {
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public string Telefone { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public string Ativo { get; set; }
        public Uri ImagemUri { get; set; }
    }
}
