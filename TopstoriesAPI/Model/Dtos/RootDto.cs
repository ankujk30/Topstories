using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TopstoriesAPI.Model.Dtos
{
    public class RootDto
    {
        public string Status { get; set; }
        public string Copyright { get; set; }
        public string Section { get; set; }
        public DateTime Last_updated { get; set; }
        public int Num_results { get; set; }
        public List<TopstoriesDto> Results { get; set; }
    }
}
