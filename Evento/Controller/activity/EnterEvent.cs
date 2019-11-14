using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Support.V7.Widget;
using Android.Text;
using Android.Views;
using Android.Widget;
using Calligraphy;
using Com.Mohamadamin.Persianmaterialdatetimepicker.Date;
using Evento.Controller.Fragment;
using static Android.Support.V7.Widget.RecyclerView;
using WebEventoo_DomainClasses.Model;
using System.Net.Http;
using Evento.Model;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using Evento.Model.ModelImages;

namespace Evento.Controller.activity
{
    [Activity(Label = "EnterEvent", Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class EnterEvent : AppCompatActivity, Com.Mohamadamin.Persianmaterialdatetimepicker.Date.DatePickerDialog.IOnDateSetListener
    {
        static int a = 0;
        static List<Byte[]> barray;

        Button entereventButtonBack;
        Button entereventbuttoncaption;
        TextView entereventtxtviewcaption;
        ImageView enterebentimgviewback;
        //جنبه رویداد
        TextView entereventtxtviewLonging;
        Button entereventbuttonLonging;
        LinearLayout entereventlinearlayoutLonging;

        DbEventoo DbConnection;

        EditText enterevenedittextHelpCaption;

        EditText entereventeditTextCaption;
        TextView entereventtxtviewcaptioneven;
        Button entereventbuttonLocal2;
        Button entereventbuttonshiraz2;
        TextView entereventtxtviewplace2;

        EditText entereventedittextHelpAddress;


        EditText entereventeditTextAddres;
        TextView entereventtxtviewaddres;

        EditText entereventeditexthelpTime;

        Button entereventbuttotnTo;
        TextView entereventtxtviewto;
        Button entereventbuttonFrom;
        TextView entereventtxtviewfrom;
        TextView entereventtxtviewtime;
        ImageButton entereventimageButtonCost;


        TextView entereventtxtviewcost;


        EditText enteteventedittexthelptel;


        EditText entereventeditTextTel;
        TextView entereventtxtviewtel;

        EditText entereventeditexthelpurl;

        EditText entereventeditTextUrl;
        TextView entereventtxtviewurl;

        EditText entereventeditexthelpdescription;

        EditText entereventeditTextdesc;
        TextView entereventtxtviewdescription;

        ImageButton entereventimageButtoncamera;
        EditText entereventedttexthelpcamera;


        Button entereventbuttoncamera;
        TextView entereventtxtviewphoto;
        LinearLayout entereventlinearLayoutcamera;
        Button entereventbuttonSend;
        Button entereventbuttonsave;

      
        TextView entereventtxtviewCaptionCost;
        string ValueToast;
        View view;
        TextView txt;
        Toast toast;

        EditText entereventedttexthelplonging;
        LinearLayout entereventlonginghelplonging;


        Button entereventbuttoncost;
        protected override void AttachBaseContext(Context context)
        {
            base.AttachBaseContext(CalligraphyContextWrapper.Wrap(context));
        }
        protected override void OnCreate(Bundle savedInstanceState)
        {

            base.OnCreate(savedInstanceState);
            CalligraphyConfig.InitDefault(new CalligraphyConfig.Builder()
                 .SetDefaultFontPath("Estedad.ttf").Build());

            SetContentView(Resource.Layout.layoutenterevent);
       
      



            var font = Typeface.CreateFromAsset(Assets, "Estedad.ttf");
            enterebentimgviewback = FindViewById<ImageView>(Resource.Id.enterebentimgviewback);
            enterebentimgviewback.Click += delegate { Finish(); };
            entereventtxtviewCaptionCost = FindViewById<TextView>(Resource.Id.entereventtxtviewCaptionCost);
            entereventtxtviewCaptionCost.Typeface = font;

            entereventButtonBack = FindViewById<Button>(Resource.Id.entereventButtonBack);
            entereventButtonBack.Typeface = font;
            entereventButtonBack.Click += delegate { Finish(); };

            entereventbuttoncaption = FindViewById<Button>(Resource.Id.entereventbuttoncaption);
            entereventbuttoncaption.Typeface = font;
            //موضوع رویداد
            entereventbuttoncaption.Click += delegate
            {
                Controller.Fragment.Captionvent fdlg = new Fragment.Captionvent(this);
                fdlg.Cancelable = false;
                fdlg.Show(this.FragmentManager, "ebrahimfragment1");
                fdlg.OnGetCurrentItem += Fdlg_OnGetCurrentItem;


            };


            //جنبه رویداد
              entereventtxtviewLonging = FindViewById<TextView>(Resource.Id.entereventtxtviewLonging);
             entereventedttexthelplonging = FindViewById<EditText>(Resource.Id.entereventedttexthelplonging);
             entereventlonginghelplonging = FindViewById<LinearLayout>(Resource.Id.entereventlonginghelplonging);
            //EditText entereventedttexthelplonging;
            //LinearLayout entereventlonginghelplonging;
            entereventtxtviewLonging.Typeface = font;
            entereventedttexthelplonging.Visibility = ViewStates.Invisible;
            entereventlonginghelplonging.Visibility = ViewStates.Invisible;
            entereventedttexthelplonging.Click += delegate
             {
                 ValueToast = "جنبه رویدادی مورد نظر را انتخاب کنید با درباره آن توضبح دهید";
                 Controller.Fragment.ShowWarning fdlg = new Fragment.ShowWarning(this, ValueToast);
                 fdlg.Show(this.FragmentManager, "ebrahimfragment1");
                 

             };
            //جنبه رویداد
            entereventbuttonLonging = FindViewById<Button>(Resource.Id.entereventbuttonLonging);
            entereventbuttonLonging.Click += delegate
            {
              //  DbConnection = new DbEventoo();
               // var item = DbConnection.JanbeEventLongingGetAll().FirstOrDefault();

                string Itemno = entereventbuttoncaption.Text;
                if (Itemno.StartsWith("فروشگاه ها"))
                {
                    Controller.Fragment.FragmentLonging fdlg = new Fragment.FragmentLonging(this, "فروشگاه");
                    fdlg.Show(this.FragmentManager, "ebrahimfragment1");
                    fdlg.OnGetCaptionLonging += delegate (object sender, GetLonging e)
                    {
                        entereventbuttonLonging.Text = e.GetCaption;
                    };
                }
                if (Itemno.StartsWith("کلاس"))
                {
                    Controller.Fragment.FragmentLonging fdlg = new Fragment.FragmentLonging(this, "کلاس");
                    fdlg.Show(this.FragmentManager, "ebrahimfragment1");
                    fdlg.OnGetCaptionLonging += delegate (object sender, GetLonging e)
                    {
                        entereventbuttonLonging.Text = e.GetCaption;
                    };
                    //اغذیه فروشی
                }
                if (Itemno.StartsWith("اغذیه فروشی"))
                {
                    Controller.Fragment.FragmentLonging fdlg = new Fragment.FragmentLonging(this, "اغذیه فروشی");
                    fdlg.Show(this.FragmentManager, "ebrahimfragment1");
                    fdlg.OnGetCaptionLonging += delegate (object sender, GetLonging e)
                    {
                        entereventbuttonLonging.Text = e.GetCaption;
                    };
                    //اغذیه فروشی
                }

            };

           
            entereventbuttonLonging.Visibility = ViewStates.Invisible;
            entereventbuttonLonging.Typeface = font;
              entereventlinearlayoutLonging = FindViewById<LinearLayout>(Resource.Id.entereventlinearlayoutLonging);
            entereventlinearlayoutLonging.Visibility = ViewStates.Invisible;


            ImageView entereventimageviewmap = FindViewById<ImageView>(Resource.Id.entereventimageviewmap);
            entereventimageviewmap.Click += delegate
            {
                //نمایش نقشه
                Intent oi = new Intent(this, typeof(MapEnterEventActivity));

                StartActivity(oi);
            };





            entereventtxtviewcaption = FindViewById<TextView>(Resource.Id.entereventtxtviewcaption);
            entereventtxtviewcaption.Typeface = font;


            enterevenedittextHelpCaption = FindViewById<EditText>(Resource.Id.enterevenedittextHelpCaption);
       

            //@+id/entereventeditTextAddres

            FindViewById<EditText>(Resource.Id.entereventeditexthelpcost).Click += delegate
            {
                ValueToast = "منظور از هزینه رویداد میزان هرینه ای است که از مخاطب بابت شرکت در رویداد خود دریافت می نمایید یکی از گزینه های درج شده را انتخاب نمایید";
                Controller.Fragment.ShowWarning fdlg = new Fragment.ShowWarning(this, ValueToast);
                fdlg.Show(this.FragmentManager, "ebrahimfragment1");
             //   Drawable errorIcon = Resources.GetDrawable(Resource.Drawable.academicblack32);



             //   FindViewById<EditText>(Resource.Id.entereventeditexthelpcost).SetError(Android.Text.Html.FromHtml("<font color='White'>منظور از هزینه رویداد میزان هرینه ای است که از مخاطب بابت شرکت در رویداد خود دریافت می نمایید یکی از گزینه های درج شده را انتخاب نمایید</font>"), errorIcon);

            };
       
            enterevenedittextHelpCaption.Click += delegate
            {
             //   Drawable errorIcon = Resources.GetDrawable(Resource.Drawable.academicblack32);

               ValueToast = "تیتر اصلی رویداد خود را شفاف و جذاب درج کنید";
                Controller.Fragment.ShowWarning fdlg = new Fragment.ShowWarning(this, ValueToast);
                fdlg.Show(this.FragmentManager, "ebrahimfragment1");

                //    enterevenedittextHelpCaption.SetError(Android.Text.Html.FromHtml("<font color='White'>تیتر اصلی رویداد خود را شفاف و جذاب درج کنید</font>"), errorIcon);
            };
            //entereventimageButtonHelpCaption.Click += delegate
            //{

            //    ValueToast = "تیتر اصلی رویداد خود را شفاف و جذاب درج کنید";
            //    view = LayoutInflater.Inflate(Resource.Layout.layoutToast, null);
            //    txt = view.FindViewById<TextView>(Resource.Id.toasttxtviewtoast);
            //    txt.Typeface = font;
            //    txt.Text = ValueToast;
            //    toast = new Toast(this)
            //    {
            //        Duration = ToastLength.Long,

            //        View = view
            //    };
            //    toast.SetGravity(GravityFlags.Center, 0, 0);
            //    toast.Show();





            //};
            entereventbuttoncost = FindViewById<Button>(Resource.Id.entereventbuttoncost);
            entereventbuttoncost.Click += delegate
            {
                PanelCostFragment Pcost = new PanelCostFragment(this);
                Pcost.Show(this.FragmentManager, "ebrahimfragmentcost");
                Pcost.OnGetCurrentcost += delegate (object sender, GetAllItemCheckd e)
                {
                    if (e.GetCost != string.Empty)
                    {
                        entereventbuttoncost.Text = e.GetCost;
                    }



                };






            };

            entereventeditTextCaption = FindViewById<EditText>(Resource.Id.entereventeditTextCaption);
            entereventeditTextCaption.Typeface = font;
            //  entereventeditTextCaption.RequestFocus();

            entereventtxtviewcaptioneven = FindViewById<TextView>(Resource.Id.entereventtxtviewcaptionevent);
            entereventtxtviewcaptioneven.Typeface = font;

            entereventbuttonLocal2 = FindViewById<Button>(Resource.Id.entereventbuttonLocal);
            entereventbuttonLocal2.Typeface = font;

            entereventbuttonLocal2.Click += delegate
            {
                Fragment.EnterPlace fdlg = new Fragment.EnterPlace(this);
                fdlg.ShowsDialog = true;
                fdlg.Show(this.FragmentManager, "ebrahimfragment2");
                fdlg.OnGetPlaceEvent += delegate (object sender, GetPlaceEvent e)
                {

                    if (e.GetPlace.Count > 1)
                    {
                        ValueToast = "بیشتر از یک مکان برای رویداد انتخاب شده است";
                        view = LayoutInflater.Inflate(Resource.Layout.layoutToast, null);
                        txt = view.FindViewById<TextView>(Resource.Id.toasttxtviewtoast);
                        txt.Typeface = font;
                        txt.Text = ValueToast;
                        toast = new Toast(this)
                        {
                            Duration = ToastLength.Long,

                            View = view
                        };
                        toast.SetGravity(GravityFlags.Center, 0, 0);
                        toast.Show();
                        return;
                    }
                    //if (e.GetPlace.Count==0)                   {
                    //    {
                    //        entereventbuttonLocal2.Text = "محله";
                    //        return;
                    //    }
                    //}
                    else
                    {
                        if (e.GetPlace.Count == 0)
                        {
                            return;
                        }
                        entereventbuttonLocal2.Text = "";
                        foreach (var item in e.GetPlace)
                        {
                            entereventbuttonLocal2.Text += item.itemplace;
                        }

                    }

                };
            };



            entereventbuttonshiraz2 = FindViewById<Button>(Resource.Id.entereventbuttonshiraz);
            entereventbuttonshiraz2.Typeface = font;


            entereventtxtviewplace2 = FindViewById<TextView>(Resource.Id.entereventtxtviewplace);
            entereventtxtviewplace2.Typeface = font;


            entereventedittextHelpAddress = FindViewById<EditText>(Resource.Id.entereventedittextHelpAddress);
            entereventedittextHelpAddress.Click += delegate
            {
                ValueToast = "می توانید آدرس  محل رویداد خود را در اینجا بنویسید";
            //    Drawable errorIcon = Resources.GetDrawable(Resource.Drawable.academicblack32);
                Controller.Fragment.ShowWarning fdlg = new Fragment.ShowWarning(this, ValueToast);
                fdlg.Show(this.FragmentManager, "ebrahimfragment1");

              //  FindViewById<EditText>(Resource.Id.entereventedittextHelpAddress).SetError(Html.FromHtml("<font color='White'>می توانید آدرس  محل رویداد خود را در اینجا بنویسید</font>"), errorIcon);

            };
          
            //
            EditText entereventedttexthelpcamera;
            entereventedttexthelpcamera = FindViewById<EditText>(Resource.Id.entereventedttexthelpcamera); entereventedttexthelpcamera.Click += delegate
            {
                ValueToast = "  تصاویر مرتیط با رویداد خود را بار گذاری کنید.تصاویر مناسب باعث بیشتر دیده شدن رویداد شما خواهد شد" + ".";
                Controller.Fragment.ShowWarning fdlg = new Fragment.ShowWarning(this, ValueToast);
                fdlg.Show(this.FragmentManager, "ebrahimfragment1");

                //   Drawable errorIcon = Resources.GetDrawable(Resource.Drawable.academicblack32);


                //     entereventedttexthelpcamera.SetError(Html.FromHtml("<font color='White'>تصاویر مرتیط با رویداد خود را بار گذاری کنید.تصاویر مناسب باعث بیشتر دیده شدن رویداد شما خواهد شد</font>"), errorIcon);



            };
            entereventedttexthelpcamera = FindViewById<EditText>(Resource.Id.entereventedttexthelpcamera);
         

            //


         

            entereventeditTextAddres = FindViewById<EditText>(Resource.Id.entereventeditTextAddres);
            entereventeditTextAddres.Typeface = font;
            // entereventeditTextAddres.Hint = "بعنوان مثال چمران کوچه 4 پلاک 10";

            string txtviewdescription = entereventeditTextAddres.Hint;
            string numberdigittsix = txtviewdescription.Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩");
            entereventeditTextAddres.Hint = numberdigittsix;


            entereventtxtviewaddres = FindViewById<TextView>(Resource.Id.entereventtxtviewaddres);
            entereventtxtviewaddres.Typeface = font;

            entereventeditexthelpTime = FindViewById<EditText>(Resource.Id.entereventeditexthelpTime);
            entereventeditexthelpTime.Click += delegate
            {
                ValueToast = "بازه زمان برگزاری رویداد خود را مشخص کنید در صورتی که رویداد شما یک روزه است تاریخ شروع و پایان را یکسان انتخاب نمایید";
                Controller.Fragment.ShowWarning fdlg = new Fragment.ShowWarning(this, ValueToast);
                fdlg.Show(this.FragmentManager, "ebrahimfragment1");
                //  Drawable errorIcon = Resources.GetDrawable(Resource.Drawable.academicblack32);



                //   FindViewById<EditText>(Resource.Id.entereventeditexthelpTime).SetError(Html.FromHtml(String.Format("<font color='White'>{0}</font>", ValueToast)), errorIcon);
            };
         

            entereventbuttotnTo = FindViewById<Button>(Resource.Id.entereventbuttotnTo);
            entereventbuttotnTo.Typeface = font;
            entereventbuttotnTo.Click += delegate
            {
                a = 2;

                Com.Mohamadamin.Persianmaterialdatetimepicker.Date.DatePickerDialog p = new Com.Mohamadamin.Persianmaterialdatetimepicker.Date.DatePickerDialog();
                Com.Mohamadamin.Persianmaterialdatetimepicker.Date.DatePickerDialog d = Com.Mohamadamin.Persianmaterialdatetimepicker.Date.DatePickerDialog.NewInstance(this, p.SelectedDay.Year, p.SelectedDay.Month, p.SelectedDay.Day);
                d.Show(FragmentManager, "ebrahimfragmnetto");

            };


            entereventtxtviewto = FindViewById<TextView>(Resource.Id.entereventtxtviewto);
            entereventtxtviewto.Typeface = font;

            entereventbuttonFrom = FindViewById<Button>(Resource.Id.entereventbuttonFrom);
            entereventbuttonFrom.Typeface = font;
            entereventbuttonFrom.Click += delegate
            {
                // a = 1;
                Com.Mohamadamin.Persianmaterialdatetimepicker.Date.DatePickerDialog p = new Com.Mohamadamin.Persianmaterialdatetimepicker.Date.DatePickerDialog();
                Com.Mohamadamin.Persianmaterialdatetimepicker.Date.DatePickerDialog d = Com.Mohamadamin.Persianmaterialdatetimepicker.Date.DatePickerDialog.NewInstance(this, p.SelectedDay.Year, p.SelectedDay.Month, p.SelectedDay.Day);

                d.Show(FragmentManager, "ebrahimfragmentdate");
                #region startfragment

                //FilterDateTime dlgdttime = new FilterDateTime(this);
                //dlgdttime.Show(this.FragmentManager, "ebrahimfragmentDatetime");
                //dlgdttime.OnGetCurrentdate += delegate (object sender, GetCurrentDateTiem e) {

                //    string month = e.month;
                //    string day = e.day;
                //    if (e.year == "0")
                //    {
                //        entereventbuttonFrom.Text = "1385" + "/" + month + "/" + day;
                //        entereventbuttonFrom.SetTextColor(Android.Graphics.Color.BlueViolet);
                //        return;
                //    }
                //    if (e.year == "1")
                //    {

                //        entereventbuttonFrom.Text = "1386" + "/" + month + "/" + day;
                //        entereventbuttonFrom.SetTextColor(Android.Graphics.Color.BlueViolet);
                //        return;
                //    }
                //    if (e.year == "2")
                //    {

                //        entereventbuttonFrom.SetTextColor(Android.Graphics.Color.BlueViolet);
                //        entereventbuttonFrom.Text = "1387" + "/" + month + "/" + day;
                //        return;
                //    }
                //    //
                //    if (e.year == "3")
                //    {
                //        entereventbuttonFrom.Text = "1388" + "/" + month + "/" + day;
                //        entereventbuttonFrom.SetTextColor(Android.Graphics.Color.BlueViolet);
                //        return;
                //    }
                //    if (e.year == "4")
                //    {

                //        entereventbuttonFrom.Text = "1389" + "/" + month + "/" + day;
                //        entereventbuttonFrom.SetTextColor(Android.Graphics.Color.BlueViolet);
                //        return;
                //    }
                //    if (e.year == "5")
                //    {

                //        entereventbuttonFrom.Text = "1390" + "/" + month + "/" + day;
                //        entereventbuttonFrom.SetTextColor(Android.Graphics.Color.BlueViolet);
                //        return;
                //    }
                //    //
                //    if (e.year == "6")
                //    {
                //        entereventbuttonFrom.Text = "1391" + "/" + month + "/" + day;
                //        entereventbuttonFrom.SetTextColor(Android.Graphics.Color.BlueViolet);
                //        return;
                //    }
                //    if (e.year == "7")
                //    {
                //        entereventbuttonFrom.Text = "1392" + "/" + month + "/" + day;
                //        entereventbuttonFrom.SetTextColor(Android.Graphics.Color.BlueViolet);
                //        return;
                //    }
                //    if (e.year == "8")
                //    {

                //        entereventbuttonFrom.Text = "1393" + "/" + month + "/" + day;
                //        entereventbuttonFrom.SetTextColor(Android.Graphics.Color.BlueViolet);
                //        return;
                //    }
                //    //
                //    if (e.year == "9")
                //    {

                //        entereventbuttonFrom.Text = "1394" + "/" + month + "/" + day;
                //        entereventbuttonFrom.SetTextColor(Android.Graphics.Color.BlueViolet);
                //        return;
                //    }
                //    if (e.year == "10")
                //    {

                //        entereventbuttonFrom.Text = "1395" + "/" + month + "/" + day;
                //        entereventbuttonFrom.SetTextColor(Android.Graphics.Color.BlueViolet);
                //        return;
                //    }
                //    if (e.year == "11")
                //    {

                //        entereventbuttonFrom.Text = "1396" + "/" + month + "/" + day;
                //        entereventbuttonFrom.SetTextColor(Android.Graphics.Color.BlueViolet);
                //        return;
                //    }//
                //    if (e.year == "12")
                //    {


                //        entereventbuttonFrom.Text = "1397" + "/" + month + "/" + day; entereventbuttonFrom.SetTextColor(Android.Graphics.Color.BlueViolet);
                //        return;
                //    }
                //    if (e.year == "13")
                //    {

                //        entereventbuttonFrom.Text = "1398" + "/" + month + "/" + day;
                //        entereventbuttonFrom.SetTextColor(Android.Graphics.Color.BlueViolet);
                //        return;
                //    }
                //    if (e.year == "14")
                //    {

                //        entereventbuttonFrom.Text = "1399" + "/" + month + "/" + day;
                //        entereventbuttonFrom.SetTextColor(Android.Graphics.Color.BlueViolet);
                //        return;
                //    }
                //    //
                //    if (e.year == "15")
                //    {

                //        entereventbuttonFrom.Text = "1400" + "/" + month + "/" + day;
                //        entereventbuttonFrom.SetTextColor(Android.Graphics.Color.BlueViolet);
                //        return;
                //    }
                //    if (e.year == "16")
                //    {

                //        entereventbuttonFrom.Text = "1401" + "/" + month + "/" + day;
                //        entereventbuttonFrom.SetTextColor(Android.Graphics.Color.BlueViolet);
                //        return;
                //    }
                //    if (e.year == "17")
                //    {

                //        entereventbuttonFrom.Text = "1402" + "/" + month + "/" + day;
                //        entereventbuttonFrom.SetTextColor(Android.Graphics.Color.BlueViolet);
                //        return;
                //    }
                //    if (e.year == "18")
                //    {

                //        entereventbuttonFrom.Text = "1403" + "/" + month + "/" + day;
                //        entereventbuttonFrom.SetTextColor(Android.Graphics.Color.BlueViolet);
                //        return;
                //    }
                //    if (e.year == "19")
                //    {
                //        entereventbuttonFrom.Text = "1404" + "/" + month + "/" + day;
                //        entereventbuttonFrom.SetTextColor(Android.Graphics.Color.BlueViolet);
                //        return;
                //    }



                //};
                #endregion




            };
            entereventtxtviewfrom = FindViewById<TextView>(Resource.Id.entereventtxtviewfrom);
            entereventtxtviewfrom.Typeface = font;


            entereventtxtviewtime = FindViewById<TextView>(Resource.Id.entereventtxtviewtime);
            entereventtxtviewtime.Typeface = font;

            //  entereventimageButtonCost = FindViewById<ImageButton>(Resource.Id.entereventimageButtonCost);












            entereventtxtviewCaptionCost.Click += delegate
            {
                if (entereventtxtviewCaptionCost.Text == string.Empty)
                {
                    return;
                }
                else
                {
                    Entercost fdialog = new Entercost(this);
                    fdialog.Show(this.FragmentManager, "ebrahimfragment3");


                    fdialog.OnGetCurrentItem += delegate (object sende1r, GetCostItem getcost)
                    {


                        this.Window.SetSoftInputMode(SoftInput.StateAlwaysHidden);
                        int valuenumber = Convert.ToInt32(getcost.GetCost);

                        string num = valuenumber.ToString("N0");
                        string digitpersiannumber = num.Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩");

                        entereventtxtviewCaptionCost.Text = digitpersiannumber + "تومان";

                        entereventtxtviewCaptionCost.SetTextColor(Android.Graphics.Color.ParseColor("#311b92"));
                        entereventtxtviewCaptionCost.Typeface = font;
                        entereventtxtviewCaptionCost.Gravity = GravityFlags.Center;
                        entereventtxtviewCaptionCost.RequestFocus();


                    };
                }


            };




            entereventtxtviewcost = FindViewById<TextView>(Resource.Id.entereventtxtviewcost);
            entereventtxtviewcost.Typeface = font;

            enteteventedittexthelptel = FindViewById<EditText>(Resource.Id.enteteventedittexthelptel);

            enteteventedittexthelptel.Click += delegate
            {

                ValueToast = ".شماره همراه جهت پاسخگویی به مخاطبین رویداد را درج نمایید.  پس از  ثبت رویداد در ایونتو پیامکی حاوی کد تایید به این شماره ارسال خواهد شد";
                Controller.Fragment.ShowWarning fdlg = new Fragment.ShowWarning(this, ValueToast);
                fdlg.Show(this.FragmentManager, "ebrahimfragment1");
                //    Drawable errorIcon = Resources.GetDrawable(Resource.Drawable.academicblack32);
                //  enteteventedittexthelptel.SetError(Html.FromHtml(String.Format("<font color='White'>{0}</font>", ValueToast)), errorIcon);
                //view = LayoutInflater.Inflate(Resource.Layout.layoutToast, null);
                //txt = view.FindViewById<TextView>(Resource.Id.toasttxtviewtoast);
                //txt.Typeface = font;
                //txt.Text = ValueToast;
                //toast = new Toast(this)
                //{
                //    Duration = ToastLength.Long,


                //    View = view
                //};
                //toast.SetGravity(GravityFlags.Center, 0, 0);
                //toast.Show();
            };
           

            entereventeditTextTel = FindViewById<EditText>(Resource.Id.entereventeditTextTel);
            entereventeditTextTel.Typeface = font;

            string numtwo = entereventeditTextTel.Hint;
            string digitpersiannumbertwo = numtwo.Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩");
            entereventeditTextTel.Hint = digitpersiannumbertwo;

            entereventtxtviewtel = FindViewById<EditText>(Resource.Id.entereventeditTextTel);




            entereventeditexthelpurl = FindViewById<EditText>(Resource.Id.entereventeditexthelpurl);

            entereventeditexthelpurl.Click += delegate
            {
                //
                ValueToast = "در این قسمت میتوانید آدرس وب سایت یا شبکه های اجتماعی خود را درج نمایید";
                Controller.Fragment.ShowWarning fdlg = new Fragment.ShowWarning(this, ValueToast);
                fdlg.Show(this.FragmentManager, "ebrahimfragment1");
                //  Drawable errorIcon = Resources.GetDrawable(Resource.Drawable.academicblack32);



            //    FindViewById<EditText>(Resource.Id.entereventeditexthelpurl).SetError(Html.FromHtml(String.Format("<font color='White'>{0}</font>", ValueToast)), errorIcon);
            };
     


            entereventeditTextUrl = FindViewById<EditText>(Resource.Id.entereventeditTextUrl);
            entereventeditTextUrl.Typeface = font;

            entereventtxtviewurl = FindViewById<TextView>(Resource.Id.entereventtxtviewurl);
            entereventtxtviewurl.Typeface = font;

            entereventeditexthelpdescription = FindViewById<EditText>(Resource.Id.entereventeditexthelpdescription);
            entereventeditexthelpdescription.Click += delegate
            {
                ValueToast = "اطلاعات تکمیلی رویداد خود از جمله شرایط هزینه را بطور کامل و شفاف ارایه دهید از درج هر گونه آدرس اینترنتی در این قسمت خودداری نمایید";
                Controller.Fragment.ShowWarning fdlg = new Fragment.ShowWarning(this, ValueToast);
                fdlg.Show(this.FragmentManager, "ebrahimfragment1");
                //  Drawable errorIcon = Resources.GetDrawable(Resource.Drawable.academicblack32);



                //  FindViewById<EditText>(Resource.Id.entereventeditexthelpdescription).SetError(Html.FromHtml(String.Format("<font color='White'>{0}</font>", ValueToast)), errorIcon);

            };
            entereventeditexthelpdescription = FindViewById<EditText>(Resource.Id.entereventeditexthelpdescription);
  
            entereventeditTextdesc = FindViewById<EditText>(Resource.Id.entereventeditTextdesc);
            entereventeditTextdesc.Typeface = font;

            entereventtxtviewdescription = FindViewById<TextView>(Resource.Id.entereventtxtviewdescription);
            entereventtxtviewdescription.Typeface = font;



            entereventbuttoncamera = FindViewById<Button>(Resource.Id.entereventbuttoncamera);
            entereventbuttoncamera.Typeface = font;
            entereventbuttoncamera.Click += delegate
            {
                var intentbrowserimage = new Intent();
                intentbrowserimage.SetAction(Intent.ActionGetContent);
                intentbrowserimage.SetType("image/*");
                StartActivityForResult(intentbrowserimage, 100);

            };

            entereventtxtviewphoto = FindViewById<TextView>(Resource.Id.entereventtxtviewphoto);
            entereventtxtviewphoto.Typeface = font;

            //  entereventlinearLayoutcamera = FindViewById<LinearLayout>(Resource.Id.entereventlinearLayoutcameras);


            entereventbuttonSend = FindViewById<Button>(Resource.Id.entereventbuttonSend);
            entereventbuttonSend.Typeface = font;

            //
            entereventbuttonSend.Click +=  delegate
            {

                //if (tell.CinfitmMessage < 1)
                //{
              //  ConfirmMessageFragment fdmessage = new ConfirmMessageFragment(this);
                //fdmessage.Cancelable = false;
              //  fdmessage.Show(this.FragmentManager, "ebrahimfragmentmessage");

                //}
            

                Controller.Fragment.ContinuRuleFragment continurule = new Fragment.ContinuRuleFragment(this);
                continurule.Cancelable = false;
                continurule.Show(this.FragmentManager, "ebrahimfragmentcontinurule");
                continurule.OnGetCaptionRule += delegate (object sender, GetCaptionRule e)
                {
                    if (e.GetCaption == true)
                    {
                        //   Finish();

                    }
                };


                if (entereventbuttoncaption.Text == "انتخاب شود")
                {
                    ValueToast = "موضوع رویداد اجباری می باشد";




                    ValueToast = "رویداد شما ذخیره شد";
                    var toast = Toast.MakeText(this, ValueToast, ToastLength.Long);
                    toast.SetGravity(GravityFlags.Center, 0, 0);
                    toast.Show();
                    return;


                   

                }
                if (entereventeditTextCaption.Text == string.Empty)
                {
                    ValueToast = "عنوان رویداد اجباری می باشد";

                    entereventeditTextCaption.Error = ValueToast;
                    ValueToast = "رویداد شما ذخیره شد";
                    var toast = Toast.MakeText(this, ValueToast, ToastLength.Long);
                    toast.SetGravity(GravityFlags.Center, 0, 0);
                    toast.Show();
                    return;
                }
                if (entereventbuttonLocal2.Text == "محله")
                {
                    ValueToast = "  انتخاب محله اجباری می باشد";
                    ValueToast = "رویداد شما ذخیره شد";
                    var toast = Toast.MakeText(this, ValueToast, ToastLength.Long);
                    toast.SetGravity(GravityFlags.Center, 0, 0);
                    toast.Show();
                   

                    entereventbuttonLocal2.Error = ValueToast;



                    return;
                }
                if (entereventeditTextAddres.Text == string.Empty)
                {
                    ValueToast = "آدرس رویداد اجباری می باشد";
                    ValueToast = "رویداد شما ذخیره شد";
                    var toast = Toast.MakeText(this, ValueToast, ToastLength.Long);
                    toast.SetGravity(GravityFlags.Center, 0, 0);
                    toast.Show();
                  //  return;
                    entereventeditTextAddres.Error = ValueToast;
                    return;
                }
                if (entereventbuttonFrom.Text == "تاریخ شروع")
                {
                    ValueToast = "تاریخ شروع اجباری می باشد";

                    entereventbuttonFrom.Error = ValueToast;
                    ValueToast = "رویداد شما ذخیره شد";
                    var toast = Toast.MakeText(this, ValueToast, ToastLength.Long);
                    toast.SetGravity(GravityFlags.Center, 0, 0);
                    toast.Show();
                    return;
                    
                }
                if (entereventbuttotnTo.Text == "تاریخ پایان")
                {
                    ValueToast = "تاریخ پایان اجباری می باشد";

                    entereventbuttotnTo.Error = ValueToast;
                    ValueToast = "رویداد شما ذخیره شد";
                    var toast = Toast.MakeText(this, ValueToast, ToastLength.Long);
                    toast.SetGravity(GravityFlags.Center, 0, 0);
                    toast.Show();
                    return;
                }
                if (entereventeditTextTel.Text == "تلفن تماس")
                {
                    ValueToast = "تلفن تماس اجباری می باشد";

                    entereventeditTextTel.Error = ValueToast;
                    ValueToast = "رویداد شما ذخیره شد";
                    var toast = Toast.MakeText(this, ValueToast, ToastLength.Long);
                    toast.SetGravity(GravityFlags.Center, 0, 0);
                    toast.Show();
                    return;
                }
                if (entereventeditTextdesc.Text.Length > 400)
                {
                    ValueToast = "توضیحات باید کمتر از 400 کاراکتر باشد";
                    //Drawable icon = Resources.GetDrawable(Resource.Drawable.warning32);
                    //if (icon != null)
                    //{
                    //    icon.SetBounds(0, 0, icon.IntrinsicWidth, icon.IntrinsicHeight);
                    //}
                    entereventeditTextdesc.Error = ValueToast;
                    ValueToast = "رویداد شما ذخیره شد";
                    var toast = Toast.MakeText(this, ValueToast, ToastLength.Long);
                    toast.SetGravity(GravityFlags.Center, 0, 0);
                    toast.Show();
                    return;
                }




                else
                {
                   
                    
                    //ارسال مقادیر به web api
                    Event ObjEvent = new Event();
                    DbConnection = new DbEventoo();
                    var tell = DbConnection.ConfirmTellGetAll().LastOrDefault();
                 
                    var itemno = DbConnection.LongingGetAll().LastOrDefault();
                    //فروشگاه

                    if (itemno .GetLonging== "فروشگاه" && itemno.DescriptionLonging== "اجرای زنده")
                    {
                        ObjEvent.TypeCaption = Event.TypeCaptionEvent.LongingStoreLive;
                    }
                    if (itemno.GetLonging == "فروشگاه" && itemno.DescriptionLonging == "قرعه کشی")
                    {
                        ObjEvent.TypeCaption = Event.TypeCaptionEvent.LongingStorelottery;
                    }
                    if (itemno.GetLonging == "فروشگاه" && itemno.DescriptionLonging == "اشانتیون")
                    {
                        ObjEvent.TypeCaption = Event.TypeCaptionEvent.LongingStoregift;
                    }
                    if (itemno.GetLonging == "فروشگاه" && itemno.DescriptionLonging == "نمایشگاه جنبی")
                    {
                        ObjEvent.TypeCaption = Event.TypeCaptionEvent.LongingStoreexhibition;
                    }
                    if (itemno.GetLonging == "فروشگاه" && itemno.DescriptionLonging == "افتتاحیه")
                    {
                        ObjEvent.TypeCaption = Event.TypeCaptionEvent.LongingStoreopening;
                    }
                    if (itemno.GetLonging == "فروشگاه" && itemno.DescriptionLonging == "تخفیف")
                    {
                        ObjEvent.TypeCaption = Event.TypeCaptionEvent.LongingStorediscount;
                    }
                    if (itemno.GetLonging == "فروشگاه" && itemno.DescriptionLonging == "سایر")
                    {
                        ObjEvent.TypeCaption = Event.TypeCaptionEvent.LongingStoreother;
                    }

                    //کلاس آموزشی

                    if (itemno.GetLonging == "کلاس آموزشی" && itemno.DescriptionLonging == "جلسه رایگان")
                    {
                        ObjEvent.TypeCaption = Event.TypeCaptionEvent.LongingclassLive;
                    }
                    if (itemno.GetLonging == "کلاس آموزشی" && itemno.DescriptionLonging == "قرعه کشی")
                    {
                        ObjEvent.TypeCaption = Event.TypeCaptionEvent.Longingclasslottery;
                    }
                    if (itemno.GetLonging == "کلاس آموزشی" && itemno.DescriptionLonging == "کارگاه جنبی")
                    {
                        ObjEvent.TypeCaption = Event.TypeCaptionEvent.LongingclassotherLive;
                    }
                    if (itemno.GetLonging == "کلاس آموزشی" && itemno.DescriptionLonging == "اشانتیون")
                    {
                        ObjEvent.TypeCaption = Event.TypeCaptionEvent.Longingclassgiftlottery;
                    }
                    if (itemno.GetLonging == "کلاس آموزشی" && itemno.DescriptionLonging == "نمایشگاه جنبی")
                    {
                        ObjEvent.TypeCaption = Event.TypeCaptionEvent.LongingclassexhibitionLive;
                    }
                    if (itemno.GetLonging == "کلاس آموزشی" && itemno.DescriptionLonging == "افتتاحیه")
                    {
                        ObjEvent.TypeCaption = Event.TypeCaptionEvent.Longingclassopening;
                    }
                    if (itemno.GetLonging == "کلاس آموزشی" && itemno.DescriptionLonging == "تخفیف")
                    {
                        ObjEvent.TypeCaption = Event.TypeCaptionEvent.Longingclassdiscount;
                    }
                    if (itemno.GetLonging == "کلاس آموزشی" && itemno.DescriptionLonging == "سایر")
                    {
                        ObjEvent.TypeCaption = Event.TypeCaptionEvent.Longingclassother;
                    }
                    //اغذیه فروشی

                    if (itemno.GetLonging == "اغذیه فروشی" && itemno.DescriptionLonging == "اجرای زنده")
                    {
                        ObjEvent.TypeCaption = Event.TypeCaptionEvent.LongingfoodLive;
                    }
                    if (itemno.GetLonging == "اغذیه فروشی" && itemno.DescriptionLonging == "قرعه کشی")
                    {
                        ObjEvent.TypeCaption = Event.TypeCaptionEvent.Longingfoodlottery;
                    }
                    if (itemno.GetLonging == "اغذیه فروشی" && itemno.DescriptionLonging == "پخش مسابقات زنده")
                    {
                        ObjEvent.TypeCaption = Event.TypeCaptionEvent.Longingfoodmajorlive;
                    }
                    if (itemno.GetLonging == "اغذیه فروشی" && itemno.DescriptionLonging == "اشانتیون")
                    {
                        ObjEvent.TypeCaption = Event.TypeCaptionEvent.Longingfoodgift;
                    }
                    if (itemno.GetLonging == "اغذیه فروشی" && itemno.DescriptionLonging == "نمایشگاه جنبی")
                    {
                        ObjEvent.TypeCaption = Event.TypeCaptionEvent.Longingfoodexhibition;
                    }
                    if (itemno.GetLonging == "اغذیه فروشی" && itemno.DescriptionLonging == "افتتاحیه")
                    {
                        ObjEvent.TypeCaption = Event.TypeCaptionEvent.Longingfoodopening;
                    }
                    if (itemno.GetLonging == "اغذیه فروشی" && itemno.DescriptionLonging == "تخفیف")
                    {
                        ObjEvent.TypeCaption = Event.TypeCaptionEvent.Longingfooddiscount;
                    }
                    if (itemno.GetLonging == "اغذیه فروشی" && itemno.DescriptionLonging == "سایر")
                    {
                        ObjEvent.TypeCaption = Event.TypeCaptionEvent.Longingfoodother;
                    }
                    //

                    if (entereventbuttoncaption.Text.StartsWith("فرهنگی هنری"))
                    {
                        ObjEvent.Type = Event.TypeEvent.Cultrual;
                        if (entereventbuttoncaption.Text.Contains("نمایشگاه"))
                        {
                            ObjEvent.TypeCaption = Event.TypeCaptionEvent.cultrualExhibition;

                        }
                        if (entereventbuttoncaption.Text.Contains("سینما"))
                        {
                            ObjEvent.TypeCaption = Event.TypeCaptionEvent.cultrualCinema;
                        }
                        if (entereventbuttoncaption.Text.Contains("کنسرت"))
                        {
                            ObjEvent.TypeCaption = Event.TypeCaptionEvent.cultrualconcert;
                        }
                        if (entereventbuttoncaption.Text.Contains("گالری"))
                        {
                            ObjEvent.TypeCaption = Event.TypeCaptionEvent.cultrualGallery;
                        }
                        if (entereventbuttoncaption.Text.Contains("همایش ومراسم"))
                        {
                            ObjEvent.TypeCaption = Event.TypeCaptionEvent.cultrualcermoney;
                        }
                        if (entereventbuttoncaption.Text.Contains("تیاتر"))
                        {
                            ObjEvent.TypeCaption = Event.TypeCaptionEvent.cultrualGravity;
                        }
                    }
                    if (entereventbuttoncaption.Text.StartsWith("ورزش و سرگرمی"))
                    {
                        ObjEvent.Type = Event.TypeEvent.Sport;
                        if (entereventbuttoncaption.Text.Contains("باشگاه"))
                        {
                            ObjEvent.TypeCaption = Event.TypeCaptionEvent.sportclub;
                        }
                        if (entereventbuttoncaption.Text.Contains("گیم کلاب"))
                        {
                            ObjEvent.TypeCaption = Event.TypeCaptionEvent.sportgymclub;
                        }
                        if (entereventbuttoncaption.Text.Contains("ورزش های توپی"))
                        {
                            ObjEvent.TypeCaption = Event.TypeCaptionEvent.sportball;
                        }
                        if (entereventbuttoncaption.Text.Contains("ورزش های آبی"))
                        {
                            ObjEvent.TypeCaption = Event.TypeCaptionEvent.sportwater;
                        }
                        if (entereventbuttoncaption.Text.Contains("ورزش های رزمی"))
                        {
                            ObjEvent.TypeCaption = Event.TypeCaptionEvent.sportmartial;
                        }

                    }
                    if (entereventbuttoncaption.Text.StartsWith("علمی و تخصصی"))
                    {
                        ObjEvent.Type = Event.TypeEvent.Sciences;
                        if (entereventbuttoncaption.Text.Contains("نمایشگاه"))
                        {
                            ObjEvent.TypeCaption = Event.TypeCaptionEvent.academicexhibition;
                        }
                        if (entereventbuttoncaption.Text.Contains("کنفرانس"))
                        {
                            ObjEvent.TypeCaption = Event.TypeCaptionEvent.academicconferance;
                        }
                        if (entereventbuttoncaption.Text.Contains("همایش"))
                        {
                            ObjEvent.TypeCaption = Event.TypeCaptionEvent.academiccermoney;
                        }


                    }
                    if (entereventbuttoncaption.Text.StartsWith("داوطلبانه و مردمی"))
                    {
                        ObjEvent.Type = Event.TypeEvent.Public;
                        if (entereventbuttoncaption.Text.Contains("نمایشگاه"))
                        {
                            ObjEvent.TypeCaption = Event.TypeCaptionEvent.popularexhibition;
                        }
                        if (entereventbuttoncaption.Text.Contains("گرد همایی"))
                        {
                            ObjEvent.TypeCaption = Event.TypeCaptionEvent.populargathering;
                        }
                        if (entereventbuttoncaption.Text.Contains("خیریه و کمک رسانی"))
                        {
                            ObjEvent.TypeCaption = Event.TypeCaptionEvent.popularhelping;
                        }


                    }
                    if (entereventbuttoncaption.Text.StartsWith("مذهبی و دینی"))
                    {
                        ObjEvent.Type = Event.TypeEvent.Religuse;
                        if (entereventbuttoncaption.Text.Contains("نمایشگاه"))
                        {
                            ObjEvent.TypeCaption = Event.TypeCaptionEvent.religionexhibition;
                        }
                        if (entereventbuttoncaption.Text.Contains("مراسم"))
                        {
                            ObjEvent.TypeCaption = Event.TypeCaptionEvent.religioncermoney;
                        }

                    }
                    if (entereventbuttoncaption.Text.StartsWith("اغذیه فروشی"))
                    {
                        ObjEvent.Type = Event.TypeEvent.Food;
                        if (entereventbuttoncaption.Text.Contains("نمایشگاه"))
                        {
                            ObjEvent.TypeCaption = Event.TypeCaptionEvent.foodsexhibition;
                        }
                        if (entereventbuttoncaption.Text.Contains("کافی شاپ"))
                        {
                            ObjEvent.TypeCaption = Event.TypeCaptionEvent.foodscoffe;
                        }
                        if (entereventbuttoncaption.Text.Contains("رستوران"))
                        {
                            ObjEvent.TypeCaption = Event.TypeCaptionEvent.foodsresturant;
                        }
                        if (entereventbuttoncaption.Text.Contains("فست فود"))
                        {
                            ObjEvent.TypeCaption = Event.TypeCaptionEvent.foodsfastfood;
                        }


                    }
                    if (entereventbuttoncaption.Text.StartsWith("سلامتی و زیبایی"))
                    {
                        ObjEvent.Type = Event.TypeEvent.Health;
                        if (entereventbuttoncaption.Text.Contains("آرایشگاه"))
                        {
                            //field is repete
                            ObjEvent.TypeCaption = Event.TypeCaptionEvent.healthitemone;
                        }
                        if (entereventbuttoncaption.Text.Contains("مشاوره"))
                        {
                            //
                            ObjEvent.TypeCaption = Event.TypeCaptionEvent.healthitemoTwo;
                        }
                    }
                    if (entereventbuttoncaption.Text.StartsWith("کلاس های آموزشی"))
                    {
                        ObjEvent.Type = Event.TypeEvent.ClassLearn;
                        if (entereventbuttoncaption.Text.Contains("گردشگری"))
                        {
                            ObjEvent.TypeCaption = Event.TypeCaptionEvent.classlearntourism;
                        }
                        if (entereventbuttoncaption.Text.Contains("ورزشی"))
                        {
                            ObjEvent.TypeCaption = Event.TypeCaptionEvent.classlearnsport;
                        }
                        if (entereventbuttoncaption.Text.Contains("اغذیه فروشی"))
                        {
                            ObjEvent.TypeCaption = Event.TypeCaptionEvent.classlearnfood;
                        }
                        if (entereventbuttoncaption.Text.Contains("مذهبی"))
                        {
                            ObjEvent.TypeCaption = Event.TypeCaptionEvent.classlearnreligion;
                        }
                        if (entereventbuttoncaption.Text.Contains("بیشه و مهارتی"))
                        {
                            ObjEvent.TypeCaption = Event.TypeCaptionEvent.classlearnskill;
                        }
                        if (entereventbuttoncaption.Text.Contains("دروس مدرسه و دانشگاه"))
                        {
                            ObjEvent.TypeCaption = Event.TypeCaptionEvent.classlearnlesson;
                        }
                        if (entereventbuttoncaption.Text.Contains("عکاسی"))
                        {
                            ObjEvent.TypeCaption = Event.TypeCaptionEvent.classlearnphoto;
                        }
                        if (entereventbuttoncaption.Text.Contains("زبان های خارجی"))
                        {
                            ObjEvent.TypeCaption = Event.TypeCaptionEvent.classlearnphoto;
                        }
                        if (entereventbuttoncaption.Text.Contains("مشاوره تحصیلی"))
                        {
                            ObjEvent.TypeCaption = Event.TypeCaptionEvent.classlearnsadvice;
                        }
                        if (entereventbuttoncaption.Text.Contains("هنری"))
                        {
                            ObjEvent.TypeCaption = Event.TypeCaptionEvent.classlearncultrual;
                        }
                        if (entereventbuttoncaption.Text.Contains("پزشکی"))
                        {
                            ObjEvent.TypeCaption = Event.TypeCaptionEvent.classlearnmedical;
                        }
                        if (entereventbuttoncaption.Text.Contains("زیبایی"))
                        {
                            ObjEvent.TypeCaption = Event.TypeCaptionEvent.classlearnperfect;
                        }
                        if (entereventbuttoncaption.Text.Contains("آموزش موسیقی"))
                        {
                            ObjEvent.TypeCaption = Event.TypeCaptionEvent.classlearnmusic;
                        }
                        if (entereventbuttoncaption.Text.Contains("ورک شاپ"))
                        {
                            ObjEvent.TypeCaption = Event.TypeCaptionEvent.classlearnorkshop;
                        }
                    }
                    ObjEvent.CaptionEvent = entereventeditTextCaption.Text;
                    Place pl = new Place() { Name = entereventbuttonLocal2.Text };
                    ObjEvent.Place = new List<Place>() { new Place() { Name = entereventbuttonLocal2.Text } };

                    ObjEvent.Address = new List<Address>() { new Address() { CaptionAddress = entereventeditTextAddres.Text } };
                    foreach (var item in ObjEvent.Address)

                        // ObjEvent.Address.Add(new Address { CaptionAddress = entereventeditTextAddres.Text });
                        if (entereventtxtviewcost.Text == "رایگان")
                        {
                            ObjEvent.Payed = Event.Cost.Free;
                        }
                    if (entereventtxtviewcost.Text.Contains("فیمت درج شود"))
                    {
                        ObjEvent.Payed = Event.Cost.AddCost;
                        ObjEvent.Price = entereventtxtviewcost.Text;
                    }
                    if (entereventtxtviewcost.Text.Contains("قیمت درج نشود"))
                    {
                        ObjEvent.Payed = Event.Cost.NotCost;

                    }
                    ObjEvent.Tell = entereventeditTextTel.Text;
                    ObjEvent.AddressUrl = entereventtxtviewurl.Text;
                    ObjEvent.Description = entereventeditTextdesc.Text;
                    //تصویر
                    // var arrayimages;
      
                    //foreach (var item in barray)
                    //{
                    //    //Images s = new List<Images>(new Images { ImageData = item.ToArray() });

                    //    foreach (var items in ObjEvent.Image)
                    //    {
                    //        items.ImageData = item;
                    //    }

                    //}
                    List<MobileImages> lstimage = new List<MobileImages>();
                    // DbConnection.ImagesGetAll().ToList().ForEach( p =>
                    //{
                    //    ObjEvent.Image.Add(new Images { ImageData = p.ImageData, NameImage = p.NameImage });
                    //    lstimage = new List<MobileImages>()
                    //    {

                    //    };
                    //});
                    //foreach (var item in DbConnection.ImagesGetAll())
                    //{
                    //    ObjEvent.Image.Add(new Images() {ImageData=item.ImageData,NameImage=item.NameImage });
                    //}

                    lstimage = DbConnection.ImagesGetAll().ToList();
                    List<Images> webimages = new List<Images>();
                    foreach (var item in lstimage)
                    {
                        webimages.Add(new Images() {ImageData=item.ImageData,NameImage=item.NameImage });
                    }

                    ObjEvent.Image = webimages;

                    ObjEvent.ToDate = entereventbuttotnTo.Text;
                    ObjEvent.FromDate = entereventbuttonFrom.Text;
                    ObjEvent.EventNow = DateTime.Now;
                    ObjEvent.Statusevent = Event.StatuseEvent.NotChecked;
                    //  ObjEvent.User.KeyUserApp = Guid.NewGuid();
                    Users user = new Users() { Type=Users.UserType.UserEvent,Tellephone= entereventeditTextTel .Text
                    };
                    //ObjEvent.User.Tellephone = entereventeditTextTel.Text;
                    ObjEvent.User = user;

                    using (HttpClient client = new HttpClient())
                    {

                        client.BaseAddress = new Uri(WebAddress.MyAddress);
                        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                        string json = JsonConvert.SerializeObject(ObjEvent, Formatting.Indented);
                        var httpContent = new StringContent(json);

                        HttpResponseMessage response = client.PostAsync("api/PostTodoItem", httpContent).Result;
                       
                        if (response.StatusCode == System.Net.HttpStatusCode.Created)
                        {
                            ValueToast = "رویداد شما در صف انتظار بررسی قرار گرفت و پس از تایید منتشر خواهد شد";
                            DbConnection.RemoveAllImages();

                            ValueToast = "رویداد شما در صف انتظار بررسی قرار گرفت و پس از تایید منتشر خواهد شد";


                            Snackbar snackBar = Snackbar.Make(entereventbuttonSend, ValueToast, Snackbar.LengthIndefinite).SetAction("تایید", (v) =>
                            {
                                Finish();
                            });


                            snackBar.SetActionTextColor(Android.Graphics.Color.Green);

                            snackBar.Show();
                            return;
                        }
                        else
                        {
                            ValueToast = "خطا در ارسال اطلاعات";
                            DbConnection.RemoveAllImages();

                            ValueToast = "رویداد شما در صف انتظار بررسی قرار گرفت و پس از تایید منتشر خواهد شد";


                            Snackbar snackBar = Snackbar.Make(entereventbuttonSend, ValueToast, Snackbar.LengthIndefinite).SetAction("تایید", (v) =>
                            {
                                Finish();
                            });


                            snackBar.SetActionTextColor(Android.Graphics.Color.Green);

                            snackBar.Show();
                            return;
                        }

                    }






                }
            };
           

       






            entereventbuttonsave = FindViewById<Button>(Resource.Id.entereventbuttonsave);
            entereventbuttonsave.Typeface = font;

            entereventbuttonsave.Click += delegate
            {

                ValueToast = "رویداد شما ذخیره شد";
                var toast = Toast.MakeText(this,ValueToast,ToastLength.Long);
                toast.SetGravity(GravityFlags.Center,0,0);
                toast.Show();
                return;
             
                
                txt = view.FindViewById<TextView>(Resource.Id.toasttxtviewtoast);
                txt.Typeface = font;
                txt.Text = ValueToast;
                view = LayoutInflater.Inflate(Resource.Layout.layoutToast, null);
                toast = new Toast(this)
                {
                    Duration = ToastLength.Long,

                    View = view
                };
                toast.SetGravity(GravityFlags.Center, 0, 0);
                toast.Show();
            };

      




        }



        private void Fdlg_OnGetCurrentItem(object sender, GetCurrentItem e)
        {
            DbConnection = new DbEventoo();
            entereventbuttoncaption.Text = e.GEtCheckBox;
            if (e.GEtCheckBox.StartsWith("کلاس های آموزشی"))
            {
                entereventtxtviewLonging.Visibility = ViewStates.Visible;
                entereventbuttonLonging.Visibility = ViewStates.Visible;
                entereventlinearlayoutLonging.Visibility = ViewStates.Visible;
                entereventedttexthelplonging.Visibility = ViewStates.Visible;
                entereventlonginghelplonging.Visibility = ViewStates.Visible;

                //  DbConnection.JanbeEventInsert(new JanbeEvent() { GetCaptinEvent = "کلاس های آموزشی" });
                //ثبت موقت در دیتا بیس
            }
            if ( e.GEtCheckBox.StartsWith("فروشگاه ها"))
            {
                entereventtxtviewLonging.Visibility = ViewStates.Visible;
                entereventbuttonLonging.Visibility = ViewStates.Visible;
                entereventlinearlayoutLonging.Visibility = ViewStates.Visible;
                entereventtxtviewLonging.Visibility = ViewStates.Visible;
                entereventbuttonLonging.Visibility = ViewStates.Visible;

                //ثبت موقت در دیتا بیس
                //  DbConnection.JanbeEventInsert(new JanbeEvent() { GetCaptinEvent = "فروشگاه ها" });
            }
            if ( e.GEtCheckBox.StartsWith("اغذیه فروشی"))
            {
                entereventtxtviewLonging.Visibility = ViewStates.Visible;
                entereventbuttonLonging.Visibility = ViewStates.Visible;
                entereventlinearlayoutLonging.Visibility = ViewStates.Visible;
                entereventtxtviewLonging.Visibility = ViewStates.Visible;
                entereventbuttonLonging.Visibility = ViewStates.Visible;

                //    DbConnection.JanbeEventInsert(new JanbeEvent() { GetCaptinEvent = "اغذیه فروشی" });
                //ثبت موقت در دیتا بیس
            }
            
          

        }


        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);
            if (requestCode == 100 && resultCode == Result.Ok && data != null)
            {
                ImageView img = new ImageView(this);
                img.LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.MatchParent);
                img.SetScaleType(ImageView.ScaleType.CenterCrop);
                img.Visibility = ViewStates.Visible;
                img.LayoutParameters.Height = 8;
                img.LayoutParameters.Width = 8;

                Stream stream = ContentResolver.OpenInputStream(data.Data);

                Bitmap bitmap = BitmapFactory.DecodeStream(stream);
                MemoryStream mem = new MemoryStream();
                bitmap.Compress(Bitmap.CompressFormat.Png, 30, mem);
                byte[] selectedImageBytes;
                selectedImageBytes = mem.ToArray();

                // img.SetImageBitmap(BitmapFactory.DecodeByteArray(selectedImageBytes, 00, selectedImageBytes.Length));
                RecyclerView Recycler;
                Recycler = FindViewById<RecyclerView>(Resource.Id.entereventRecyclerViewcameras);
                LayoutManager Lmanager = new LinearLayoutManager(this, LinearLayoutManager.Horizontal, false);
                Recycler.SetLayoutManager(Lmanager);
                barray = new List<byte[]>();
                barray.Add(selectedImageBytes);
                DbConnection = new DbEventoo();
                MobileImages images = new MobileImages()
                {
                    ImageData = selectedImageBytes,
                    NameImage = Guid.NewGuid().ToString()

                };
                DbConnection.ImagesInsert(images);

                Adapter.Adapter_Images.BrowsImageEnterEvent_Adapter Adapter;
                List<MobileImages> lstImages;
                lstImages = new List<MobileImages>();
                lstImages = DbConnection.ImagesGetAll();
                Adapter = new Adapter.Adapter_Images.BrowsImageEnterEvent_Adapter(this, lstImages);
                //  entereventlinearLayoutcamera.AddView(img, 170, 170);
                Recycler.SetAdapter(Adapter);
                TextView txtdefault = FindViewById<TextView>(Resource.Id.entereventtextviewdefaultimage);

                txtdefault.Visibility = ViewStates.Visible;
                // txtdefault.TextColors= Color.White;


                entereventbuttoncamera.Text = "افزودن تصویر";

            }
        }

