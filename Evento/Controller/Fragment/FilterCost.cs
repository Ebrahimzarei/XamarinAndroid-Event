using System;


using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.OS;

using Android.Views;
using Android.Widget;

namespace Evento.Controller.Fragment
{
    public class GetcostEvent : EventArgs
    {
        public GetcostEvent(string _getPlace) : base()
        {
            GetPlace = _getPlace;
        }
        public string GetPlace { get; set; }


    }
    public class FilterCost : DialogFragment
    {
        public event EventHandler<GetcostEvent> OnGetcostEvent;
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }
        Context ctx;
        public FilterCost(Context _ctx)
        {
            ctx = _ctx;
        }
        public override void OnStart()
        {
            base.OnStart();
            Dialog dialog =  Dialog;
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

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var dlg = inflater.Inflate(Resource.Layout.layoutfiltercost, container, false);
            var font = Typeface.CreateFromAsset(ctx.Assets, "Estedad.ttf");
            LinearLayout lnaboutus = dlg.FindViewById<LinearLayout>(Resource.Id.filtercostlinearlayout);
            lnaboutus.SetBackgroundResource(Resource.Drawable.dialog_fragment_round);

            TextView filtercosttxtviewcaption = dlg.FindViewById<TextView>(Resource.Id.filtercosttxtviewcaption);
            filtercosttxtviewcaption.Typeface = font;
            Button filtercostbtnfree = dlg.FindViewById<Button>(Resource.Id.filtercostbtnfree);
            filtercostbtnfree.Typeface = font;
            filtercostbtnfree.Click += delegate {
                //رایگان
                OnGetcostEvent.Invoke(this, new GetcostEvent(filtercostbtnfree.Text));

                Dismiss(); };
            Button filtercostbtnInexpensive = dlg.FindViewById<Button>(Resource.Id.filtercostbtnInexpensive);
            filtercostbtnInexpensive.Typeface = font;
            filtercostbtnInexpensive.Click += delegate {
                //ارزان
                OnGetcostEvent.Invoke(this, new GetcostEvent(filtercostbtnInexpensive.Text));
                Dismiss();
            };
            Button filtercostbtnexpensive = dlg.FindViewById<Button>(Resource.Id.filtercostbtnexpensive);
            filtercostbtnexpensive.Typeface = font;
            filtercostbtnexpensive.Click += delegate {

                //گرانترین
                OnGetcostEvent.Invoke(this, new GetcostEvent(filtercostbtnexpensive.Text));
                Dismiss(); };
            return dlg;
        }
    }
}