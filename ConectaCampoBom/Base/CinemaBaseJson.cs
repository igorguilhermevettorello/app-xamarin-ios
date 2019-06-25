namespace ConectaCampoBom.Base
{
    public class CinemaBaseJson
    {
        [Newtonsoft.Json.JsonProperty("id")]
        public int Id { get; set; }

        [Newtonsoft.Json.JsonProperty("descricao")]
        public string Descricao { get; set; }
    }
}
