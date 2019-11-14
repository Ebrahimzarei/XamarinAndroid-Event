using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using Evento.Adapter;
using Evento.Model;
using Newtonsoft.Json;
using WebEventoo_DomainClasses.Model;

namespace Evento.Controller.activity
{
    [Activity(Label = "CategoryEvent")]
    public class CategoryEvent : AppCompatActivity
    {
        Button categorybtnenterevent;
        TextView categorytxtviewgroup;
        ImageButton categorymgbtnlogo;
        Button categorybtnContact;
        Button categorybtngift;
        Button categorybtnEventDay;
        Button categorybtngroupingGrouping;
        ListView categorylstevent;
        List<Event> objr;
        List<Event> SelectItem;
        protected async override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.CategoryEvent);
            var font = Typeface.CreateFromAsset(Assets, "Estedad.ttf");
            categorybtnenterevent = FindViewById<Button>(Resource.Id.categorybtnenterevent);
            categorybtnenterevent.Typeface = font;
            categorytxtviewgroup = FindViewById<TextView>(Resource.Id.categorytxtviewgroup);
            categorytxtviewgroup.Typeface = font;
            categorymgbtnlogo = FindViewById<ImageButton>(Resource.Id.categorymgbtnlogo); ;
            categorybtnContact = FindViewById<Button>(Resource.Id.categorybtnContact);
            categorybtnContact.Typeface = font;
            categorybtngift = FindViewById<Button>(Resource.Id.categorybtngift); ;
            categorybtngift.Typeface = font;
            categorybtnEventDay = FindViewById<Button>(Resource.Id.categorybtnEventDay); ;
            categorybtnEventDay.Typeface = font;
            categorybtngroupingGrouping = FindViewById<Button>(Resource.Id.categorybtngroupingGrouping); ;
            categorybtngroupingGrouping.Typeface = font;
              categorylstevent = FindViewById<ListView>(Resource.Id.categorylstevent);
            //علمی و تخصصی
            using (HttpClient client = new HttpClient())
            {

                client.BaseAddress = new Uri(WebAddress.MyAddress);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                string json = JsonConvert.SerializeObject("", Formatting.Indented);
                var httpContent = new StringContent(json);
                HttpResponseMessage response = client.PostAsync("api/GetEventsItems", httpContent).Result;
                if (response.IsSuccessStatusCode)
                {
                    response.EnsureSuccessStatusCode();
                    var responseJsonString = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject(responseJsonString).ToString();
                     objr = JsonConvert.DeserializeObject<List<Event>>(result);
                


                }
            }
            string StrValue = Intent.GetStringExtra("Key");

            if (StrValue == "اغذیه فروشی-نمایشگاه")
            {
                SelectItem = objr.Where(u => u.TypeCaption == Event.TypeCaptionEvent.foodsexhibition).ToList();
                categorytxtviewgroup.Text = StrValue;



            }
            if (StrValue == "اغذیه فروشی-کافی شاپ")
            {
                SelectItem = objr.Where(u => u.TypeCaption == Event.TypeCaptionEvent.foodscoffe).ToList();
                categorytxtviewgroup.Text = StrValue;



            }
            if (StrValue == "اغذیه فروشی-رستوران")
            {
                SelectItem = objr.Where(u => u.TypeCaption == Event.TypeCaptionEvent.foodsresturant).ToList();
                categorytxtviewgroup.Text = StrValue;


                //اغذبه فروشی-فست فود
            }
            if (StrValue == "اغذبه فروشی-فست فود")
            {
                SelectItem = objr.Where(u => u.TypeCaption == Event.TypeCaptionEvent.foodsfastfood).ToList();
                categorytxtviewgroup.Text = StrValue;


                //اغذبه فروشی-فست فود
            }
            if (StrValue=="علمی و تخصصی-همایش")
            {
                  SelectItem = objr.Where(u => u.TypeCaption == Event.TypeCaptionEvent.academiccermoney).ToList();
                categorytxtviewgroup.Text = StrValue;



            }
            if (StrValue == "علمی و تخصصی-نمایشگاه")
            {
                SelectItem = objr.Where(u => u.TypeCaption == Event.TypeCaptionEvent.academicexhibition).ToList();
                categorytxtviewgroup.Text = StrValue;
            }

