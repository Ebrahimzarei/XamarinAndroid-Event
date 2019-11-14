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
using Android.Support.Design.Widget;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace Evento.Controller.Fragment
{
    public class StatuseDeleteFragment : DialogFragment
    {
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
                dialog.Window.SetBackgroundDrawable(inset);
            }
        }
        public override Dialog OnCreateDialog(Bundle savedInstanceState)
        {
            Dialog NotTitle = base.OnCreateDialog(savedInstanceState);
            NotTitle.Window.RequestFeature(WindowFeatures.NoTitle);

            return NotTitle;
        }
        Context ctx;
        public StatuseDeleteFragment(Context _ctx)
        {
            ctx = _ctx;
        }
        TextView statusedeletetxtviewcaption;
        CheckBox statusedelterchkboxnotevent;
        CheckBox statusedeletechknotokeyevent;
        CheckBox statusedeletechkcancell;
        Button statusedeletebuttonenter;


        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var dlg = inflater.Inflate(Resource.Layout.layoutStatuseDelete, container, false);
            var font = Typeface.CreateFromAsset(ctx.Assets, "Estedad.ttf");
            LinearLayout lnaboutus = dlg.FindViewById<LinearLayout>(Resource.Id.statusedeltelinearlayout);
            lnaboutus.SetBackgroundResource(Resource.Drawable.dialog_fragment_round);

            statusedeletetxtviewcaption =dlg.FindViewById<TextView>(Resource.Id.statusedeletetxtviewcaption);
            statusedeletetxtviewcaption.Typeface = font;
             statusedelterchkboxnotevent=dlg.FindViewById<CheckBox>(Resource.Id.statusedelterchkboxnotevent);
            statusedelterchkboxnotevent.Typeface = font;
            statusedelterchkboxnotevent.Click += delegate 
            {
                statusedeletechknotokeyevent.Checked = false;
                statusedeletechkcancell.Checked = false;
            };

             statusedeletechknotokeyevent = dlg.FindViewById<CheckBox>(Resource.Id.statusedeletechknotokeyevent);
            statusedeletechknotokeyevent.Typeface = font;
            statusedeletechknotokeyevent.Click += delegate 
            {
                statusedelterchkboxnotevent.Checked = false;
                statusedeletechkcancell.Checked = false;
            };
             statusedeletechkcancell = dlg.FindViewById<CheckBox>(Resource.Id.statusedeletechkcancell);
            statusedeletechkcancell.Typeface = font;
            statusedeletechkcancell.Click += delegate {
                statusedelterchkboxnotevent.Checked = false;
                statusedeletechknotokeyevent.Checked = false;
            };
            Button statusedeletebuttonenter = dlg.FindViewById<Button>(Resource.Id.statusedeletebuttonenter);
            statusedeletebuttonenter.Typeface = font;
            statusedeletebuttonenter.Click += delegate
            {
                Snackbar snackBar = Snackbar.Make(statusedeletebuttonenter, "حذف رویداد با موفقیت انجام شد", Snackbar.LengthIndefinite).SetAction("باشه", (v) =>
                {
                    Dismiss();
                });
                snackBar.SetActionTextColor(Android.Graphics.Color.Green);

                snackBar.Show();
            };

            return dlg;
        }
    }
}