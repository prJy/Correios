using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Correios.Entities.Models
{
    [XmlRoot(ElementName = "encomendas")]
    public class EncomendasEtiquetaInternacional
    {
        [XmlElement(ElementName = "encomenda")]
        public EncomendaEtiquetaInternacional Encomenda { get; set; }
    }
}