            if (StrValue == "علمی و تخصصی-کنفرانس")
            {
                SelectItem = objr.Where(u => u.TypeCaption == Event.TypeCaptionEvent.academicconferance).ToList();
                categorytxtviewgroup.Text = StrValue;
            }



            //کلاس های آموزشی
            if (StrValue == "کلاس های آموزشی-گردشگری")
            {
                SelectItem = objr.Where(u => u.TypeCaption == Event.TypeCaptionEvent.classlearntourism).ToList();
                categorytxtviewgroup.Text = StrValue;
            }
            if (StrValue == "کلاس های آموزشی-ورزشی")
            {
                SelectItem = objr.Where(u => u.TypeCaption == Event.TypeCaptionEvent.classlearnsport).ToList();
                categorytxtviewgroup.Text = StrValue;
            }
            if (StrValue == "کلاس های آموزشی-خوراکی")
            {
                SelectItem = objr.Where(u => u.TypeCaption == Event.TypeCaptionEvent.classlearnfood).ToList();
                categorytxtviewgroup.Text = StrValue;
            }
            if (StrValue == "کلاس های آموزشی-مذهبی")
            {
                SelectItem = objr.Where(u => u.TypeCaption == Event.TypeCaptionEvent.classlearnreligion).ToList();
                categorytxtviewgroup.Text = StrValue;
            }
            if (StrValue == "کلاس های آموزشی-بیشه و مهارتی")
            {
                SelectItem = objr.Where(u => u.TypeCaption == Event.TypeCaptionEvent.classlearnskill).ToList();
                categorytxtviewgroup.Text = StrValue;
            }
            if (StrValue == "کلاس های آموزشی-دروس مدرسه و دانشگاه")
            {
                SelectItem = objr.Where(u => u.TypeCaption == Event.TypeCaptionEvent.classlearnlesson).ToList();
                categorytxtviewgroup.Text = StrValue;
            }
            if (StrValue == "کلاس های آموزشی-زبان های خارجی")
            {
                SelectItem = objr.Where(u => u.TypeCaption == Event.TypeCaptionEvent.classlearnlanguage).ToList();
                categorytxtviewgroup.Text = StrValue;
            }
            if (StrValue == "کلاس های آموزش- مشاوره تحصیلی")
            {
                SelectItem = objr.Where(u => u.TypeCaption == Event.TypeCaptionEvent.classlearnsadvice).ToList();
                categorytxtviewgroup.Text = StrValue;
            }
            if (StrValue == "کلاس های آموزشی-هنری")
            {
                SelectItem = objr.Where(u => u.TypeCaption == Event.TypeCaptionEvent.classlearncultrual).ToList();
                categorytxtviewgroup.Text = StrValue;
            }
            if (StrValue == "کلاس های آموزشی-پزشکی")
            {
                SelectItem = objr.Where(u => u.TypeCaption == Event.TypeCaptionEvent.classlearnmedical).ToList();
                categorytxtviewgroup.Text = StrValue;
            }
            if (StrValue == "کلاس های آموزشی-زیبایی")
            {
                SelectItem = objr.Where(u => u.TypeCaption == Event.TypeCaptionEvent.classlearnperfect).ToList();
                categorytxtviewgroup.Text = StrValue;
            }
            if (StrValue == "کلاس های آموزشی-آموزش موسیقی")
            {
                
                      SelectItem = objr.Where(u => u.TypeCaption == Event.TypeCaptionEvent.classlearnmusic).ToList();
                categorytxtviewgroup.Text = StrValue;
            }
            if (StrValue == "کلاس های آموزشی-آموزش عکاسی")
            {
                SelectItem = objr.Where(u => u.TypeCaption == Event.TypeCaptionEvent.classlearnphoto).ToList();
                categorytxtviewgroup.Text = StrValue;
            }
            if (StrValue == "کلاس های آموزشی-ورک شاپ")
            {
                SelectItem = objr.Where(u => u.TypeCaption == Event.TypeCaptionEvent.classlearnorkshop).ToList();
                categorytxtviewgroup.Text = StrValue;
            }
            if (StrValue == "کلاس های آموزشی-سایر")
            {
              //  SelectItem = objr.Where(u => u.TypeCaption == Event.TypeCaptionEvent.classlearnorkshop).ToList();
                categorytxtviewgroup.Text = StrValue;
            }
           // oi.PutExtra("Key", "کلاس های آموزشی-سایر");

