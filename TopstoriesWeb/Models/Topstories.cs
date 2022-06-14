using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TopstoriesWeb.Models
{
    public class Topstories
    {
        [Required]
        [Display(Name = "API key")]
        public string ApiKey { get; set; }
    }
}
