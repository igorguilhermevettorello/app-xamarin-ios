using System;
using System.Collections.Generic;
using System.Text;

namespace ConectaCampoBom.Base
{
    public class EmpregoBaseJson
    {
        [Newtonsoft.Json.JsonProperty("id")]
        public int Id { get; set; }

        [Newtonsoft.Json.JsonProperty("nome_empresa")]
        public string NomeEmpresa { get; set; }

        [Newtonsoft.Json.JsonProperty("cargo_oferecido")]
        public string CargoOferecido { get; set; }

        [Newtonsoft.Json.JsonProperty("descricao_cargo")]
        public string DescricaoCargo { get; set; }

        [Newtonsoft.Json.JsonProperty("telefone")]
        public string Telefone { get; set; }

        [Newtonsoft.Json.JsonProperty("email")]
        public string Email { get; set; }

        [Newtonsoft.Json.JsonProperty("site")]
        public string Site { get; set; }

        [Newtonsoft.Json.JsonProperty("serial_celular")]
        public string SerialCelular { get; set; }

        [Newtonsoft.Json.JsonProperty("ativo")]
        public string Ativo { get; set; }

        [Newtonsoft.Json.JsonProperty("deleted")]
        public string Deleted { get; set; }

        [Newtonsoft.Json.JsonProperty("vaga")]
        public string Vaga { get; set; }

        [Newtonsoft.Json.JsonProperty("numero")]
        public string Numero { get; set; }
    }
}
