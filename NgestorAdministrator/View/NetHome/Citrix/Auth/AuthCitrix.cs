using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using NgestorAdministrator.View.NetHome.App;

namespace NgestorAdministrator.View.NetHome.Citrix.Auth
{
    public class Citrix
    {
        public async Task<bool> execute()
        {
            string stateContext = await callCaption();
            string redirectURL = await validateCaption(stateContext);
            await initURL(redirectURL);
            return true;
        }
        private string GenereteGoogleKey1(int length)
        {
            Random random = new Random();
            const string chars = "AAAAAAWRntOMSEcZPXkEH8DhgHBFfLV_XU0Nv3icW1ZaUhr1Dr9g9RpJ-G8mKW-XFHWyQPDIfLi-IOELQd2BXbU7qNeutpqv_cFpY8RAqhtgZODfLh3ahErRfh2vTQWiSsqY1vM";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        private string GenereteGoogleKey2(int length)
        {
            Random random = new Random();
            const string chars = "abcdefghijlmnopqrstuvxzky0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        private async Task<string> callCaption()
        {
            HttpClient client = new HttpClient(new HttpClientHandler { UseCookies = false, AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate });
            client.Timeout = TimeSpan.FromHours(2);

            string[] Accept = new string[] { "application/xml", "text/xml", "*/*;q=0.01" };
            string[] CitrixCredentialTypes = new string[] { "none", "username", "domain", "password", "newpassword", "passcode", "savecredentials", "textcredential", "webview", "negotiate", "nsg_push", "nsg-epa", "nsg-x1", "nsg-setclient", "nsg-eula", "nsg-tlogin", "nsg-fullvpn", "nsg-hidden", "nsg-auth-failure", "nsg-auth-success", "nsg-epa-success", "nsg-l20n", "GoBack", "nf-recaptcha", "ns-dialogue", "nf-gw-test", "nsg_qrcode", "nsg_manageotp" };
            string[] CitrixLabelTypes = new string[] { "none", "plain", "heading", "information", "warning", "error", "confirmation", "image", "nsg-epa", "nsg-epa-failure", "nsg-login-label", "tlogin-failure-msg", "nsg-tlogin-heading", "nsg-tlogin-single-res", "nsg-tlogin-multi-res", "nsg-tlogin", "nsg-login-heading", "nsg-fullvpn", "nsg-l20n", "nsg-l20n-error", "certauth-failure-msg", "dialogue-label", "nsg-change-pass-assistive-text", "nsg_confirmation", "nf-manage-otp" };
            string[] AcceptEncoding = new string[] { "gzip", "deflate" };

            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Add("Accept", Accept);
            client.DefaultRequestHeaders.Add("Accept-Language", "pt-BR");
            client.DefaultRequestHeaders.Add("Accept-Encoding", AcceptEncoding);
            client.DefaultRequestHeaders.Add("X-Citrix-AM-CredentialTypes", CitrixCredentialTypes);
            client.DefaultRequestHeaders.Add("X-Citrix-AM-LabelTypes", CitrixLabelTypes);
            client.DefaultRequestHeaders.Add("X-Citrix-IsUsingHTTPS", "Yes");
            client.DefaultRequestHeaders.Add("X-Requested-With", "XMLHttpRequest");
            client.DefaultRequestHeaders.Add("Referer", "https://portalapps.claro.com.br/logon/LogonPoint/tmindex.html");
            client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.2; WOW64; Trident/7.0; .NET4.0C; .NET4.0E; .NET CLR 2.0.50727; .NET CLR 3.0.30729; .NET CLR 3.5.30729)");
            client.DefaultRequestHeaders.Add("X-Citrix-AM-CredentialTypes", "www.atlas.netservicos.com.br");
            client.DefaultRequestHeaders.Add("Host", "portalapps.claro.com.br");
            client.DefaultRequestHeaders.Add("Cookie", "NSC_TASS=https://www.atlas.netservicos.com.br/nethome/; NSC_TMAP=aaa_Authprofile");

            Dictionary<string, string> form_data = new Dictionary<string, string>();

            HttpContent content = new FormUrlEncodedContent(form_data);
            HttpResponseMessage response = await client.PostAsync("https://portalapps.claro.com.br/nf/auth/getAuthenticationRequirements.do", content);
            var contents = await response.Content.ReadAsStringAsync();
            HttpContentHeaders headers = content.Headers;
            if (response.IsSuccessStatusCode)
            {
                try
                {
                    var StateContext = Between(contents, "<StateContext >", "</StateContext>");
                    return StateContext;
                }
                catch { }
            }

            return null;
        }
        private async Task<string> validateCaption(string stateContent)
        {
            Config.FAKE_CITRIX_TOKEN1   = GenereteGoogleKey1(240);
            Config.FAKE_CITRIX_TOKEN2   = GenereteGoogleKey2(40);

            HttpClient client = new HttpClient(new HttpClientHandler { UseCookies = false, AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate });
            client.Timeout = TimeSpan.FromHours(2);

            string[] Accept = new string[] { "application/xml", "text/xml", "*/*;q=0.01" };
            string[] CitrixCredentialTypes = new string[] { "none", "username", "domain", "password", "newpassword", "passcode", "savecredentials", "textcredential", "webview", "negotiate", "nsg_push", "nsg-epa", "nsg-x1", "nsg-setclient", "nsg-eula", "nsg-tlogin", "nsg-fullvpn", "nsg-hidden", "nsg-auth-failure", "nsg-auth-success", "nsg-epa-success", "nsg-l20n", "GoBack", "nf-recaptcha", "ns-dialogue", "nf-gw-test", "nsg_qrcode", "nsg_manageotp" };
            string[] CitrixLabelTypes = new string[] { "none", "plain", "heading", "information", "warning", "error", "confirmation", "image", "nsg-epa", "nsg-epa-failure", "nsg-login-label", "tlogin-failure-msg", "nsg-tlogin-heading", "nsg-tlogin-single-res", "nsg-tlogin-multi-res", "nsg-tlogin", "nsg-login-heading", "nsg-fullvpn", "nsg-l20n", "nsg-l20n-error", "certauth-failure-msg", "dialogue-label", "nsg-change-pass-assistive-text", "nsg_confirmation", "nf-manage-otp" };
            string[] AcceptEncoding = new string[] { "gzip", "deflate" };

            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Add("Accept", Accept);
            client.DefaultRequestHeaders.Add("Accept-Language", "pt-BR");
            client.DefaultRequestHeaders.Add("Accept-Encoding", AcceptEncoding);
            client.DefaultRequestHeaders.Add("X-Citrix-AM-CredentialTypes", CitrixCredentialTypes);
            client.DefaultRequestHeaders.Add("X-Citrix-AM-LabelTypes", CitrixLabelTypes);
            client.DefaultRequestHeaders.Add("X-Citrix-IsUsingHTTPS", "Yes");
            client.DefaultRequestHeaders.Add("X-Requested-With", "XMLHttpRequest");
            client.DefaultRequestHeaders.Add("Referer", "https://portalapps.claro.com.br/logon/LogonPoint/tmindex.html");
            client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.2; WOW64; Trident/7.0; .NET4.0C; .NET4.0E; .NET CLR 2.0.50727; .NET CLR 3.0.30729; .NET CLR 3.5.30729)");
            client.DefaultRequestHeaders.Add("X-Citrix-AM-CredentialTypes", "www.atlas.netservicos.com.br");
            client.DefaultRequestHeaders.Add("Host", "portalapps.claro.com.br");
            client.DefaultRequestHeaders.Add("Cookie", "NSC_TASS=" + "https://www.atlas.netservicos.com.br/nethome/");
            client.DefaultRequestHeaders.Add("Cookie", "NSC_TMAP=" + "aaa_Authprofile");

            Dictionary<string, string> form_data = new Dictionary<string, string>
                {
                    { "login", "T7413323" },
                    { "passwd", "Cam@0242" },
                    { "saveCredentials", "false" },
                    { "recaptcha",  Config.FAKE_CITRIX_TOKEN1},
                    { "loginBtn","Log On" },
                    { "StateContext", stateContent }
                };

            HttpContent content = new FormUrlEncodedContent(form_data);
            HttpResponseMessage response = await client.PostAsync("https://portalapps.claro.com.br/nf/auth/doAuthentication.do", content);
            var contents = await response.Content.ReadAsStringAsync();
            HttpContentHeaders headers = content.Headers;
            if (response.IsSuccessStatusCode)
            {
                try
                {
                    string hResponse = response.Headers.ToString();
                    string NSC_TMAA = Between(hResponse, "NSC_TMAA=", ";");
                    string NSC_TMAS = Between(hResponse, "NSC_TMAS=", ";");
                    Config.NSC_TMAA = "NSC_TMAA=" + NSC_TMAA;
                    Config.NSC_TMAS = "NSC_TMAS=" + NSC_TMAS;
                    string REDIRECTURI = Between(contents, "<RedirectURL>", "</RedirectURL>");
                    return REDIRECTURI;
                }
                catch { return null; }
            }

            return null;
        }
        private async Task<bool> initURL(string url)
        {
            HttpClient client = new HttpClient(new HttpClientHandler { UseCookies = false, AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate });
            client.Timeout = TimeSpan.FromHours(2);

            string[] Accept = new string[] { "image/gif", "image/jpeg", "image/pjpeg", "application/x-ms-application", "application/xaml+xml", "application/x-ms-xbap", "*/*" };
            string[] AcceptEncoding = new string[] { "gzip", "deflate" };

            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Add("Accept", Accept);
            client.DefaultRequestHeaders.Add("Accept-Language", "pt-BR");
            client.DefaultRequestHeaders.Add("Accept-Encoding", AcceptEncoding);
            client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.2; WOW64; Trident/7.0; .NET4.0C; .NET4.0E; .NET CLR 2.0.50727; .NET CLR 3.0.30729; .NET CLR 3.5.30729)");
            client.DefaultRequestHeaders.Add("Host", "www.atlas.netservicos.com.br");

            client.DefaultRequestHeaders.Add("Cookie", "asc-key-remote=" + Config.ASC_KEY_REMOTE);

            HttpResponseMessage response = await client.GetAsync(url);
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
