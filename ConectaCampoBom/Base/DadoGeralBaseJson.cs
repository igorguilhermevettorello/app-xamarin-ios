namespace ConectaCampoBom.Base
{
    public class DadoGeralBaseJson
    {
        [Newtonsoft.Json.JsonProperty("id")]
        public int Id { get; set; }

        [Newtonsoft.Json.JsonProperty("descricao")]
        public string Descricao { get; set; }

        [Newtonsoft.Json.JsonProperty("imagem")]
        public string Url { get; set; }
    }
}
