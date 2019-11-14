 

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
 
using Android.Widget;

namespace Evento.Controller.activity.groupingactivity
{
    [Activity(Label = "tourismactivity")]
    public class tourismactivity : Activity
    {

        ImageButton tourismimgbtnlogo;
        TextView tourismtxtviewgroup;
        Button tourismbtnenterevent;
        Button tourismbtntourism;
        Button tourismbtntour;
        readonly Button tourismbtnjashnvare;
        readonly Button tourismbtntafrihi;

        Button tourismbtngroupingGrouping;
        Button tourismbtnEventDay;
        Button tourismbtngift;
        Button tourismbtnContact;
        //گردشگری  و سرگرمی
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.layouttourism);
            var font = Typeface.CreateFromAsset(Assets, "Estedad.ttf");
          

            tourismimgbtnlogo = FindViewById<ImageButton>(Resource.Id.tourismimgbtnlogo);
            tourismimgbtnlogo.Click += delegate { Finish(); };

            tourismtxtviewgroup = FindViewById<TextView>(Resource.Id.tourismtxtviewgroup);
            tourismtxtviewgroup.Typeface = font;

            tourismbtnenterevent = FindViewById<Button>(Resource.Id.tourismbtnenterevent);
            tourismbtnenterevent.Click += delegate {  StartActivity(typeof(EnterEvent)); };
            tourismbtnenterevent.Typeface = font;


            tourismbtntourism = FindViewById<Button>(Resource.Id.tourismbtntourism);
            tourismbtntourism.Typeface = font;
            tourismbtntourism.Click += delegate {

                Intent oi = new Intent(this, typeof(CategoryEvent));
                oi.PutExtra("Key", "گردشگری و سرگرمی-تور");
                StartActivity(oi);
            };

            tourismbtntour = FindViewById<Button>(Resource.Id.tourismbtntour);
            tourismbtntour.Typeface = font;
            tourismbtntour.Click += delegate {

                Intent oi = new Intent(this, typeof(CategoryEvent));
                oi.PutExtra("Key", "گردشگری  و سرگرمی-جاذبه ها و مکان های تفریجی");
                StartActivity(oi);
            };




            tourismbtngroupingGrouping = FindViewById<Button>(Resource.Id.tourismbtngroupingGrouping);
            tourismbtngroupingGrouping.Click += delegate { StartActivity(typeof(Grouping)); };
            tourismbtngroupingGrouping.Typeface = font;

            tourismbtnEventDay = FindViewById<Button>(Resource.Id.tourismbtnEventDay);
            tourismbtnEventDay.Typeface = font;
            tourismbtnEventDay.Click += delegate { StartActivity(typeof(CustomActivity.EventDay_Activity)); };
            tourismbtngift = FindViewById<Button>(Resource.Id.tourismbtngift);
            tourismbtngift.Typeface = font;
            tourismbtngift.Click += delegate { StartActivity(typeof(CustomActivity.Suprised_Activity)); };

            tourismbtnContact = FindViewById<Button>(Resource.Id.tourismbtnContact);
            tourismbtnContact.Click += delegate { StartActivity(typeof(Account)); };
            tourismbtnContact.Typeface = font;
        }
    }
}