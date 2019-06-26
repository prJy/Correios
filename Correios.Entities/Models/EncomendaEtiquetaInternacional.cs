using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Correios.Entities.Models
{
    [XmlRoot(ElementName = "encomenda")]
    public class EncomendaEtiquetaInternacional
    {
        [XmlElement(ElementName = "cartaoDePostagem")]
        public string CartaoDePostagem { get; set; }
        [XmlElement(ElementName = "codigoControleCliente")]
        public string CodigoControleCliente { get; set; }
        [XmlElement(ElementName = "nomeRemetente")]
        public string NomeRemetente { get; set; }
        [XmlElement(ElementName = "enderecoRemetente")]
        public string EnderecoRemetente { get; set; }
        [XmlElement(ElementName = "numeroEnderecoRemetente")]
        public string NumeroEnderecoRemetente { get; set; }
        [XmlElement(ElementName = "complementoEnderecoRemetente")]
        public string ComplementoEnderecoRemetente { get; set; }
        [XmlElement(ElementName = "codigoPostalRemetente")]
        public string CodigoPostalRemetente { get; set; }
        [XmlElement(ElementName = "cidadeRemetente")]
        public string CidadeRemetente { get; set; }
        [XmlElement(ElementName = "estadoRemetente")]
        public string EstadoRemetente { get; set; }
        [XmlElement(ElementName = "paisRemetente")]
        public string PaisRemetente { get; set; }
        [XmlElement(ElementName = "emailRemetente")]
        public string EmailRemetente { get; set; }
        [XmlElement(ElementName = "telefoneRemetente")]
        public string TelefoneRemetente { get; set; }
        [XmlElement(ElementName = "siteRemetente")]
        public string SiteRemetente { get; set; }
        [XmlElement(ElementName = "nomeDestinatario")]
        public string NomeDestinatario { get; set; }
        [XmlElement(ElementName = "tipoDocumentoDestinatario")]
        public string TipoDocumentoDestinatario { get; set; }
        [XmlElement(ElementName = "numeroDocumentoDestinatario")]
        public string NumeroDocumentoDestinatario { get; set; }
        [XmlElement(ElementName = "enderecoDestinatario")]
        public string EnderecoDestinatario { get; set; }
        [XmlElement(ElementName = "numeroEnderecoDestinatario")]
        public string NumeroEnderecoDestinatario { get; set; }
        [XmlElement(ElementName = "complementoEnderecoDestinatario")]
        public string ComplementoEnderecoDestinatario { get; set; }
        [XmlElement(ElementName = "codigoPostalDestinatario")]
        public string CodigoPostalDestinatario { get; set; }
        [XmlElement(ElementName = "caixaPostalDestinatario")]
        public string CaixaPostalDestinatario { get; set; }
        [XmlElement(ElementName = "cidadeDestinatario")]
        public string CidadeDestinatario { get; set; }
        [XmlElement(ElementName = "ufDestinatario")]
        public string UfDestinatario { get; set; }
        [XmlElement(ElementName = "paisDestinatario")]
        public string PaisDestinatario { get; set; }
        [XmlElement(ElementName = "emailDestinatario")]
        public string EmailDestinatario { get; set; }
        [XmlElement(ElementName = "telefoneDestinatario")]
        public string TelefoneDestinatario { get; set; }
        [XmlElement(ElementName = "pesoObjeto")]
        public string PesoObjeto { get; set; }
        [XmlElement(ElementName = "comprimentoObjeto")]
        public string ComprimentoObjeto { get; set; }
        [XmlElement(ElementName = "larguraObjeto")]
        public string LarguraObjeto { get; set; }
        [XmlElement(ElementName = "alturaObjeto")]
        public string AlturaObjeto { get; set; }
        [XmlElement(ElementName = "modalidadeDistribuicaoObjeto")]
        public string ModalidadeDistribuicaoObjeto { get; set; }
        [XmlElement(ElementName = "modalidadePagamentoImpostosObjeto")]
        public string ModalidadePagamentoImpostosObjeto { get; set; }
        [XmlElement(ElementName = "codigoMoeda")]
        public string CodigoMoeda { get; set; }
        [XmlElement(ElementName = "valorFreteObjeto")]
        public string ValorFreteObjeto { get; set; }
        [XmlElement(ElementName = "valorSeguroObjeto")]
        public string ValorSeguroObjeto { get; set; }
        [XmlElement(ElementName = "modoDevolucaoObjeto")]
        public string ModoDevolucaoObjeto { get; set; }
        [XmlElement(ElementName = "seguroDevolucaoObjeto")]
        public string SeguroDevolucaoObjeto { get; set; }
        [XmlElement(ElementName = "itensEncomenda")]
        public ItensEncomendaEtiquetaInternacional ItensEncomenda { get; set; }
    }
}
