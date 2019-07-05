using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Correios.Entities.Models.Fatura
{
    [XmlRoot(ElementName = "expedicoes")]
    public class FaturaExpedicoes
    {
        [XmlElement(ElementName = "numeroExpedicao")]
        public List<string> NumeroExpedicao { get; set; }
    }
}
