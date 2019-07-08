using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Correios.Entities.Models.Restricao
{
    [XmlRoot(ElementName = "consultaRestricao")]
    public class ConsultaRestricao
    {
        [XmlElement(ElementName = "idioma")]
        public string Idioma { get; set; }
        [XmlElement(ElementName = "codigos")]
        public CodigosRestricao Codigos { get; set; }
    }
}
