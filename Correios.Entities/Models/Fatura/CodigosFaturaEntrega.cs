using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Correios.Entities.Models.Fatura
{
    [XmlRoot(ElementName = "codigosFaturaEntrega")]
    public class CodigosFaturaEntrega
    {
        [XmlElement(ElementName = "codigoFatura")]
        public List<string> CodigoFatura { get; set; }
    }
}
