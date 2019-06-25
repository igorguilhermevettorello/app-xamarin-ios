namespace ConectaCampoBom.Base
{
    public class TelefoneBaseJson
    {
        [Newtonsoft.Json.JsonProperty("id")]
        public int Id { get; set; }

        [Newtonsoft.Json.JsonProperty("descricao")]
        public string Descricao { get; set; }

        [Newtonsoft.Json.JsonProperty("telefone")]
        public string Telefone { get; set; }

        [Newtonsoft.Json.JsonProperty("discagem")]
        public string Discagem { get; set; }
    }
}
