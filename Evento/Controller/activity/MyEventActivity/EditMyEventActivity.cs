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
using Android.Text;
using Android.Views;
using Android.Widget;
using Calligraphy;
using Evento.Controller.Fragment;

namespace Evento.Controller.activity.MyEventActivity
{
    [Activity(Label = "EditMyEvent", Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class EditMyEventActivity : AppCompatActivity, Com.Mohamadamin.Persianmaterialdatetimepicker.Date.DatePickerDialog.IOnDateSetListener
    {
        static int a = 0;

        Button editmyeventButtonBack;
        ImageView editmyeventimgviewback;
        Button editmyeventbuttoncaption;
        TextView editmyeventtxtviewcaption;


        EditText editmyeventeditTextCaption;
        TextView editmyeventtxtviewcaptionevent;

        TextView editeventedittextHelpCaption;


        Button editmyeventbuttonLocal;
        Button editmyeventbuttonshiraz;
        TextView editmyeventtxtviewplace;

        EditText editmyeventeditTextAddres;



        TextView editmyeventtxtviewaddres;

        EditText editmyeventedittextHelpAddress;

        Button editmyeventbuttotnTo;
        TextView editmyeventtxtviewto;
        Button editmyeventbuttonFrom;
        TextView editmyeventtxtviewfrom;

        TextView editmyeventtxtviewtime;

        EditText editmyeventeditexthelpTime;
        TextView editmyeventtxtviewCaptionCost;
        Button editmyeventbuttoncost;
        TextView editmyeventtxtviewcost;


        EditText editmyeventeditexthelpcost;


        EditText editmyeventeditTextTel;
        TextView editmyeventtxtviewtel;

        EditText editmyeventedittexthelptel;

        EditText editmyeventeditTextUrl;
        TextView editmyeventtxtviewurl;

        EditText editmyeventeditexthelpurl;

        EditText editmyeventeditTextdesc;
        TextView editmyeventtxtviewdescription;
        EditText editmyeventeditexthelpdescription;
        Button editmyeventbuttoncamera;
        TextView editmyeventtxtviewphoto;
        EditText editmyeventedttexthelpcamera;
        LinearLayout editmyeventlinearLayoutcamera;
        Button editmyeventbuttonSend;
        Button editmyeventbuttondelete;

        ImageView editmyeventimageviewclose;
        ImageView editmyeventimageviewSend;

        





 
        string ValueToast = "";
        View view;
        TextView txt;
        Toast toast;
        protected override void AttachBaseContext(Context context)
        {
            base.AttachBaseContext(CalligraphyContextWrapper.Wrap(context));
        }
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            CalligraphyConfig.InitDefault(new CalligraphyConfig.Builder()
         .SetDefaultFontPath("Estedad.ttf").Build());
            SetContentView(Resource.Layout.layoutEditMyEvent);
            var font = Typeface.CreateFromAsset(Assets, "Estedad.ttf");
           
            editmyeventtxtviewCaptionCost = FindViewById<TextView>(Resource.Id.editmyeventtxtviewCaptionCost);
            editmyeventtxtviewCaptionCost.Typeface = font;
            editmyeventimgviewback = FindViewById<ImageView>(Resource.Id.editmyeventimgviewback);
            editmyeventimgviewback.Click += delegate { Finish(); };

            editmyeventButtonBack = FindViewById<Button>(Resource.Id.editmyeventButtonBack);
            editmyeventButtonBack.Typeface = font;
            editmyeventButtonBack.Click += delegate { Finish(); };

            editmyeventbuttoncaption = FindViewById<Button>(Resource.Id.editmyeventbuttoncaption);
            editmyeventbuttoncaption.Typeface = font;
            editmyeventbuttoncaption.Click += delegate {
                Controller.Fragment.Captionvent fdlg = new Fragment.Captionvent(this);
                fdlg.Show(this.FragmentManager, "ebrahimeditfragment1");
                fdlg.OnGetCurrentItem += Fdlg_OnGetCurrentItem;


            };

            editmyeventtxtviewcaption = FindViewById<TextView>(Resource.Id.editmyeventtxtviewcaption);
            editmyeventtxtviewcaption.Typeface = font;


            editeventedittextHelpCaption = FindViewById<TextView>(Resource.Id.editmyeventtxtviewcaptionevent);
          
            editeventedittextHelpCaption.Click += delegate {
                

                ValueToast = "تیتر اصلی رویداد خود را شفاف و جذاب درج کنید";

                Controller.Fragment.ShowWarning fdlg = new Fragment.ShowWarning(this, ValueToast);
                fdlg.Show(this.FragmentManager, "ebrahimfragment1");
            };

            editmyeventeditTextCaption = FindViewById<EditText>(Resource.Id.editmyeventeditTextCaption);
            editmyeventeditTextCaption.Typeface = font;
         
            //   editmyeventeditTextCaption.RequestFocus();

            editmyeventtxtviewcaptionevent = FindViewById<TextView>(Resource.Id.editmyeventtxtviewcaptionevent);
            editmyeventtxtviewcaptionevent.Typeface = font;

            editmyeventbuttonLocal = FindViewById<Button>(Resource.Id.editmyeventbuttonLocal);
            editmyeventbuttonLocal.Typeface = font;

           editmyeventbuttonLocal.Click += delegate {
                Fragment.EnterPlace fdlg = new Fragment.EnterPlace(this);
                fdlg.ShowsDialog = true;
                fdlg.Show(this.FragmentManager, "ebrahimfragmentfdlg");
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
                    else
                    {
                        if (e.GetPlace.Count == 0)
                        {
                            return;
                        }

                        editmyeventbuttonLocal.Text = "";
                        foreach (var item in e.GetPlace)
                        {
                           editmyeventbuttonLocal.Text += item.itemplace;
                        }
                     //  editmyeventbuttonshiraz.Visibility = ViewStates.Invisible;
                    }

                };
            };
           editmyeventbuttonshiraz = FindViewById<Button>(Resource.Id.editmyeventbuttonshiraz);
           editmyeventbuttonshiraz.Typeface = font;


           editmyeventtxtviewplace = FindViewById<TextView>(Resource.Id.editmyeventtxtviewplace);
           editmyeventtxtviewplace.Typeface = font;


           editmyeventedittextHelpAddress = FindViewById<EditText>(Resource.Id.editmyeventedittextHelpAddress);
           editmyeventedittextHelpAddress.Click += delegate
            {
                ValueToast = "می توانید آدرس  محل رویداد خود را در اینجا بنویسید";
                Controller.Fragment.ShowWarning fdlg = new Fragment.ShowWarning(this, ValueToast);
                fdlg.Show(this.FragmentManager, "ebrahimfragment1");

            };

           



            FindViewById<EditText>(Resource.Id.editmyeventeditexthelpcost).Click += delegate {
                Drawable errorIcon = Resources.GetDrawable(Resource.Drawable.academicblack32);



                FindViewById<EditText>(Resource.Id.editmyeventeditexthelpcost).SetError(Android.Text.Html.FromHtml("<font color='White'>منظور از هزینه رویداد میزان هرینه ای است که از مخاطب بابت شرکت در رویداد خود دریافت می نمایید یکی از گزینه های درج شده را انتخاب نمایید</font>"), errorIcon);

            };
          



            editmyeventeditTextAddres = FindViewById<EditText>(Resource.Id.editmyeventeditTextAddres);
           editmyeventeditTextAddres.Typeface = font;

            string editTextAddres = editmyeventeditTextAddres.Hint;
            string numberdigittAddres = editTextAddres.Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩");
            editmyeventeditTextAddres.Hint = numberdigittAddres;

            string editTextAddresText = editmyeventeditTextAddres.Text;
            string numberdigittAddresText = editTextAddresText.Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩");
            editmyeventeditTextAddres.Text = numberdigittAddresText;


            editmyeventtxtviewaddres = FindViewById<TextView>(Resource.Id.editmyeventtxtviewaddres);
            editmyeventtxtviewaddres.Typeface = font;

            editmyeventeditexthelpTime = FindViewById<EditText>(Resource.Id.editmyeventeditexthelpTime);
            editmyeventeditexthelpTime.Click += delegate
            {
                ValueToast = "بازه زمان برگزاری رویداد خود را مشخص کنید در صورتی که رویداد شما یک روزه است تاریخ شروع و پایان را یکسان انتخاب نمایید";
                Controller.Fragment.ShowWarning fdlg = new Fragment.ShowWarning(this, ValueToast);
                fdlg.Show(this.FragmentManager, "ebrahimfragment1");




            };
            

            editmyeventbuttotnTo = FindViewById<Button>(Resource.Id.editmyeventbuttotnTo);
            editmyeventbuttotnTo.Typeface = font;

            string buttotnTo = editmyeventbuttotnTo.Text;
            string myeventbuttotnTo = buttotnTo.Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩");
            editmyeventbuttotnTo.Text = myeventbuttotnTo;



            editmyeventbuttotnTo.Click += delegate {
                a = 2;

                Com.Mohamadamin.Persianmaterialdatetimepicker.Date.DatePickerDialog p = new Com.Mohamadamin.Persianmaterialdatetimepicker.Date.DatePickerDialog();
                Com.Mohamadamin.Persianmaterialdatetimepicker.Date.DatePickerDialog d = Com.Mohamadamin.Persianmaterialdatetimepicker.Date.DatePickerDialog.NewInstance(this, p.SelectedDay.Year, p.SelectedDay.Month, p.SelectedDay.Day);
                d.Show(FragmentManager, "ebrahimeditfragmnetto");
            };
            editmyeventtxtviewto = FindViewById<TextView>(Resource.Id.editmyeventtxtviewto);
            editmyeventtxtviewto.Typeface = font;

            editmyeventbuttonFrom = FindViewById<Button>(Resource.Id.editmyeventbuttonFrom);
            editmyeventbuttonFrom.Typeface = font;

            string buttonFrom = editmyeventbuttonFrom.Text;
            string myeventbuttonFrom = buttonFrom.Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩");
            editmyeventbuttonFrom.Text = myeventbuttonFrom;



            editmyeventbuttonFrom.Click += delegate {
                // a = 1;
                Com.Mohamadamin.Persianmaterialdatetimepicker.Date.DatePickerDialog p = new Com.Mohamadamin.Persianmaterialdatetimepicker.Date.DatePickerDialog();
                Com.Mohamadamin.Persianmaterialdatetimepicker.Date.DatePickerDialog d = Com.Mohamadamin.Persianmaterialdatetimepicker.Date.DatePickerDialog.NewInstance(this, p.SelectedDay.Year, p.SelectedDay.Month, p.SelectedDay.Day);
                d.Show(FragmentManager, "ebrahimeditfragmentdate");




            };
            editmyeventtxtviewfrom = FindViewById<TextView>(Resource.Id.editmyeventtxtviewfrom);
            editmyeventtxtviewfrom.Typeface = font;


            editmyeventtxtviewtime = FindViewById<TextView>(Resource.Id.editmyeventtxtviewtime);
            editmyeventtxtviewtime.Typeface = font;


        editmyeventbuttoncost = FindViewById<Button>(Resource.Id.editmyeventbuttoncost);
            editmyeventbuttoncost.Click += delegate
            {
                PanelCostFragment Pcost = new PanelCostFragment(this);
                Pcost.Show(this.FragmentManager, "ebrahimeditfragmentcost");
                Pcost.OnGetCurrentcost += delegate (object sender, GetAllItemCheckd e)
                {
                    if (e.GetCost != string.Empty)
                    {
                        editmyeventbuttoncost.Text = e.GetCost;
                    }

                };
            };

            editmyeventtxtviewCaptionCost.Click += delegate {
                if (editmyeventtxtviewCaptionCost.Text == string.Empty)
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

                        editmyeventtxtviewCaptionCost.Text = digitpersiannumber + "تومان";
                    
                        editmyeventtxtviewCaptionCost.SetTextColor(Android.Graphics.Color.ParseColor("#311b92"));
                        editmyeventtxtviewCaptionCost.Typeface = font;
                        editmyeventtxtviewCaptionCost.Gravity = GravityFlags.Center;
                        editmyeventtxtviewCaptionCost.RequestFocus();


                    };
                }


            };

