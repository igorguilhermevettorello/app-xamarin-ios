using System;
using System.Collections.Generic;
using System.Text;

namespace ConectaCampoBom.Models
{
    public class DeuCertoModel
    {
        public string Id { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public string Whatsapp { get; set; }
        public string SerialCelular { get; set; }
        public string Imagem { get; set; }
        public string DataHora { get; set; }
        public string Ativo { get; set; }
        public string DeuCerto { get; set; }
        public object Descritivo { get; set; }
        public string Deleted { get; set; }
        public string Notificado { get; set; }
        public string ImagemDeuCerto { get; set; }
        public string ImagemDeuCertoAntes { get; set; }
        public string DescricaoDeuCerto { get; set; }
        public string DescricaoSuaVoz { get; set; }
        public string Protocolo { get; set; }
        public string Data { get; set; }
        public string Hora { get; set; }
        public string Situacao { get; set; }
        public string Secretaria { get; set; }
        public Uri ImagemAntes { get; set; }
        public Uri ImagemDepois { get; set; }
        public string EnderecoDemanda { get; set; }
    }
}
