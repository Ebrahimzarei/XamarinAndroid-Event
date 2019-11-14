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
    public class ShowWarning : DialogFragment
    {
        TextView ShowWarningTxtViewHeader;
        TextView ShowWarningTxtViewContent;
      
        Button ShowWarningBtnExit;
        Context ctx;
        string Content;
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
        public ShowWarning(Context _ctx,string _Content)
        {
            ctx = _ctx;
            Content = _Content;
        }
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var dlg = inflater.Inflate(Resource.Layout.layoutShowWarning, container, false);
            var font = Typeface.CreateFromAsset(ctx.Assets, "Estedad.ttf");
            LinearLayout lnaboutus = dlg.FindViewById<LinearLayout>(Resource.Id.ShowWarningLinearLayout);
            lnaboutus.SetBackgroundResource(Resource.Drawable.dialog_fragment_round);

            ShowWarningTxtViewHeader = dlg.FindViewById<TextView>(Resource.Id.ShowWarningTxtViewHeader);
            ShowWarningTxtViewHeader.Typeface = font;

            ShowWarningTxtViewContent = dlg.FindViewById<TextView>(Resource.Id.ShowWarningTxtViewContent);
            ShowWarningTxtViewContent.Text = Content;
            ShowWarningTxtViewContent.Typeface = font;
            ShowWarningBtnExit = dlg.FindViewById<Button>(Resource.Id.ShowWarningBtnExit);
            ShowWarningBtnExit.Typeface = font;
            ShowWarningBtnExit.Click += delegate { Dismiss(); };



            return dlg;
        }
    }
}