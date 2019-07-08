using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Correios.Entities.Models.Restricao
{
    [XmlRoot(ElementName = "codigos")]
    public class CodigosRestricao
    {
        [XmlElement(ElementName = "codigo")]
        public List<string> Codigo { get; set; }
    }
}
