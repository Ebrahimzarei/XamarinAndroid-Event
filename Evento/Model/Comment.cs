using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace WebEventoo_DomainClasses.Model
{
    public class Comment
    {
        //[System.ComponentModel.DataAnnotations.Key]
        public int Id { get; set; }
       // [DisplayName("نظر")]
        public string CaptionComment { get; set; }
        public Users User { get; set; }
        public Event Event { get; set; }
        public bool OkComment { get; set; }
    }
}
