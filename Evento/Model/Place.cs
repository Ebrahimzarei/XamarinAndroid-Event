using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WebEventoo_DomainClasses.Model
{
   /// <summary>
   /// مکان
   /// </summary>
    public    class Place
    {
        public enum TypePlace
        {
          //  [Display(Name = " گردشگری و سرگرمی")]
            Tourism
           ,
          //  [Display(Name = " ورزشی")]
            Sport
             

        };
       // [System.ComponentModel.DataAnnotations.Key]
        public int Id { get; set; }
        [DisplayName("نوع مکان")]
        public TypePlace Type { get; set; }
        [DisplayName("نام مکان")]
        public string Name { get; set; }
     //   public Event Event { get; set; }

    }
}
