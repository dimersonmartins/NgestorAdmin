using Server.App;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Server.Http.NetHome
{
    public class Controller
    {
        private string prefix = "/host";
        public async Task<bool> cadastrar(Dictionary<string, string> body)
        {
            HttpClient client = new HttpClient();
            client.Timeout = TimeSpan.FromHours(2);  //TEMPO LIMTE DE RESPOSTA DA REQUISÃO
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Config.TOKEN);
            HttpContent content = new FormUrlEncodedContent(body);
            HttpResponseMessage response = await client.PostAsync($"{Config.SERVER_URL}/{Config.VERSAO_API}{prefix}/config_net_home", content);
            var contents = await response.Content.ReadAsStringAsync();

            HttpContentHeaders headers = content.Headers;

            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }
    }
}
