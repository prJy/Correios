# Correios
Rest API Integration with Edei WebService

Example api/etiqueta/internacional
```json
{
  "idioma": "PT",
  "encomendas": {
    "encomenda": {
      "cartaoDePostagem": "0073423777",
      "codigoControleCliente": "100052202",
      "nomeRemetente": "BODYBUILDING.COM",
      "enderecoRemetente": "S. SILVERSTONE WAY",
      "numeroEnderecoRemetente": "2016",
      "codigoPostalRemetente": "83642",
      "cidadeRemetente": "MERIDIAN",
      "estadoRemetente": "ID",
      "paisRemetente": "US",
      "emailRemetente": "sales@bodybuilding.com",
      "siteRemetente": "www.bodybuilding.com",
      "nomeDestinatario": "Jean Albuquerque da Silva Castro",
      "tipoDocumentoDestinatario": "1",
      "numeroDocumentoDestinatario": "16549651468",
      "enderecoDestinatario": "QMSW 5 LOTE 2 BLOCO B",
      "numeroEnderecoDestinatario": "Apto 402",
      "complementoEnderecoDestinatario": "SUDOESTE",
      "codigoPostalDestinatario": "70680506",
      "cidadeDestinatario": "BRASÍLIA",
      "ufDestinatario": "DF",
      "paisDestinatario": "BR",
      "emailDestinatario": "JEANCS2@CORREIOS.COM.BR",
      "pesoObjeto": "150",
      "comprimentoObjeto": "16",
      "larguraObjeto": "11",
      "alturaObjeto": "2",
      "modalidadeDistribuicaoObjeto": "33375",
      "modalidadePagamentoImpostosObjeto": "1",
      "codigoMoeda": "USD",
      "valorFreteObjeto": "50.00",
      "valorSeguroObjeto": "0.00",
      "modoDevolucaoObjeto": "1",
      "seguroDevolucaoObjeto": "N",
      "itensEncomenda": {
        "itemEncomenda": [
          {
            "codigoSHItem": "100190",
            "codigoSKUItem": "TYH820040",
            "descricaoItem": "BPI SPORTS BLOX - 110 SERVINGS - BLUEBERRY",
            "quantidadeItem": "1",
            "valorUnitario": "100.00"
          }
        ]
      }
    }
  }
}
```
Example api/

```json
{
  "idioma": "PT",
  "cartaoDePostagem": "0073423777",
  "numeroExpedicao": "0043",
  "paisOrigemOperador": "US",
  "operadorLogisticoOrigem": "SKYP",
  "paisOperadorDestino": "BR",
  "operadorLogisticoDestino": "SAOD",
  "codigoCategoriaCorreio": "A",
  "codigoSubClasseServico": "NX",
  "unitizadores": {
    "unitizador": {
      "sequencial": "001",
      "tipoUnitizador": "01",
      "itens": {
        "CodigoObjeto": [
          "NX000023704BR"
        ]
      }
    }
  }
}
```
