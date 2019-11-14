using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WebEventoo_DomainClasses.Model
{
    public class Event
    {
        public Event()
        {
       
        }
        public enum TypeEvent {
            //[Display(Name = "فرهنگی هنری")]
            Cultrual
               
                ,
          //  [Display(Name = "گردشگری")]
            Toursm
                ,
           // [Display(Name = "ورزشی")]
            Sport
                ,
          //  [Display(Name = "علمی و تخصصی")]
            Sciences
                ,
          //  [Display(Name = " مذهبی و ذینی")]
            Religuse
                ,
          //  [Display(Name = "داوطلبانه و مردمی")]
            Public
                    ,
          //  [Display(Name = "خوراکی")]
            Food
                       ,
          //  [Display(Name = "سلامتی و زیبایی")]
            Health
                          ,
         //   [Display(Name = "  کلاس های آموزشی")]
            ClassLearn
                           ,
           // [Display(Name = " فروشگاه ها")]
            Stores
                   ,
           // [Display(Name = "برنامه های تلوزیونی")]
            ProgramTv

        }
        public enum TypeCaptionEvent {
            //اغذیه فروشی
           // [Display(Name = "  جنبه رویداد-اجرای زنده")]
            LongingfoodLive
                ,
           // [Display(Name = "  جنبه رویداد-قرعه کشی")]
            Longingfoodlottery
                ,
           // [Display(Name = "  جنبه رویداد-پخش مسابقات زنده")]
            Longingfoodmajorlive
                ,
           // [Display(Name = "  جنبه رویداد-اشانتیون")]
            Longingfoodgift
                ,
          //  [Display(Name = "  جنبه رویداد-نمایشگاه جنبی")]
            Longingfoodexhibition
                ,
           // [Display(Name = "  جنبه رویداد-افتتاحیه")]
            Longingfoodopening
                ,
           // [Display(Name = "  جنبه رویداد-تخفیف")]
            Longingfooddiscount
                ,
           // [Display(Name = "  جنبه رویداد-سایر")]
            Longingfoodother
                ,



            //کلاس آموزشی
            //  [Display(Name = "  جنبه رویداد-جلسه رایگان")]
            LongingclassLive
                ,
          //  [Display(Name = "  جنبه رویداد-قرعه کشی")]
            Longingclasslottery
                ,
           // [Display(Name = "  جنبه رویداد-کارگاه جنبی")]
            LongingclassotherLive
                ,
          //  [Display(Name = "  جنبه رویداد-اشانتیون")]
            Longingclassgiftlottery
                ,
          //  [Display(Name = "  جنبه رویداد-نمایشگاه جنبی")]
            LongingclassexhibitionLive
                ,
          //  [Display(Name = "  جنبه رویداد-افتتاحیه")]
            Longingclassopening
                ,
          //  [Display(Name = "  جنبه رویداد-تخفیف")]
            Longingclassdiscount
                ,
          //  [Display(Name = "  جنبه رویداد-سایر")]
            Longingclassother
                ,

            //جنبه رویداد-فروشگاه
         //   [Display(Name = "  جنبه رویداد-اجرای زنده")]
            LongingStoreLive
                ,
           // [Display(Name = "  جنبه رویداد-قرعه کشی")]
            LongingStorelottery
                ,
          //  [Display(Name = "  جنبه رویداد-اشانتیون")]
            LongingStoregift
                ,
          //  [Display(Name = "  جنبه رویداد-نمایشگاه جنبی")]
            LongingStoreexhibition
                ,
           // [Display(Name = "  جنبه رویداد-افتتاحیه")]
            LongingStoreopening
                ,
           // [Display(Name = "  جنبه رویداد-تخفیف")]
            LongingStorediscount
                ,
          //  [Display(Name = "  جنبه رویداد-سایر")]
            LongingStoreother
                ,



            //  [Display(Name = " فروشگاه ها-پوشاک")]
            storescloths
                ,
           // [Display(Name = " فروشگاه ها-کالای دیجیتال")]
            StoresDigital
                ,
          //  [Display(Name = " فروشگاه ها-مواد غدایی")]
            StoresFood
                ,
          //  [Display(Name = " فروشگاه ها-آرایشی بهداشتی")]
            StoresHealth
                ,
          //  [Display(Name = "  برنامه های تلوزیونی-زنده")]
            ProgramTvLive
                ,

         //   [Display(Name = "  برنامه های تلوزیونی-پرطرفدار")]
            ProgramTvPopular
                ,


         //   [Display(Name = "  برنامه های تلوزیونی-تازه ها")]
            ProgramTvRefresh,

            ///  [Display(Name = "فرهنگی هنری-نمایشگاه")]
            cultrualExhibition
                ,
          //  [Display(Name = "فرهنگی هنری-سینما")]
            cultrualCinema
                ,
          //  [Display(Name = "فرهنگی هنری-کنسرت")]
            cultrualconcert
                ,
         //   [Display(Name = "فرهنگی هنری-گالری")]
            cultrualGallery

                ,
          //  [Display(Name = "فرهنگی هنری-همایش و مراسم")]
            cultrualcermoney,

          //  [Display(Name = "فرهنگی هنری-تیاتر")]
            cultrualGravity
                ,



       //     [Display(Name = "ورزش و سرگرمی-باشگاه")]
            sportclub

                ,
       //     [Display(Name = "ورزش و سرگرمی-گیم گلاب")]
            sportgymclub

                ,
        //    [Display(Name = "ورزش و سرگرمی-ورزش های توپی")]
            sportball
    ,
       //     [Display(Name = "ورزش و سرگرمی-ورزش های آبی")]
            sportwater
                    ,
        //    [Display(Name = "ورزش و سرگرمی-ورزش های رزمی")]
            sportmartial
                    ,
        
          
           
         //   [Display(Name = "علمی و تخصصی -نمایشگاه")]
            academicexhibition
                    ,
         //   [Display(Name = "علمی و تخصصی-کنفرانس")]
            academicconferance
                    ,
         
         //   [Display(Name = "علمی و تخصصی -همایش")]
            academiccermoney
                    ,
         //   [Display(Name = "داوطلبانه و مردمی-نمایشگاه")]
            popularexhibition
                    ,
        //    [Display(Name = "داوطلبانه و مردمی-گرد همایی")]
            populargathering
                    ,
        //    [Display(Name = "داوطلبانه و مردمی-خیریه و کمک رسانی")]
            popularhelping
                    
         
                    ,
                    
         
         //   [Display(Name = "تفریح و گردشگری-تور")]
            tourismtour
                    ,
           
         //   [Display(Name = "تفریح و گردشگری-جاذبه ها و مکان های تفریحی")]
            tourismgravity
                    ,
         //   [Display(Name = "خوراکی ها-نمایشگاه")]
            foodsexhibition
                    ,
           // [Display(Name = "خوراکی ها-کافی شاپ")]
            foodscoffe
                    ,
        //    [Display(Name = "خوراکی ها-رستوران")]
            foodsresturant
                    ,
         //   [Display(Name = "خوراکی ها-فست فود")]
            foodsfastfood
                    ,
         //   [Display(Name = "مذهبی و دینی -نمایشگاه  ")]
            religionexhibition
                    ,
         
         //   [Display(Name = "مذهبی و دینی -مراسم  ")]
            religioncermoney
                    ,
         //   [Display(Name = "سلامتی و زیبایی-سلامتی و زیبایی ")]
            healthitemone
                    ,
          //  [Display(Name = "کلاس های آمورشی-گردشگری ")]
            classlearntourism
                ,
            healthitemoTwo
                    ,
         //   [Display(Name = "کلاس های آمورشی-ورزشی ")]
            classlearnsport
                    ,
          //  [Display(Name = "کلاس های آمورشی-خوراکی  ")]
            classlearnfood
                    ,
          //  [Display(Name = "کلاس های آمورشی-مذهبی ")]
            classlearnreligion
                    ,
          //  [Display(Name = "کلاس های آمورشی-بیشه و مهارتی ")]
            classlearnskill
                    ,
          //  [Display(Name = "کلاس های آمورشی-دروس مدرسه و دانشگاه ")]
            classlearnlesson
                    ,
         //   [Display(Name = "کلاس های آمورشی-زبان های خارجی ")]
            classlearnlanguage
                    ,
          //  [Display(Name = "کلاس های آمورشی-مشاوره تحصیلی ")]
            classlearnsadvice
                    ,
           // [Display(Name = "کلاس های آمورشی-هنری ")]
            classlearncultrual
                    ,
          //  [Display(Name = "کلاس های آمورشی-پزشکی ")]
            classlearnmedical
                    ,
        //    [Display(Name = "کلاس های آمورشی-زیبایی ")]
            classlearnperfect
                    ,
         //   [Display(Name = "کلاس های آمورشی-آموزش موسیقی ")]
            classlearnmusic
                    ,
        //    [Display(Name = "کلاس های آمورشی-عکاسی ")]
            classlearnphoto
                    ,
         //   [Display(Name = "کلاس های آمورشی-ورک شاپ ")]
            classlearnorkshop
                    ,



        }
        public enum Cost {
          //  [Display(Name = "رایگان")]
            Free
                ,
          //  [Display(Name = "قیمت درج شود")]
            AddCost

                ,
         //   [Display(Name = "قیمت درج نشود")]
            NotCost }
        public enum StatuseEvent
        {
         //   [Display(Name = " رویداد های بررسی نشده")]
            NotChecked,
         //   [Display(Name = " رویداد های منتشر شده")]
            Published,
          //  [Display(Name = " رویداد های نیاز به تغییرات")]
            IsEdit,
          //  [Display(Name = "رویداد های نیاز به پرداخت ")]
            Ispayed,
         //   [Display(Name = " رویداد های ویژه")]
            Special,
          //  [Display(Name = " رویداد های نردبان شده")]
            Ladder,
           // [Display(Name = " رویداد های اسلایدر")]
            Slider
        }
       
       // [Display(Name = "جنبه رویداد")]
        public string OtherLonging { get; set; }
        //    [Key]
        public int Id { get; set; }
       // [Display(Name = " وضعیت رویداد")]

        public StatuseEvent Statusevent { get; set; }
      // [DisplayName("موضوع رویداد")]
        public TypeEvent Type { get; set; }
      //  [DisplayName("انتخاب رویداد")]
        public TypeCaptionEvent TypeCaption { get; set; }
      //  [DisplayName("نام رویداد ")]
        public string CaptionEvent { get; set; }
      //  [DisplayName("زمان رویداد")]
        public string TimeEvent { get; set; }

        public int ExhibotionOfId { get; set; }
      //  [DisplayName("نمایشگاه")]
        public List<Exhibition> Exhibotion { get; set; }
        public int EductionOfId { get; set; }
       // [DisplayName("آموزشی")]
        public List<Eduction> Eduction { get; set; }
        public int PlaceOfId { get; set; }
      //  [DisplayName("مکان")]
        public List<Place> Place { get; set; }
        public int AddressOfId { get; set; }
      //  [DisplayName("آدرس")]
        public List<Address> Address { get; set; }
        public int CermoneyOfId { get; set; }
       // [DisplayName("مراسم و همایش")]
        public List<Ceremony> Cermoney { get; set; }
      //  [DisplayName("هزینه")]
        public Cost Payed { get; set; }
      //  [DisplayName("تلفن")]
        public string Tell { get; set; }
      //  [DisplayName("توضیحات بیشتر")]
        public string Description { get; set; }
        public  List<Images> Image { get; set; }
        public int UserofId { get; set; }
      //  [DisplayName("از تاریخ")]
        public string FromDate { get; set; }
     //   [DisplayName("تا تاریخ")]
        public string ToDate { get; set; }
        public virtual  Users User { get; set; }
        public int CommentofId { get; set; }
        public virtual ICollection<Comment> Comment{get;set;}
        public Boolean StatuseChecked { get; set; }
        public Boolean StatuseEnter { get; set; }
        public DateTime EventNow { get; set; }

        public   ICollection<Report> ReportList { get; set; }
      //  public string SliderImage { get; set; }
        public byte[] SliderImages { get; set; }

        public EventResultBank EventResultBank { get; set; }

        public string Price { get; set; }
        public string AddressUrl { get; set; }



    }
}
