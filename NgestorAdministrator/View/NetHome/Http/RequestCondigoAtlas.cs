using NgestorAdministrator.View.NetHome.App;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace NgestorAdministrator.View.NetHome.Http
{
    class RequestCondigoAtlas
    {
        public async Task<string> getCodigoAtlas(string nomeLocal,string descricao,string idOperadora,string idTipoLocal)
        {
            Dictionary<string, string> form_data = new Dictionary<string, string>
                {
                    { "acao", "search" },
                    { "action", "manterLocalizacaoLocalGenericoByOperacaoDiv" },
                    { "campoRetorno","" },
                    { "campoRetornoText","nomeLocalizacao" },
                    { "campoRetornoValor","idLocalizacao" },
                    { "codigoLocal","" },
                    { "codigoSAP","" },
                    { "descricao", descricao },
                    { "idOperadora", idOperadora },
                    { "idTipoLocalOrigem","" },
                    { "isIntermediario","" },
                    { "nomeLocal", nomeLocal },
                    { "tipoFiltro","" },
                    { "tipoLocal.idTipoLocal",idTipoLocal },
                };

            HttpClient client = new HttpClient(new HttpClientHandler { UseCookies = false, AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate, AllowAutoRedirect = false });
            client.Timeout = TimeSpan.FromHours(2);

            string[] Accept = new string[] { "image/gif", "image/jpeg", "image/pjpeg", "application/x-ms-application", "application/xaml+xml", "application/x-ms-xbap", "*/*" };
            string[] AcceptEncoding = new string[] { "gzip", "deflate" };

            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Add("Accept", Accept);
            client.DefaultRequestHeaders.Add("Accept-Language", "pt-BR");
            client.DefaultRequestHeaders.Add("Accept-Encoding", AcceptEncoding);
            client.DefaultRequestHeaders.Add("Referer", "https://www.atlas.netservicos.com.br/nethome/equipamento/manterLocalizacaoLocalGenericoByOperacaoDiv.do");
            client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.2; WOW64; Trident/7.0; .NET4.0C; .NET4.0E; .NET CLR 2.0.50727; .NET CLR 3.0.30729; .NET CLR 3.5.30729)");
            client.DefaultRequestHeaders.Add("Host", "www.atlas.netservicos.com.br");
            client.DefaultRequestHeaders.Add("Cookie", "asc-key-remote="
                + Config.ASC_KEY_REMOTE + ";"
                + Config._JSESSIONID + ";"
                + Config.AUTHCOOKIE + ";"
                + Config.CITRIX_TOKEN_JSESSIONID + ";"
                + Config.CITRIX_TOKEN1 + ";"
                + Config.CITRIX_TOKEN2 + ";"
                + Config.CITRIX_TOKEN3 + ";"
                + Config.NSC_TMAA + ";"
                + Config.NSC_TMAS);

            HttpContent content = new FormUrlEncodedContent(form_data);
            HttpResponseMessage response = await client.PostAsync("https://www.atlas.netservicos.com.br/nethome/equipamento/manterLocalizacaoLocalGenericoByOperacaoDiv.do", content);
            var contents = await response.Content.ReadAsStringAsync();
            HttpContentHeaders headers = content.Headers;

            if (response.IsSuccessStatusCode)
            {
                return contents;
            }

            return null;
        }
    }
}
