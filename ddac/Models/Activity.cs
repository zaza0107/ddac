using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ddac.Models
{
    public class Activity
    {
        public int Actid { get; set; }
        public string ActName { get; set; }
        public decimal ActPrice { get; set; }
        public int AQty { get; set; }
    }
}
