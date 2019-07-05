using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Correios.Entities.Extensions;
using Correios.Services.WebService;

namespace Correios.Services.Etiqueta
{
    public class EtiquetaService
    {      
        public RetornoEtiquetaInternacional SolicitarCodigoEtiquetaInternacional(string remessa) {            
            RetornoEtiquetaInternacional resultado = ClientWS.Instance().solicitarCodigoEtiquetaInternacional(remessa);            
            return resultado;
        }
    }
}
