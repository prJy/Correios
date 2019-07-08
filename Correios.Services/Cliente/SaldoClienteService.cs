using Correios.Services.WebService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correios.Services.Cliente
{
    public class SaldoClienteService
    {
        public RetornoSaldo SolicitarSaldoCliente(string remessa)
        {
            RetornoSaldo resultado = ClientWS.Instance().solicitarSaldoCliente(remessa);
            return resultado;
        }
    }
}