            //فرهنگی هنری

            //
            if (StrValue == "فرهنگی هنری- نمایشگاه")
            {
                SelectItem = objr.Where(u => u.TypeCaption == Event.TypeCaptionEvent.cultrualExhibition).ToList();
                categorytxtviewgroup.Text = StrValue;
            }
            if (StrValue == "فرهنگی هنری-سینما")
            {
                SelectItem = objr.Where(u => u.TypeCaption == Event.TypeCaptionEvent.cultrualCinema).ToList();
                categorytxtviewgroup.Text = StrValue;
            }
            if (StrValue == "فرهنگی هنری-کنسرت")
            {
                SelectItem = objr.Where(u => u.TypeCaption == Event.TypeCaptionEvent.cultrualconcert).ToList();
                categorytxtviewgroup.Text = StrValue;
            }
            if (StrValue == "فرهنگی هنری-گالری")
            {
                SelectItem = objr.Where(u => u.TypeCaption == Event.TypeCaptionEvent.cultrualGallery).ToList();
                categorytxtviewgroup.Text = StrValue;
            }
            if (StrValue == "فرهنگی هنری-همایش ومراسم")
            {
                SelectItem = objr.Where(u => u.TypeCaption == Event.TypeCaptionEvent.cultrualcermoney).ToList();
                categorytxtviewgroup.Text = StrValue;
            }
            if (StrValue == "فرهنگی هنری-تیاتر")
            {
                SelectItem = objr.Where(u => u.TypeCaption == Event.TypeCaptionEvent.cultrualGravity).ToList();
                categorytxtviewgroup.Text = StrValue;
            }


            //سلامتی و زیبایی
            if (StrValue == "سلامتی و زیبایی- مشاوره")
            {
                SelectItem = objr.Where(u => u.TypeCaption == Event.TypeCaptionEvent.healthitemoTwo).ToList();
                categorytxtviewgroup.Text = StrValue;
            }
            if (StrValue == "سلامتی و زیبایی- آرایشگاه")
            {
                SelectItem = objr.Where(u => u.TypeCaption == Event.TypeCaptionEvent.healthitemone).ToList();
                categorytxtviewgroup.Text = StrValue;
            }


            //داوطلبانه و مردمی
          
            if (StrValue == "داوطلبانه و مردمی-نمایشگاه")
            {
                SelectItem = objr.Where(u => u.TypeCaption == Event.TypeCaptionEvent.popularexhibition).ToList();
                categorytxtviewgroup.Text = StrValue;
            }
            if (StrValue == "داوطلبانه و مردمی-خیریه و کمک رسانی")
            {
                SelectItem = objr.Where(u => u.TypeCaption == Event.TypeCaptionEvent.popularhelping).ToList();
                categorytxtviewgroup.Text = StrValue;
            }
            if (StrValue == "داوطلبانه و مردمی-گرد همایی")
            {
                SelectItem = objr.Where(u => u.TypeCaption == Event.TypeCaptionEvent.populargathering).ToList();
                categorytxtviewgroup.Text = StrValue;
            }

            //مذهبی
            if (StrValue == "مذهبی-نمایشگاه")
            {
                SelectItem = objr.Where(u => u.TypeCaption == Event.TypeCaptionEvent.religionexhibition).ToList();
                categorytxtviewgroup.Text = StrValue;
            }
            if (StrValue == "مذهبی-مراسم")
            {
                SelectItem = objr.Where(u => u.TypeCaption == Event.TypeCaptionEvent.religioncermoney).ToList();
                categorytxtviewgroup.Text = StrValue;
            }



