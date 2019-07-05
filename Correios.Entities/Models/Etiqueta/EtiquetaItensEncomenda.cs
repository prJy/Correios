using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Correios.Entities.Models.Etiqueta
{
    [XmlRoot(ElementName = "itensEncomenda")]
    public class EtiquetaItensEncomenda
    {
        [XmlElement(ElementName = "itemEncomenda")]
        public EtiquetaItemEncomenda[] ItemEncomenda { get; set; }
    }
}