        public void OnDateSet(Com.Mohamadamin.Persianmaterialdatetimepicker.Date.DatePickerDialog p0, int p1, int p2, int p3)
        {
            int month = p2 + 1;
            string Month = string.Empty;
            if (month == 1)
            {
                Month = "فروردین";
            }
            if (month == 2)
            {
                Month = "اردیبهشت";
            }
            if (month == 3)
            {
                Month = "خرداد";
            }

            if (month == 4)
            {
                Month = "تیر";
            }
            if (month == 5)
            {
                Month = "مرداد";
            }
            if (month == 6)
            {
                Month = "شهریور";
            }

            if (month == 7)
            {
                Month = "مهر";
            }
            if (month == 8)
            {
                Month = "آبان";
            }
            if (month == 9)
            {
                Month = "آذر";
            }

            if (month == 10)
            {
                Month = "دی";
            }
            if (month == 11)
            {
                Month = "بهمن";
            }
            if (month == 12)
            {
                Month = "اسفند";
            }
            string year = p1.ToString();
            string removeonechar = year.Remove(0, 2);


            string yearremoveone = removeonechar;
            string numberdigittyear = yearremoveone.Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩");
            string day = p3.ToString();
            string numberdigitday = day.Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩");

            if (a == 2)
            {
                entereventbuttotnTo.Text = numberdigitday + Month + numberdigittyear;

                a = 0;
            }
            else
            {
                entereventbuttonFrom.Text = numberdigitday + Month + numberdigittyear;
            }
        }
    }

    //other item for spinner
   


}