using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WebEventoo_DomainClasses.Model
{
    /// <summary>
    /// نمایشگاه
    /// </summary>
  public  class Exhibition
    {
      public  enum TypeExhbition {
          //  [Display(Name = "فرهنگی و هنری")]
            Cultrual
                ,
           // [Display(Name = "گررشکری و سرگرمی")]
            Tourism
                ,
        //    [Display(Name = " ورزشی")]
            Sport
                ,
         //   [Display(Name = " علمی و تخصصی")]
            Scientific
                ,
          //  [Display(Name = " مذهبی")]
            Religions
                ,
          //  [Display(Name = " مذهبی")]
            Public };

       // [Key]
        public int Id { get; set; }
      //  [DisplayName("نوع نمایشگاه")]
        public TypeExhbition Type { get; set; }
       // [DisplayName("نام نمایشگاه")]
        public string  Name { get; set; }
      //  public Event Event { get; set; }

    }
}
