using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Correios.Entities.Models.Unitizador
{
    [XmlRoot(ElementName = "unitizador")]
    public class Unitizador
    {
        [XmlElement(ElementName = "sequencial")]
        public string Sequencial { get; set; }
        [XmlElement(ElementName = "tipoUnitizador")]
        public string TipoUnitizador { get; set; }
        [XmlElement(ElementName = "itens")]
        public UnitizadorItens Itens { get; set; }
    }
}
