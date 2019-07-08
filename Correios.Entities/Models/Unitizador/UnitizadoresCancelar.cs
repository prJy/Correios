using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Correios.Entities.Models.Unitizador
{
    [XmlRoot(ElementName = "unitizadores")]
    public class UnitizadoresCancelar
    {
        [XmlElement(ElementName = "unitizador")]
        public List<string> Unitizador { get; set; }
    }
}
