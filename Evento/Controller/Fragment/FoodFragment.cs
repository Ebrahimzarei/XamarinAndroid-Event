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

    //خوراکی

    public class GetCaptionFood : EventArgs
    {

        public GetCaptionFood(string _getcaptionfood) : base()
        {
            GetCaption = _getcaptionfood;
        }
        public string GetCaption { get; set; }


    }
    public class FoodFragment : DialogFragment
    {
        TextView fragmentfoodtxtviewheader;
        CheckBox frafoodchkboxexhibition;
        CheckBox frafoodchkboxcoffeshop;
        CheckBox frafoodchkboxresturant;
        CheckBox frafoodchkboxfastfood;

        //  Button frafoodbtncancell;
        Context ctx;
        string value = "اغذیه فروشی";

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
        public FoodFragment(Context _ctx)
        {
            ctx = _ctx;
        }
        public event EventHandler<GetCaptionFood> OnGetCaptionFood;





        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var dlg = inflater.Inflate(Resource.Layout.layout_Food, container, false);
            //
            LinearLayout lnaboutus = dlg.FindViewById<LinearLayout>(Resource.Id.fragmentfoodlinearlayout);
            lnaboutus.SetBackgroundResource(Resource.Drawable.dialog_fragment_round);
            var font = Typeface.CreateFromAsset(ctx.Assets, "Estedad.ttf");


            Button frafoodbtncancell;
            fragmentfoodtxtviewheader = dlg.FindViewById<TextView>(Resource.Id.fragmentfoodtxtviewheader);
            frafoodchkboxcoffeshop = dlg.FindViewById<CheckBox>(Resource.Id.frafoodchkboxcoffeshop);
            frafoodchkboxresturant = dlg.FindViewById<CheckBox>(Resource.Id.frafoodchkboxresturant);
            frafoodchkboxfastfood = dlg.FindViewById<CheckBox>(Resource.Id.frafoodchkboxfastfood);
            fragmentfoodtxtviewheader.Typeface = font;
            fragmentfoodtxtviewheader.Text = "انتخاب رویداد";

            frafoodchkboxexhibition = dlg.FindViewById<CheckBox>(Resource.Id.frafoodchkboxexhibition);
            frafoodchkboxexhibition.Typeface = font;
            frafoodchkboxexhibition.Click += delegate
            {


                frafoodchkboxcoffeshop.Checked = false;
                frafoodchkboxresturant.Checked = false;
                frafoodchkboxfastfood.Checked = false;



                OnGetCaptionFood.Invoke(this, new GetCaptionFood(value + "-" + frafoodchkboxexhibition.Text));
                Dismiss();
            };


            frafoodchkboxcoffeshop.Typeface = font;
            frafoodchkboxcoffeshop.Click += delegate
            {
                frafoodchkboxexhibition.Checked = false;

                frafoodchkboxresturant.Checked = false;
                frafoodchkboxfastfood.Checked = false;

                OnGetCaptionFood.Invoke(this, new GetCaptionFood(value + "-" + frafoodchkboxcoffeshop.Text));
                Dismiss();
            };


            frafoodchkboxresturant.Typeface = font;
            frafoodchkboxresturant.Click += delegate
            {
                frafoodchkboxexhibition.Checked = false;
                frafoodchkboxcoffeshop.Checked = false;

                frafoodchkboxfastfood.Checked = false;
                OnGetCaptionFood.Invoke(this, new GetCaptionFood(value + "-" + frafoodchkboxresturant.Text));
                Dismiss();
            };


            frafoodchkboxfastfood.Typeface = font;
            frafoodchkboxfastfood.Click += delegate
            {
                frafoodchkboxexhibition.Checked = false;
                frafoodchkboxcoffeshop.Checked = false;
                frafoodchkboxresturant.Checked = false;

                OnGetCaptionFood.Invoke(this, new GetCaptionFood(value + "-" + frafoodchkboxfastfood.Text));
                Dismiss();
            };






            frafoodbtncancell = dlg.FindViewById<Button>(Resource.Id.frafoodbtncancell);
            frafoodbtncancell.Typeface = font;
            frafoodbtncancell.Click += delegate { Dismiss(); };
            return dlg;
        }


    }
}