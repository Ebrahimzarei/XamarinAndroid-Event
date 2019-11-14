 

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
 
using Android.Widget;

namespace Evento.Controller.activity.groupingactivity
{
    [Activity(Label = "SportActivity")]
    public class SportActivity : Activity
    {
        ImageButton sportimgbtnlogo;
        TextView sporttxtviewcaption;
        Button sportbtnenterevent;

        Button sportbtntiatr;
        Button sportbtnnamayeshgah;
        Button sportbtnmosabeghe;
        Button sportbtnhamayesh;
          Button sportbtnlearning;
        readonly Button sportbtnamaken;

        Button sportbtngroupingGrouping;
        Button sportbtnEventDay;
        Button sportbtngift;
        Button sportbtnContact;
        //ورزش و بازی
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.layoutsport);
            var font = Typeface.CreateFromAsset(Assets, "Estedad.ttf");
           

            sportimgbtnlogo = FindViewById<ImageButton>(Resource.Id.sportimgbtnlogo);
            sportimgbtnlogo.Click += delegate { Finish();   };

            sporttxtviewcaption = FindViewById<TextView>(Resource.Id.sporttxtviewcaption);
            sporttxtviewcaption.Typeface = font;

            sportbtnenterevent = FindViewById<Button>(Resource.Id.sportbtnenterevent);
            sportbtnenterevent.Click += delegate {   StartActivity(typeof(EnterEvent)); };
            sportbtnenterevent.Typeface = font;


            sportbtntiatr = FindViewById<Button>(Resource.Id.sportbtntiatr);
            sportbtntiatr.Typeface = font;
            sportbtntiatr.Click += delegate {
                Intent oi = new Intent(this, typeof(CategoryEvent));
                oi.PutExtra("Id", "ورزش و بازی-باشگاه ");
                StartActivity(oi);


            };

            sportbtnnamayeshgah = FindViewById<Button>(Resource.Id.sportbtnnamayeshgah);
            sportbtnnamayeshgah.Typeface = font;
            sportbtnnamayeshgah.Click += delegate {
                Intent oi = new Intent(this, typeof(CategoryEvent));
                oi.PutExtra("Id", "ورزش و بازی-گیم کلاب");
                StartActivity(oi);

            };

            sportbtnmosabeghe = FindViewById<Button>(Resource.Id.sportbtnmosabeghe);
            sportbtnmosabeghe.Typeface = font;
            sportbtnmosabeghe.Click += delegate {
                Intent oi = new Intent(this, typeof(CategoryEvent));
                oi.PutExtra("Id", "ورزش و بازی-ورزش های توپی");
                StartActivity(oi);

            };

            sportbtnhamayesh = FindViewById<Button>(Resource.Id.sportbtnhamayesh);
            sportbtnhamayesh.Typeface = font;
            sportbtnhamayesh.Click += delegate {

                Intent oi = new Intent(this, typeof(CategoryEvent));
                oi.PutExtra("Id", "ورزش و بازی-ورزش های آبی");
                StartActivity(oi);
            };

            sportbtnlearning = FindViewById<Button>(Resource.Id.sportbtnlearning);
            sportbtnlearning.Typeface = font;
            sportbtnlearning.Click += delegate {

                Intent oi = new Intent(this, typeof(CategoryEvent));
                oi.PutExtra("Id", "ورزش و بازی-ورزش های رزمی");
                StartActivity(oi);
            };






            sportbtngroupingGrouping = FindViewById<Button>(Resource.Id.sportbtngroupingGrouping);
            sportbtngroupingGrouping.Click += delegate { Finish(); StartActivity(typeof(Grouping)); };
            sportbtngroupingGrouping.Typeface = font;

            sportbtnEventDay = FindViewById<Button>(Resource.Id.sportbtnEventDay);
            sportbtnEventDay.Typeface = font;
            sportbtnEventDay.Click += delegate { StartActivity(typeof(CustomActivity.EventDay_Activity)); };
            sportbtngift = FindViewById<Button>(Resource.Id.sportbtngift);
            sportbtngift.Typeface = font;
            sportbtngift.Click += delegate { StartActivity(typeof(CustomActivity.Suprised_Activity)); };

            sportbtnContact = FindViewById<Button>(Resource.Id.sportbtnContact);
            sportbtnContact.Click += delegate {  StartActivity(typeof(Account)); };
            sportbtnContact.Typeface = font;

        }
    }
}