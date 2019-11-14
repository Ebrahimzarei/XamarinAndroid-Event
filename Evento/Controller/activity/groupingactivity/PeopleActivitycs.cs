 

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
 
using Android.Widget;

namespace Evento.Controller.activity.groupingactivity
{
    [Activity(Label = "PeopleActivitycs")]
    public class PeopleActivitycs : Activity
    {
        ImageButton peopleimgbtnlogo;
        TextView peopletxtviewgroup;
        Button   peoplebtnenterevent;

        Button peoplebtnnamayeshgah;
        Button peoplebtnhamaeshgah;
        Button peoplebtnharaji;
     
        


        Button peoplebtngroupingGrouping;
        Button peoplebtnEventDay;
        Button peoplebtngift;
        Button peoplebtnContact;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.layoutpeople);
           
            var font = Typeface.CreateFromAsset(Assets, "Estedad.ttf");

            peopleimgbtnlogo = FindViewById<ImageButton>(Resource.Id.peopleimgbtnlogo);
            peopleimgbtnlogo.Click += delegate { Finish(); };

            peopletxtviewgroup = FindViewById<TextView>(Resource.Id.peopletxtviewgroup);
            peopletxtviewgroup.Typeface = font;
            peopletxtviewgroup.Text = "داوطلبانه و مردمی";

            peoplebtnenterevent = FindViewById<Button>(Resource.Id.peoplebtnenterevent);
            peoplebtnenterevent.Click += delegate {  StartActivity(typeof(EnterEvent)); };
            peoplebtnenterevent.Typeface = font;


            peoplebtnnamayeshgah = FindViewById<Button>(Resource.Id.peoplebtnnamayeshgah);
            peoplebtnnamayeshgah.Click += delegate {
                Intent oi = new Intent(this, typeof(CategoryEvent));
                oi.PutExtra("Key", "داوطلبانه و مردمی-گرد همایی");
                StartActivity(oi);

            };
            peoplebtnnamayeshgah.Typeface = font;

            peoplebtnhamaeshgah = FindViewById<Button>(Resource.Id.peoplebtnhamaeshgah);
            peoplebtnhamaeshgah.Click += delegate {
                Intent oi = new Intent(this, typeof(CategoryEvent));
                oi.PutExtra("Key", "داوطلبانه و مردمی-نمایشگاه");
                StartActivity(oi);

            };
            peoplebtnhamaeshgah.Typeface = font;

            peoplebtnharaji = FindViewById<Button>(Resource.Id.peoplebtnharaji);
            peoplebtnharaji.Click += delegate {
                Intent oi = new Intent(this, typeof(CategoryEvent));
                oi.PutExtra("Key", "داوطلبانه و مردمی-خیریه و کمک رسانی");
                StartActivity(oi);


            };
            peoplebtnharaji.Typeface = font;

            peoplebtngroupingGrouping = FindViewById<Button>(Resource.Id.peoplebtngroupingGrouping);
            peoplebtngroupingGrouping.Click += delegate {   StartActivity(typeof(Grouping)); };
            peoplebtngroupingGrouping.Typeface = font;

            peoplebtnEventDay = FindViewById<Button>(Resource.Id.peoplebtnEventDay);
            peoplebtnEventDay.Typeface = font;
            peoplebtnEventDay.Click += delegate {

                StartActivity(typeof(CustomActivity.EventDay_Activity));
            };

            peoplebtngift = FindViewById<Button>(Resource.Id.peoplebtngift);
            peoplebtngift.Typeface = font;
            peoplebtngift.Click += delegate {

                StartActivity(typeof(CustomActivity.Suprised_Activity));
            };

            peoplebtnContact = FindViewById<Button>(Resource.Id.peoplebtnContact);
            peoplebtnContact.Click += delegate {   StartActivity(typeof(Account)); };
            peoplebtnContact.Typeface = font;

        }
    }
}