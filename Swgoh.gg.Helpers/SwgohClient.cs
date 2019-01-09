using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Swgoh.gg.Helpers
{
    public static class SwgohClient
    {
        public static HttpClient SwgohApiClient { get; set; }

        public static void Initialize()
        {
            SwgohApiClient = new HttpClient();

            SwgohApiClient.BaseAddress = new Uri(ConfigurationManager.AppSettings["SWGOHGGAPIBASEURL"].ToString());
            SwgohApiClient.DefaultRequestHeaders.Accept.Clear();
            SwgohApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
