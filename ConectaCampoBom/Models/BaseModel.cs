using System.Collections.Generic;

namespace ConectaCampoBom.Models
{
    public class BaseModel
    {
        [Newtonsoft.Json.JsonProperty("status")]
        public string status { get; set; }

        [Newtonsoft.Json.JsonProperty("msg")]
        public string msg { get; set; }

        [Newtonsoft.Json.JsonProperty("dados")]
        public List<DadoModel> dados { get; set; }
    }
}
