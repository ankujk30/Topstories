using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TopstoriesAPI.Model;

namespace TopstoriesAPI.Repository.IRepository
{
    public interface ITopstoriesRepository
    {
        bool CreateTopStories(Root objroot);

        bool Save();

    }
}
