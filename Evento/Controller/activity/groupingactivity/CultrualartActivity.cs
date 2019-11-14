 

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
 
using Android.Widget;

namespace Evento.Controller.activity.groupingactivity
{
    [Activity(Label = "CultrualartActivity")]
    public class CultrualartActivity : Activity
    {
        ImageButton culturalimgbtnlogo;
        TextView culturaltxtviewgroup;
        Button culturalbtnenterevent;
        Button culturalbtnfarhangi;
        Button cultrulbtncinema;
        Button cultrualbtnconcert;
        Button cultrualbtngallery;
        Button cultrualbtnmarasem;
        Button cultrualbtnjazebe;
        Button cultrualbtnlearn;
         Button cultrualbtngroupingGrouping;
         Button cultrualbtnEventDay;
         Button cultrualbtngift;
         Button cultrualbtnContact;

        //فرهنگی هنری
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.layouartcultural);
            var font = Typeface.CreateFromAsset(Assets, "Estedad.ttf");
            

            culturalimgbtnlogo =FindViewById<ImageButton>(Resource.Id.culturalimgbtnlogo);
            culturalimgbtnlogo.Click += delegate {   StartActivity(typeof(MainActivity)); };

            culturaltxtviewgroup = FindViewById<TextView>(Resource.Id.culturaltxtviewgroup);
            culturaltxtviewgroup.Typeface = font;

             culturalbtnenterevent = FindViewById<Button>(Resource.Id.culturalbtnenterevent);
            culturalbtnenterevent.Click += delegate {  StartActivity(typeof(EnterEvent)); };
            culturalbtnenterevent.Typeface = font;


            culturalbtnfarhangi = FindViewById<Button>(Resource.Id.culturalbtnfarhangi);
            culturalbtnfarhangi.Typeface = font;
            culturalbtnfarhangi.Click += delegate {

                Intent oi = new Intent(this, typeof(CategoryEvent));
                oi.PutExtra("Key", "فرهنگی هنری- نمایشگاه");
              StartActivity(oi);

            };

            cultrulbtncinema = FindViewById<Button>(Resource.Id.cultrulbtncinema);
            cultrulbtncinema.Typeface = font;
            cultrulbtncinema.Click += delegate {

                Intent oi = new Intent(this, typeof(CategoryEvent));
                oi.PutExtra("Key","فرهنگی هنری-سینما");
                StartActivity(oi);

            };

            cultrualbtnconcert = FindViewById<Button>(Resource.Id.cultrualbtnconcert);
            cultrualbtnconcert.Typeface = font;
            cultrualbtnconcert.Click += delegate {

                Intent oi = new Intent(this, typeof(CategoryEvent));
                oi.PutExtra("Key", "فرهنگی هنری-کنسرت");
                StartActivity(oi);
            };

            cultrualbtngallery = FindViewById<Button>(Resource.Id.cultrualbtngallery);
            cultrualbtngallery.Typeface = font;
            cultrualbtngallery.Click += delegate {

                Intent oi = new Intent(this, typeof(CategoryEvent));
                oi.PutExtra("Key", "فرهنگی هنری-گالری");
                StartActivity(oi);
            };


            cultrualbtnmarasem = FindViewById<Button>(Resource.Id.cultrualbtnmarasem);
            cultrualbtnmarasem.Typeface = font;
            cultrualbtnmarasem.Click += delegate {
                Intent oi = new Intent(this, typeof(CategoryEvent));
                oi.PutExtra("Key", "فرهنگی هنری-همایش ومراسم");
                StartActivity(oi);


            };

            cultrualbtnjazebe = FindViewById<Button>(Resource.Id.cultrualbtnjazebe);
            cultrualbtnjazebe.Typeface = font;
            cultrualbtnjazebe.Click += delegate {

                Intent oi = new Intent(this, typeof(CategoryEvent));
                oi.PutExtra("Key", "فرهنگی هنری-تیاتر");
                StartActivity(oi);
            };


            cultrualbtngroupingGrouping = FindViewById<Button>(Resource.Id.cultrualbtngroupingGrouping);
            cultrualbtngroupingGrouping.Click += delegate {   StartActivity(typeof(Grouping)); };
            cultrualbtngroupingGrouping.Typeface = font;

            cultrualbtnEventDay = FindViewById<Button>(Resource.Id.cultrualbtnEventDay);
            cultrualbtnEventDay.Typeface = font;
            cultrualbtnEventDay.Click += delegate {

                StartActivity(typeof(CustomActivity.EventDay_Activity));
            };

            cultrualbtngift = FindViewById<Button>(Resource.Id.cultrualbtngift);
            cultrualbtngift.Typeface = font;
            cultrualbtngift.Click += delegate {

                StartActivity(typeof(CustomActivity.Suprised_Activity));
            };

            cultrualbtnContact = FindViewById<Button>(Resource.Id.cultrualbtnContact);
            cultrualbtnContact.Click += delegate {  StartActivity(typeof(Account)); };
            cultrualbtnContact.Typeface = font;

        }
    }
}