using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Correios.Entities.Models.Unitizador
{
    [XmlRoot(ElementName = "unitizadores")]
    public class Unitizadores
    {
        [XmlElement(ElementName = "unitizador")]
        public Unitizador Unitizador { get; set; }
    }
}
