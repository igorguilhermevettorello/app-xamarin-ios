using System;
using System.Collections.Generic;
using System.Text;

namespace ConectaCampoBom.Base
{
    public class DownloadBaseJson
    {
        [Newtonsoft.Json.JsonProperty("id")]
        public int Id { get; set; }

        [Newtonsoft.Json.JsonProperty("descricao")]
        public string Descricao { get; set; }

        [Newtonsoft.Json.JsonProperty("imagem")]
        public string Url { get; set; }
    }
}
