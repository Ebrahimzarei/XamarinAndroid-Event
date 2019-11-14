
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace WebEventoo_DomainClasses.Model
{
    public class Users 
    {
        public enum UserType
        {
           // [DisplayName("کاربران استفاده کننده")]
            UserApp,
           // [DisplayName("کاربران صاحب  رویداد")]
            UserEvent,
          //  [DisplayName("کاربر وب")]
            UserWeb
        }
        public Users()
        {
          //  Event = new HashSet<Event>();
        }
      //  [Key]
        public int UsersID { get; set; }
      //  [DisplayName("نام ")]
        public string FirstName { get; set; }
      //  [DisplayName("نام خانوادگی")]
        public string LastName { get; set; }
      //  [DisplayName("کاربر ها")]
        public UserType Type { get; set; }
      //  [DisplayName("کاربران استفاده کننده")]
        public Guid KeyUserApp { get; set; }
      //  [DisplayName("شماره تلفن")]
        public string Tellephone { get; set; }
        public int UsersOfId { get; set; }
        public virtual   ICollection<Event> Event { get; set; }
        public ICollection<Comment> Comment { get; set; }
        public Information information { get; set; }
 

    }
}
