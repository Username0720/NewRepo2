using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Grants_data.Models
{
    public class Data_
    {
        [Required]
        public string konkurs_name { get; set; }
        public string href { get; set; }
        public string organization { get; set; }
        public string date_begin { get; set; }
        public string date_end { get; set; }
        public string date_ { get; set; }
        public string location_ { get; set; }
    }
}
