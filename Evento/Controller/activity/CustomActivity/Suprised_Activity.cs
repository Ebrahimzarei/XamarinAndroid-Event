using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using WebEventoo_DomainClasses.Model;
using Newtonsoft.Json;
using Evento.Model;
using System.Net.Http;
using System.Net.Http.Headers;
using Extensions;
using Evento.Adapter;

/// <summary>
/// رویداد های ویژه
/// </summary>
namespace Evento.Controller.activity.CustomActivity
{
    [Activity(Label = "Suprised_Activity")]
    public class Suprised_Activity : AppCompatActivity
    {
        Button Suprisedbtnenterevent;
        TextView Suprisedtxtviewcaption;
        ImageButton Suprisedimgbtnlogo;
        Button SuprisedbtnContact;
        Button Suprisedbtngift;
        Button SuprisedbtnSuprised;
        Button SuprisedbtngroupingGrouping;
        ListView SuprisedListView;
        List<Event> objr;
        List<Event> SelectItem;

        protected async override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.layoutSuprised);
            var font = Android.Graphics.Typeface.CreateFromAsset(Assets, "Estedad.ttf");
            Suprisedbtnenterevent = FindViewById<Button>(Resource.Id.Suprisedbtnenterevent);
            Suprisedbtnenterevent.Click += delegate { StartActivity(typeof(EnterEvent)); };
            Suprisedbtnenterevent.Typeface = font;
            Suprisedtxtviewcaption = FindViewById<TextView>(Resource.Id.Suprisedtxtviewcaption);
            Suprisedtxtviewcaption.Typeface = font;
            Suprisedimgbtnlogo = FindViewById<ImageButton>(Resource.Id.Suprisedimgbtnlogo);
            Suprisedimgbtnlogo.Click += delegate { StartActivity(typeof(MainActivity)); };
            SuprisedbtnContact = FindViewById<Button>(Resource.Id.SuprisedbtnContact);
            SuprisedbtnContact.Typeface = font;
            SuprisedbtnContact.Click += delegate { StartActivity(typeof(Account)); };
            Suprisedbtngift = FindViewById<Button>(Resource.Id.Suprisedbtngift);
            Suprisedbtngift.Typeface = font;
            Suprisedbtngift.Click += delegate { StartActivity(typeof(CustomActivity.Suprised_Activity)); };
            SuprisedbtnSuprised = FindViewById<Button>(Resource.Id.SuprisedbtnSuprised);
            SuprisedbtnSuprised.Typeface = font;
            SuprisedbtngroupingGrouping = FindViewById<Button>(Resource.Id.SuprisedbtngroupingGrouping);
            SuprisedListView = FindViewById<ListView>(Resource.Id.SuprisedListView);
            SuprisedbtngroupingGrouping.Typeface = font;
            SuprisedbtngroupingGrouping.Click += delegate
            {
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


                    SelectItem = objr.Where(u => u.Statusevent == Event.StatuseEvent.Special).ToList();

                }
                if (SelectItem != null)
                {
                    MainShowEventAdapter t = new MainShowEventAdapter(this, SelectItem);
                    SuprisedListView.Adapter = t;
                }
                if (SelectItem.Count == 0)
                {
                    string ValueToast = "رویدادی برای امروز ثبت نگردیده است";
                    var toast = Toast.MakeText(this, ValueToast, ToastLength.Long);

                    toast.SetGravity(GravityFlags.Center, 0, 0);
                    toast.Show();

                }
                //    Adapter.ClustomSuprised_Adapter cs = new Adapter.ClustomSuprised_Adapter(this, eventlist);
                //SuprisedListView.Adapter = cs;





                // Create your application here
            }


        }
    }
}