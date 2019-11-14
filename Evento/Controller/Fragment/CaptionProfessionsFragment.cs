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
    //علمی و تخصصی
    public class GetCaptionProfessions : EventArgs
    {

        public GetCaptionProfessions(string _getcaptionProfessions) : base()
        {
            GetValue = _getcaptionProfessions;
        }
        public string GetValue { get; set; }


    }
    public class CaptionProfessionsFragment : DialogFragment
    {
        TextView captionprofesionstxtviewheader;
        CheckBox captionoprofesionschkboxseminar;
        CheckBox captionprofesinschkboxconferance;
        CheckBox captionprofesionschkboxlearning;
        Button captionprofesionbtncancell;
        Context ctx;
        string value = "علمی و تخصصی";
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
        public CaptionProfessionsFragment(Context _ctx)
        {
            ctx = _ctx;
        }
        public event EventHandler<GetCaptionProfessions> OnGetCaptionProfessions;
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var dlg = inflater.Inflate(Resource.Layout.layoutcaptionprofesions, container, false);
            var font = Typeface.CreateFromAsset(ctx.Assets, "Estedad.ttf");


            LinearLayout lnaboutus = dlg.FindViewById<LinearLayout>(Resource.Id.CAptionprofessionlinearlayout);
            lnaboutus.SetBackgroundResource(Resource.Drawable.dialog_fragment_round);


            captionprofesionstxtviewheader = dlg.FindViewById<TextView>(Resource.Id.captionprofesionstxtviewheader);
            captionprofesionstxtviewheader.Typeface = font;
            captionprofesionstxtviewheader.Text = "انتخاب رویداد";

            captionprofesionbtncancell = dlg.FindViewById<Button>(Resource.Id.captionprofesionbtncancell);
            captionprofesionbtncancell.Typeface = font;

            captionprofesionbtncancell.Click += delegate {
               
                Dismiss();

            };


            captionprofesionschkboxlearning = dlg.FindViewById<CheckBox>(Resource.Id.captionprofesionschkboxlearning);
            captionprofesionschkboxlearning.Typeface = font;

            captionprofesionschkboxlearning.Click += delegate {
                  captionoprofesionschkboxseminar.Checked = false;
                  captionprofesinschkboxconferance.Checked = false;

                OnGetCaptionProfessions.Invoke(this, new GetCaptionProfessions(value + "-" + captionprofesionschkboxlearning.Text));
                Dismiss();

            };


            captionprofesinschkboxconferance = dlg.FindViewById<CheckBox>(Resource.Id.captionprofesinschkboxconferance);
            captionprofesinschkboxconferance.Typeface = font;

            captionprofesinschkboxconferance.Click += delegate {
                  captionoprofesionschkboxseminar.Checked = false;

                  captionprofesionschkboxlearning.Checked = false;
                OnGetCaptionProfessions.Invoke(this, new GetCaptionProfessions(value + "-" + captionprofesinschkboxconferance.Text));
                Dismiss();

            };



            captionoprofesionschkboxseminar = dlg.FindViewById<CheckBox>(Resource.Id.captionoprofesionschkboxseminar);
            captionoprofesionschkboxseminar.Typeface = font;

            captionoprofesionschkboxseminar.Click += delegate {
             
                  captionprofesinschkboxconferance.Checked = false;
                captionprofesionschkboxlearning.Checked=false;
                OnGetCaptionProfessions.Invoke(this, new GetCaptionProfessions(value + "-" + captionoprofesionschkboxseminar.Text));
                Dismiss();

            };
            return dlg;
        }
    }
}