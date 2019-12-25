using NgestorAdministrator.View.NetHome.App;
using NgestorAdministrator.View.NetHome.ASCWebBrowser.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NgestorAdministrator.View.NetHome.Auth
{
    public class AuthNetHome
    {
        public async Task<bool> execute(string operadora, string login, string password)
        {
            try
            {
                AuthAscWebBrowser MainASCBrowser = new AuthAscWebBrowser();
                await MainASCBrowser.execute();

                Citrix.Auth.Citrix citrix = new Citrix.Auth.Citrix();
                await citrix.execute();

                await loginNetHome(operadora,  login,  password);
                return await indexNetHome();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }


        public string GenereteGoogleKey1(int length)
        {
            Random random = new Random();
            const string chars = "AAAAAAWRntOMSEcZPXkEH8DhgHBFfLV_XU0Nv3icW1ZaUhr1Dr9g9RpJ-G8mKW-XFHWyQPDIfLi-IOELQd2BXbU7qNeutpqv_cFpY8RAqhtgZODfLh3ahErRfh2vTQWiSsqY1vM";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public string GenereteGoogleKey2(int length)
        {
            Random random = new Random();
            const string chars = "abcdefghijlmnopqrstuvxzky0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
      
        public async Task<string[]> loginNetHome(string operadora, string login, string password)
        {
            Dictionary<string, string> form_data = new Dictionary<string, string>
                {
                    { "j_username", login },
                    { "j_password", password },
                    { "j_identity_base", operadora },
                    { "j_system","5" },
                    { "j_application","NATLAS" },
                    { "as_sfid", Config.FAKE_CITRIX_TOKEN1 },
                    { "as_fid", Config.FAKE_CITRIX_TOKEN2 }
                };
            CookieContainer cookies = new CookieContainer();
            HttpClient client = new HttpClient(new HttpClientHandler { UseCookies = false, AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate, AllowAutoRedirect = false });
            client.Timeout = TimeSpan.FromHours(2);

            string[] Accept = new string[] { "image/gif", "image/jpeg", "image/pjpeg", "application/x-ms-application", "application/xaml+xml", "application/x-ms-xbap", "*/*" };
            string[] AcceptEncoding = new string[] { "gzip", "deflate" };

            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Add("Accept", Accept);
            client.DefaultRequestHeaders.Add("Accept-Language", "pt-BR");
            client.DefaultRequestHeaders.Add("Accept-Encoding", AcceptEncoding);
            client.DefaultRequestHeaders.Add("Referer", "https://updateasc.netservicos.com.br/home/portal.do");
            client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.2; WOW64; Trident/7.0; .NET4.0C; .NET4.0E; .NET CLR 2.0.50727; .NET CLR 3.0.30729; .NET CLR 3.5.30729)");
            client.DefaultRequestHeaders.Add("Host", "www.atlas.netservicos.com.br");
            client.DefaultRequestHeaders.Add("Cookie", "asc-key-remote=" + Config.ASC_KEY_REMOTE + ";" + Config._JSESSIONID + ";" + "citrix_ns_id_.atlas.netservicos.com.br_%2F_wlf=" + GenereteGoogleKey1(93) + ";" + "citrix_ns_id=" + GenereteGoogleKey2(31) + ";" + Config.NSC_TMAA + ";" + Config.NSC_TMAS);

            HttpContent content = new FormUrlEncodedContent(form_data);
            HttpResponseMessage response = await client.PostAsync("https://www.atlas.netservicos.com.br/nethome/j_security_check", content);
            var contents = await response.Content.ReadAsStringAsync();
            HttpContentHeaders headers = content.Headers;

            if (response.StatusCode.ToString() == "Redirect")
            {
                string _WL_AUTHCOOKIE_JSESSIONID = Between(response.Headers.ToString(), "_WL_AUTHCOOKIE_JSESSIONID=", ";");
                Config.AUTHCOOKIE = $"_WL_AUTHCOOKIE_JSESSIONID={_WL_AUTHCOOKIE_JSESSIONID}";

                string JSESSIONID = Between(response.Headers.ToString(), "JSESSIONID=", ";");
                Config._JSESSIONID = $"JSESSIONID={JSESSIONID}";

                string jsessionid = Between(response.Headers.ToString(), "jsessionid=", ";");
                Config.CITRIX_TOKEN_JSESSIONID = $"jsessionid={jsessionid}";

                string citrix_ns_id = Between(response.Headers.ToString(), "citrix_ns_id=", ";");
                Config.CITRIX_TOKEN1 = $"citrix_ns_id={citrix_ns_id}";

                string citrix_ns_id_atlas_netservicos_wlf = Between(response.Headers.ToString(), "citrix_ns_id_.atlas.netservicos.com.br_%2F_wlf=", ";");
                Config.CITRIX_TOKEN3 = $"citrix_ns_id_.atlas.netservicos.com.br_%2F_wlf={citrix_ns_id_atlas_netservicos_wlf}";

                string citrix_ns_id_atlas_netservicos_wat = Between(response.Headers.ToString(), "citrix_ns_id_.atlas.netservicos.com.br_%2F_wat=", ";");
                Config.CITRIX_TOKEN3 = $"citrix_ns_id_.atlas.netservicos.com.br_%2F_wat={citrix_ns_id_atlas_netservicos_wat}";
            }
            return null;
        }
        public async Task<bool> indexNetHome()
        {
            HttpClient client = new HttpClient(new HttpClientHandler { UseCookies = false, AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate });
            client.Timeout = TimeSpan.FromHours(2);

            string[] Accept = new string[] { "image/gif", "image/jpeg", "image/pjpeg", "application/x-ms-application", "application/xaml+xml", "application/x-ms-xbap", "*/*" };
            string[] AcceptEncoding = new string[] { "gzip", "deflate" };

            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Add("Accept", Accept);
            client.DefaultRequestHeaders.Add("Accept-Language", "pt-BR");
            client.DefaultRequestHeaders.Add("Accept-Encoding", AcceptEncoding);
            client.DefaultRequestHeaders.Add("Referer", "https://www.atlas.netservicos.com.br/nethome/");
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

            HttpResponseMessage response = await client.GetAsync("https://www.atlas.netservicos.com.br/nethome/index.do");
            var contents = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }

        private string Between(string strSource, string strStart, string strEnd)
        {
            int Start, End;
            if (strSource.Contains(strStart) && strSource.Contains(strEnd))
            {
                Start = strSource.IndexOf(strStart, 0) + strStart.Length;
                End = strSource.IndexOf(strEnd, Start);
                return strSource.Substring(Start, End - Start);
            }
            return null;
        }

    }
}
