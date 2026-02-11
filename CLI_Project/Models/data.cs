using System;
using System.Collections.Generic;
using System.Text;

namespace CLI_Project_V2_Aditya.CLI_Project.Models
{
    internal class data
    {
        public int? ID { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Status { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
    }
}
