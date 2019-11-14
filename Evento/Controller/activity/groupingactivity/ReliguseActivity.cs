 

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
 
using Android.Widget;

namespace Evento.Controller.activity.groupingactivity
{
    //مذهبی
    [Activity(Label = "ReliguseActivity")]
    public class ReliguseActivity : Activity
    {
        ImageButton religiuseimgbtnlogo;
        TextView religiusetxtviewgroup;
        Button religiusebtnenterevent;

        Button religiusebtnnamayeshgah;
       
        Button religiusebtnlearning;


        Button religiusebtngroupingGrouping;
        Button religiusebtnEventDay;
        Button religiusebtngift;
        Button religiusebtnContact;
   
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            var font = Typeface.CreateFromAsset(Assets, "Estedad.ttf");
            SetContentView(Resource.Layout.layoutreligious);
            
            religiuseimgbtnlogo = FindViewById<ImageButton>(Resource.Id.religiuseimgbtnlogo);
            religiuseimgbtnlogo.Click += delegate { Finish(); };

            religiusetxtviewgroup = FindViewById<TextView>(Resource.Id.religiusetxtviewgroup);
            religiusetxtviewgroup.Typeface = font;

            religiusebtnenterevent = FindViewById<Button>(Resource.Id.religiusebtnenterevent);
            religiusebtnenterevent.Click += delegate { StartActivity(typeof(EnterEvent)); };
            religiusebtnenterevent.Typeface = font;


            religiusebtnnamayeshgah = FindViewById<Button>(Resource.Id.religiusebtnnamayeshgah);
            religiusebtnnamayeshgah.Typeface = font;
            religiusebtnnamayeshgah.Click += delegate {

                Intent oi = new Intent(this, typeof(CategoryEvent));
                oi.PutExtra("Key", "مذهبی-نمایشگاه");
                StartActivity(oi);
            };



            religiusebtnlearning = FindViewById<Button>(Resource.Id.religiusebtnlearning);
            religiusebtnlearning.Typeface = font;
            religiusebtnlearning.Click += delegate {

                Intent oi = new Intent(this, typeof(CategoryEvent));
                oi.PutExtra("Key", "مذهبی-مراسم");
                StartActivity(oi);

            };

            religiusebtngroupingGrouping = FindViewById<Button>(Resource.Id.religiusebtngroupingGrouping);
            religiusebtngroupingGrouping.Click += delegate { Finish(); StartActivity(typeof(Grouping)); };
            religiusebtngroupingGrouping.Typeface = font;

            religiusebtnEventDay = FindViewById<Button>(Resource.Id.religiusebtnEventDay);
            religiusebtnEventDay.Typeface = font;
            religiusebtnEventDay.Click += delegate { StartActivity(typeof(CustomActivity.EventDay_Activity)); };

            religiusebtngift = FindViewById<Button>(Resource.Id.religiusebtngift);
            religiusebtngift.Typeface = font;

            religiusebtngift.Click += delegate { StartActivity(typeof(CustomActivity.Suprised_Activity)); };

            religiusebtnContact = FindViewById<Button>(Resource.Id.religiusebtnContact);
            religiusebtnContact.Click += delegate {  StartActivity(typeof(Account)); };
            religiusebtnContact.Typeface = font;
        }
    }
}