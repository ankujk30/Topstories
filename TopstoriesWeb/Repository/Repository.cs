using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TopstoriesWeb.Repository.IRepository;

namespace TopstoriesWeb.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly IHttpClientFactory _cientFactory;

        public Repository(IHttpClientFactory clientFactory)
        {
            _cientFactory = clientFactory;
        }
        public async Task<HttpResponseMessage> CreateAsync(string url, string APIKey)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, url + APIKey);

            var client = _cientFactory.CreateClient();
            HttpResponseMessage response = await client.SendAsync(request);

            return response;

        }
    }
}