            editmyeventtxtviewcost = FindViewById<TextView>(Resource.Id.editmyeventtxtviewcost);
            editmyeventtxtviewcost.Typeface = font;

            editmyeventedittexthelptel = FindViewById<EditText>(Resource.Id.enteteventedittexthelptel);
            editmyeventedittexthelptel.Click += delegate {

                ValueToast = ".شماره همراه جهت پاسخگویی به مخاطبین رویداد را درج نمایید.  پس از  ثبت رویداد در ایونتو پیامکی حاوی کد تایید به این شماره ارسال خواهد شد";
                Controller.Fragment.ShowWarning fdlg = new Fragment.ShowWarning(this, ValueToast);
                fdlg.Show(this.FragmentManager, "ebrahimfragment1");
            };
            EditText editmteventedittextHelpCaption;
            editmteventedittextHelpCaption = FindViewById<EditText>(Resource.Id.editmteventedittextHelpCaption);
           
            editmteventedittextHelpCaption = FindViewById<EditText>(Resource.Id.editmteventedittextHelpCaption);
            editmteventedittextHelpCaption.Click += delegate {
                

                ValueToast = "تیتر اصلی رویداد خود را شفاف و جذاب درج کنید";

                Controller.Fragment.ShowWarning fdlg = new Fragment.ShowWarning(this, ValueToast);
                fdlg.Show(this.FragmentManager, "ebrahimfragment1");
            };

          
            editmyeventeditTextTel = FindViewById<EditText>(Resource.Id.editmyeventeditTextTel);
            editmyeventeditTextTel.Typeface = font;

