using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TopstoriesAPI
{
    public class Constants
    {
        public const string NyTimesbaseUrl = "https://api.nytimes.com/";
        public const string TopstoriesAPIPath = NyTimesbaseUrl + "/svc/topstories/v2/home.json?api-key={0}";
        
    }
}
