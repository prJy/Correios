using Correios.Entities.Models.Fatura;
using Correios.Services.Fatura;
using Correios.Services.WebService;
using System.Web.Http;
using Correios.Entities.Extensions;

namespace Correios.WebApi.Controllers
{
    public class FaturaController : ApiController
    {
        [Route("api/etiqueta/fatura")]
        [HttpPost]
        public RetornoCodigoFatura SolicitarFaturaEntrega([FromBody]SolicitarCodigoFatura remessa)
        {
            var service = new FaturaService();
            var resultado = service.SolicitarFaturaEntrega(remessa.ToXml());
            return resultado;
        }

        [Route("api/etiqueta/fatura/entrega")]
        [HttpGet]
        public RetornoConsultaFaturaEntregaTO ConsultarFaturaEntrega([FromUri]ConsultaFaturaEntrega remessa)
        {
            var service = new FaturaService();
            var resultado = service.ConsultaFaturaEntrega(remessa.ToXml());
            return resultado;
        }
    }
}
