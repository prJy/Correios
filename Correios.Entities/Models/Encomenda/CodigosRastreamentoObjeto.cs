using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Correios.Entities.Models.Encomenda
{
    [XmlRoot(ElementName = "codigosRastreamentoObjeto")]
    public class CodigosRastreamentoObjeto
    {
        [XmlElement(ElementName = "codigoRastreamentoObjeto")]
        public List<string> CodigoRastreamentoObjeto { get; set; }
    }
}
