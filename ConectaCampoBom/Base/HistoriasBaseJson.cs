namespace ConectaCampoBom.Base
{
    public class HistoriasBaseJson
    {
        [Newtonsoft.Json.JsonProperty("status")]
        public string Status { get; set; }

        [Newtonsoft.Json.JsonProperty("msg")]
        public string Msg { get; set; }

        [Newtonsoft.Json.JsonProperty("dados")]
        public HistoriaBaseJson Dados { get; set; }
    }
}
