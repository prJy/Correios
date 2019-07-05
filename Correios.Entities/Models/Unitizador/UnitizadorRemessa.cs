using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Correios.Entities.Models.Unitizador
{
    [XmlRoot(ElementName = "remessa")]
    public class UnitizadorRemessa
    {
        [XmlElement(ElementName = "idioma")]
        public string Idioma { get; set; }
        [XmlElement(ElementName = "cartaoDePostagem")]
        public string CartaoDePostagem { get; set; }
        [XmlElement(ElementName = "numeroExpedicao")]
        public string NumeroExpedicao { get; set; }
        [XmlElement(ElementName = "paisOrigemOperador")]
        public string PaisOrigemOperador { get; set; }
        [XmlElement(ElementName = "operadorLogisticoOrigem")]
        public string OperadorLogisticoOrigem { get; set; }
        [XmlElement(ElementName = "paisOperadorDestino")]
        public string PaisOperadorDestino { get; set; }
        [XmlElement(ElementName = "operadorLogisticoDestino")]
        public string OperadorLogisticoDestino { get; set; }
        [XmlElement(ElementName = "codigoCategoriaCorreio")]
        public string CodigoCategoriaCorreio { get; set; }
        [XmlElement(ElementName = "codigoSubClasseServico")]
        public string CodigoSubClasseServico { get; set; }
        [XmlElement(ElementName = "unitizadores")]
        public Unitizadores Unitizadores { get; set; }
    }
}
