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
    //تماس با ایونتوو
    public class TellEventoFragment : DialogFragment
    {
        readonly TextView EventoTellTxtviewcaptipn;
        readonly TextView EventoTellTxtviewcaptipnOne;
        readonly TextView EventoTellTxtviewcaptipnTwo;
        readonly TextView EventoTellTxtviewcaptipnThree;
        readonly Button EventoTellBtnEnter;
        Context ctx;
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
        public TellEventoFragment(Context _ctx)
        {
            ctx = _ctx;
        }



        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var dlg = inflater.Inflate(Resource.Layout.layoutEventoTell, container, false);
            var font = Typeface.CreateFromAsset(ctx.Assets, "Estedad.ttf");
            LinearLayout lnaboutus = dlg.FindViewById<LinearLayout>(Resource.Id.EventoTelllinearlayout);
            lnaboutus.SetBackgroundResource(Resource.Drawable.dialog_fragment_round);

            TextView EventoTellTxtviewcaptipn= dlg.FindViewById<TextView>(Resource.Id.EventoTellTxtviewcaptipn);
            EventoTellTxtviewcaptipn.Typeface = font;
            TextView EventoTellTxtviewcaptipnOne = dlg.FindViewById<TextView>(Resource.Id.EventoTellTxtviewcaptipnOne);
            EventoTellTxtviewcaptipnOne.Typeface = font;
            TextView EventoTellTxtviewcaptipnTwo = dlg.FindViewById<TextView>(Resource.Id.EventoTellTxtviewcaptipnTwo);
            EventoTellTxtviewcaptipnTwo.Typeface = font;
            TextView EventoTellTxtviewcaptipnThree = dlg.FindViewById<TextView>(Resource.Id.EventoTellTxtviewcaptipnThree);
            EventoTellTxtviewcaptipnThree.Typeface = font;
            Button EventoTellBtnEnter = dlg.FindViewById<Button>(Resource.Id.EventoTellBtnEnter);
            EventoTellBtnEnter.Typeface = font;
            EventoTellBtnEnter.Click += delegate { Dismiss(); };

            return dlg;

        }
    }
}