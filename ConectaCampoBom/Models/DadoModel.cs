namespace ConectaCampoBom.Models
{
    public class DadoModel
    {
        [Newtonsoft.Json.JsonProperty("id")]
        public int Id { get; set; }

        [Newtonsoft.Json.JsonProperty("nome")]
        public string Nome { get; set; }

        [Newtonsoft.Json.JsonProperty("cargo")]
        public string Cargo { get; set; }

        [Newtonsoft.Json.JsonProperty("telefone")]
        public string Telefone { get; set; }

        [Newtonsoft.Json.JsonProperty("tel")]
        public string Tel { get; set; }

        [Newtonsoft.Json.JsonProperty("email")]
        public string Email { get; set; }

        [Newtonsoft.Json.JsonProperty("imagem")]
        public string Imagem { get; set; }

        [Newtonsoft.Json.JsonProperty("ativo")]
        public string Ativo { get; set; }
    }
}
