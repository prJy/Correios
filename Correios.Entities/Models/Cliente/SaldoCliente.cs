using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Correios.Entities.Models.Cliente
{
    [XmlRoot(ElementName = "consultaSaldo")]
    public class SaldoCliente
    {
        [XmlElement(ElementName = "idioma")]
        public string Idioma { get; set; }
        [XmlElement(ElementName = "cartaoPostagem")]
        public string CartaoPostagem { get; set; }
        [XmlElement(ElementName = "expedicoes")]
        public ExpedicoesCliente Expedicoes { get; set; }
    }
}
