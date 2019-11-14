using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using Evento.Model;
using Newtonsoft.Json;
using WebEventoo_DomainClasses.Model;
using Extensions;
using Evento.Adapter;

namespace Evento.Controller.activity.CustomActivity
{
    [Activity(Label = "EventDay_Activity")]
    public class EventDay_Activity : AppCompatActivity
    {
        Button EventtDaybtnenterevent;
        TextView EventDaytxtviewcaption;
        ImageButton EventDayimgbtnlogo;
        Button EventDaybtnContact;
        Button EventDaybtngift;
        Button EventDaybtnEventDay;
        Button EventDaybtngroupingGrouping;
        ListView EventDayListView;
        List<Event> objr;
        List<Event> SelectItem;
        protected async override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.layoutEventDay);
            var font = Android.Graphics.Typeface.CreateFromAsset(Assets, "Estedad.ttf");
            EventtDaybtnenterevent = FindViewById<Button>(Resource.Id.EventtDaybtnenterevent);
            EventtDaybtnenterevent.Click += delegate { StartActivity(typeof(EnterEvent)); };
            EventtDaybtnenterevent.Typeface = font;
              EventDaytxtviewcaption = FindViewById<TextView>(Resource.Id.EventDaytxtviewcaption);
            EventDaytxtviewcaption.Typeface = font;
              EventDayimgbtnlogo = FindViewById<ImageButton>(Resource.Id.EventDayimgbtnlogo);
            EventDayimgbtnlogo.Click += delegate { StartActivity(typeof(MainActivity)); };
              EventDaybtnContact = FindViewById<Button>(Resource.Id.EventDaybtnContact);
            EventDaybtnContact.Typeface = font;
            EventDaybtnContact.Click += delegate { StartActivity(typeof(Account)); };
              EventDaybtngift = FindViewById<Button>(Resource.Id.EventDaybtngift);
            EventDaybtngift.Typeface = font;
            EventDaybtngift.Click += delegate { StartActivity(typeof(CustomActivity.Suprised_Activity)); };
              EventDaybtnEventDay = FindViewById<Button>(Resource.Id.EventDaybtnEventDay);
            EventDaybtnEventDay.Typeface = font;

            EventDaybtngroupingGrouping = FindViewById<Button>(Resource.Id.EventDaybtngroupingGrouping);
            EventDaybtngroupingGrouping.Typeface = font;
            EventDaybtngroupingGrouping.Click += delegate {
                Intent oi = new Intent(this, typeof(Grouping));
                StartActivity(oi);
            };
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


                    SelectItem = objr.Where(u => u.FromDate == DateTime.Now.ToPersianDateString()).ToList();

                }
                if (SelectItem != null)
                {
                    MainShowEventAdapter t = new MainShowEventAdapter(this, SelectItem);
                    EventDayListView.Adapter = t;
                }
                if (SelectItem.Count == 0)
                {
                    string ValueToast = "رویدادی برای امروز ثبت نگردیده است";
                    var toast = Toast.MakeText(this, ValueToast, ToastLength.Long);

                    toast.SetGravity(GravityFlags.Center, 0, 0);
                    toast.Show();

                }
            }


            //  EventDayListView.Adapter = cs;


            // Create your application here
        }

     
    }
}