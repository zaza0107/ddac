using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ddac.Models
{
    public class BeautynSpa
    {
        [Key]
        public int Bid { get; set; }
        public string BeautyName { get; set; }
        public decimal BeautyPrice { get; set; }
        public int BQty { get; set; }

    }
}
