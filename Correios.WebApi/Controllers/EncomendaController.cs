using Correios.Entities.Models.Encomenda;
using Correios.Services.Encomenda;
using Correios.Services.WebService;
using Correios.WebApi.Filters;
using Correios.Entities.Extensions;
using System.Web.Http;

namespace Correios.WebApi.Controllers
{
    public class EncomendaController : ApiController
    {
        [ValidateModel]
        [Route("api/encomenda/")]
        [HttpGet]
        public RetornoConsultaEncomenda ConsultarEncomenda([FromUri]ConsultaEncomenda remessa)
        {
            var service = new EncomendaService();
            var resultado = service.ConsultarEncomenda(remessa.ToXml());
            return resultado;
        }
    }
}
