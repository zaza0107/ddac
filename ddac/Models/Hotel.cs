using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ddac.Models
{
    public class Hotel
    {
        [Key]
        public int Hid { get; set; }


       
        public string HotelName { get; set; }

 
        public decimal HotelPrice { get; set; }


     
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public System.DateTime HDateCheckInDate { get; set; }
       
        public System.DateTime HDateCheckOutDate { get; set; }
      
        public int HQty { get; set; }
        
    }
}
