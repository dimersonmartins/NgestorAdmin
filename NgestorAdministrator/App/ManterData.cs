using Newtonsoft.Json.Linq;
using Server.Http.Company;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NgestorAdministrator.App
{
    class ManterData
    {
        private JObject JSON = null;
        public async Task<bool> manter()
        {
            Controller controller = new Controller();
            string response = await controller.manter();
            if (!string.IsNullOrWhiteSpace(response))
            {
                JSON = JObject.Parse(response);
            }
            return true;
        }
        public Dictionary<string, string> timerZone()
        {
            Dictionary<string, string> timerZone = new Dictionary<string, string>();
            timerZone.Add("AC", "America/Rio_branco");
            timerZone.Add("AL", "America/Maceio");
            timerZone.Add("AP", "America/Belem");
            timerZone.Add("AM", "America/Manaus");
            timerZone.Add("BA", "America/Bahia");
            timerZone.Add("CE", "America/Fortaleza");
            timerZone.Add("DF", "America/Sao_Paulo");
            timerZone.Add("ES", "America/Sao_Paulo");
            timerZone.Add("GO", "America/Sao_Paulo");
            timerZone.Add("MA", "America/Fortaleza");
            timerZone.Add("MT", "America/Cuiaba");
            timerZone.Add("MS", "America/Campo_Grande");
            timerZone.Add("MG", "America/Sao_Paulo");
            timerZone.Add("PR", "America/Sao_Paulo");
            timerZone.Add("PB", "America/Fortaleza");
            timerZone.Add("PA", "America/Belem");
            timerZone.Add("PE", "America/Recife");
            timerZone.Add("PI", "America/Fortaleza");
            timerZone.Add("RJ", "America/Sao_Paulo");
            timerZone.Add("RN", "America/Fortaleza");
            timerZone.Add("RS", "America/Sao_Paulo");
            timerZone.Add("RO", "America/Porto_Velho");
            timerZone.Add("RR", "America/Boa_Vista");
            timerZone.Add("SC", "America/Sao_Paulo");
            timerZone.Add("SE", "America/Maceio");
            timerZone.Add("SP", "America/Sao_Paulo");
            timerZone.Add("TO", "America/Araguaia");
            return timerZone;
        }
        public Dictionary<string, string> servers()
        {
            Dictionary<string, string> servers = new Dictionary<string, string>();
            servers.Add("NG-Sales", "http://webmaster.sales.osgerenciador.com");
            servers.Add("NG-Field Service", "http://webmaster.fs.osgerenciador.com");
            
            return servers;
        }
      
        public Dictionary<string, string> operadoras()
        {
            Dictionary<string, string> operadoras = new Dictionary<string, string>();
            try
            {
                if (JSON == null)
                {
                    return null;
                }
                foreach (var item in JSON["operadora"])
                {
                    operadoras.Add(item["name"].ToString(), item["id"].ToString());
                }
            }
            catch { }
            
            return operadoras;
        }
        public Dictionary<string, string> operadoras_servidores()
        {
            Dictionary<string, string> operadorasServidores = new Dictionary<string, string>();
            try
            {
                if (JSON == null)
                {
                    return null;
                }
                foreach (var item in JSON["operadora_servidores"])
                {
                    operadorasServidores.Add(item["name"].ToString(), item["id"].ToString());
                }

            }
            catch { }
          
            return operadorasServidores;
        }
    }
}
