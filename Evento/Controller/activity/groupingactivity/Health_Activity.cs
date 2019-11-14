using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Evento.Controller.activity.CustomActivity;

namespace Evento.Controller.activity.groupingactivity
{
    [Activity(Label = "Health_Activity")]
    public class Health_Activity : Activity
    {
        Button healthsbtnenterevent;
        TextView healthstxtviewcaption;
        ImageButton healthsimgbtnlogo;

        Button healthsbtnContact;
        Button healthsbtngift;
        Button healthsbtnEventDay;
        Button healthsbtngroupingGrouping;

        Button healthbarbare;
        Button healthbuttonmoshavere;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.layout_health);
            var font = Typeface.CreateFromAsset(Assets, "Estedad.ttf");
            healthsbtnenterevent = FindViewById<Button>(Resource.Id.healthbtnenterevent);
            healthsbtnenterevent.Typeface = font;
            healthsbtnenterevent.Click += delegate { StartActivity(typeof(EnterEvent)); };
            healthstxtviewcaption = FindViewById<TextView>(Resource.Id.healthtxtviewgroup);
            healthstxtviewcaption.Typeface = font;
            healthsbtnenterevent.Typeface = font;
            healthsimgbtnlogo = FindViewById<ImageButton>(Resource.Id.healthimgbtnlogo);
            healthsimgbtnlogo.Click += delegate { StartActivity(typeof(MainActivity)); };

            healthsbtnContact = FindViewById<Button>(Resource.Id.healthbtnContact);
            healthsbtnContact.Click += delegate { StartActivity(typeof(Account)); };
            healthsbtnContact.Typeface = font;
            healthsbtngift = FindViewById<Button>(Resource.Id.healthbtngift);
            healthsbtngift.Click += delegate { StartActivity(typeof(Suprised_Activity)); };
            healthsbtngift.Typeface = font;
            healthsbtnEventDay = FindViewById<Button>(Resource.Id.healthbtnEventDay);
            healthsbtnEventDay.Click += delegate { StartActivity(typeof(EventDay_Activity)); };
            healthsbtnEventDay.Typeface = font;
            healthsbtngroupingGrouping = FindViewById<Button>(Resource.Id.healthbtngroupingGrouping);
            healthsbtngroupingGrouping.Typeface = font;
            healthsbtngroupingGrouping.Click += delegate { StartActivity(typeof(Grouping)); };
            healthsbtnenterevent.Typeface = font;
             healthbuttonmoshavere = FindViewById<Button>(Resource.Id.healthbuttonmoshavere);
            healthbuttonmoshavere.Typeface = font;
            healthbuttonmoshavere.Click += delegate {

                Intent oi = new Intent(this, typeof(CategoryEvent));
                oi.PutExtra("Key", "سلامتی و زیبایی- مشاوره");
                StartActivity(oi);

            };


            healthbarbare = FindViewById<Button>(Resource.Id.healthbarbare);
            healthbarbare.Click += delegate {
                Intent oi = new Intent(this, typeof(CategoryEvent));
                oi.PutExtra("Key", "سلامتی و زیبایی- آرایشگاه");
                StartActivity(oi);


            };
            healthbarbare.Typeface = font;
            // Create your application here
        }
    }
}