            //ورزش و بازی
            if (StrValue == "ورزش و بازی-باشگاه ")
            {
                SelectItem = objr.Where(u => u.TypeCaption == Event.TypeCaptionEvent.sportclub).ToList();
                categorytxtviewgroup.Text = StrValue;
            }
            if (StrValue == "ورزش و بازی-گیم کلاب")
            {
                SelectItem = objr.Where(u => u.TypeCaption == Event.TypeCaptionEvent.sportgymclub).ToList();
                categorytxtviewgroup.Text = StrValue;
            }
            if (StrValue == "ورزش و بازی-ورزش های توپی")
            {
                SelectItem = objr.Where(u => u.TypeCaption == Event.TypeCaptionEvent.sportball).ToList();
                categorytxtviewgroup.Text = StrValue;
            }
            if (StrValue == "ورزش و بازی-ورزش های آبی")
            {
                SelectItem = objr.Where(u => u.TypeCaption == Event.TypeCaptionEvent.sportwater).ToList();
                categorytxtviewgroup.Text = StrValue;

            }
            if (StrValue == "ورزش و بازی-ورزش های رزمی")
            {
                SelectItem = objr.Where(u => u.TypeCaption == Event.TypeCaptionEvent.sportmartial).ToList(); categorytxtviewgroup.Text = StrValue;
            }


            //گردشگری و سرگرمی-تور
            if (StrValue == "گردشگری و سرگرمی-تور")
            {
                SelectItem = objr.Where(u => u.TypeCaption == Event.TypeCaptionEvent.tourismtour).ToList();
                categorytxtviewgroup.Text = StrValue;
            }
            if (StrValue == "گردشگری  و سرگرمی-جاذبه ها و مکان های تفریجی")
            {
                SelectItem = objr.Where(u => u.TypeCaption == Event.TypeCaptionEvent.tourismgravity).ToList();
                categorytxtviewgroup.Text = StrValue;
            }
            if (StrValue == "فروشگاه ها-پوشاک")
            {
                SelectItem = objr.Where(u => u.TypeCaption == Event.TypeCaptionEvent.storescloths).ToList();
                categorytxtviewgroup.Text = StrValue;
            }
            if (StrValue == "فروشگاه ها- کالای دیجیتال")
            {
                SelectItem = objr.Where(u => u.TypeCaption == Event.TypeCaptionEvent.StoresDigital).ToList();
                categorytxtviewgroup.Text = StrValue;
            }
            if (StrValue == "فروشگاه ها- مواد غدایی")
            {
                  SelectItem = objr.Where(u => u.TypeCaption == Event.TypeCaptionEvent.StoresFood).ToList();
                categorytxtviewgroup.Text = StrValue;
            }
            if (StrValue == "فروشگاه ها- آرایشی و بهداشتی")
            {
                  SelectItem = objr.Where(u => u.TypeCaption == Event.TypeCaptionEvent.StoresHealth).ToList();
                categorytxtviewgroup.Text = StrValue;
            }
        
            if (StrValue == "فروشگاه ها- سایر")
            {
              //  SelectItem = objr.Where(u => u.TypeCaption == Event.TypeCaptionEvent.StoresHealth).ToList();
                categorytxtviewgroup.Text = StrValue;
            }
            if (StrValue == "برنامه های تلوزیونی-زنده")
            {
                 SelectItem = objr.Where(u => u.TypeCaption == Event.TypeCaptionEvent.ProgramTvLive).ToList();
                categorytxtviewgroup.Text = StrValue;
            }
            if (StrValue == "برنامه های تلوزیونی- تازه ها")
            {
                  SelectItem = objr.Where(u => u.TypeCaption == Event.TypeCaptionEvent.ProgramTvRefresh).ToList();
                categorytxtviewgroup.Text = StrValue;
            }
            if (StrValue == "ببرنامه های تلوزیونی- پرطرفدار")
            {
                SelectItem = objr.Where(u => u.TypeCaption == Event.TypeCaptionEvent.ProgramTvPopular).ToList();
                categorytxtviewgroup.Text = StrValue;
            }
         
            if (SelectItem!=null)
            {
                MainShowEventAdapter t = new MainShowEventAdapter(this, SelectItem);
                categorylstevent.Adapter = t;
            }
    
      
          
         
         
            //  oi.PutExtra("Key", " برنامه های تلوزیونی- تازه ها");
            if (SelectItem.Count==0)
            {
                string ValueToast = "رویدادی ثبت نگردیده است";
                var toast=    Toast.MakeText(this, ValueToast, ToastLength.Long);
              
                toast.SetGravity(GravityFlags.Center, 0, 0);
                toast.Show();

            }

 
        }
    }
}