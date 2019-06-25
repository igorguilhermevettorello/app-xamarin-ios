namespace ConectaCampoBom.Base
{
    public class CinemaFilmeBaseJson
    {
        [Newtonsoft.Json.JsonProperty("id")]
        public int Id { get; set; }

        [Newtonsoft.Json.JsonProperty("descricao")]
        public string Descricao { get; set; }

        [Newtonsoft.Json.JsonProperty("titulo")]
        public string Titulo { get; set; }

        [Newtonsoft.Json.JsonProperty("cartaz")]
        public string Cartaz { get; set; }
    }
}
