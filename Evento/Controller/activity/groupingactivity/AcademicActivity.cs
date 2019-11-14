 

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
 
using Android.Widget;

namespace Evento.Controller.activity.groupingactivity
{
    [Activity(Label = "AcademicActivity")]
    public class AcademicActivity : Activity
    {
        ImageButton academicimgbtnlogo;
        TextView academictxtviewgroup;
        Button academicbtnenterevent;

        Button academicbtnnamayeshgah;
        Button academicbtnhamayesh;
        Button academicbtnkargah;
        

        Button academicbtngroupingGrouping;
        Button academicbtnEventDay;
        Button academicbtngift;
        Button academicbtnContact;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            //علمی و تخصصی
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.layoutacademic);
            var font = Typeface.CreateFromAsset(Assets, "Estedad.ttf");
           

            academicimgbtnlogo = FindViewById<ImageButton>(Resource.Id.academicimgbtnlogo);
            academicimgbtnlogo.Click += delegate { Finish(); };

            academictxtviewgroup = FindViewById<TextView>(Resource.Id.academictxtviewgroup);
            academictxtviewgroup.Typeface = font;

            academicbtnenterevent = FindViewById<Button>(Resource.Id.academicbtnenterevent);
            academicbtnenterevent.Click += delegate { StartActivity(typeof(EnterEvent)); };
            academicbtnenterevent.Typeface = font;


            academicbtnnamayeshgah = FindViewById<Button>(Resource.Id.academicbtnnamayeshgah);
            academicbtnnamayeshgah.Typeface = font;
            academicbtnnamayeshgah.Click += delegate
            {
                Intent oi = new Intent(this, typeof(CategoryEvent));
                oi.PutExtra("Key", "علمی و تخصصی-نمایشگاه");

                StartActivity(oi);


            };


            academicbtnhamayesh = FindViewById<Button>(Resource.Id.academicbtnhamayesh);
            academicbtnhamayesh.Typeface = font;
            academicbtnhamayesh.Click += delegate
            {
                Intent oi = new Intent(this, typeof(CategoryEvent));
                oi.PutExtra("Key", "علمی و تخصصی-همایش");

                StartActivity(oi);


            };


            academicbtnkargah = FindViewById<Button>(Resource.Id.academicbtnkargah);
            academicbtnkargah.Typeface = font;
            academicbtnkargah.Click += delegate {

                Intent oi = new Intent(this, typeof(CategoryEvent));
                oi.PutExtra("Key", "علمی و تخصصی-کنفرانس");

                StartActivity(oi);

            };

            academicbtngroupingGrouping = FindViewById<Button>(Resource.Id.academicbtngroupingGrouping);
            academicbtngroupingGrouping.Click += delegate {   StartActivity(typeof(Grouping)); };
            academicbtngroupingGrouping.Typeface = font;

            academicbtnEventDay = FindViewById<Button>(Resource.Id.academicbtnEventDay);
            academicbtnEventDay.Typeface = font;
            academicbtnEventDay.Click += delegate {

                StartActivity(typeof(CustomActivity.EventDay_Activity));
            };

            academicbtngift = FindViewById<Button>(Resource.Id.academicbtngift);
            academicbtngift.Typeface = font;

            academicbtngift.Click += delegate {

                StartActivity(typeof(CustomActivity.Suprised_Activity));
            };
            academicbtnContact = FindViewById<Button>(Resource.Id.academicbtnContact);
            academicbtnContact.Click += delegate {  StartActivity(typeof(Account)); };
            academicbtnContact.Typeface = font;
        }
    }
}