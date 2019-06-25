namespace ConectaCampoBom.Base
{
    public class PodaBaseJson
    {
        [Newtonsoft.Json.JsonProperty("id")]
        public int Id { get; set; }

        [Newtonsoft.Json.JsonProperty("descricao")]
        public string Descricao { get; set; }

        [Newtonsoft.Json.JsonProperty("bairro")]
        public string Bairro { get; set; }

        [Newtonsoft.Json.JsonProperty("poda")]
        public string Poda { get; set; }
    }
}
