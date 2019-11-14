using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WebEventoo_DomainClasses.Model
{
    /// <summary>
    /// مراسم و همایش
    /// </summary>
  public  class Ceremony
    {
        public enum TypeCermoney
        {
           // [Display(Name = "هنری")]
            Cultrul
           
                ,
          //  [Display(Name = "ورزشی")]
            Sport
                ,
          //  [Display(Name = "علمی و تخصصی")]
            Sciences
               
                ,
          //  [Display(Name = "عمومی")]
            Public



        };
      

       // [System.ComponentModel.DataAnnotations.Key]
        public int Id { get; set; }
      //  [DisplayName("نام")]
        public string Name { get; set; }
       // [DisplayName("نوع مراسم")]
        public TypeCermoney Type { get; set; }

       // public Event Event { get; set; }
    }
}
