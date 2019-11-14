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

namespace Evento.Controller.activity.MyEventActivity

{
    /// <summary>
    /// رویداد های من
    /// </summary>
    [Activity(Label = "@string/app_name", Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class MyeventActivity : AppCompatActivity
    {

        Button Myeventbtnenterevent;
        TextView Myeventxtviewgroup;
        ImageButton Myeventimgbtnlogo;
        ListView myeventlstview;

        Button MyeventbtnContact;
        Button Myeventbtngift;
        Button MyeventbtnEventDay;
        Button MyeventbtngroupingGrouping;

        Typeface font;
        protected async override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.layoutMyEvent);
            myeventlstview = FindViewById<ListView>(Resource.Id.myeventlstview);
           

            font = Typeface.CreateFromAsset(Assets, "Estedad.ttf");
           
            Myeventbtnenterevent =  FindViewById<Button>(Resource.Id.Myeventbtnenterevent);
            Myeventbtnenterevent.Typeface = font;

            Myeventbtnenterevent.Click += delegate
            {
                Intent oi = new Intent(this, typeof(EnterEvent));
                StartActivity(oi);
            };
          Myeventxtviewgroup = FindViewById<TextView>(Resource.Id.Myeventxtviewgroup);
            Myeventxtviewgroup.Typeface = font;

             Myeventimgbtnlogo=FindViewById<ImageButton>(Resource.Id.Myeventimgbtnlogo);
            Myeventimgbtnlogo.Click += delegate {
                Finish();
                Intent om = new Intent(this, typeof(MainActivity));
                StartActivity(om);
            };

             MyeventbtnContact= FindViewById<Button>(Resource.Id.MyeventbtnContact);
            MyeventbtnContact.Typeface = font;
            MyeventbtnContact.Click += delegate {
            
                Intent oa = new Intent(this, typeof(Account));
                StartActivity(oa);
            };
             Myeventbtngift =  FindViewById<Button>(Resource.Id.Myeventbtngift);
            Myeventbtngift.Typeface = font;

             MyeventbtnEventDay =  FindViewById<Button>(Resource.Id.MyeventbtnEventDay);
            MyeventbtnEventDay.Typeface = font;
            MyeventbtnEventDay.Click += delegate { };
             MyeventbtngroupingGrouping =FindViewById<Button>(Resource.Id.MyeventbtngroupingGrouping);
            MyeventbtngroupingGrouping.Typeface = font;
            MyeventbtngroupingGrouping.Click += delegate {

              
                Intent oa = new Intent(this, typeof(Grouping));
                StartActivity(oa);
            };


           
            List<Model.ItemEvent> eventlist = new List<Model.ItemEvent>() {
        new Model.ItemEvent() { id = 1, caption = "مسابقه کشتی",Placeevebt="ورزشی_مسابقه",category="شیراز زرهی",Timeevent="از 22اردیبهشت تا 25خرداد",Cost="5000" } ,
         new Model.ItemEvent() { id = 1, caption = "مسابقه کشتی",Placeevebt="ورزشی_مسابقه",category="شیراز زرهی",Timeevent="از 22اردیبهشت تا 25خرداد",Cost="5000" } ,
  new Model.ItemEvent() { id = 1, caption = "مسابقه کشتی",Placeevebt="ورزشی_مسابقه",category="شیراز زرهی",Timeevent="از 22اردیبهشت تا 25خرداد",Cost="5000" } ,
            new Model.ItemEvent() { id = 1, caption = "مسابقه کشتی",Placeevebt="ورزشی_مسابقه",category="شیراز زرهی",Timeevent="از 22اردیبهشت تا 25خرداد",Cost="5000" } ,

             //
  new Model.ItemEvent() { id = 1, caption = "مسابقه کشتی",Placeevebt="ورزشی_مسابقه",category="شیراز زرهی",Timeevent="از 22اردیبهشت تا 25خرداد",Cost=" 5000" } ,
  new Model.ItemEvent() { id = 1, caption = "مسابقه کشتی",Placeevebt="ورزشی_مسابقه",category="شیراز زرهی",Timeevent="از 22اردیبهشت تا 25خرداد",Cost=" 5000" } ,
  new Model.ItemEvent() { id = 1, caption = "مسابقه کشتی",Placeevebt="ورزشی_مسابقه",category="شیراز زرهی",Timeevent="از 22اردیبهشت تا 25خرداد",Cost=" 5000,00" } ,
   new Model.ItemEvent() { id = 1, caption = "مسابقه کشتی",Placeevebt="ورزشی_مسابقه",category="شیراز زرهی",Timeevent="از 22اردیبهشت تا 25خرداد",Cost=" 5000" } ,
   //
  new Model.ItemEvent() { id = 1, caption = "مسابقه کشتی",Placeevebt="ورزشی_مسابقه",category="شیراز زرهی",Timeevent="از 22اردیبهشت تا 25خرداد",Cost=" 5000" } ,
  new Model.ItemEvent() { id = 1, caption = "مسابقه کشتی",Placeevebt="ورزشی_مسابقه",category="شیراز زرهی",Timeevent="از 22اردیبهشت تا 25خرداد",Cost=" 5000" } ,
  new Model.ItemEvent() { id = 1, caption = "مسابقه کشتی",Placeevebt="ورزشی_مسابقه",category="شیراز زرهی",Timeevent="از 22اردیبهشت تا 25خرداد",Cost=" 5000" } ,
   new Model.ItemEvent() { id = 1, caption = "مسابقه کشتی",Placeevebt="ورزشی_مسابقه",category="شیراز زرهی",Timeevent="از 22اردیبهشت تا 25خرداد",Cost=" 5000" } ,
 new Model.ItemEvent() { id = 1, caption = "مسابقه کشتی",Placeevebt="ورزشی_مسابقه",category="شیراز زرهی",Timeevent="از 22اردیبهشت تا 25خرداد",Cost=" 5000" } ,
  new Model.ItemEvent() { id = 1, caption = "مسابقه کشتی",Placeevebt="ورزشی_مسابقه",category="شیراز زرهی",Timeevent="از 22اردیبهشت تا 25خرداد",Cost=" 5000" } ,
  new Model.ItemEvent() { id = 1, caption = "مسابقه کشتی",Placeevebt="ورزشی_مسابقه",category="شیراز زرهی",Timeevent="از 22اردیبهشت تا 25خرداد",Cost=" 5000" } ,
   new Model.ItemEvent() { id = 1, caption = "مسابقه کشتی",Placeevebt="ورزشی_مسابقه",category="شیراز زرهی",Timeevent="از 22اردیبهشت تا 25خرداد",Cost=" 5000" } ,
             //
   new Model.ItemEvent() { id = 1, caption = "مسابقه کشتی",Placeevebt="ورزشی_مسابقه",category="شیراز زرهی",Timeevent="از 22اردیبهشت تا 25خرداد",Cost=" 5000" } ,
  new Model.ItemEvent() { id = 1, caption = "مسابقه کشتی",Placeevebt="ورزشی_مسابقه",category="شیراز زرهی",Timeevent="از 22اردیبهشت تا 25خرداد",Cost=" 5000" } ,
  new Model.ItemEvent() { id = 1, caption = "مسابقه کشتی",Placeevebt="ورزشی_مسابقه",category="شیراز زرهی",Timeevent="از 22اردیبهشت تا 25خرداد",Cost=" 5000" } ,
   new Model.ItemEvent() { id = 1, caption = "مسابقه کشتی",Placeevebt="ورزشی_مسابقه",category="شیراز زرهی",Timeevent="از 22اردیبهشت تا 25خرداد",Cost=" 5000" } ,
 new Model.ItemEvent() { id = 1, caption = "مسابقه کشتی",Placeevebt="ورزشی_مسابقه",category="شیراز زرهی",Timeevent="از 22اردیبهشت تا 25خرداد",Cost=" 5000" } ,
  new Model.ItemEvent() { id = 1, caption = "مسابقه کشتی",Placeevebt="ورزشی_مسابقه",category="شیراز زرهی",Timeevent="از 22اردیبهشت تا 25خرداد",Cost=" 5000" } ,

             //
  new Model.ItemEvent() { id = 1, caption = "مسابقه کشتی",Placeevebt="ورزشی_مسابقه",category="شیراز زرهی",Timeevent="از 22اردیبهشت تا 25خرداد",Cost=" 5000" } ,
  new Model.ItemEvent() { id = 1, caption = "مسابقه کشتی",Placeevebt="ورزشی_مسابقه",category="شیراز زرهی",Timeevent="از 22اردیبهشت تا 25خرداد",Cost=" 5000" } ,
  new Model.ItemEvent() { id = 1, caption = "مسابقه کشتی",Placeevebt="ورزشی_مسابقه",category="شیراز زرهی",Timeevent="از 22اردیبهشت تا 25خرداد",Cost=" 5000" } ,
   new Model.ItemEvent() { id = 1, caption = "مسابقه کشتی",Placeevebt="ورزشی_مسابقه",category="شیراز زرهی",Timeevent="از 22اردیبهشت تا 25خرداد",Cost=" 5000" } ,
 new Model.ItemEvent() { id = 1, caption = "مسابقه کشتی",Placeevebt="ورزشی_مسابقه",category="شیراز زرهی",Timeevent="از 22اردیبهشت تا 25خرداد",Cost=" 5000" } ,
  new Model.ItemEvent() { id = 1, caption = "مسابقه کشتی",Placeevebt="ورزشی_مسابقه",category="شیراز زرهی",Timeevent="از 22اردیبهشت تا 25خرداد",Cost=" 5000" } ,
             //
   new Model.ItemEvent() { id = 1, caption = "مسابقه کشتی",Placeevebt="ورزشی_مسابقه",category="شیراز زرهی",Timeevent="از 22اردیبهشت تا 25خرداد",Cost=" 5000" } ,
  new Model.ItemEvent() { id = 1, caption = "مسابقه کشتی",Placeevebt="ورزشی_مسابقه",category="شیراز زرهی",Timeevent="از 22اردیبهشت تا 25خرداد",Cost=" 5000" } ,
  new Model.ItemEvent() { id = 1, caption = "مسابقه کشتی",Placeevebt="ورزشی_مسابقه",category="شیراز زرهی",Timeevent="از 22اردیبهشت تا 25خرداد",Cost=" 5000" } ,
   new Model.ItemEvent() { id = 1, caption = "مسابقه کشتی",Placeevebt="ورزشی_مسابقه",category="شیراز زرهی",Timeevent="از 22اردیبهشت تا 25خرداد",Cost=" 5000" } ,
 new Model.ItemEvent() { id = 1, caption = "مسابقه کشتی",Placeevebt="ورزشی_مسابقه",category="شیراز زرهی",Timeevent="از 22اردیبهشت تا 25خرداد",Cost=" 5000" } ,
  new Model.ItemEvent() { id = 1, caption = "مسابقه کشتی",Placeevebt="ورزشی_مسابقه",category="شیراز زرهی",Timeevent="از 22اردیبهشت تا 25خرداد",Cost=" 5000" } ,

    };
            //using (HttpClient client = new HttpClient())
            //{

            //    client.BaseAddress = new Uri(WebAddress.MyAddress);
            //    client.DefaultRequestHeaders.Accept.Clear();
            //    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //    string json = JsonConvert.SerializeObject("", Formatting.Indented);
            //    var httpContent = new StringContent(json);
            //    HttpResponseMessage response = client.PostAsync("api/GetEventsItems", httpContent).Result;
            //    if (response.IsSuccessStatusCode)
            //    {
            //        response.EnsureSuccessStatusCode();
            //        var responseJsonString = await response.Content.ReadAsStringAsync();
            //        var result = JsonConvert.DeserializeObject(responseJsonString).ToString();
            //        List<WebEventoo_DomainClasses.Model.Event> objr = JsonConvert.DeserializeObject<List<WebEventoo_DomainClasses.Model.Event>>(result);
            //        var SelectItem = objr.Where(u => u.Statusevent == WebEventoo_DomainClasses.Model.Event.StatuseEvent.Published).ToList();
            //        MainShowEventAdapter t = new MainShowEventAdapter(this, SelectItem);
            //        myeventlstview.Adapter = t;


            //    }
            //}
        
            myeventlstview.ItemClick += Myeventlstview_ItemClick; ;

        }

        private void Myeventlstview_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {

            Intent om = new Intent(this, typeof(MyEventManagmnetActivity));
            StartActivity(om);
        }
    }
}