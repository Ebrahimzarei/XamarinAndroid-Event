using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace Evento.Controller.Fragment
{
    public class Reportevent : DialogFragment
    {
        Context ctx;
        TextView reporteventtxtviewcaption;
        CheckBox reporteventchk1;
        CheckBox reporteventchk2;
        CheckBox reporteventchk3;
        CheckBox reporteventchk4;
        CheckBox reporteventchk5;
        CheckBox reporteventchk6;
        
        CheckBox reporteventchk8;
        Button reporteventbtncancell;
        Button reporteventbtnsend;


        public Reportevent(Context _ctx)
        {
            ctx = _ctx;
        }
        public override void OnStart()
        {
            base.OnStart();
            Dialog dialog = Dialog;
            if (dialog != null)
            {
                dialog.Window.SetBackgroundDrawable(new ColorDrawable(Color.Transparent));
                int width = ViewGroup.LayoutParams.MatchParent;
                int height = ViewGroup.LayoutParams.WrapContent;
                dialog.Window.SetLayout(width, height);
                InsetDrawable inset = new InsetDrawable(new ColorDrawable(color: Color.Transparent), 20, 20, 20, 20);
                dialog.Window.SetBackgroundDrawable(inset); dialog.Window.SetLayout(400, ViewGroup.LayoutParams.WrapContent);
                dialog.Window.SetBackgroundDrawable(new ColorDrawable(Color.Transparent));
            }
        }
        public override Dialog OnCreateDialog(Bundle savedInstanceState)
        {
            Dialog NotTitle = base.OnCreateDialog(savedInstanceState);
            NotTitle.Window.RequestFeature(WindowFeatures.NoTitle);

            return NotTitle;
        }
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }


        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            // return inflater.Inflate(Resource.Layout.YourFragment, container, false);

            var dlg = inflater.Inflate(Resource.Layout.layoutReportEvent, container, false);
            var font = Typeface.CreateFromAsset(ctx.Assets, "Estedad.ttf");
            LinearLayout lnaboutus = dlg.FindViewById<LinearLayout>(Resource.Id.reporteventlinearlayout);
            lnaboutus.SetBackgroundResource(Resource.Drawable.dialog_fragment_round);
            reporteventtxtviewcaption = dlg.FindViewById<TextView>(Resource.Id.reporteventtxtviewcaption); ;
            reporteventtxtviewcaption.Typeface = font;

            reporteventchk1 = dlg.FindViewById<CheckBox>(Resource.Id.reporteventchk1);
            reporteventchk1.Typeface = font;

            reporteventchk2 = dlg.FindViewById<CheckBox>(Resource.Id.reporteventchk2);
            reporteventchk2.Typeface = font;

            reporteventchk3 = dlg.FindViewById<CheckBox>(Resource.Id.reporteventchk3);
            reporteventchk3.Typeface = font;


            reporteventchk4 = dlg.FindViewById<CheckBox>(Resource.Id.reporteventchk4);
            reporteventchk4.Typeface = font;

            reporteventchk5 = dlg.FindViewById<CheckBox>(Resource.Id.reporteventchk5);
            reporteventchk5.Typeface = font;

            reporteventchk6 = dlg.FindViewById<CheckBox>(Resource.Id.reporteventchk6);
            reporteventchk6.Typeface = font;

       

            reporteventchk8 = dlg.FindViewById<CheckBox>(Resource.Id.reporteventchk8);
            reporteventchk8.Typeface = font;

            reporteventbtncancell = dlg.FindViewById<Button>(Resource.Id.reporteventbtncancell);
            reporteventbtncancell.Typeface = font;
            reporteventbtncancell.Click += delegate { Dismiss(); };

            reporteventbtnsend = dlg.FindViewById<Button>(Resource.Id.reporteventbtnsend);
            reporteventbtnsend.Typeface = font;
           
            reporteventbtnsend.Click += delegate {

                Toast treport = Toast.MakeText(ctx, "شکایت شما از رویداد ثبت شد و در اسرع وقت پیگیری خواهد شد", ToastLength.Long);
                treport.SetGravity(GravityFlags.Center, 0, 0);
                treport.Show();
                Dismiss();

            };

       

            return dlg;
        }
    }
}