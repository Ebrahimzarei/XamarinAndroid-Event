using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using Evento.Controller.activity.groupingactivity;

namespace Evento.Controller.activity
{
    [Activity(Label = "Grouping")]
    public class Grouping : Activity
    {
        Button groupeventbtnenterevent;
        TextView groupeventtxtviewgroup;
        ImageButton groupeventimgbtnlogo;
        Button groupeventbtnfilter;
        Button groupeventbtnsearch;
        Button groupeventbtndelete;
        EditText groupeventedtxtsearch;
        Button groupeventbtntourism;
        Button groupeventbtnfarhangi;
        Button groupeventbtnelmi;
        Button groupeventbtnsport;
        Button groupeventbtnmaromi;
        Button groupeventbtnmazhabi;
        Button groupeventbtncontact;
        Button groupeventbtngift;
        Button groupeventbtnEventDay;
        Button groupeventbtngrouping;

        ImageView groupeventimgviewfarhangi;
        ImageView groupeventimgviewtourist;
        ImageView groupeventimgviewsport;
        ImageView groupeventimgviewelmi;
        ImageView groupeventimgviewereligion;
        ImageView groupeventimgviewpeople;

        Button groupeventbtnperfect;
        ImageView groupeventimgviewperfect;

        Button groupeventbtnfood;
        ImageView groupeventimgviewecook;

        Button groupeventbtnlearnclass;
        ImageView groupeventimglearnclass;
        //فروشگاه ها
        Button groupeventbtnstore;
        ImageView groupeventimgstore;

        //برنامه های تلوزیونی
        Button groupeventbtntelevision;
        ImageView groupeventimgtelevision;

        protected   override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.layoutgroupevent);
            var font = Typeface.CreateFromAsset(Assets, "Estedad.ttf");

            groupeventbtnperfect = FindViewById<Button>(Resource.Id.groupeventbtnperfect);
            groupeventbtnperfect.Typeface = font;
            groupeventbtnperfect.Click += delegate {

                //Android.Views.Animations.Animation animation = AnimationUtils.LoadAnimation(this, Resource.Animation.design_bottom_sheet_slide_out);
                //groupeventbtnperfect.StartAnimation(animation);

                StartActivity(typeof(Health_Activity));
                //  OverridePendingTransition(Resource.Animation.abc_fade_in, Resource.Animation.abc_fade_out);

            };
            groupeventimgviewperfect = FindViewById<ImageView>(Resource.Id.groupeventimgviewperfect);
            groupeventimgviewperfect.Click += delegate {


                StartActivity(typeof(Health_Activity));
                // OverridePendingTransition(Resource.Animation.abc_fade_in, Resource.Animation.abc_fade_out);
            };

            groupeventbtnfood = FindViewById<Button>(Resource.Id.groupeventbtnfood);
            groupeventbtnfood.Typeface = font;
            groupeventbtnfood.Click += delegate { StartActivity(typeof(Food_Activity)); };
            groupeventimgviewecook = FindViewById<ImageView>(Resource.Id.groupeventimgviewecook);
            groupeventimgviewecook.Click += delegate { StartActivity(typeof(Food_Activity)); };

            groupeventbtnlearnclass = FindViewById<Button>(Resource.Id.groupeventbtnlearnclass);
            groupeventbtnlearnclass.Typeface = font;
            groupeventbtnlearnclass.Click += delegate { StartActivity(typeof(Classeduction_Activity)); };
            groupeventimglearnclass = FindViewById<ImageView>(Resource.Id.groupeventimglearnclass);
            groupeventimglearnclass.Click += delegate { StartActivity(typeof(Classeduction_Activity)); };





            groupeventimgviewfarhangi = FindViewById<ImageView>(Resource.Id.groupeventimgviewfarhangi);
            groupeventimgviewfarhangi.Click += delegate {
                StartActivity(typeof(Controller.activity.groupingactivity.CultrualartActivity))


                ;
            };

            groupeventimgviewtourist = FindViewById<ImageView>(Resource.Id.groupeventimgviewtourist);
            groupeventimgviewtourist.Click += delegate { StartActivity(typeof(Controller.activity.groupingactivity.tourismactivity)); };

            groupeventimgviewsport = FindViewById<ImageView>(Resource.Id.groupeventimgviewsport);
            groupeventimgviewsport.Click += delegate { StartActivity(typeof(Controller.activity.groupingactivity.SportActivity)); };

            groupeventimgviewelmi = FindViewById<ImageView>(Resource.Id.groupeventimgviewelmi);
            groupeventimgviewelmi.Click += delegate { StartActivity(typeof(Controller.activity.groupingactivity.AcademicActivity)); };

            groupeventimgviewereligion = FindViewById<ImageView>(Resource.Id.groupeventimgviewereligion);
            groupeventimgviewereligion.Click += delegate {

                StartActivity(typeof(Controller.activity.groupingactivity.ReliguseActivity));
            };
            groupeventimgviewpeople = FindViewById<ImageView>(Resource.Id.groupeventimgviewpeople);
            groupeventimgviewpeople.Click += delegate { StartActivity(typeof(Controller.activity.groupingactivity.PeopleActivitycs)); };



            groupeventbtnenterevent = FindViewById<Button>(Resource.Id.groupeventbtnenterevent);
            groupeventbtnenterevent.Typeface = font;
            groupeventbtnenterevent.Click += delegate { StartActivity(typeof(Controller.activity.EnterEvent)); };