            string editTextTel = editmyeventeditTextTel.Hint;
            string numberdigitTel = editTextTel.Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩");
            editmyeventeditTextTel.Hint = numberdigitTel;

            string editTextTelText = editmyeventeditTextTel.Text;
            string numberdigitTelText = editTextTelText.Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩");
            editmyeventeditTextTel.Text = numberdigitTelText;




            editmyeventtxtviewtel = FindViewById<TextView>(Resource.Id.editmyeventtxtviewtel);
            editmyeventtxtviewtel.Typeface = font;

            editmyeventeditexthelpurl = FindViewById<EditText>(Resource.Id.editmyeventeditexthelpurl);

            editmyeventeditexthelpurl.Click += delegate {
                ValueToast = "در این قسمت میتوانید آدرس وب سایت یا شبکه های اجتماعی خود را درج نمایید";
                Controller.Fragment.ShowWarning fdlg = new Fragment.ShowWarning(this, ValueToast);
                fdlg.Show(this.FragmentManager, "ebrahimfragment1");



               
            };
         


            editmyeventeditTextUrl = FindViewById<EditText>(Resource.Id.editmyeventeditTextUrl);
            editmyeventeditTextUrl.Typeface = font;

            editmyeventtxtviewurl = FindViewById<TextView>(Resource.Id.editmyeventtxtviewurl);
            editmyeventtxtviewurl.Typeface = font;


