using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Correios.Entities.Models.Unitizador
{
    [XmlRoot(ElementName = "cancelaRotuloUnitizador")]
    public class CancelaRotuloUnitizador
    {
        [XmlElement(ElementName = "idioma")]
        public string Idioma { get; set; }
        [XmlElement(ElementName = "cartaoDePostagem")]
        public string CartaoDePostagem { get; set; }
        [XmlElement(ElementName = "unitizadores")]
        public UnitizadoresCancelar Unitizadores { get; set; }
    }
}
