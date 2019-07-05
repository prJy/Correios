using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Correios.Entities.Extensions;
using Correios.Services.WebService;


namespace Correios.Services.Encomenda
{
    public class EncomendaService
    {
        public RetornoConsultaEncomenda ConsultarEncomenda(string remessa)
        {
            RetornoConsultaEncomenda resultado = ClientWS.Instance().consultarEncomenda(remessa);
            return resultado;
        }
    }
}
