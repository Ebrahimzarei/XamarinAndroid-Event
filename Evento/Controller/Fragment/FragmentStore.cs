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

    //فروشگاه

    public class GetStore : EventArgs
    {

        public GetStore(string _getcaptionstore) : base()
        {
            GetCaption = _getcaptionstore;
        }
        public string GetCaption { get; set; }


    }
    public class FragmnetStore : DialogFragment
    {
        TextView fragmentstoretxtviewheader;
        CheckBox fragmentstoreclothing;
        CheckBox fragmentstorechkcommodity;
        CheckBox fragmentstorechkfood;
        CheckBox fragmentstorechkhealth;
        CheckBox fragmentstorechkother;
        Button fragmentstorebtncancell;
        Context ctx;
        string value = "فروشگاه ها";

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
     
        public FragmnetStore(Context _ctx)
        {
            ctx = _ctx;
        }
        public event EventHandler<GetStore> OnGetCaptionStore;





        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var dlg = inflater.Inflate(Resource.Layout.layoutstore, container, false);
            //
            LinearLayout lnaboutus = dlg.FindViewById<LinearLayout>(Resource.Id.fragmentstorelinearlayout);
            lnaboutus.SetBackgroundResource(Resource.Drawable.dialog_fragment_round);
            var font = Typeface.CreateFromAsset(ctx.Assets, "Estedad.ttf");

          
         


            fragmentstoretxtviewheader = dlg.FindViewById<TextView>(Resource.Id.fragmentstoretxtviewheader);
            fragmentstoreclothing = dlg.FindViewById<CheckBox>(Resource.Id.fragmentstoreclothing);
            fragmentstorechkother = dlg.FindViewById<CheckBox>(Resource.Id.fragmentstorechkother);
            fragmentstorechkother.Typeface = font;
            //  CheckBox fragmentstoreclothing;


            fragmentstoretxtviewheader.Text = "انتخاب رویداد";
            fragmentstoretxtviewheader.Typeface = font;
            fragmentstoreclothing.Typeface = font;
            fragmentstorechkother.Click += delegate
            {


                OnGetCaptionStore.Invoke(this, new GetStore(value + "-" + fragmentstorechkother.Text));
                Dismiss();
            };
            fragmentstoreclothing.Click += delegate
            {


                OnGetCaptionStore.Invoke(this, new GetStore(value + "-" + fragmentstoreclothing.Text));
                Dismiss();
            };
         //   CheckBox fragmentstorechkcommodity;
       
            fragmentstorechkcommodity = dlg.FindViewById<CheckBox>(Resource.Id.fragmentstorechkcommodity);
            fragmentstorechkcommodity.Typeface = font;

            fragmentstorechkcommodity.Click += delegate
            {


                OnGetCaptionStore.Invoke(this, new GetStore(value + "-" + fragmentstorechkcommodity.Text));
                Dismiss();
            };
            fragmentstorechkfood = dlg.FindViewById<CheckBox>(Resource.Id.fragmentstorechkfood);
            fragmentstorechkfood.Typeface = font;

            fragmentstorechkfood.Click += delegate
            {


                OnGetCaptionStore.Invoke(this, new GetStore(value + "-" + fragmentstorechkfood.Text));
                Dismiss();
            };


            fragmentstorechkhealth = dlg.FindViewById<CheckBox>(Resource.Id.fragmentstorechkhealth);
            fragmentstorechkhealth.Typeface = font;

            fragmentstorechkhealth.Click += delegate
            {


                OnGetCaptionStore.Invoke(this, new GetStore(value + "-" + fragmentstorechkhealth.Text));
                Dismiss();
            };



            fragmentstorebtncancell = dlg.FindViewById<Button>(Resource.Id.fragmentstorebtncancell);
            fragmentstorebtncancell.Typeface = font;
            fragmentstorebtncancell.Click += delegate { Dismiss(); };
            return dlg;
        }

    }
}