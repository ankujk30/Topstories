using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TopstoriesAPI.Data;
using TopstoriesAPI.Model;
using TopstoriesAPI.Repository.IRepository;

namespace TopstoriesAPI.Repository
{
    public class TopstoriesRepository : ITopstoriesRepository
    {

        private readonly ApplicationDbContext _db;

        public TopstoriesRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool CreateTopStories(Root objroot)
        {
            ////To avoid duplicate record in the DB based on num of results
            if (!_db.Roots.Any(x => x.Num_results == objroot.Num_results))
                _db.Roots.Update(objroot);
           
                foreach (Topstories obj in objroot.Results)
                {
                    //To avoid duplicate record in the DB based on the URL
                    if (!_db.Topstories.Any(x => x.Url.ToLower().Trim() == obj.Url.ToLower().Trim()))
                        _db.Topstories.Add(obj);
                }
            return Save();
        }

        public bool Save()
        {
            return _db.SaveChanges() >= 0 ? true : false;
        }


    }
}
