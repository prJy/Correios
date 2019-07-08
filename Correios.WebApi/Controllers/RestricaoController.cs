using Correios.Services.Restricao;
using Correios.Entities.Models.Restricao;
using Correios.Services.WebService;
using Correios.Entities.Extensions;
using System.Web.Http;

namespace Correios.WebApi.Controllers
{
    public class RestricaoController : ApiController
    {
        [Route("api/itens/proibidos")]
        [HttpGet]
        public RetornoRestricaoProibicao ConsultarRestricaoProibicaoItem([FromUri]ConsultaRestricao remessa)
        {
            var service = new ItemService();
            var resultado = service.ConsultarRestricaoProibicaoItem(remessa.ToXml());
            return resultado;
        }
    }
}
