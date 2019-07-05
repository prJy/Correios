using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Correios.Entities.Extensions;
using Correios.Services.WebService;

namespace Correios.Services.Fatura
{
    public class FaturaService
    {
        public RetornoCodigoFatura SolicitarFaturaEntrega(string xml) {
            RetornoCodigoFatura retorno = ClientWS.Instance().solicitarCodigoFatura(xml);
            return retorno;
        }
    }
}