            //فروشگاه ها
             groupeventbtnstore = FindViewById<Button>(Resource.Id.groupeventbtnstore);
            groupeventbtnstore.Typeface = font;
            groupeventbtnstore.Click += delegate { StartActivity(typeof(store_activity)); };
              groupeventimgstore = FindViewById<ImageView>(Resource.Id.groupeventimgbtnstore);
            groupeventimgstore.Click += delegate { StartActivity(typeof(store_activity)); };
            //برنامه های تلوزیونی
             groupeventbtntelevision = FindViewById<Button>(Resource.Id.groupeventbtntelevision);
            groupeventbtntelevision.Typeface = font;
            groupeventbtntelevision.Click += delegate { StartActivity(typeof(televisionactivity)); };
             groupeventimgtelevision = FindViewById<ImageView>(Resource.Id.groupeventimgtelevision);
            groupeventimgtelevision.Click += delegate { StartActivity(typeof(televisionactivity)); };



            groupeventtxtviewgroup = FindViewById<TextView>(Resource.Id.groupeventtxtviewgroup);
            groupeventtxtviewgroup.Typeface = font;
            groupeventimgbtnlogo = FindViewById<ImageButton>(Resource.Id.groupeventimgbtnlogo);
            groupeventimgbtnlogo.Click += delegate { StartActivity(typeof(MainActivity)); };

            groupeventbtnfilter = FindViewById<Button>(Resource.Id.groupeventbtnfilter);
            groupeventbtnfilter.Typeface = font;
            groupeventbtnfilter.Click += delegate {


                Controller.Fragment.FilterMain fdlg = new Controller.Fragment.FilterMain(this);
                fdlg.Show(this.FragmentManager, "ebrahimfragmentfliterMainToFilterMain");
            };
            groupeventbtnsearch = FindViewById<Button>(Resource.Id.groupeventbtnsearch);

            groupeventbtndelete = FindViewById<Button>(Resource.Id.groupeventbtndelete);
            groupeventbtndelete.Click += delegate { groupeventedtxtsearch.Text = ""; };
            groupeventbtndelete.Typeface = font;
            groupeventedtxtsearch = FindViewById<EditText>(Resource.Id.groupeventedtxtsearch);
            groupeventedtxtsearch.TextChanged += Groupeventedtxtsearch_TextChanged;
            groupeventedtxtsearch.Typeface = font;
            groupeventbtntourism = FindViewById<Button>(Resource.Id.groupeventbtntourist);
            groupeventbtntourism.Typeface = font;
            groupeventbtntourism.Click += delegate { StartActivity(typeof(Controller.activity.groupingactivity.tourismactivity)); };

            groupeventbtnfarhangi = FindViewById<Button>(Resource.Id.groupeventbtnfarhani);
            groupeventbtnfarhangi.Typeface = font;
            groupeventbtnfarhangi.Click += delegate { StartActivity(typeof(Controller.activity.groupingactivity.CultrualartActivity)); };

            groupeventbtnelmi = FindViewById<Button>(Resource.Id.groupeventbtnelmi);
            groupeventbtnelmi.Typeface = font;
            groupeventbtnelmi.Click += delegate {
                //علمی و تخصصی
                StartActivity(typeof(Controller.activity.groupingactivity.AcademicActivity));


            };

            groupeventbtnsport = FindViewById<Button>(Resource.Id.groupeventbtnsport);


            groupeventbtnsport.Typeface = font;
            groupeventbtnsport.Click += delegate { StartActivity(typeof(Controller.activity.groupingactivity.SportActivity)); };

            groupeventbtnmaromi = FindViewById<Button>(Resource.Id.groupeventbtnpeople);
            groupeventbtnmaromi.Typeface = font;
            groupeventbtnmaromi.Click += delegate { StartActivity(typeof(Controller.activity.groupingactivity.PeopleActivitycs)); };

            groupeventbtnmazhabi = FindViewById<Button>(Resource.Id.groupeventbtnreligion);
            groupeventbtnmazhabi.Typeface = font;
            groupeventbtnmazhabi.Click += delegate {

                StartActivity(typeof(Controller.activity.groupingactivity.ReliguseActivity));

            };

            groupeventbtncontact = FindViewById<Button>(Resource.Id.groupeventbtncontact);
            groupeventbtncontact.Typeface = font;
            groupeventbtncontact.Click += delegate {

                StartActivity(typeof(Controller.activity.Account));
            };
            groupeventbtngift = FindViewById<Button>(Resource.Id.groupeventbtngift);
            groupeventbtngift.Typeface = font;
            groupeventbtngift.Click += delegate {

                StartActivity(typeof(CustomActivity.Suprised_Activity));
            };
            groupeventbtnEventDay = FindViewById<Button>(Resource.Id.groupeventbtnEventDay);
            groupeventbtnEventDay.Typeface = font;
            groupeventbtnEventDay.Click += delegate {

                StartActivity(typeof(CustomActivity.EventDay_Activity));
            };
            groupeventbtngrouping = FindViewById<Button>(Resource.Id.groupeventbtngrouping);
            groupeventbtngrouping.Typeface = font;
        }

        private void Groupeventedtxtsearch_TextChanged(object sender, Android.Text.TextChangedEventArgs e)
        {
            if (e.AfterCount >= 1)
            {

                groupeventbtnsearch.Visibility = ViewStates.Visible;
                groupeventbtndelete.Visibility = ViewStates.Visible;
                groupeventedtxtsearch.TextAlignment = TextAlignment.Center;



            }
            else
            {
                groupeventbtnsearch.Visibility = ViewStates.Gone;
                groupeventbtndelete.Visibility = ViewStates.Gone;
                groupeventedtxtsearch.TextAlignment = TextAlignment.Center;

            }
        }
    }
}