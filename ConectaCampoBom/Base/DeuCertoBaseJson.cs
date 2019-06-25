using System.Collections.Generic;

namespace ConectaCampoBom.Base
{
    public class DeuCertoBaseJson
    {
        [Newtonsoft.Json.JsonProperty("status")]
        public string Status { get; set; }

        [Newtonsoft.Json.JsonProperty("msg")]
        public string Msg { get; set; }

        [Newtonsoft.Json.JsonProperty("dados")]
        public List<DeuCertoDadosBaseJson> Dados { get; set; }
    }

    public class DeuCertoDadosBaseJson
    {
        [Newtonsoft.Json.JsonProperty("id")]
        public string id { get; set; }

        [Newtonsoft.Json.JsonProperty("endereco")]
        public string endereco { get; set; }

        [Newtonsoft.Json.JsonProperty("numero")]
        public string numero { get; set; }

        [Newtonsoft.Json.JsonProperty("bairro")]
        public string bairro { get; set; }

        [Newtonsoft.Json.JsonProperty("complemento")]
        public string complemento { get; set; }

        [Newtonsoft.Json.JsonProperty("titulo")]
        public string titulo { get; set; }

        [Newtonsoft.Json.JsonProperty("descricao")]
        public string descricao { get; set; }

        [Newtonsoft.Json.JsonProperty("nome")]
        public string nome { get; set; }

        [Newtonsoft.Json.JsonProperty("email")]
        public string email { get; set; }

        [Newtonsoft.Json.JsonProperty("celular")]
        public string celular { get; set; }

        [Newtonsoft.Json.JsonProperty("whatsapp")]
        public string whatsapp { get; set; }

        [Newtonsoft.Json.JsonProperty("serial_celular")]
        public string serial_celular { get; set; }

        [Newtonsoft.Json.JsonProperty("imagem")]
        public string imagem { get; set; }

        [Newtonsoft.Json.JsonProperty("data_hora")]
        public string data_hora { get; set; }

        [Newtonsoft.Json.JsonProperty("ativo")]
        public string ativo { get; set; }

        [Newtonsoft.Json.JsonProperty("deu_certo")]
        public string deu_certo { get; set; }

        [Newtonsoft.Json.JsonProperty("descritivo")]
        public object descritivo { get; set; }

        [Newtonsoft.Json.JsonProperty("deleted")]
        public string deleted { get; set; }

        [Newtonsoft.Json.JsonProperty("notificado")]
        public string notificado { get; set; }

        [Newtonsoft.Json.JsonProperty("imagem_deu_certo")]
        public string imagem_deu_certo { get; set; }

        [Newtonsoft.Json.JsonProperty("imagem_deu_certo_antes")]
        public string imagem_deu_certo_antes { get; set; }

        [Newtonsoft.Json.JsonProperty("descricao_deu_certo")]
        public string descricao_deu_certo { get; set; }

        [Newtonsoft.Json.JsonProperty("descricao_sua_voz")]
        public string descricao_sua_voz { get; set; }

        [Newtonsoft.Json.JsonProperty("protocolo")]
        public string protocolo { get; set; }

        [Newtonsoft.Json.JsonProperty("data")]
        public string data { get; set; }

        [Newtonsoft.Json.JsonProperty("hora")]
        public string hora { get; set; }

        [Newtonsoft.Json.JsonProperty("situacao")]
        public string situacao { get; set; }

        [Newtonsoft.Json.JsonProperty("secretaria")]
        public string secretaria { get; set; }
    }
}
