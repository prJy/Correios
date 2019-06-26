using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Correios.Entities.Models
{
    [XmlRoot(ElementName = "itemEncomenda")]
    public class ItemEncomendaEtiquetaInternacional
    {
        [XmlElement(ElementName = "codigoSHItem")]
        public string CodigoSHItem { get; set; }
        [XmlElement(ElementName = "codigoSKUItem")]
        public string CodigoSKUItem { get; set; }
        [XmlElement(ElementName = "descricaoItem")]
        public string DescricaoItem { get; set; }
        [XmlElement(ElementName = "quantidadeItem")]
        public string QuantidadeItem { get; set; }
        [XmlElement(ElementName = "valorUnitario")]
        public string ValorUnitario { get; set; }
        [XmlElement(ElementName = "pesoUnitario")]
        public string PesoUnitario { get; set; }
    }
}
