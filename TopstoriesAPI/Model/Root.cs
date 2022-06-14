using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TopstoriesAPI.Model
{
    public class Root
    {
        [Key]
        public int Rootid { get; set; }
        public string Status { get; set; }
        public string Copyright { get; set; }
        public string Section { get; set; }
        public DateTime Last_updated { get; set; }
        public int Num_results { get; set; }
        public List<Topstories> Results { get; set; }
    }
}
