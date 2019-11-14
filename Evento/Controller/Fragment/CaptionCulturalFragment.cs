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

    //فرهنگی هنری

    public class GetCaptionCultrual: EventArgs
    {

        public GetCaptionCultrual(string _getcaptionCultrural) : base()
        {
            GetCaption = _getcaptionCultrural;
        }
        public string GetCaption { get; set; }


    }
    public class CaptionCulturalFragment : DialogFragment
    {
        TextView captioncultrualtxtviewheader;
        CheckBox captioncultralchkboxsiminar;
        CheckBox captioncultralchkboxcinema;
        CheckBox captioncultralchkboxcocert;
        CheckBox captioncultralchkboxgallery;
        CheckBox captioncultralchkboxcongrees;
        CheckBox captioncultralchkbxattractions;
     //   CheckBox captioncultralchkboxlearning;
        Button   captioneventbtncancelll;
        Context ctx;
        string value = "فرهنگی هنری";

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
                dialog.Window.SetBackgroundDrawable(inset); dialog.Window.SetLayout(400, 500);
                dialog.Window.SetBackgroundDrawable(new ColorDrawable(Color.Transparent));
            }
        }
        public override Dialog OnCreateDialog(Bundle savedInstanceState)
        {
            Dialog NotTitle = base.OnCreateDialog(savedInstanceState);
            NotTitle.Window.RequestFeature(WindowFeatures.NoTitle);

            return NotTitle;
        }
        public CaptionCulturalFragment(Context _ctx)
        {
            ctx = _ctx;
        }
        public event EventHandler<GetCaptionCultrual> OnGetCaptionCultrual;





        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var dlg = inflater.Inflate(Resource.Layout.layoutcaptioncultural, container, false);
            var font = Typeface.CreateFromAsset(ctx.Assets, "Estedad.ttf");

            LinearLayout lnaboutus = dlg.FindViewById<LinearLayout>(Resource.Id.LinearlayoutfragmentCaptioncultrual);
            lnaboutus.SetBackgroundResource(Resource.Drawable.dialog_fragment_round);

            captioncultrualtxtviewheader = dlg.FindViewById<TextView>(Resource.Id.captioncultrualtxtviewheader);
            captioncultrualtxtviewheader.Typeface = font;
            captioncultrualtxtviewheader.Text = "انتخاب رویداد";

             captioncultralchkboxsiminar = dlg.FindViewById<CheckBox>(Resource.Id.captioncultralchkboxsiminar);
            captioncultralchkboxsiminar.Typeface = font;
            captioncultralchkboxsiminar.Click += delegate {
                
                  captioncultralchkboxcinema.Checked=false;
                  captioncultralchkboxcocert.Checked = false;
                  captioncultralchkboxgallery.Checked = false;
                  captioncultralchkboxcongrees.Checked = false;
                  captioncultralchkbxattractions.Checked = false;
              //    captioncultralchkboxlearning.Checked = false;

                OnGetCaptionCultrual.Invoke(this, new GetCaptionCultrual(value + "-" + captioncultralchkboxsiminar.Text));
                Dismiss();
            };

            captioncultralchkboxcinema = dlg.FindViewById<CheckBox>(Resource.Id.captioncultralchkboxcinema);
            captioncultralchkboxcinema.Typeface = font;
            captioncultralchkboxcinema.Click += delegate {
                  captioncultralchkboxsiminar.Checked = false;

                  captioncultralchkboxcocert.Checked = false;
                  captioncultralchkboxgallery.Checked = false;
                  captioncultralchkboxcongrees.Checked = false;
                  captioncultralchkbxattractions.Checked = false;
               //   captioncultralchkboxlearning.Checked = false;
                OnGetCaptionCultrual.Invoke(this, new GetCaptionCultrual(value + "-" + captioncultralchkboxcinema.Text));
                Dismiss();
            };

            captioncultralchkboxcocert = dlg.FindViewById<CheckBox>(Resource.Id.captioncultralchkboxcocert);
            captioncultralchkboxcocert.Typeface = font;
            captioncultralchkboxcocert.Click += delegate {
                  captioncultralchkboxsiminar.Checked = false;
                  captioncultralchkboxcinema.Checked = false;
               
                  captioncultralchkboxgallery.Checked = false;
                  captioncultralchkboxcongrees.Checked = false;
                  captioncultralchkbxattractions.Checked = false;
                //  captioncultralchkboxlearning.Checked = false;
                OnGetCaptionCultrual.Invoke(this, new GetCaptionCultrual(value + "-" + captioncultralchkboxcocert.Text));
                Dismiss();
            };

            captioncultralchkboxgallery = dlg.FindViewById<CheckBox>(Resource.Id.captioncultralchkboxgallery);
            captioncultralchkboxgallery.Typeface = font;
            captioncultralchkboxgallery.Click += delegate {
                  captioncultralchkboxsiminar.Checked = false;
                  captioncultralchkboxcinema.Checked = false;
                  captioncultralchkboxcocert.Checked = false;
           
                  captioncultralchkboxcongrees.Checked = false;
                  captioncultralchkbxattractions.Checked = false;
                //  captioncultralchkboxlearning.Checked = false;
                OnGetCaptionCultrual.Invoke(this, new GetCaptionCultrual(value + "-" + captioncultralchkboxgallery.Text));
                Dismiss();
            };

            captioncultralchkboxcongrees = dlg.FindViewById<CheckBox>(Resource.Id.captioncultralchkboxcongrees);
            captioncultralchkboxcongrees.Typeface = font;
            captioncultralchkboxcongrees.Click += delegate {
                  captioncultralchkboxsiminar.Checked = false;
                  captioncultralchkboxcinema.Checked = false;
                  captioncultralchkboxcocert.Checked = false;
                  captioncultralchkboxgallery.Checked = false;

                  captioncultralchkbxattractions.Checked = false;
                //  captioncultralchkboxlearning.Checked = false;
                OnGetCaptionCultrual.Invoke(this, new GetCaptionCultrual(value + "-" + captioncultralchkboxcongrees.Text));
                Dismiss();
            };

            captioncultralchkbxattractions = dlg.FindViewById<CheckBox>(Resource.Id.captioncultralchkbxattractions);
            captioncultralchkbxattractions.Typeface = font;
            captioncultralchkbxattractions.Click += delegate {
                  captioncultralchkboxsiminar.Checked = false;
                  captioncultralchkboxcinema.Checked = false;
                  captioncultralchkboxcocert.Checked = false;
                  captioncultralchkboxgallery.Checked = false;
                  captioncultralchkboxcongrees.Checked = false;
               
               //   captioncultralchkboxlearning.Checked = false;
                OnGetCaptionCultrual.Invoke(this, new GetCaptionCultrual(value + "-" + captioncultralchkbxattractions.Text));
                Dismiss();
            };

          

            captioneventbtncancelll = dlg.FindViewById<Button>(Resource.Id.captioneventbtncancell);
            captioneventbtncancelll.Typeface = font;
            captioneventbtncancelll.Click += delegate { Dismiss(); };
            return dlg;
        }
    }
}