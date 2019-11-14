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
    [Activity(Label = "televisionactivity")]
    public class televisionactivity : Activity
    {
        Button tvbtnenterevent;
        TextView tvtxtheader;
        ImageButton tvimgbtnlogo;

        Button tvbtnContact;
        Button tvbtngift;
        Button tvbtnEventDay;
        Button tvbtngroupingGrouping;

        Button tvbtnpopular;
        Button tvbtnrefresh;
    

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activitytelevision);
            var font = Typeface.CreateFromAsset(Assets, "Estedad.ttf");



 

            tvbtnenterevent = FindViewById<Button>(Resource.Id.tvbtnenterevent);
            tvbtnenterevent.Typeface = font;
            tvbtnenterevent.Click += delegate { StartActivity(typeof(EnterEvent)); };
            tvtxtheader = FindViewById<TextView>(Resource.Id.tvtxtheader);
            tvtxtheader.Typeface = font;

            tvimgbtnlogo = FindViewById<ImageButton>(Resource.Id.tvimgbtnlogo);
            tvimgbtnlogo.Click += delegate { StartActivity(typeof(MainActivity)); };

 
           
         
        
            

            //  Button storebtngroupingGrouping;
            tvbtnContact = FindViewById<Button>(Resource.Id.tvbtnContact);
            tvbtnContact.Click += delegate { StartActivity(typeof(Account)); };
            tvbtnContact.Typeface = font;
            tvbtngift = FindViewById<Button>(Resource.Id.tvbtngift);
            tvbtngift.Click += delegate { StartActivity(typeof(Suprised_Activity)); };
            tvbtngift.Typeface = font;
            tvbtnEventDay = FindViewById<Button>(Resource.Id.tvbtnEventDay);
            tvbtnEventDay.Click += delegate { StartActivity(typeof(EventDay_Activity)); };
            tvbtnEventDay.Typeface = font;



            tvbtngroupingGrouping = FindViewById<Button>(Resource.Id.tvbtngroupingGrouping);
            tvbtngroupingGrouping.Typeface = font;
            tvbtngroupingGrouping.Click += delegate { StartActivity(typeof(Grouping)); };

            Button tvbtnpopular;
            Button tvbtnrefresh;



            tvbtnpopular = FindViewById<Button>(Resource.Id.tvbtnpopular);
            tvbtnpopular.Typeface = font;
            tvbtnpopular.Click += delegate
            {

                Intent oi = new Intent(this, typeof(CategoryEvent));
                oi.PutExtra("Key", " برنامه های تلوزیونی- پرطرفدار");
                StartActivity(oi);

            };
            Button tvbtnlive;
            tvbtnlive = FindViewById<Button>(Resource.Id.tvbtnlive);
            tvbtnlive.Typeface = font;
            tvbtnlive.Click += delegate
            {

                Intent oi = new Intent(this, typeof(CategoryEvent));
                oi.PutExtra("Key", " برنامه های تلوزیونی-زنده");
                StartActivity(oi);

            };
            tvbtnrefresh = FindViewById<Button>(Resource.Id.tvbtnrefresh);
            tvbtnrefresh.Typeface = font;
            tvbtnrefresh.Click += delegate
            {

                Intent oi = new Intent(this, typeof(CategoryEvent));
                oi.PutExtra("Key", " برنامه های تلوزیونی- تازه ها");
                StartActivity(oi);

            };

        


           
        }
    }
}