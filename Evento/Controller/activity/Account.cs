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
using Evento.Controller.Fragment;

namespace Evento.Controller.activity
{
    [Activity(Label = "Account", Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    //اطلاعات من
    public class Account : AppCompatActivity
    {
        Button Accountbtnenterevent;
        TextView Accounttxtviewgroup;
        ImageButton Accountimgbtnlogo;
        Button Accountbtnfilter;
        Button Accountbtnsearch;
        Button Accountbtndelete;
        EditText Accountedtxtsearch;
        ImageView AccountImageviewRule;



        Button AccountButtonEventMe;

        Button AccountButtonMark;

        Button accountbtnhesabmali;
        Button AccountButtonRule;
        Button AccountbuttonAboutUs;
        Button AccountbuttonContactMe;
        Button accountbtncontact;
        Button accountbtngift;
        Button accountbtnEventDay;
        Button accountbtngrouping;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.layoutAccount);
           
            var font = Typeface.CreateFromAsset(Assets, "Estedad.ttf");

             accountbtngift = FindViewById<Button>(Resource.Id.accountbtngift);
            accountbtngift.Click += delegate {

                StartActivity(typeof(CustomActivity.Suprised_Activity));
            };
             accountbtnEventDay = FindViewById<Button>(Resource.Id.accountbtnEventDay);
            accountbtnEventDay.Click += delegate {

                StartActivity(typeof(CustomActivity.EventDay_Activity));
            };

            Accountbtnenterevent = FindViewById<Button>(Resource.Id.Accountbtnenterevent);



            Accountbtnenterevent.Typeface = font;
            Accountbtnenterevent.Click += delegate { StartActivity(typeof(EnterEvent)); };
            Accounttxtviewgroup = FindViewById<TextView>(Resource.Id.Accounttxtviewgroup);
            Accounttxtviewgroup.Typeface = font;
            Accountimgbtnlogo = FindViewById<ImageButton>(Resource.Id.Accountimgbtnlogo);
            Accountimgbtnlogo.Click += delegate { StartActivity(typeof(MainActivity)); };

            Accountbtnfilter = FindViewById<Button>(Resource.Id.Accountbtnfilter);
            Accountbtnfilter.Typeface = font;
            Accountbtnfilter.Click += delegate {


                Controller.Fragment.FilterMain fdlg = new Controller.Fragment.FilterMain(this);
                fdlg.Show(this.FragmentManager, "ebrahimfragmentfliterMainToFilterMain");
            };
            Accountbtnsearch = FindViewById<Button>(Resource.Id.Accountbtnsearch);
            Accountbtnsearch.Typeface = font;


            Accountbtndelete = FindViewById<Button>(Resource.Id.Accountbtndelete);
            Accountbtndelete.Click += delegate { Accountedtxtsearch.Text = string.Empty; };
            Accountbtndelete.Typeface = font;
            Accountedtxtsearch = FindViewById<EditText>(Resource.Id.Accountedtxtsearch);
            Accountedtxtsearch.Typeface = font;

            Accountedtxtsearch.TextChanged += Accountedtxtsearch_TextChanged;


            AccountButtonEventMe = FindViewById<Button>(Resource.Id.AccountButtonEventMe);
            AccountButtonEventMe.Typeface = font;
            AccountButtonEventMe.Click += delegate {
                //رویدادهای من
                StartActivity(typeof(MyEventActivity.MyeventActivity));

            };
          FindViewById<ImageView>(Resource.Id.accountimgviewEventMe).Click += delegate {
              //رویداد های من
              StartActivity(typeof(MyEventActivity.MyeventActivity));
          };
            AccountButtonMark = FindViewById<Button>(Resource.Id.AccountButtonMark);
            ImageView im = FindViewById<ImageView>(Resource.Id.AccountImageviewMark);

            im.Click += delegate {
                //رویدادهای نشان شده
                Intent oi = new Intent(this, typeof(CustomActivity.MarkedEvent_Activity));

                StartActivity(oi);
            };
            AccountButtonMark.Click += delegate {
                Intent oi = new Intent(this, typeof(CustomActivity.MarkedEvent_Activity));

                StartActivity(oi);
            };
            AccountButtonMark.Typeface = font;
         
            accountbtnhesabmali = FindViewById<Button>(Resource.Id.accountbtnhesabmali);
            accountbtnhesabmali.Typeface = font;
            accountbtnhesabmali.Click += delegate {
                // حساب مالی
                Intent oi = new Intent(this, typeof(CustomActivity.Payed_Activity));
                StartActivity(oi);
            };
            ImageView hmali = FindViewById<ImageView>(Resource.Id.AccountImageviewMali);

            hmali.Click += delegate {
                // حساب مالی
                Intent oi = new Intent(this, typeof(CustomActivity.Payed_Activity));
                StartActivity(oi);

            };

            AccountButtonRule = FindViewById<Button>(Resource.Id.AccountButtonRule);
            AccountButtonRule.Typeface = font;
            AccountButtonRule.Click += delegate {

                Controller.Fragment.RuleFragment fdlg = new Controller.Fragment.RuleFragment(this);
                fdlg.Show(this.FragmentManager, "ebrahimfragmentrulefragment");
            };
            AccountImageviewRule = FindViewById<ImageView>(Resource.Id.AccountImageviewRule);
            AccountImageviewRule.Click += delegate {

               Controller.Fragment.RuleFragment fdlg = new Controller.Fragment.RuleFragment(this);
                fdlg.Show(this.FragmentManager, "ebrahimfragmentrulefragment");
            };



            AccountbuttonAboutUs = FindViewById<Button>(Resource.Id.AccountbuttonAboutUs);

            AccountbuttonAboutUs.Typeface = font;
            AccountbuttonAboutUs.Click += delegate {
                //درباره ما

                AboutUsFragment fdlg = new AboutUsFragment(this);
                fdlg.Show(this.FragmentManager, "ebrahimfragmentAccountShow");

                 
            };
            
            ImageView Accountimageviewaboutus = FindViewById<ImageView>(Resource.Id.Accountimageviewaboutus);
            Accountimageviewaboutus.Click += delegate {
                //درباره ما

                AboutUsFragment fdlg = new AboutUsFragment(this);
                fdlg.Show(this.FragmentManager, "ebrahimfragmentAccountShow");

            };

            AccountbuttonContactMe = FindViewById<Button>(Resource.Id.AccountbuttonContactMe);
            AccountbuttonContactMe.Typeface = font;
            AccountbuttonContactMe.Click += delegate {

                //تماس با ایونتو
                TellEventoFragment fdlg = new TellEventoFragment(this);
                fdlg.Show(this.FragmentManager, "ebrahimTellEventoMananger");


            };
            ImageView AccountimageviewContactMe = FindViewById<ImageView>(Resource.Id.AccountimageviewContactMe);
            AccountimageviewContactMe.Click += delegate
            {

                //تماس با ایونتو
                TellEventoFragment fdlg = new TellEventoFragment(this);
                fdlg.Show(this.FragmentManager, "ebrahimTellEventoMananger");
            };
            accountbtncontact = FindViewById<Button>(Resource.Id.accountbtncontact);
            accountbtncontact.Typeface = font;
            accountbtncontact.Click += delegate { };

            accountbtngift = FindViewById<Button>(Resource.Id.accountbtngift);
            accountbtngift.Typeface = font;
            accountbtnEventDay = FindViewById<Button>(Resource.Id.accountbtnEventDay);
            accountbtnEventDay.Typeface = font;
            accountbtngrouping = FindViewById<Button>(Resource.Id.accountbtngrouping);
            accountbtngrouping.Typeface = font;
            accountbtngrouping.Click += delegate { StartActivity(typeof(Grouping)); };
        }

        private void Accountedtxtsearch_TextChanged(object sender, Android.Text.TextChangedEventArgs e)
        {
            if (e.AfterCount >= 1)
            {

                Accountbtnsearch.Visibility = ViewStates.Visible;
                Accountbtndelete.Visibility = ViewStates.Visible;
                Accountedtxtsearch.TextAlignment = TextAlignment.Center;



            }
            else
            {
                Accountbtnsearch.Visibility = ViewStates.Gone;
                Accountbtndelete.Visibility = ViewStates.Gone;
                Accountedtxtsearch.TextAlignment = TextAlignment.Center;

            }
        }
    }
}