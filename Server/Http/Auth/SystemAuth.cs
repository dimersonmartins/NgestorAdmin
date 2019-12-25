using Newtonsoft.Json.Linq;
using Server.App;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Server.Http.Auth
{
    public class SystemAuth
    {
        public SystemAuth(string url_server, string login, string password)
        {
            _url_server = url_server;
            _login      = login;
            _password   = password;
        }
        private string _url_server;
        private string _login;
        private string _password;
        public async Task<string> execute()
        {
            HttpClient client = new HttpClient();
            client.Timeout = TimeSpan.FromHours(2);  //TEMPO LIMTE DE RESPOSTA DA REQUISÃO

            client.DefaultRequestHeaders.Clear();

            Dictionary<string, string> form_data = new Dictionary<string, string>
            {
                {"email", _login },
                {"password", _password }
            };

            HttpContent content = new FormUrlEncodedContent(form_data);

            HttpResponseMessage response = await client.PostAsync($"{_url_server}/{Config.VERSAO_API}/auth", content);
            var contents = await response.Content.ReadAsStringAsync();
            HttpContentHeaders headers = content.Headers;

            if (response.IsSuccessStatusCode)
            {
                try
                {
                    if (tokenAcsses(contents))
                    {
                        Config.SERVER_URL = _url_server;
                        JObject jtoken = JObject.Parse(contents);
                        Config.TOKEN = jtoken["token"].ToString();
                    }
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

        private bool tokenAcsses(string response_json)
        {
            try
            {
                JObject jtoken = JObject.Parse(response_json);
                if (jtoken.HasValues)
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}
