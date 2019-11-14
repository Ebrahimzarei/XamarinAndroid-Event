using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace WebEventoo_DomainClasses.Model
{/// <summary>
/// آدرس
/// </summary>
  public  class Address
    {
      //  [System.ComponentModel.DataAnnotations.Key]
        public int Id { get; set; }
     //   [DisplayName("نام")]
        public string Name { get; set; }
      //  [DisplayName("آدرس")]
        public string CaptionAddress { get; set; }
     //   [DisplayName("آدرس دقیق")]
        public string AddressTwo { get; set; }
      //  [DisplayName("طول جغرافیایی")]
        public double Lattiude { get; set; }
      //  [DisplayName("عرض جغرافیایی")]
        public double Longtiude { get; set; }
        //public int EventOfId { get; set; }
        //public Event Event { get; set; }



    }
}
