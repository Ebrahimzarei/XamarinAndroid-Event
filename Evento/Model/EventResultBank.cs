using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WebEventoo_DomainClasses.Model
{
    /// <summary>
    /// تراکنش های رویداد
    /// </summary>
   public class EventResultBank
    {
       // [Key]
        public int Id { get; set; }
        public int EventId { get; set; }
        public Event Event { get; set; }
      //  [DisplayName("تاریخ تراکنش")]
        public string DateTime { get; set; }
      //  [DisplayName("علت تراکنش")]
        public string ReasonEvent { get; set; }
      //  [DisplayName("مبلغ تراکنش")]
        public decimal Price { get; set; }

    }
}
