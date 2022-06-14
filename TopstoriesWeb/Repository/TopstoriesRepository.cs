using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TopstoriesWeb.Models;
using TopstoriesWeb.Repository.IRepository;

namespace TopstoriesWeb.Repository
{
    public class TopstoriesRepository : Repository<Topstories>, ITopstoriesRepository
    {
        private readonly IHttpClientFactory _clientFactory;

        public TopstoriesRepository(IHttpClientFactory clientFactory) :base(clientFactory)
        {
            _clientFactory = clientFactory;
                
        }
    }
}
