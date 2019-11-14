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
    [Activity(Label = "Classeduction_Activity")]
    public class Classeduction_Activity : Activity
    {
        Button classeductionbtnenterevent;
        TextView classeductiontxtviewcaption;
        ImageButton classeductionimgbtnlogo;

        Button classeductionbtnContact;
        Button classeductionbtngift;
        Button classeductionbtnEventDay;
        Button classeductionbtngroupingGrouping;

        Button classeductionbtnexhibition;
        Button classeductionbtnsport;
        Button classeductionbtnfastfoos;
        Button classeductionbtnreligion;
        Button classeductionbtnskill;
        Button classeductionbtnlessons;
        Button classeductionbtnlanguage;
        Button classeductionbtnconsultation;
        Button classeductionbtnarticle;
        Button classeductionbtnmedical;
        Button classeductionbtnperfect;
        Button classeductionbtnmusic;
        Button classeductionbtnlearnphoto;
        Button classeductionbtnworkshop;
        Button classeductionbtnother;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.layout_classeduction);
            Typeface font = Typeface.CreateFromAsset(Assets, "Estedad.ttf");
            classeductionbtnenterevent = FindViewById<Button>(Resource.Id.classeductionbtnenterevent);
            classeductionbtnenterevent.Click += delegate { StartActivity(typeof(EnterEvent)); };
            classeductionbtnenterevent.Typeface = font;
            classeductiontxtviewcaption = FindViewById<TextView>(Resource.Id.classeductiontxtviewgroup);
            classeductiontxtviewcaption.Typeface = font;
            classeductionimgbtnlogo = FindViewById<ImageButton>(Resource.Id.classeductionimgbtnlogo);
            classeductionimgbtnlogo.Click += delegate { StartActivity(typeof(MainActivity)); };



            classeductionbtnContact = FindViewById<Button>(Resource.Id.classeductionbtnContact);
            classeductionbtnContact.Click += delegate { StartActivity(typeof(Account)); };
            classeductionbtnContact.Typeface = font;
            classeductionbtngift = FindViewById<Button>(Resource.Id.classeductionbtngift);
            classeductionbtngift.Click += delegate { StartActivity(typeof(Suprised_Activity)); };
            classeductionbtngift.Typeface = font;
            classeductionbtnEventDay = FindViewById<Button>(Resource.Id.classeductionbtnEventDay);
            classeductionbtnEventDay.Click += delegate { StartActivity(typeof(EventDay_Activity)); };
            classeductionbtnEventDay.Typeface = font;
            classeductionbtngroupingGrouping = FindViewById<Button>(Resource.Id.classeductionbtngroupingGrouping);
            classeductionbtngroupingGrouping.Typeface = font;
            classeductionbtngroupingGrouping.Click += delegate { StartActivity(typeof(Grouping)); };
            classeductionbtnother = FindViewById<Button>(Resource.Id.classeductionbtnother);
            classeductionbtnother.Typeface = font;
            classeductionbtnother.Click += delegate {
                Intent oi = new Intent(this, typeof(CategoryEvent));
                oi.PutExtra("Key", "کلاس های آموزشی-سایر");
                StartActivity(oi);
            };

            classeductionbtnexhibition = FindViewById<Button>(Resource.Id.classeductionbtnexhibition);
            classeductionbtnexhibition.Typeface = font;
            classeductionbtnexhibition.Click += delegate {
                Intent oi = new Intent(this, typeof(CategoryEvent));
                oi.PutExtra("Key", "کلاس های آموزشی-گردشگری");
                StartActivity(oi);
            };

            classeductionbtnsport = FindViewById<Button>(Resource.Id.classeductionbtnsport);
            classeductionbtnsport.Typeface = font;
            classeductionbtnsport.Click += delegate
            {
                Intent oi = new Intent(this, typeof(CategoryEvent));
                oi.PutExtra("Key", "کلاس های آموزشی-ورزشی");
                StartActivity(oi);
            };
            classeductionbtnfastfoos = FindViewById<Button>(Resource.Id.classeductionbtnfastfoos);
            classeductionbtnfastfoos.Typeface = font;
            classeductionbtnfastfoos.Click += delegate
            {
                Intent oi = new Intent(this, typeof(CategoryEvent));
                oi.PutExtra("Key", "کلاس های آموزشی-خوراکی");
                StartActivity(oi);
            };
            classeductionbtnreligion = FindViewById<Button>(Resource.Id.classeductionbtnreligion);
            classeductionbtnreligion.Typeface = font;
            classeductionbtnreligion.Click += delegate {
                Intent oi = new Intent(this, typeof(CategoryEvent));
                oi.PutExtra("Key", "کلاس های آموزشی-مذهبی");
                StartActivity(oi);

            };
            classeductionbtnskill = FindViewById<Button>(Resource.Id.classeductionbtnskill);
            classeductionbtnskill.Typeface = font;
            classeductionbtnskill.Click += delegate {
                Intent oi = new Intent(this, typeof(CategoryEvent));
                oi.PutExtra("Key", "کلاس های آموزشی-بیشه و مهارتی");
                StartActivity(oi);

            };
            /////////
            classeductionbtnlessons = FindViewById<Button>(Resource.Id.classeductionbtnlessons);
            classeductionbtnlessons.Typeface = font;
            classeductionbtnlessons.Click += delegate {


                Intent oi = new Intent(this, typeof(CategoryEvent));
                oi.PutExtra("Key", "کلاس های آموزشی-دروس مدرسه و دانشگاه");
                StartActivity(oi);
            };
            classeductionbtnlanguage = FindViewById<Button>(Resource.Id.classeductionbtnlanguage);
            classeductionbtnlanguage.Click += delegate {
                Intent oi = new Intent(this, typeof(CategoryEvent));
                oi.PutExtra("Key", "کلاس های آموزشی-زبان های خارجی");
                StartActivity(oi);
            };
            classeductionbtnlanguage.Typeface = font;
            classeductionbtnconsultation = FindViewById<Button>(Resource.Id.classeductionbtnconsultation);
            classeductionbtnconsultation.Click += delegate {
                Intent oi = new Intent(this, typeof(CategoryEvent));
                oi.PutExtra("Key", "کلاس های آموزش- مشاوره تحصیلی");
                StartActivity(oi);
            };
            classeductionbtnconsultation.Typeface = font;
            classeductionbtnarticle = FindViewById<Button>(Resource.Id.classeductionbtnarticle);
            classeductionbtnarticle.Click += delegate {
                Intent oi = new Intent(this, typeof(CategoryEvent));
                oi.PutExtra("Key", "کلاس های آموزشی-هنری");
                StartActivity(oi);
            };
            classeductionbtnarticle.Typeface = font;
            classeductionbtnmedical = FindViewById<Button>(Resource.Id.classeductionbtnmedical);
            classeductionbtnmedical.Click += delegate {
                Intent oi = new Intent(this, typeof(CategoryEvent));
                oi.PutExtra("Key", "کلاس های آموزشی-پزشکی");
                StartActivity(oi);
            };
            classeductionbtnmedical.Typeface = font;
            classeductionbtnperfect = FindViewById<Button>(Resource.Id.classeductionbtnperfect);
            classeductionbtnperfect.Click += delegate {

                Intent oi = new Intent(this, typeof(CategoryEvent));
                oi.PutExtra("Key", "کلاس های آموزشی-زیبایی");
                StartActivity(oi);
            };
            classeductionbtnperfect.Typeface = font;
            classeductionbtnmusic = FindViewById<Button>(Resource.Id.classeductionbtnmusic);
            classeductionbtnmusic.Click += delegate {

                Intent oi = new Intent(this, typeof(CategoryEvent));
                oi.PutExtra("Key", "کلاس های آموزشی-آموزش موسیقی");
                StartActivity(oi);
            };
            classeductionbtnmusic.Typeface = font;
            classeductionbtnlearnphoto = FindViewById<Button>(Resource.Id.classeductionbtnlearnphoto);
            classeductionbtnlearnphoto.Click += delegate {


                Intent oi = new Intent(this, typeof(CategoryEvent));
                oi.PutExtra("Key", "کلاس های آموزشی-آموزش عکاسی");
                StartActivity(oi);
            };
            classeductionbtnlearnphoto.Typeface = font;
            classeductionbtnworkshop = FindViewById<Button>(Resource.Id.classeductionbtnworkshop);
            classeductionbtnworkshop.Click += delegate {

                Intent oi = new Intent(this, typeof(CategoryEvent));
                oi.PutExtra("Key", "کلاس های آموزشی-ورک شاپ");
                StartActivity(oi);
            };
            classeductionbtnworkshop.Typeface = font;
        }
    }
}