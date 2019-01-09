using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Swgoh.gg.Helpers
{
    public static class SwgohApiProcessor
    {
        public static async Task<T> MakeRequest<T>(string queryPath)
        {
            using (HttpResponseMessage response = await SwgohClient.SwgohApiClient.GetAsync(queryPath))
            {
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<T>();
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
