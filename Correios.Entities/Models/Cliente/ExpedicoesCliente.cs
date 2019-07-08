using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Correios.Entities.Models.Cliente
{
    [XmlRoot(ElementName = "expedicoes")]
    public class ExpedicoesCliente
    {
        [XmlElement(ElementName = "numeroExpedicao")]
        public string NumeroExpedicao { get; set; }
    }
}
