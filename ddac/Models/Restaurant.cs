using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ddac.Models
{
    public class Restaurant
    {
        [Key]
        public int Rid { get; set; }

        [Display(Name = "Restaurant Name")]
        public string RestName { get; set; }

    
        public decimal RestPrice { get; set; }
        

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public System.DateTime RDateCheckInDate { get; set; }
        public System.DateTime RDateCheckOutDate { get; set; }
        public int RQty { get; set; }
    }
}
