using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Correios.Entities.Models.Fatura
{
    [XmlRoot(ElementName = "consultaFaturaEntrega")]
    public class ConsultaFaturaEntrega
    {
        [XmlElement(ElementName = "idioma")]
        public string Idioma { get; set; }
        [XmlElement(ElementName = "cartaoPostagem")]
        public string CartaoPostagem { get; set; }
        [XmlElement(ElementName = "codigosFaturaEntrega")]
        public CodigosFaturaEntrega CodigosFaturaEntrega { get; set; }
    }
}
