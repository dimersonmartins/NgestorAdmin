using Server.App;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Server.Http.Operadoras
{
    public class Controller
    {
        private string prefix = "/operadoras";
        public async Task<string> listar()
        {
            HttpClient client = new HttpClient(new HttpClientHandler { UseCookies = false, AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate });
            client.Timeout = TimeSpan.FromHours(2);  //TEMPO LIMTE DE RESPOSTA DA REQUISÃO
            string[] AcceptEncoding = new string[] { "gzip", "deflate" };
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Config.TOKEN);
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Add("Accept", "text/plain");
            client.DefaultRequestHeaders.Add("Accept", "*/*");
            client.DefaultRequestHeaders.Add("Accept-Encoding", AcceptEncoding);
            HttpResponseMessage response = await client.GetAsync($"{Config.SERVER_URL}/{Config.VERSAO_API}{prefix}/listar_operadoras");
            var contents = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                try
                {
                    return contents;
                }
                catch (Exception)
                {
                    return null;
                }
            }
            else
            {
                return null;
            }

        }
        public async Task<string> pesquisa(string name)
        {
            HttpClient client = new HttpClient();
            client.Timeout = TimeSpan.FromHours(2);  //TEMPO LIMTE DE RESPOSTA DA REQUISÃO
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Config.TOKEN);
            Dictionary<string, string> body = new Dictionary<string, string>
            {
                { "name",name }
            };

            HttpContent content = new FormUrlEncodedContent(body);
            HttpResponseMessage response = await client.PostAsync($"{Config.SERVER_URL}/{Config.VERSAO_API}{prefix}/pesquisa", content);
            var contents = await response.Content.ReadAsStringAsync();

            HttpContentHeaders headers = content.Headers;

            if (response.IsSuccessStatusCode)
            {
                try
                {
                    return contents;
                }
                catch (Exception)
                {
                    return null;
                }
            }
            else
            {
                return null;
            }

        }

        public async Task<string> cadastrarOperadora(Dictionary<string, string> body)
        {
            HttpClient client = new HttpClient();
            client.Timeout = TimeSpan.FromHours(2);  //TEMPO LIMTE DE RESPOSTA DA REQUISÃO
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Config.TOKEN);
            HttpContent content = new FormUrlEncodedContent(body);
            HttpResponseMessage response = await client.PostAsync($"{Config.SERVER_URL}/{Config.VERSAO_API}{prefix}/nova_operadora", content);
            var contents = await response.Content.ReadAsStringAsync();

            HttpContentHeaders headers = content.Headers;

            if (response.IsSuccessStatusCode)
            {
                try
                {
                    return contents;
                }
                catch (Exception)
                {
                    return null;
                }
            }
            else
            {
                return null;
            }

        }
    }
}
