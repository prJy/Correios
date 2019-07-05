using Correios.Entities.Models.Unitizador;
using Correios.Services.WebService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Correios.Entities.Extensions;
using Correios.Services.Unitizador;

namespace Correios.WebApi.Controllers
{
    public class UnitizadorController : ApiController
    {
        [Route("api/etiqueta/rotulo/unitizador")]
        [HttpPost]
        public RetornoRotuloUnitizador Post([FromBody]UnitizadorRemessa remessa)
        {
            var service = new UnitizadorService();
            var resultado = service.SolicitarRotuloUnitizador(remessa.ToXml());
            return resultado;
        }
    }
}
