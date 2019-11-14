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
    [Activity(Label = "store_activity")]
    public class store_activity : Activity
    {
        Button storebtnenterevent;
        TextView storetxtheader;
        ImageButton storeimgbtnlogo;

        Button storebtnContact;
        Button storebtngift;
        Button storebtnEventDay;
        Button storebtngroupingGrouping;

        Button storebtnclothing;
        Button storebtndigital;
        Button storebtnfood;
        Button storebtnbarber;
        Button storebtnother;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activitystore);
            var font = Typeface.CreateFromAsset(Assets, "Estedad.ttf");







            storebtnenterevent = FindViewById<Button>(Resource.Id.storebtnenterevent);
            storebtnenterevent.Typeface = font;
            storebtnenterevent.Click += delegate { StartActivity(typeof(EnterEvent)); };
            storetxtheader = FindViewById<TextView>(Resource.Id.storetxtheader);
            storetxtheader.Typeface = font;

            storeimgbtnlogo = FindViewById<ImageButton>(Resource.Id.storeimgbtnlogo);
            storeimgbtnlogo.Click += delegate { StartActivity(typeof(MainActivity)); };
            storebtnother = FindViewById<Button>(Resource.Id.storebtnother);
            storebtnother.Typeface = font;



            //  Button storebtngroupingGrouping;
            storebtnContact = FindViewById<Button>(Resource.Id.storebtnContact);
            storebtnContact.Click += delegate { StartActivity(typeof(Account)); };
            storebtnContact.Typeface = font;
            storebtngift = FindViewById<Button>(Resource.Id.storebtngift);
            storebtngift.Click += delegate { StartActivity(typeof(Suprised_Activity)); };
            storebtngift.Typeface = font;
            storebtnEventDay = FindViewById<Button>(Resource.Id.storebtnEventDay);
            storebtnEventDay.Click += delegate { StartActivity(typeof(EventDay_Activity)); };
            storebtnEventDay.Typeface = font;

            storebtnother = FindViewById<Button>(Resource.Id.storebtnother);
            storebtnother.Typeface = font;

            storebtngroupingGrouping = FindViewById<Button>(Resource.Id.storebtngroupingGrouping);
            storebtngroupingGrouping.Typeface = font;
            storebtngroupingGrouping.Click += delegate { StartActivity(typeof(Grouping)); };





            storebtnbarber = FindViewById<Button>(Resource.Id.storebtnbarber);
            storebtnbarber.Typeface = font;
            storebtnbarber.Click += delegate
            {

                Intent oi = new Intent(this, typeof(CategoryEvent));
                oi.PutExtra("Key", "  فروشگاه ها- آرایشی و بهداشتی");
                StartActivity(oi);

            };


            storebtnfood = FindViewById<Button>(Resource.Id.storebtnfood);
            storebtnfood.Typeface = font;
            storebtnfood.Click += delegate
            {

                Intent oi = new Intent(this, typeof(CategoryEvent));
                oi.PutExtra("Key", "فروشگاه ها- مواد غدایی");
                StartActivity(oi);

            };

            storebtnclothing = FindViewById<Button>(Resource.Id.storebtnclothing);
            storebtnclothing.Typeface = font;
            storebtnclothing.Click += delegate
            {

                Intent oi = new Intent(this, typeof(CategoryEvent));
                oi.PutExtra("Key", "فروشگاه ها-پوشاک");
                StartActivity(oi);

            };


            storebtndigital = FindViewById<Button>(Resource.Id.storebtndigital);
            storebtndigital.Click += delegate
            {
                Intent oi = new Intent(this, typeof(CategoryEvent));
                oi.PutExtra("Key", "فروشگاه ها- کالای دیجیتال");
                StartActivity(oi);


            };
            storebtnother.Click += delegate
            {
                Intent oi = new Intent(this, typeof(CategoryEvent));
                oi.PutExtra("Key", "فروشگاه ها- سایر");
                StartActivity(oi);


            };
            storebtndigital.Typeface = font;
            // Create your application here
        }
    }
}