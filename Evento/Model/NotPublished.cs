using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WebEventoo_DomainClasses.Model
{
    /// <summary>
    /// رویدادهای منتشر نشده
    /// </summary>
    public class NotPublished
    {
       // [Key]
        public int Id { get; set; }
    //    [System.ComponentModel.DisplayName("نام رویداد")]
        public string NameEvent{get;set;}
     //   [System.ComponentModel.DisplayName("تاریخ رد شدن رویداد")]
        public string DeleteDate { get; set; }

    }
}
