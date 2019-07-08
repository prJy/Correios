using Correios.Services.WebService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correios.Services.Restricao
{
    public class ItemService
    {
        public RetornoRestricaoProibicao ConsultarRestricaoProibicaoItem(string xml)
        {
            RetornoRestricaoProibicao retorno = ClientWS.Instance().consultarRestricaoProibicaoItem(xml);
            return retorno;
        }        
    }
}
