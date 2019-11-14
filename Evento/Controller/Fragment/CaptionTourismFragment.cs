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

    //گردشگری و سرگرمی
    public class GetCaptionTourism : EventArgs
    {

        public GetCaptionTourism(string _getcaptiontourism) : base()
        {
            GetValue = _getcaptiontourism;
        }
        public string GetValue { get; set; }


    }
    public class CaptionTourismFragment : DialogFragment
    {

        TextView captiontourismtxtviewheader;
         
        CheckBox captiontourisnchkboxtour;
        
        CheckBox captiontourismchkboxplacetourism;
        Button captioneventbtncancell;
        Context ctx;
        string value = "تفریح و گردشگری";
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
        public CaptionTourismFragment(Context _ctx)
        {
            ctx = _ctx;
        }
        public event EventHandler<GetCaptionTourism> OnGetCaptionTourism;


        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var dlg = inflater.Inflate(Resource.Layout.layoutcaptiontourism, container, false);
            var font = Typeface.CreateFromAsset(ctx.Assets, "Estedad.ttf");
            LinearLayout lnaboutus = dlg.FindViewById<LinearLayout>(Resource.Id.captiontourismLinearlayout);
            lnaboutus.SetBackgroundResource(Resource.Drawable.dialog_fragment_round);
            captioneventbtncancell = dlg.FindViewById<Button>(Resource.Id.captioneventbtncancell);
            captioneventbtncancell.Typeface = font;
            captioneventbtncancell.Click += delegate {
              
                Dismiss();

            };


            captiontourismtxtviewheader = dlg.FindViewById<TextView>(Resource.Id.captiontourismtxtviewheader);
            captiontourismtxtviewheader.Typeface = font;
            captiontourismtxtviewheader.Text = "انتخاب رویداد";

            captiontourismchkboxplacetourism = dlg.FindViewById<CheckBox>(Resource.Id.captiontourismchkboxplacetourism);
            captiontourismchkboxplacetourism.Typeface = font;
            captiontourismchkboxplacetourism.Click += delegate {
                 
                 captiontourisnchkboxtour.Checked = false;
               

                OnGetCaptionTourism.Invoke(this, new GetCaptionTourism(value + "-" + captiontourismchkboxplacetourism.Text));
                Dismiss();

            };

            

            captiontourisnchkboxtour = dlg.FindViewById<CheckBox>(Resource.Id.captiontourisnchkboxtour);
            captiontourisnchkboxtour.Typeface = font;
            captiontourisnchkboxtour.Click += delegate {
                 

                 
                  captiontourismchkboxplacetourism.Checked = false;
                OnGetCaptionTourism.Invoke(this, new GetCaptionTourism(value + "-" + captiontourisnchkboxtour.Text));
                Dismiss();

            };

           
            return dlg;
        }
    }
}