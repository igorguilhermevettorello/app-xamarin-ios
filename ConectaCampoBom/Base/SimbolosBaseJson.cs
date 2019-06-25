namespace ConectaCampoBom.Base
{
    public class SimbolosBaseJson
    {
        [Newtonsoft.Json.JsonProperty("status")]
        public string Status { get; set; }

        [Newtonsoft.Json.JsonProperty("msg")]
        public string Msg { get; set; }

        [Newtonsoft.Json.JsonProperty("dados")]
        public SimboloBaseJson Dados { get; set; }
    }
}
