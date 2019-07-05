using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Correios.Services
{
    public static class ClientWS
    {
        private static WebService.edei _service;
        public static WebService.edei Instance()
        {
            if (_service != null) return _service;

            _service = new WebService.edei
            {
                Credentials = new System.Net.NetworkCredential("testeint", "123456")
            };

            return _service;
        }

    }
}
