using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Correios.Entities.Models
{
    [XmlRoot(ElementName = "remessa")]
    public class RemessaEtiquetaInternacional
    {
        [XmlElement(ElementName = "idioma")]
        public string Idioma { get; set; }
        [XmlElement(ElementName = "encomendas")]
        public EncomendasEtiquetaInternacional Encomendas { get; set; }
    }
}
