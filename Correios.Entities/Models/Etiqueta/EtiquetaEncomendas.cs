using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Correios.Entities.Models.Etiqueta
{
    [XmlRoot(ElementName = "encomendas")]
    public class Encomendas
    {
        [XmlElement(ElementName = "encomenda")]
        public EtiquetaEncomenda Encomenda { get; set; }
    }
}
