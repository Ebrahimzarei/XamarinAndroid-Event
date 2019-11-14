using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V4.View;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using Calligraphy;
using Evento.Controller.Fragment;
using MikePhil.Charting.Charts;
using MikePhil.Charting.Data;

namespace Evento.Controller.activity.MyEventActivity
{
    [Activity(Label = "MyEventManagmnet", Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class MyEventManagmnetActivity : AppCompatActivity
    {
        TextView myeventmanagmnettxtviewcaption;
        Button myeventmanagmnetButtonBack;
        ImageView myeventmanagmnetimgviewback;

        Button myeventmanagmnetbuttondelete;
        Button myeventmanagmnetbuttonedit;
        Button myeventmanagmnetbuttondown;

        ViewPager myeventmanagmnetvpagerslider;
        TabLayout myeventmanagmnettablayoutdots;

        TextView myeventmanagmnettxtviewmajor;
        TextView myeventmanagmnettxtviewsport;
        TextView myeventmanagmnettxtviewcaptiongroup;
        TextView myeventmanagmnettxtviewplace;
        TextView myeventmanagmnettxtviewcaptionplace;
        TextView myeventmanagmnettxtviewdate;
        TextView myeventmanagmnettxtviewcaptiontime;
        TextView myeventmanagmnettxtviewprice;
        TextView myeventmanagmnettxtviewcaptioncost;
        TextView myeventmanagmnettxtviewdescription;
        TextView myeventmanagmnettxtviewcaptiondescription;
        TextView myeventmanagmnettxtviewcaptioncontact;

        TextView myeventmanagmnettxtviewcaptionurl;
        TextView myeventmanagmnettxtviewurl;


        TextView myeventmanagmnettxtviewaddress;
        TextView myeventmanagmnettxtviewtel;



        BarChart myeventmanagmnetchart;
        





        protected override void AttachBaseContext(Context context)
        {
            base.AttachBaseContext(CalligraphyContextWrapper.Wrap(context));
        }
        protected async override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            CalligraphyConfig.InitDefault(new CalligraphyConfig.Builder()
           .SetDefaultFontPath("Estedad.ttf").Build());

            SetContentView(Resource.Layout.layoutMyEventManangment);
          var  font = Typeface.CreateFromAsset(Assets, "Estedad.ttf");
       FindViewById<TextView>(Resource.Id.myeventmanagmnettxtviewstatuse).Typeface = font;
             myeventmanagmnettxtviewcaption=FindViewById<TextView>(Resource.Id.myeventmanagmnettxtviewcaption);
            myeventmanagmnettxtviewcaption.Typeface = font;

             myeventmanagmnetButtonBack = FindViewById<Button>(Resource.Id.myeventmanagmnetButtonBack);
            myeventmanagmnetButtonBack.Typeface = font;
            myeventmanagmnetButtonBack.Click += delegate { Finish(); };
            ImageView myeventmanagmnetimgviewback;
            myeventmanagmnetimgviewback = FindViewById<ImageView>(Resource.Id.myeventmanagmnetimgviewback);
            myeventmanagmnetimgviewback.Click +=delegate{ Finish(); };

             myeventmanagmnetbuttondelete= FindViewById<Button>(Resource.Id.myeventmanagmnetbuttondelete);
            myeventmanagmnetbuttondelete.Click += delegate {

            string    ValueToast = "مطمئنی میخوای حذفش کنی؟";



                Android.App.AlertDialog.Builder alert = new Android.App.AlertDialog.Builder(this);
                alert.SetTitle("حذف رویداد");
                alert.SetMessage(ValueToast);
                alert.SetPositiveButton("بله", (senderAlert, args) =>
                {
                    //باز شدن فرگمنت ذیگر
                    StatuseDeleteFragment dlg = new StatuseDeleteFragment(this);

                    dlg.Show(this.FragmentManager, "Fragmentmanangerstatusedelete");


                });

                alert.SetNegativeButton("خیر", (senderAlert, args) =>
                {

                });

                Dialog dialog = alert.Create();
                dialog.Show();
            };
             myeventmanagmnetbuttonedit=FindViewById<Button>(Resource.Id.myeventmanagmnetbuttonedit);
            myeventmanagmnetbuttonedit.Typeface = font;
            myeventmanagmnetbuttonedit.Click += delegate {
            
                Intent oi = new Intent(this, typeof(EditMyEventActivity));
                StartActivity(oi);
            };
             myeventmanagmnetbuttondown = FindViewById<Button>(Resource.Id.myeventmanagmnetbuttondown);
            myeventmanagmnetbuttondown.Typeface = font;
            myeventmanagmnetbuttondown.Click += delegate
            { //ارتقا}
                Intent ine = new Intent(this, typeof(MyEventUpgradeActivity));
                StartActivity(ine);

            };

                myeventmanagmnetvpagerslider = FindViewById<ViewPager>(Resource.Id.myeventmanagmnetvpagerslider);
              //  myeventmanagmnetvpagerslider.Adapter = new ImageAdapter(this);
                var myeventmanagmnettablayoutdots = FindViewById<TabLayout>(Resource.Id.myeventmanagmnettablayoutdots);
                myeventmanagmnettablayoutdots.SetupWithViewPager(myeventmanagmnetvpagerslider, true);


                 myeventmanagmnettxtviewmajor=FindViewById<TextView>(Resource.Id.myeventmanagmnettxtviewmajor);
            myeventmanagmnettxtviewmajor.Typeface = font;
                 myeventmanagmnettxtviewsport= FindViewById<TextView>(Resource.Id.myeventmanagmnettxtviewsport);
            myeventmanagmnettxtviewsport.Typeface = font;
            string txtviewsport = myeventmanagmnettxtviewsport.Text;
            string numberdigitone= txtviewsport.Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩");
            myeventmanagmnettxtviewsport.Text = numberdigitone;

            




            myeventmanagmnettxtviewcaptiongroup = FindViewById<TextView>(Resource.Id.myeventmanagmnettxtviewcaptiongroup);
            myeventmanagmnettxtviewcaptiongroup.Typeface = font;

             myeventmanagmnettxtviewplace = FindViewById<TextView>(Resource.Id.myeventmanagmnettxtviewplace);
            myeventmanagmnettxtviewplace.Typeface = font;

            string txtviewplace = myeventmanagmnettxtviewplace.Text;
            string numberdigittwo= txtviewplace.Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩");
            myeventmanagmnettxtviewplace.Text = numberdigittwo;

           

            myeventmanagmnettxtviewcaptionplace = FindViewById<TextView>(Resource.Id.myeventmanagmnettxtviewcaptionplace);
            myeventmanagmnettxtviewcaptionplace.Typeface = font;
             myeventmanagmnettxtviewdate = FindViewById<TextView>(Resource.Id.myeventmanagmnettxtviewdate);
            myeventmanagmnettxtviewdate.Typeface = font;
            string txtviewdate = myeventmanagmnettxtviewdate.Text;
            string numberdigitthree = txtviewdate.Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩");
            myeventmanagmnettxtviewdate.Text = numberdigitthree;

           myeventmanagmnettxtviewtel = FindViewById<TextView>(Resource.Id.myeventmanagmnettxtviewtel);
           myeventmanagmnettxtviewtel.Typeface = font;
            string txtviewtel = myeventmanagmnettxtviewtel.Text;
            string numberdigittel = txtviewtel.Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩");
            myeventmanagmnettxtviewtel.Text = numberdigittel;


            myeventmanagmnettxtviewcaptiontime = FindViewById<TextView>(Resource.Id.myeventmanagmnettxtviewcaptiontime);
            myeventmanagmnettxtviewcaptiontime.Typeface = font;
             myeventmanagmnettxtviewprice = FindViewById<TextView>(Resource.Id.myeventmanagmnettxtviewprice);
            myeventmanagmnettxtviewprice.Typeface = font;
            string txtviewprice = myeventmanagmnettxtviewprice.Text;
            string numberdigittfor = txtviewprice.Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩");
            myeventmanagmnettxtviewprice.Text = numberdigittfor;


            myeventmanagmnettxtviewaddress =FindViewById<TextView>(Resource.Id.myeventmanagmnettxtviewaddress);
            myeventmanagmnettxtviewaddress.Typeface = font;
            string tviewaddress = myeventmanagmnettxtviewaddress.Text;
            string numberdigittfive = tviewaddress.Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩");
            myeventmanagmnettxtviewaddress.Text = numberdigittfive;


            myeventmanagmnettxtviewcaptioncost = FindViewById<TextView>(Resource.Id.myeventmanagmnettxtviewcaptioncost);
            myeventmanagmnettxtviewcaptioncost.Typeface = font;
             myeventmanagmnettxtviewdescription = FindViewById<TextView>(Resource.Id.myeventmanagmnettxtviewdescription);
            myeventmanagmnettxtviewdescription.Typeface = font;

            string txtviewdescription = myeventmanagmnettxtviewdescription.Text;
            string numberdigittsix= txtviewdescription.Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩");
            myeventmanagmnettxtviewdescription.Text = numberdigittsix;

            myeventmanagmnettxtviewurl = FindViewById<TextView>(Resource.Id.myeventmanagmnettxtviewurl);
            myeventmanagmnettxtviewurl.Typeface = font;
            string ttxtviewurl = myeventmanagmnettxtviewurl.Text;
            string numberdigittseven = ttxtviewurl.Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩");
            myeventmanagmnettxtviewurl.Text = numberdigittseven;
      


            myeventmanagmnettxtviewcaptiondescription = FindViewById<TextView>(Resource.Id.myeventmanagmnettxtviewcaptiondescription);
            myeventmanagmnettxtviewcaptiondescription.Typeface = font;
           //TextView myeventmanagmnettxtviewcaptioncontact = FindViewById<TextView>(Resource.Id.myeventmanagmnettxtviewcaptioncontact);
            //myeventmanagmnettxtviewcaptioncontact.Typeface = font;
             myeventmanagmnetchart=FindViewById<BarChart>(Resource.Id.myeventmanagmnetchart);
            BarData data = new BarData(getXAxisValues(), getDataSet());
            myeventmanagmnetchart.Data = (data);
            myeventmanagmnetchart.SetDescription("EventooChart");
            myeventmanagmnetchart.AnimateXY(2000, 2000);
            myeventmanagmnetchart.Invalidate();
        }
        private List<System.String> getXAxisValues()
        {
            List<System.String> xAxis = new List<System.String>();
            xAxis.Add("1");
            xAxis.Add("2");
            xAxis.Add("3");
            xAxis.Add("4");
            xAxis.Add("5");
            xAxis.Add("6");
            return xAxis;
        }
        private List<BarDataSet> getDataSet()
        {
            List<BarDataSet> dataSets = null;

            List<BarEntry> valueSet1 = new List<BarEntry>();
            BarEntry v1e1 = new BarEntry(110.000f, 0); // Jan
            valueSet1.Add(v1e1);
            BarEntry v1e2 = new BarEntry(40.000f, 1); // Feb
            valueSet1.Add(v1e2);
            BarEntry v1e3 = new BarEntry(60.000f, 2); // Mar
            valueSet1.Add(v1e3);
            BarEntry v1e4 = new BarEntry(30.000f, 3); // Apr
            valueSet1.Add(v1e4);
            BarEntry v1e5 = new BarEntry(90.000f, 4); // May
            valueSet1.Add(v1e5);
            BarEntry v1e6 = new BarEntry(100.000f, 5); // Jun
            valueSet1.Add(v1e6);

            List<BarEntry> valueSet2 = new List<BarEntry>();
            BarEntry v2e1 = new BarEntry(150.000f, 0); // Jan
            valueSet2.Add(v2e1);
            BarEntry v2e2 = new BarEntry(90.000f, 1); // Feb
            valueSet2.Add(v2e2);
            BarEntry v2e3 = new BarEntry(120.000f, 2); // Mar
            valueSet2.Add(v2e3);
            BarEntry v2e4 = new BarEntry(60.000f, 3); // Apr
            valueSet2.Add(v2e4);
            BarEntry v2e5 = new BarEntry(20.000f, 4); // May
            valueSet2.Add(v2e5);
            BarEntry v2e6 = new BarEntry(80.000f, 5); // Jun
            valueSet2.Add(v2e6);

            BarDataSet barDataSet1 = new BarDataSet(valueSet1, "1");
            barDataSet1.Color = (Color.Rgb(0, 155, 0));
            BarDataSet barDataSet2 = new BarDataSet(valueSet2, "2");
            //barDataSet2.SetColor(ColorTemplate.ColorfulColors);

            dataSets = new List<BarDataSet>();
            dataSets.Add(barDataSet1);
            dataSets.Add(barDataSet2);
            return dataSets;
        }
    }
}