using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WebEventoo_DomainClasses.Model
{
    /// <summary>
    /// رنگ ذکمه ها
    /// </summary>
public    class Colors
    {
       // [Key]
        public int Id { get; set; }
      //  [DisplayName("رنگ هدر")]
        public string ColorHeader { get; set; }
     //   [DisplayName("رنگ پایین")]
        public string ColorFooter { get; set; }
     //   [DisplayName("رنگ کحتوا")]
        public string ColorSubContetntView { get; set; }
      //  [DisplayName("رنگ دکمه ها")]
        public string ColorButton { get; set; }

    }
}