            editmyeventeditexthelpdescription = FindViewById<EditText>(Resource.Id.editmyeventeditexthelpdescription);
            editmyeventeditexthelpdescription.Click += delegate {
                ValueToast = "اطلاعات تکمیلی رویداد خود از جمله شرایط هزینه را بطور کامل و شفاف ارایه دهید از درج هر گونه آدرس اینترنتی در این قسمت خودداری نمایید";
                Controller.Fragment.ShowWarning fdlg = new Fragment.ShowWarning(this, ValueToast);
                fdlg.Show(this.FragmentManager, "ebrahimfragment1");
                 
            };


            editmyeventeditexthelpdescription = FindViewById<EditText>(Resource.Id.editmyeventeditexthelpdescription);
     

            FindViewById<EditText>(Resource.Id.editmyeventedttexthelpcamera).Click += delegate {
                ValueToast = "  تصاویر مرتیط با رویداد خود را بار گذاری کنید.تصاویر مناسب باعث بیشتر دیده شدن رویداد شما خواهد شد" + ".";

                Controller.Fragment.ShowWarning fdlg = new Fragment.ShowWarning(this, ValueToast);
                fdlg.Show(this.FragmentManager, "ebrahimfragment1");



            };
            //
          


            editmyeventeditTextdesc = FindViewById<EditText>(Resource.Id.editmyeventeditTextdesc);
            editmyeventeditTextdesc.Typeface = font;

            editmyeventtxtviewdescription = FindViewById<TextView>(Resource.Id.editmyeventtxtviewdescription);
            editmyeventtxtviewdescription.Typeface = font;



            editmyeventbuttoncamera = FindViewById<Button>(Resource.Id.editmyeventbuttoncamera);
            editmyeventbuttoncamera.Typeface = font;
            editmyeventbuttoncamera.Click += delegate {
                var intentbrowserimage = new Intent();
                intentbrowserimage.SetAction(Intent.ActionGetContent);
                intentbrowserimage.SetType("image/*");
                StartActivityForResult(intentbrowserimage, 100);

            };

