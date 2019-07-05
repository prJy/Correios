using System.Web.Http;
using Correios.Entities.Extensions;
using Correios.Entities.Models.Etiqueta;
using Correios.Services.Etiqueta;
using Correios.Services.WebService;
using Correios.WebApi.Filters;

namespace Correios.WebApi.Controllers
{
    public class EtiquetaInternacionalController : ApiController
    {                    
        [ValidateModel]
        [Route("api/etiqueta/internacional")]
        [HttpPost]        
        public RetornoEtiquetaInternacional Post([FromBody]EtiquetaRemessa remessa)
        {        
            var service = new EtiquetaService();
            var resultado = service.SolicitarCodigoEtiquetaInternacional(remessa.ToXml());
            return resultado;
        }
    }

    
}
