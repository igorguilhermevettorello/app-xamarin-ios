using System;
using System.Collections.Generic;
using System.Text;

namespace ConectaCampoBom.Models
{
    public class DemandaModel
    {
        public string Id { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Nome { get; set; }
        public object Email { get; set; }
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
        public object ImagemDeuCerto { get; set; }
        public string ImagemDeuCertoAntes { get; set; }
        public object DescricaoDeuCerto { get; set; }
        public string DescricaoSuaVoz { get; set; }
        public string Protocolo { get; set; }
        public string Data { get; set; }
        public string Hora { get; set; }
        public string Situacao { get; set; }
        public string Secretaria { get; set; }
        public Uri ImagemDemanda { get; set; }
        public string DescricaoSolicitacao { get; set; }
        public string DescricaoEndereco { get; set; }
        public string DescricaoMensagem { get; set; }
        public void SetNumeroDescricaoSolicitacao()
        {
            DescricaoSolicitacao = "Solicitacao #" + Id.PadLeft(15, '0');
        }
        public void SetDescricaoMensagem()
        {
            DescricaoMensagem = "Olá " + Nome + ", recebemos sua demanda e já estamos direcionando para a secretaria correspondente.";
        }
        public void SetDescricaoEndereco()
        {
            DescricaoEndereco = Endereco + ", " + Numero + " - " + Bairro;
        }
    }
}