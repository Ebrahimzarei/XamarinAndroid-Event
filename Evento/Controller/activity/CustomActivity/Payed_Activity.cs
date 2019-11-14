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

namespace Evento.Controller.activity.CustomActivity
{
    [Activity(Label = "Payed_Activity")]
    public class Payed_Activity : AppCompatActivity
    {
        Button Payedbtnenterevent;
        TextView Payedtxtviewcaption;
        ImageButton Payedimgbtnlogo;
        Button PayedbtnContact;
        Button Payedbtngift;
        Button PayedbtnPayed;
        Button PayedbtngroupingGrouping;
        ListView PayedListView;
        protected   override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.layoutPayed);
            var font = Android.Graphics.Typeface.CreateFromAsset(Assets, "Estedad.ttf");
           Payedbtnenterevent = FindViewById<Button>(Resource.Id.Payedbtnenterevent);
           Payedbtnenterevent.Click += delegate { StartActivity(typeof(EnterEvent)); };
            Payedbtnenterevent.Typeface = font;
            Payedtxtviewcaption = FindViewById<TextView>(Resource.Id.Payedtxtviewcaption);
            Payedtxtviewcaption.Typeface = font;
            Payedimgbtnlogo = FindViewById<ImageButton>(Resource.Id.Payedimgbtnlogo);
            Payedimgbtnlogo.Click += delegate { StartActivity(typeof(MainActivity)); };
            PayedbtnContact = FindViewById<Button>(Resource.Id.PayedbtnContact);
            PayedbtnContact.Typeface = font;
            PayedbtnContact.Click += delegate { StartActivity(typeof(Account)); };
            Payedbtngift = FindViewById<Button>(Resource.Id.Payedbtngift);
            Payedbtngift.Typeface = font;
            Payedbtngift.Click += delegate { StartActivity(typeof(CustomActivity.Suprised_Activity)); };
            PayedbtnPayed = FindViewById<Button>(Resource.Id.PayedbtnPayed);
            PayedbtnPayed.Typeface = font;
            PayedbtngroupingGrouping = FindViewById<Button>(Resource.Id.PayedbtngroupingGrouping);
            PayedbtngroupingGrouping.Typeface = font;
            PayedbtngroupingGrouping.Click += delegate {
                Intent oi = new Intent(this, typeof(Grouping));
                StartActivity(oi);
            };
            PayedListView = FindViewById<ListView>(Resource.Id.PayedListView);
            List<Model.TestPayed> Payed = new List<Model.TestPayed>()
           {
               new Model.TestPayed{Id=1,Number=5000, Price=5000,StatusePayed="پرداخت شده"},
                   new Model.TestPayed{Id=1,Number=6000, Price=5000,StatusePayed="پرداخت شده"},
                      new Model.TestPayed{Id=1,Number=8000, Price=5000,StatusePayed="پرداخت شده"},
                         new Model.TestPayed{Id=1,Number=9000, Price=5000,StatusePayed="پرداخت شده"},
            };
            Adapter.CustomPayed_Adapter pa = new Adapter.CustomPayed_Adapter(this, Payed);
            PayedListView.Adapter = pa;
            // Create your application here
        }
    }
}