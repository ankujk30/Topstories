using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TopstoriesAPI.Model
{
    public class Multimedium
    {

        [Key]
        public int Multimediumid { get; set; }
        public string Url { get; set; }
        public string Format { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public string Type { get; set; }
        public string Subtype { get; set; }
        public string Caption { get; set; }
        public string Copyright { get; set; }

    }
}
