using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Xml;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using Evento.Adapter;
using Evento.Model;
using Newtonsoft.Json;

namespace Evento.Controller.activity.CustomActivity
{
    [Activity(Label = "MarkedEvent_Activity")]
    public class MarkedEvent_Activity : AppCompatActivity
    {
        /// <summary>
        /// نشان شده ها
        /// </summary>
        Button MarkedEventbtnenterevent;
        TextView MarkedEventtxtviewcaption;
        ImageButton MarkedEventimgbtnlogo;
        Button MarkedEventbtnContact;
        Button MarkedEventbtngift;
        Button MarkedEventbtnMarkedEvent;
        Button MarkedEventbtngroupingGrouping;
        ListView MarkedEventListView;
        protected async override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.layout_MarkedEvent);
            var font = Android.Graphics.Typeface.CreateFromAsset(Assets, "Estedad.ttf");
            MarkedEventbtnenterevent = FindViewById<Button>(Resource.Id.MarkedEventbtnenterevent);
            MarkedEventbtnenterevent.Click += delegate { StartActivity(typeof(EnterEvent)); };
            MarkedEventbtnenterevent.Typeface = font;
            MarkedEventtxtviewcaption = FindViewById<TextView>(Resource.Id.MarkedEventtxtviewcaption);
            MarkedEventtxtviewcaption.Text = "نشان شده ها";
            MarkedEventtxtviewcaption.Typeface = font;
            MarkedEventimgbtnlogo = FindViewById<ImageButton>(Resource.Id.MarkedEventimgbtnlogo);
            MarkedEventimgbtnlogo.Click += delegate { StartActivity(typeof(MainActivity)); };
            MarkedEventbtnContact = FindViewById<Button>(Resource.Id.MarkedEventbtnContact);
            MarkedEventbtnContact.Typeface = font;
            MarkedEventbtnContact.Click += delegate { StartActivity(typeof(Account)); };
            MarkedEventbtngift = FindViewById<Button>(Resource.Id.MarkedEventbtngift);
            MarkedEventbtngift.Typeface = font;
            MarkedEventbtngift.Click += delegate { StartActivity(typeof(CustomActivity.Suprised_Activity)); };
            MarkedEventbtnMarkedEvent = FindViewById<Button>(Resource.Id.MarkedEventbtnMarkedEvent);
            MarkedEventbtnMarkedEvent.Typeface = font;
            MarkedEventbtngroupingGrouping = FindViewById<Button>(Resource.Id.MarkedEventbtngroupingGrouping);
            MarkedEventbtngroupingGrouping.Typeface = font;
            MarkedEventbtngroupingGrouping.Click += delegate {
                Intent oi = new Intent(this, typeof(Grouping));
                StartActivity(oi);
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
            using (HttpClient client = new HttpClient())
            {

                client.BaseAddress = new Uri(WebAddress.MyAddress);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                string json = JsonConvert.SerializeObject("", Newtonsoft.Json.Formatting.Indented);
                var httpContent = new StringContent(json);
                HttpResponseMessage response = client.PostAsync("api/GetEventsItems", httpContent).Result;
                if (response.IsSuccessStatusCode)
                {
                    response.EnsureSuccessStatusCode();
                    var responseJsonString = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject(responseJsonString).ToString();
                    List<WebEventoo_DomainClasses.Model.Event> objr = JsonConvert.DeserializeObject<List<WebEventoo_DomainClasses.Model.Event>>(result);
                    var SelectItem = objr.Where(u => u.Statusevent == WebEventoo_DomainClasses.Model.Event.StatuseEvent.Special).ToList();
                 //   MainShowEventAdapter t = new MainShowEventAdapter(this, SelectItem);
                    MarkedEventListView = FindViewById<ListView>(Resource.Id.MarkedEventListView);
                  //  MarkedEventListView.Adapter = t;
            


                }
            }

      
            MarkedEventListView.ItemClick += MarkedEventListView_ItemClick;
        }

        private void MarkedEventListView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
//انتخاب رویداد
            Intent oi = new Intent(this, typeof(SelectEvent));
            StartActivity(oi);
        }
    }
}