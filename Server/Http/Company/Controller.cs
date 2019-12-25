using Server.App;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Server.Http.Company
{
    public class Controller
    {
        private string prefixCompany = "/company";
        private string prefixHost = "/host";
        public async Task<string> manter()
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
            HttpResponseMessage response = await client.GetAsync($"{Config.SERVER_URL}/{Config.VERSAO_API}{prefixHost}/manter");
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
        public async Task<string> listarCompanys()
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
            HttpResponseMessage response = await client.GetAsync($"{Config.SERVER_URL}/{Config.VERSAO_API}{prefixCompany}/listar_companys");
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
        public async Task<string> listarHosts()
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
            HttpResponseMessage response = await client.GetAsync($"{Config.SERVER_URL}/{Config.VERSAO_API}{prefixHost}/listar_hosts");
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
        public async Task<string> cadastrarCompany(Dictionary<string, string> body)
        {
            HttpClient client = new HttpClient();
            client.Timeout = TimeSpan.FromHours(2);  //TEMPO LIMTE DE RESPOSTA DA REQUISÃO
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Config.TOKEN);
            HttpContent content = new FormUrlEncodedContent(body);
            HttpResponseMessage response = await client.PostAsync($"{Config.SERVER_URL}/{Config.VERSAO_API}{prefixCompany}/nova_empresa", content);
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
        public async Task<bool> cadastrarHost(Dictionary<string, string> body)
        {
            HttpClient client = new HttpClient();
            client.Timeout = TimeSpan.FromHours(2);  //TEMPO LIMTE DE RESPOSTA DA REQUISÃO
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Config.TOKEN);
            HttpContent content = new FormUrlEncodedContent(body);
            HttpResponseMessage response = await client.PostAsync($"{Config.SERVER_URL}/{Config.VERSAO_API}{prefixHost}/novo_host", content);
            var contents = await response.Content.ReadAsStringAsync();

            HttpContentHeaders headers = content.Headers;

            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }
        public async Task<string> pesquisaHost(string name)
        {
            HttpClient client = new HttpClient();
            client.Timeout = TimeSpan.FromHours(2);  //TEMPO LIMTE DE RESPOSTA DA REQUISÃO
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Config.TOKEN);
            Dictionary<string, string> body = new Dictionary<string, string>();
            body.Add("host_name", name);

            HttpContent content = new FormUrlEncodedContent(body);
            HttpResponseMessage response = await client.PostAsync($"{Config.SERVER_URL}/{Config.VERSAO_API}{prefixHost}/pesquisa_host", content);
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
        public async Task<string> pesquisaCompany(string name)
        {
            HttpClient client = new HttpClient();
            client.Timeout = TimeSpan.FromHours(2);  //TEMPO LIMTE DE RESPOSTA DA REQUISÃO
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Config.TOKEN);
            Dictionary<string, string> body = new Dictionary<string, string>();
            body.Add("nome_fantasia", name);

            HttpContent content = new FormUrlEncodedContent(body);
            HttpResponseMessage response = await client.PostAsync($"{Config.SERVER_URL}/{Config.VERSAO_API}{prefixCompany}/pesquisa_company", content);
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
