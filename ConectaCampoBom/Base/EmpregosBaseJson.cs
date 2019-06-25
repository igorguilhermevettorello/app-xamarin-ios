using System.Collections.Generic;

namespace ConectaCampoBom.Base
{
    public class EmpregosBaseJson
    {
        [Newtonsoft.Json.JsonProperty("status")]
        public string Status { get; set; }

        [Newtonsoft.Json.JsonProperty("msg")]
        public string Msg { get; set; }

        [Newtonsoft.Json.JsonProperty("dados")]
        public List<EmpregoBaseJson> Dados { get; set; }
    }
}
