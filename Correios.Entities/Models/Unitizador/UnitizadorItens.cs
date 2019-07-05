using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Correios.Entities.Models.Unitizador
{
    public class UnitizadorItens
    {
        [XmlElement(ElementName = "codigoObjeto")]
        public List<string> CodigoObjeto { get; set; }
    }
}
