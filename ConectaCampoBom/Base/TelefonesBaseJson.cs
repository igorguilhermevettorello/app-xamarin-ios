using System.Collections.Generic;

namespace ConectaCampoBom.Base
{
    class TelefonesBaseJson
    {
        [Newtonsoft.Json.JsonProperty("status")]
        public string Status { get; set; }

        [Newtonsoft.Json.JsonProperty("msg")]
        public string Msg { get; set; }

        [Newtonsoft.Json.JsonProperty("dados")]
        public List<TelefoneBaseJson> Dados { get; set; }
    }
}