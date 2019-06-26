using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Correios.Entities.Models
{
    [XmlRoot(ElementName = "itensEncomenda")]
    public class ItensEncomendaEtiquetaInternacional
    {
        [XmlElement(ElementName = "itemEncomenda")]
        public ItemEncomendaEtiquetaInternacional[] ItemEncomenda { get; set; }
    }
}
