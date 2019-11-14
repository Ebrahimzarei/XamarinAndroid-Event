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
    //مذهبی
    public class GetCaptionReligiouse : EventArgs
    {

        public GetCaptionReligiouse(string _getcaptionereligiouse) : base()
        {
            GetValue = _getcaptionereligiouse;
        }
        public string GetValue { get; set; }


    }
    public class CaptionReligiouseFragment : DialogFragment
    {
        TextView captionreligiousetxtviewheader;
        CheckBox captionreligiousechkboxsiminar;
      
        CheckBox captionreligiousechkboxceremoney;
        Button captionreligiousebtncancell;
        string value = "مذهبی و دینی";
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
        public CaptionReligiouseFragment(Context _ctx)
        {
            ctx = _ctx;
        }
        public event EventHandler<GetCaptionReligiouse> OngetCaptionreligiouse;
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var dlg = inflater.Inflate(Resource.Layout.layoutcaptionreligiouse, container, false);
            var font = Typeface.CreateFromAsset(ctx.Assets, "Estedad.ttf");


            LinearLayout lnaboutus = dlg.FindViewById<LinearLayout>(Resource.Id.captionreligiouselinearlayout);
            lnaboutus.SetBackgroundResource(Resource.Drawable.dialog_fragment_round);



            captionreligiousebtncancell = dlg.FindViewById<Button>(Resource.Id.captionreligiousebtncancell);
            captionreligiousebtncancell.Typeface = font;

            captionreligiousebtncancell.Click += delegate {
               
                Dismiss();

            };


            captionreligiousetxtviewheader = dlg.FindViewById<TextView>(Resource.Id.captionreligiousetxtviewheader);
            captionreligiousetxtviewheader.Typeface = font;
            captionreligiousetxtviewheader.Text = "انتخاب رویداد";

            captionreligiousechkboxsiminar = dlg.FindViewById<CheckBox>(Resource.Id.captionreligiousechkboxsiminar);
            captionreligiousechkboxsiminar.Typeface = font;
            captionreligiousechkboxsiminar.Click += delegate {
           
              
                  captionreligiousechkboxceremoney.Checked = false;
                OngetCaptionreligiouse.Invoke(this, new GetCaptionReligiouse(value + "-" + captionreligiousechkboxsiminar.Text));
                Dismiss();

            };

            
            captionreligiousechkboxceremoney = dlg.FindViewById<CheckBox>(Resource.Id.captionreligiousechkboxceremoney);
            captionreligiousechkboxceremoney.Typeface = font;

            captionreligiousechkboxceremoney.Click += delegate {
                captionreligiousechkboxsiminar.Checked = false;
                 

                OngetCaptionreligiouse.Invoke(this, new GetCaptionReligiouse(value + "-" + captionreligiousechkboxceremoney.Text));
                Dismiss();

            };
            return dlg;
        }
    }
}