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

    //سلامتی و زیبایی

    public class GetHealth : EventArgs
    {

        public GetHealth(string _getcaptionfood) : base()
        {
            GetCaption = _getcaptionfood;
        }
        public string GetCaption { get; set; }


    }
    public class HealthFragment : DialogFragment
    {
        TextView fragmenthealthtxtviewheader;
        CheckBox fragmentchkhealth;
        CheckBox fragmentchkadvice;
        Button fragmentbtncancell;
        Context ctx;
        string value = "سلامتی و زیبایی";

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
        public HealthFragment(Context _ctx)
        {
            ctx = _ctx;
        }
        public event EventHandler<GetHealth> OnGetCaptionHealth;





        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var dlg = inflater.Inflate(Resource.Layout.layout_Fragmenthealth, container, false);
            //
            LinearLayout lnaboutus = dlg.FindViewById<LinearLayout>(Resource.Id.fragmenthealthlinearlayout);
            lnaboutus.SetBackgroundResource(Resource.Drawable.dialog_fragment_round);
            var font = Typeface.CreateFromAsset(ctx.Assets, "Estedad.ttf");
           



            fragmenthealthtxtviewheader = dlg.FindViewById<TextView>(Resource.Id.fragmenthealthtxtviewheader);
            fragmentchkhealth = dlg.FindViewById<CheckBox>(Resource.Id.fragmentchkbarber);


            fragmenthealthtxtviewheader.Text = "انتخاب رویداد";
            fragmenthealthtxtviewheader.Typeface = font;
            fragmentchkhealth.Typeface = font;
            fragmentchkhealth.Click += delegate
            {


                OnGetCaptionHealth.Invoke(this, new GetHealth(value + "-" + fragmentchkhealth.Text));
                Dismiss();
            };
              fragmentchkadvice = dlg.FindViewById<CheckBox>(Resource.Id.fragmentchkbarber);
            fragmentchkadvice.Typeface = font;

            fragmentchkadvice.Click += delegate
            {


                OnGetCaptionHealth.Invoke(this, new GetHealth(value + "-" + fragmentchkadvice.Text));
                Dismiss();
            };



            fragmentbtncancell = dlg.FindViewById<Button>(Resource.Id.fragmentbtncancell);
            fragmentbtncancell.Typeface = font;
            fragmentbtncancell.Click += delegate { Dismiss(); };
            return dlg;
        }

    }
}