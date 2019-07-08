using System.Web.Http;
using Correios.Services.Cliente;
using Correios.Services.WebService;
using Correios.Entities.Models.Cliente;
using Correios.Entities.Extensions;

namespace Correios.WebApi.Controllers
{
    public class SaldoClienteController : ApiController
    {
        [Route("api/etiqueta/cliente/saldo")]
        [HttpPost]
        public RetornoSaldo SolicitarSaldoCliente([FromBody]SaldoCliente remessa)
        {
            var service = new SaldoClienteService();
            var resultado = service.SolicitarSaldoCliente(remessa.ToXml());
            return resultado;
        }
    }
}
