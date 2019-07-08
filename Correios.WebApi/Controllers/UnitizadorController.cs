using Correios.Entities.Models.Unitizador;
using Correios.Services.WebService;
using System.Web.Http;
using Correios.Entities.Extensions;
using Correios.Services.Unitizador;

namespace Correios.WebApi.Controllers
{
    public class UnitizadorController : ApiController
    {
        [Route("api/etiqueta/unitizador/rotulo")]
        [HttpPost]
        public RetornoRotuloUnitizador SolicitarRotuloUnitizador([FromBody]UnitizadorRemessa remessa)
        {
            var service = new UnitizadorService();
            var resultado = service.SolicitarRotuloUnitizador(remessa.ToXml());
            return resultado;
        }

        [Route("api/etiqueta/unitizador")]
        [HttpGet]
        public RetornoConsultaUnitizador ConsultarUnitizador([FromUri]UnitizadorConsulta remessa)
        {
            var service = new UnitizadorService();
            var resultado = service.ConsultaUnitizador(remessa.ToXml());
            return resultado;
        }

        [Route("api/etiqueta/unitizador/rotulo/cancelar")]
        [HttpPost]
        public RetornoCancelarRotuloUnitizador CancelarRotuloUnitizador([FromBody]CancelaRotuloUnitizador remessa)
        {
            var service = new UnitizadorService();
            var resultado = service.CancelarRotuloUnitizador(remessa.ToXml());
            return resultado;
        }
    }
}
