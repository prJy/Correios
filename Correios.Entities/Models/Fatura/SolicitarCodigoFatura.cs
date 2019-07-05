using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Correios.Entities.Models.Fatura
{
    [XmlRoot(ElementName = "solicitarCodigoFatura")]
    public class SolicitarCodigoFatura
    {
        [XmlElement(ElementName = "idioma")]
        public string Idioma { get; set; }
        [XmlElement(ElementName = "cartaoPostagem")]
        public string CartaoPostagem { get; set; }
        [XmlElement(ElementName = "ciaAerea")]
        public string CiaAerea { get; set; }
        [XmlElement(ElementName = "numeroVoo")]
        public string NumeroVoo { get; set; }
        [XmlElement(ElementName = "dataPartida")]
        public string DataPartida { get; set; }
        [XmlElement(ElementName = "horaPartida")]
        public string HoraPartida { get; set; }
        [XmlElement(ElementName = "aeroportoPartida")]
        public string AeroportoPartida { get; set; }
        [XmlElement(ElementName = "aeroportoTransbordo")]
        public string AeroportoTransbordo { get; set; }
        [XmlElement(ElementName = "aeroportoEntrega")]
        public string AeroportoEntrega { get; set; }
        [XmlElement(ElementName = "expedicoes")]
        public FaturaExpedicoes Expedicoes { get; set; }
    }
}
