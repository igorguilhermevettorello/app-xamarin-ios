using System;
using System.Collections.Generic;
using System.Text;

namespace ConectaCampoBom.Base
{

    public class DemandasBaseJson
    {
        public string status { get; set; }
        public string msg { get; set; }
        public DadoDemandasBaseJson[] dados { get; set; }
    }

    public class DadoDemandasBaseJson
    {
        public string id { get; set; }
        public string endereco { get; set; }
        public string numero { get; set; }
        public string bairro { get; set; }
        public string complemento { get; set; }
        public string titulo { get; set; }
        public string descricao { get; set; }
        public string nome { get; set; }
        public object email { get; set; }
        public string celular { get; set; }
        public string whatsapp { get; set; }
        public string serial_celular { get; set; }
        public string imagem { get; set; }
        public string data_hora { get; set; }
        public string ativo { get; set; }
        public string deu_certo { get; set; }
        public object descritivo { get; set; }
        public string deleted { get; set; }
        public string notificado { get; set; }
        public object imagem_deu_certo { get; set; }
        public string imagem_deu_certo_antes { get; set; }
        public object descricao_deu_certo { get; set; }
        public string descricao_sua_voz { get; set; }
        public string protocolo { get; set; }
        public string data { get; set; }
        public string hora { get; set; }
        public string situacao { get; set; }
        public string secretaria { get; set; }
    }

}
