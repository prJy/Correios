using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Correios.Entities.Extensions;
using Correios.Entities.Models;
using Correios.Services;
using Correios.Services.WebService;

namespace Correios.WebApi.Controllers
{
    public class EtiquetaInternacionalController : ApiController
    {       
        [HttpGet]
        public string xml() {
            return "";
        }

        [HttpPost]
        public RetornoEtiquetaInternacional Post([FromBody]RemessaEtiquetaInternacional remessa)
        {        
            var service = new EtiquetaInternacionalService();
            var resultado = service.SolicitarCodigoEtiquetaInternacional(remessa.ToXml());
            return resultado;
        }
    }

    
}