            editmyeventtxtviewphoto = FindViewById<TextView>(Resource.Id.editmyeventtxtviewphoto);
            editmyeventtxtviewphoto.Typeface = font;


            editmyeventlinearLayoutcamera = FindViewById<LinearLayout>(Resource.Id.editmyeventlinearLayoutcamera);

          
            editmyeventimageviewSend=FindViewById<ImageView>(Resource.Id.editmyeventimageviewSend);
           editmyeventimageviewSend.Click += delegate {

               if (editmyeventbuttoncaption.Text == "انتخاب شود")
               {
                   ValueToast = "موضوع رویداد اجباری می باشد";




                   editmyeventbuttoncaption.Error = ValueToast;



                   return;

               }
               if (editmyeventeditTextCaption.Text == string.Empty)
               {
                   ValueToast = "عنوان رویداد اجباری می باشد";

                   editmyeventeditTextCaption.Error = ValueToast;
                   return;
               }
               if (editmyeventbuttonLocal.Text == "محله")
               {
                   ValueToast = "  انتخاب محله اجباری می باشد";

                   editmyeventbuttonLocal.Error = ValueToast;



                   return;
               }
               if (editmyeventeditTextAddres.Text == string.Empty)
               {
                   ValueToast = "آدرس رویداد اجباری می باشد";
                   //Drawable icon = Resources.GetDrawable(Resource.Drawable.warning32);
                   //if (icon != null)
                   //{
                   //    icon.SetBounds(0, 0, icon.IntrinsicWidth, icon.IntrinsicHeight);
                   //}
                   editmyeventeditTextAddres.Error = ValueToast;
                   return;
               }
               if (editmyeventbuttonFrom.Text == "تاریخ شروع")
               {
                   ValueToast = "تاریخ شروع اجباری می باشد";

                   editmyeventbuttonFrom.Error = ValueToast;
                   return;
               }
               if (editmyeventbuttotnTo.Text == "تاریخ پایان")
               {
                   ValueToast = "تاریخ پایان اجباری می باشد";

                   editmyeventbuttotnTo.Error = ValueToast;
                   return;
               }
               if (editmyeventeditTextTel.Text == "تلفن تماس")
               {
                   ValueToast = "تلفن تماس اجباری می باشد";

                   editmyeventeditTextTel.Error = ValueToast;
                   return;
               }
               if (editmyeventeditTextdesc.Text.Length > 400)
               {
                   ValueToast = "توضیحات باید کمتر از 400 کاراکتر باشد";
                   //Drawable icon = Resources.GetDrawable(Resource.Drawable.warning32);
                   //if (icon != null)
                   //{
                   //    icon.SetBounds(0, 0, icon.IntrinsicWidth, icon.IntrinsicHeight);
                   //}
                   editmyeventeditTextdesc.Error = ValueToast;
                   return;
               }




               else
               {






                   ValueToast = "تغییرات رویداد با موفقیت انجام شد";


                   Snackbar snackBar = Snackbar.Make(editmyeventbuttonSend, ValueToast, Snackbar.LengthIndefinite).SetAction("تایید", (v) =>
                   {
                       Finish();
                   });

                   //set  action button text color 
                   snackBar.SetActionTextColor(Android.Graphics.Color.Green);

                   snackBar.Show();
                   //Android.App.AlertDialog.Builder alert = new Android.App.AlertDialog.Builder(this);


                   //alert.SetTitle("تایید رویداد");
                   //alert.SetIcon(Resource.Drawable.alert24);
                   //alert.SetMessage(ValueToast);
                   //alert.SetPositiveButton("باشه", (senderAlert, args) => {
                   //    Finish();

                   //});



                   //Dialog dialog = alert.Create();
                   //dialog.Show();
               }

           };
            editmyeventbuttonSend = FindViewById<Button>(Resource.Id.editmyeventbuttonSend);
            editmyeventbuttonSend.Typeface = font;
            editmyeventbuttonSend.Click += delegate {

                if (editmyeventbuttoncaption.Text == "انتخاب شود")
                {
                    ValueToast = "موضوع رویداد اجباری می باشد";




                    editmyeventbuttoncaption.Error = ValueToast;



                    return;

                }
                if (editmyeventeditTextCaption.Text == string.Empty)
                {
                    ValueToast = "عنوان رویداد اجباری می باشد";

                    editmyeventeditTextCaption.Error = ValueToast;
                    return;
                }
                if (editmyeventbuttonLocal.Text == "محله")
                {
                    ValueToast = "  انتخاب محله اجباری می باشد";

                    editmyeventbuttonLocal.Error = ValueToast;



                    return;
                }
                if (editmyeventeditTextAddres.Text == string.Empty)
                {
                    ValueToast = "آدرس رویداد اجباری می باشد";
                    //Drawable icon = Resources.GetDrawable(Resource.Drawable.warning32);
                    //if (icon != null)
                    //{
                    //    icon.SetBounds(0, 0, icon.IntrinsicWidth, icon.IntrinsicHeight);
                    //}
                    editmyeventeditTextAddres.Error = ValueToast;
                    return;
                }
                if (editmyeventbuttonFrom.Text == "تاریخ شروع")
                {
                    ValueToast = "تاریخ شروع اجباری می باشد";

                    editmyeventbuttonFrom.Error = ValueToast;
                    return;
                }
                if (editmyeventbuttotnTo.Text == "تاریخ پایان")
                {
                    ValueToast = "تاریخ پایان اجباری می باشد";

                    editmyeventbuttotnTo.Error = ValueToast;
                    return;
                }
                if (editmyeventeditTextTel.Text == "تلفن تماس")
                {
                    ValueToast = "تلفن تماس اجباری می باشد";

                    editmyeventeditTextTel.Error = ValueToast;
                    return;
                }
                if (editmyeventeditTextdesc.Text.Length > 400)
                {
                    ValueToast = "توضیحات باید کمتر از 400 کاراکتر باشد";
                    //Drawable icon = Resources.GetDrawable(Resource.Drawable.warning32);
                    //if (icon != null)
                    //{
                    //    icon.SetBounds(0, 0, icon.IntrinsicWidth, icon.IntrinsicHeight);
                    //}
                    editmyeventeditTextdesc.Error = ValueToast;
                    return;
                }




                else
                {

                 
              



                ValueToast = "تغییرات رویداد با موفقیت انجام شد";


                    Snackbar snackBar = Snackbar.Make(editmyeventbuttonSend, ValueToast, Snackbar.LengthIndefinite).SetAction("تایید", (v) =>
                    {
                        Finish();
                    });

                    //set  action button text color 
                    snackBar.SetActionTextColor(Android.Graphics.Color.Green);

                    snackBar.Show();
                    //Android.App.AlertDialog.Builder alert = new Android.App.AlertDialog.Builder(this);


                    //alert.SetTitle("تایید رویداد");
                    //alert.SetIcon(Resource.Drawable.alert24);
                    //alert.SetMessage(ValueToast);
                    //alert.SetPositiveButton("باشه", (senderAlert, args) => {
                    //    Finish();

                    //});



                    //Dialog dialog = alert.Create();
                    //dialog.Show();
                }
            };

