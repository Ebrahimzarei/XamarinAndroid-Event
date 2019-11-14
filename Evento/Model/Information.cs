using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WebEventoo_DomainClasses.Model
{
 public   class Information
    {
        public enum TypeInformation {
          //  [Display(Name = " قوانین")]
            Rule
                ,
          //  [Display(Name = " درباره ما")]
            AboutUs }
     //   [System.ComponentModel.DataAnnotations.Key]
        public int Id { get; set; }
      //  [DisplayName("نوع ثبت")]
        public TypeInformation Type  { get; set; }
      //  [DisplayName("موضوع")]
        public string Caption { get; set; }
        public string UserForeignKey { get; set; }
        public Users User { get; set; }
    }
}
