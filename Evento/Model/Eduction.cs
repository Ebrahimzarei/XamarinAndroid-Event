using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WebEventoo_DomainClasses.Model
{
    /// <summary>
    /// آموزشی
    /// </summary>
 public   class Eduction
    {
        public enum TypeEduction
        {
         //   [Display(Name = "فرهنگی هنری")]
            Cultrual 
              ,
         //   [Display(Name = "ورزشی")]
            Sport
                //علمی
              ,
          //  [Display(Name = "علمی")]
            Scientific
            
        };
      ///  [System.ComponentModel.DataAnnotations.Key]
        public int Id { get; set; }
        [DisplayName("نام")]
        public string Name { get; set; }
        [DisplayName("نوع آموزش")]
        public TypeEduction Type { get; set; }
     //   public Event Event { get; set; }
    }

}
