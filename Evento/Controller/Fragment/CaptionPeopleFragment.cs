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
    //مردمی
    public class GetCaptionPeople : EventArgs
    {

        public GetCaptionPeople(string _getcaptionevent) : base()
        {
            GEtValue = _getcaptionevent;
        }
        public string GEtValue { get; set; }


    }
    public class CaptionPeopleFragment : DialogFragment
    {
        TextView captionpeopletxtviewheader;
        CheckBox  captionpeoplechkboxseminar;
        CheckBox captionpeoplechkboxcongrees;
        CheckBox captionpeoplechkboxsales;
        Button    captionpeoplebtncancell;
        Context ctx;
        string value = "داوطلبانه و مردمی";
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
        public CaptionPeopleFragment(Context _ctx)
        {
            ctx = _ctx;
        }
        public event EventHandler<GetCaptionPeople> OngetCaptionPeople;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var dlg = inflater.Inflate(Resource.Layout.layoutcaptionpeople, container, false);
            var font = Typeface.CreateFromAsset(ctx.Assets, "Estedad.ttf");
            LinearLayout lnaboutus = dlg.FindViewById<LinearLayout>(Resource.Id.CaptionPeopleLinearlayout);
            lnaboutus.SetBackgroundResource(Resource.Drawable.dialog_fragment_round);

            captionpeopletxtviewheader = dlg.FindViewById<TextView>(Resource.Id.captionpeopletxtviewheader); 
            captionpeopletxtviewheader.Typeface = font;
            captionpeopletxtviewheader.Text = "انتخاب رویداد";

             captionpeoplechkboxseminar = dlg.FindViewById<CheckBox>(Resource.Id.captionpeoplechkboxseminar);
            captionpeoplechkboxseminar.Typeface = font;

            captionpeoplechkboxseminar.Click += delegate {
                
                  captionpeoplechkboxcongrees.Checked = false;
                  captionpeoplechkboxsales.Checked = false;
                OngetCaptionPeople.Invoke(this, new GetCaptionPeople(value + "-" + captionpeoplechkboxseminar.Text));
                Dismiss();

            };
             captionpeoplechkboxcongrees=dlg.FindViewById<CheckBox>(Resource.Id.captionpeoplechkboxcongrees);
            captionpeoplechkboxcongrees.Typeface = font;
            captionpeoplechkboxcongrees.Click += delegate 
            {
                  captionpeoplechkboxseminar.Checked = false;

                  captionpeoplechkboxsales.Checked = false;
                OngetCaptionPeople.Invoke(this, new GetCaptionPeople(value + "-" + captionpeoplechkboxcongrees.Text));
                Dismiss();
            };
             captionpeoplechkboxsales=dlg.FindViewById<CheckBox>(Resource.Id.captionpeoplechkboxsales);
            captionpeoplechkboxsales.Typeface = font;
            captionpeoplechkboxsales.Click += delegate {

                  captionpeoplechkboxseminar.Checked = false;
                captionpeoplechkboxcongrees.Checked=false;
              
                OngetCaptionPeople.Invoke(this, new GetCaptionPeople(value+"-"+captionpeoplechkboxsales.Text));

                Dismiss();
            };
            // 

             captionpeoplebtncancell= dlg.FindViewById<Button>(Resource.Id.captionpeoplebtncancell); ;
            captionpeoplebtncancell.Typeface = font;
            captionpeoplebtncancell.Click += delegate { Dismiss(); };
            return dlg;
        }
    }
}