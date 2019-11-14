using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace WebEventoo_DomainClasses.Model
{

 public   class Report
    {
        public enum TypeReport
        {
          //  [DisplayName("گزارش نظر")]
            ReportComment,
           // [DisplayName("گزارش رویداد")]
            ReportEvent,
        }
      //  [System.ComponentModel.DataAnnotations.Key]
        public int Id { get; set; }
        [DisplayName("'نوع گزارش رویداد ")]
        public string CaptionReport { get; set; }
        public int evtId { get; set; }
        public TypeReport? RoleReport { get; set; }
        public  Event Event { get; set; }
    }
}
