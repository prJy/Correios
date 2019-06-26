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

            _service = new WebService.edei();
            _service.Credentials = new System.Net.NetworkCredential("testeint", "123456");
            
            /* Caso fosse via referencia deveriamos usar:
              _service = new WebService.edeiClient();
              _service.ClientCredentials.UserName.UserName = "testeint";
               _service.ClientCredentials.UserName.Password = "123456";
              OperationContextScope scope = new OperationContextScope(_service.InnerChannel);
              var httpRequestProperty = new HttpRequestMessageProperty();
              httpRequestProperty.Headers[System.Net.HttpRequestHeader.Authorization] = "Basic " +
                           Convert.ToBase64String(Encoding.ASCII.GetBytes(_service.ClientCredentials.UserName.UserName + ":" +
                           _service.ClientCredentials.UserName.Password));
              OperationContext.Current.OutgoingMessageProperties[HttpRequestMessageProperty.Name] = httpRequestProperty;
              */

            return _service;
        }

    }
}
