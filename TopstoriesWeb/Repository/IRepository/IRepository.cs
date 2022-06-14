using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace TopstoriesWeb.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        Task<HttpResponseMessage> CreateAsync(string url, string APIKey);
    }
}
