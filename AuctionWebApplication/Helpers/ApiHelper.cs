using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace AuctionWebApplication.Helpers
{
    public class ApiHelper : IApiHelper
    {
        public Uri BaseUri { get; set; }
        public T Get<T>(string query)
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = BaseUri;

                var response = httpClient.GetAsync(query).Result;
                return response.Content.ReadAsAsync<T>().Result;
            }
        }
        public bool Post<T>(T data, string query)
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = BaseUri;

                var postTask = httpClient.PostAsJsonAsync<T>(query, data);
                postTask.Wait();

                var result = postTask.Result;

                if (result.IsSuccessStatusCode)
                {
                    return true;
                }
                return false;
            }
        }
    }
}
