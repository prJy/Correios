using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Correios.Entities.Models.Unitizador
{
    [XmlRoot(ElementName = "consultaUnitizador")]
    public class UnitizadorConsulta
    {
        [XmlElement(ElementName = "idioma")]
        public string Idioma { get; set; }
        [XmlElement(ElementName = "cartaoDePostagem")]
        public string CartaoDePostagem { get; set; }
        [XmlElement(ElementName = "unitizadores")]
        public UnitizadoresConsulta Unitizadores { get; set; }
    }
}
