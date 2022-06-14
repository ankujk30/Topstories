using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TopstoriesAPI.Model
{

    

    public class Topstories
    {
        [Key]
        public int Topstoriesid { get; set; }
        public string Section { get; set; }
        public string Subsection { get; set; }
        [Required]
        public string Title { get; set; }
        public string Abstract { get; set; }
        public string Url { get; set; }
        public string Uri { get; set; }
        public string Byline { get; set; }
        public string Item_type { get; set; }
        public DateTime Updated_date { get; set; }
        public DateTime Created_date { get; set; }
        public DateTime Published_date { get; set; }
        public string Material_type_facet { get; set; }
        public string Kicker { get; set; }
        public string Des_facet { get; set; }
        public string Org_facet { get; set; }
        public string Per_facet { get; set; }
        public string Geo_facet { get; set; }
        public List<Multimedium> Multimedia { get; set; }
        public string Short_url { get; set; }
    }
}
