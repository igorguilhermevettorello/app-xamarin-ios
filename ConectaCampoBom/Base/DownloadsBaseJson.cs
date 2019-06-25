using System;
using System.Collections.Generic;
using System.Text;

namespace ConectaCampoBom.Base
{
    public class DownloadsBaseJson
    {
        [Newtonsoft.Json.JsonProperty("status")]
        public string Status { get; set; }

        [Newtonsoft.Json.JsonProperty("msg")]
        public string Msg { get; set; }

        [Newtonsoft.Json.JsonProperty("dados")]
        public List<DownloadBaseJson> Dados { get; set; }
    }
}
