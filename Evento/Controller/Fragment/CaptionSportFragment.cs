using System;


using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.OS;

using Android.Views;
using Android.Widget;

namespace Evento.Controller.Fragment
{//ورزش و بازی
    public class GetCaptionSport : EventArgs
    {

        public GetCaptionSport(string _getcaptionsport) : base()
        {
            GetValue = _getcaptionsport;
        }
        public string GetValue { get; set; }


    }
    public class CaptionSportFragment : DialogFragment
    {
        TextView captiontxttxtviewheader;
   
        CheckBox captionsportchkboxsiminarsport;
        CheckBox captionsportchkboxcompetitions;
        CheckBox captionsportchkboxcongress;
        CheckBox captionsportchkboxlearning;
        CheckBox captionsportchkboxplacesport;
         Button   captionsportbuttoncancell;
        Context ctx;
        string value = "ورزش و سرگرمی";
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
        public CaptionSportFragment(Context _ctx)
        {
            ctx = _ctx;
        }
        public event EventHandler<GetCaptionSport> OnGetCaptionSport;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var dlg = inflater.Inflate(Resource.Layout.layoutcaptionsport, container, false);
            var font = Typeface.CreateFromAsset(ctx.Assets, "Estedad.ttf");


            LinearLayout lnaboutus = dlg.FindViewById<LinearLayout>(Resource.Id.captionsportlinearlayout);
            lnaboutus.SetBackgroundResource(Resource.Drawable.dialog_fragment_round);





            captiontxttxtviewheader = dlg.FindViewById<TextView>(Resource.Id.captiontxttxtviewheader);
            captiontxttxtviewheader.Typeface = font;
            captiontxttxtviewheader.Text = "انتخاب رویداد";


                        

            captionsportchkboxsiminarsport = dlg.FindViewById<CheckBox>(Resource.Id.captionsportchkboxsiminarsport);
            captionsportchkboxsiminarsport.Typeface = font;
            captionsportchkboxsiminarsport.Click += delegate {
                 

                  captionsportchkboxcompetitions.Checked = false;
                  captionsportchkboxcongress.Checked = false;
                  captionsportchkboxlearning.Checked = false;
                  captionsportchkboxplacesport.Checked = false;
                OnGetCaptionSport.Invoke(this, new GetCaptionSport(value + "-" + captionsportchkboxsiminarsport.Text));
                Dismiss(); };

            captionsportchkboxcompetitions = dlg.FindViewById<CheckBox>(Resource.Id.captionsportchkboxcompetitions);
            captionsportchkboxcompetitions.Typeface = font;
            captionsportchkboxcompetitions.Click += delegate {
                OnGetCaptionSport.Invoke(this, new GetCaptionSport(value + "-" + captionsportchkboxcompetitions.Text));
                Dismiss(); };

            captionsportchkboxcongress = dlg.FindViewById<CheckBox>(Resource.Id.captionsportchkboxcongress);
            captionsportchkboxcongress.Typeface = font;
            captionsportchkboxcongress.Click += delegate {
                 
                  captionsportchkboxsiminarsport.Checked = false;
                  captionsportchkboxcompetitions.Checked = false;

                  captionsportchkboxlearning.Checked = false;
                  captionsportchkboxplacesport.Checked = false;
                OnGetCaptionSport.Invoke(this, new GetCaptionSport(value + "-" + captionsportchkboxcongress.Text));
                Dismiss(); };

            captionsportchkboxlearning = dlg.FindViewById<CheckBox>(Resource.Id.captionsportchkboxlearning);
            captionsportchkboxlearning.Typeface = font;
            captionsportchkboxlearning.Click += delegate {
                 
                  captionsportchkboxsiminarsport.Checked = false;
                  captionsportchkboxcompetitions.Checked = false;
                  captionsportchkboxcongress.Checked = false;

                  captionsportchkboxplacesport.Checked = false;
                OnGetCaptionSport.Invoke(this, new GetCaptionSport(value + "-" + captionsportchkboxlearning.Text));
                Dismiss(); };

            captionsportchkboxplacesport = dlg.FindViewById<CheckBox>(Resource.Id.captionsportchkboxplacesport);
            captionsportchkboxplacesport.Typeface = font;
            captionsportchkboxplacesport.Click += delegate {
                  
                captionsportchkboxsiminarsport.Checked = false;
                captionsportchkboxcompetitions.Checked = false;
                captionsportchkboxcongress.Checked = false;
                captionsportchkboxlearning.Checked = false;
               

                OnGetCaptionSport.Invoke(this, new GetCaptionSport(value + "-" + captionsportchkboxplacesport.Text));
                Dismiss(); };


            captionsportbuttoncancell = dlg.FindViewById<Button>(Resource.Id.captionsportbuttoncancell);
            captionsportbuttoncancell.Typeface = font;
            captionsportbuttoncancell.Click += delegate { Dismiss(); };





            return dlg;
        }
    }
}