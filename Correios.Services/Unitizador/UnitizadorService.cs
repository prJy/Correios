using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Correios.Entities.Extensions;
using Correios.Services.WebService;


namespace Correios.Services.Unitizador
{
    public class UnitizadorService
    {
        public RetornoRotuloUnitizador SolicitarRotuloUnitizador(string remessa) {
            RetornoRotuloUnitizador retorno = ClientWS.Instance().solicitarRotuloUnitizador(remessa);
            return retorno;
        }

        public RetornoConsultaUnitizador ConsultaUnitizador(string remessa) {
            RetornoConsultaUnitizador retorno = ClientWS.Instance().consultarUnitizador(remessa);
            return retorno;
        }

        public RetornoCancelarRotuloUnitizador CancelarRotuloUnitizador(string remessa) {
            RetornoCancelarRotuloUnitizador retorno = ClientWS.Instance().cancelarRotuloUnitizador(remessa);
            return retorno;
        }

    }
}