            editmyeventbuttondelete = FindViewById<Button>(Resource.Id.editmyeventbuttondelete);
            editmyeventbuttondelete.Typeface = font;

            editmyeventbuttondelete.Text = "صرف نظر";
            editmyeventbuttondelete.Click += delegate {
                Finish();
            };




    
            editmyeventimageviewclose = FindViewById<ImageView>(Resource.Id.editmyeventimageviewclose);
            editmyeventimageviewclose.Click += delegate {
                Finish();

            };

        }
        private void Fdlg_OnGetCurrentItem(object sender, GetCurrentItem e)
        {
            editmyeventbuttoncaption.Text = e.GEtCheckBox;
            // entereventbuttoncaption.SetTextColor(Android.Graphics.Color.Red);

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
                img.SetImageBitmap(BitmapFactory.DecodeByteArray(selectedImageBytes, 00, selectedImageBytes.Length));

                editmyeventlinearLayoutcamera.AddView(img, 170, 170);
                editmyeventbuttoncamera.Text = "افزودن تصویر";

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
            string numberdigitday= day.Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩");

            if (a == 2)
            {
                editmyeventbuttotnTo.Text = numberdigitday + Month + numberdigittyear;

                a = 0;
            }
            else
            {
                editmyeventbuttonFrom.Text = numberdigitday + Month + numberdigittyear;
            }
        }
    }
}