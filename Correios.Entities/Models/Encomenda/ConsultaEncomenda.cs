using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Correios.Entities.Models.Encomenda
{
    [XmlRoot(ElementName = "consultaEncomenda")]
    public class ConsultaEncomenda
    {
        [XmlElement(ElementName = "idioma")]
        public string Idioma { get; set; }
        [XmlElement(ElementName = "cartaoDePostagem")]
        public string CartaoDePostagem { get; set; }
        [XmlElement(ElementName = "codigosRastreamentoObjeto")]
        public CodigosRastreamentoObjeto CodigosRastreamentoObjeto { get; set; }
    }
}
