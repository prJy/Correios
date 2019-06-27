using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Correios.Entities.ExtendedModels;

namespace Correios.Entities.Models
{
    [XmlRoot(ElementName = "remessa")]
    public class RemessaEtiquetaInternacional
    {
        [XmlElement(ElementName = "idioma")]
        [Required(ErrorMessage = "{0} is required")]        
        [StringRange(AllowableValues = new[] { "PT", "EN" }, ErrorMessage = "{0} must be either 'PT' or 'EN'.")]
        [MaxLength(2, ErrorMessage = "Maximum characters are {1}}")]
        public string Idioma { get; set; }
        [XmlElement(ElementName = "encomendas")]        
        public EncomendasEtiquetaInternacional Encomendas { get; set; }
    }
}
