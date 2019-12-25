using Newtonsoft.Json.Linq;
using Server.App;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Server.Http.ACL
{
    public class Controller
    {
        private string prefix = "/acl";
        private JObject JSON = null;
        public Dictionary<string, string> tipoPermission()
        {
            Dictionary<string, string> tipoPermission = new Dictionary<string, string>();
            if (JSON == null)
            {
                return null;
            }
            foreach (var item in JSON["tipo_permissons"])
            {
                tipoPermission.Add(item["name"].ToString(), item["id"].ToString());
            }
            return tipoPermission;
        }
        public async Task<string> listar(int current_page)
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
            HttpResponseMessage response = await client.GetAsync($"{Config.SERVER_URL}/{Config.VERSAO_API}{prefix}/listar_permissions?page="+ current_page.ToString());
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
        public async Task<string> listarTipoPermission()
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
            HttpResponseMessage response = await client.GetAsync($"{Config.SERVER_URL}/{Config.VERSAO_API}{prefix}/listar_tipo_permissons");
            var contents = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                try
                {
                    JSON = JObject.Parse(contents);
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
        public async Task<string> cadastrar(Dictionary<string, string> body)
        {
            HttpClient client = new HttpClient();
            client.Timeout = TimeSpan.FromHours(2);  //TEMPO LIMTE DE RESPOSTA DA REQUISÃO
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Config.TOKEN);
            HttpContent content = new FormUrlEncodedContent(body);
            HttpResponseMessage response = await client.PostAsync($"{Config.SERVER_URL}/{Config.VERSAO_API}{prefix}/novo_acl", content);
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
