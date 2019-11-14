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

    public class GetClassEduction : EventArgs
    {

        public GetClassEduction(string _getclasseduction) : base()
        {
            GetCaption = _getclasseduction;
        }
        public string GetCaption { get; set; }


    }
    public class ClassEductionFragment : DialogFragment
    {
        TextView fragmentclasseductiontxtheader;
        CheckBox fragmentclasseductionchktourism;
        CheckBox captioneventradsport;
        CheckBox fragmentclasseductionchkfood;
        CheckBox fragmentclasseductionchkreligion;
        CheckBox fragmentclasseductionchkskill;
        CheckBox fragmentclasseductionchklessonschool;
        CheckBox fragmentclasseductionchklanguage;
        CheckBox fragmentclasseductionchkmoshavere;

        CheckBox fragmentclasseductionchkcultrual;
        CheckBox fragmentclasseductionchkmedicall;
        CheckBox fragmentclasseductionchkperfect;
        CheckBox fragmentclasseductionchkmusic;
        CheckBox fragmentclasseductionchktakephoto;
        CheckBox fragmentclasseductionchkworkshop;
        CheckBox fragmentclasseductionchkother;


        Button fragmentclasseeductionbtncancell;
        Context ctx;
        string value = "کلاس های آموزشی";

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
        public ClassEductionFragment(Context _ctx)
        {
            ctx = _ctx;
        }
        public event EventHandler<GetClassEduction> OnGetCaption;





        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var dlg = inflater.Inflate(Resource.Layout.layout_FragmentClasseduction, container, false);
            var font = Typeface.CreateFromAsset(ctx.Assets, "Estedad.ttf");

            LinearLayout lnaboutus = dlg.FindViewById<LinearLayout>(id: Resource.Id.fragmentclasseductionlinearlayout);
            lnaboutus.SetBackgroundResource(Resource.Drawable.dialog_fragment_round);
            fragmentclasseductionchkother = dlg.FindViewById<CheckBox>(Resource.Id.fragmentclasseductionchkother);
            fragmentclasseductionchkother.Typeface = font;

            fragmentclasseductiontxtheader = dlg.FindViewById<TextView>(Resource.Id.fragmentclasseductiontxtheader);
            fragmentclasseductiontxtheader.Typeface = font;
            fragmentclasseductionchktourism = dlg.FindViewById<CheckBox>(Resource.Id.fragmentclasseductionchktourism);
            fragmentclasseductionchktourism.Typeface = font;
            captioneventradsport = dlg.FindViewById<CheckBox>(Resource.Id.captioneventradsport);
            captioneventradsport.Typeface = font;
            fragmentclasseductionchkfood = dlg.FindViewById<CheckBox>(Resource.Id.fragmentclasseductionchkfood);
            fragmentclasseductionchkfood.Typeface = font;
            fragmentclasseductionchkreligion = dlg.FindViewById<CheckBox>(Resource.Id.fragmentclasseductionchkreligion);
            fragmentclasseductionchkreligion.Typeface = font;
            fragmentclasseductionchkskill = dlg.FindViewById<CheckBox>(Resource.Id.fragmentclasseductionchkskill);
            fragmentclasseductionchkskill.Typeface = font;
            fragmentclasseductionchklessonschool = dlg.FindViewById<CheckBox>(Resource.Id.fragmentclasseductionchklessonschool);
            fragmentclasseductionchklessonschool.Typeface = font;
            fragmentclasseductionchklanguage = dlg.FindViewById<CheckBox>(Resource.Id.fragmentclasseductionchklanguage);
            fragmentclasseductionchklanguage.Typeface = font;
            fragmentclasseductionchkmoshavere = dlg.FindViewById<CheckBox>(Resource.Id.fragmentclasseductionchkmoshavere);
            fragmentclasseductionchkmoshavere.Typeface = font;
            fragmentclasseductionchkcultrual = dlg.FindViewById<CheckBox>(Resource.Id.fragmentclasseductionchkcultrual);
            fragmentclasseductionchkcultrual.Typeface = font;
            fragmentclasseductionchkmedicall = dlg.FindViewById<CheckBox>(Resource.Id.fragmentclasseductionchkmedicall);
            fragmentclasseductionchkmedicall.Typeface = font;
            fragmentclasseductionchkperfect = dlg.FindViewById<CheckBox>(Resource.Id.fragmentclasseductionchkperfect);
            fragmentclasseductionchkperfect.Typeface = font;
            fragmentclasseductionchkmusic = dlg.FindViewById<CheckBox>(Resource.Id.fragmentclasseductionchkmusic);
            fragmentclasseductionchkmusic.Typeface = font;
            fragmentclasseductionchktakephoto = dlg.FindViewById<CheckBox>(Resource.Id.fragmentclasseductionchktakephoto);
            fragmentclasseductionchktakephoto.Typeface = font;
            fragmentclasseductionchkworkshop = dlg.FindViewById<CheckBox>(Resource.Id.fragmentclasseductionchkworkshop);
            fragmentclasseductionchkworkshop.Typeface = font;


            fragmentclasseeductionbtncancell = dlg.FindViewById<Button>(Resource.Id.fragmentclasseeductionbtncancell);
            fragmentclasseeductionbtncancell.Typeface = font;



            fragmentclasseductiontxtheader.Text = "انتخاب رویداد";



            fragmentclasseductionchkother.Click += delegate {
                captioneventradsport.Checked = false;
                fragmentclasseductionchktourism.Checked = false;
                fragmentclasseductionchkfood.Checked = false;
                fragmentclasseductionchkreligion.Checked = false;
                fragmentclasseductionchkskill.Checked = false;
                fragmentclasseductionchklessonschool.Checked = false;
                fragmentclasseductionchklanguage.Checked = false;
                fragmentclasseductionchkmoshavere.Checked = false;
                fragmentclasseductionchkcultrual.Checked = false;
                fragmentclasseductionchkmedicall.Checked = false;
                fragmentclasseductionchkperfect.Checked = false;
                fragmentclasseductionchkmusic.Checked = false;
                fragmentclasseductionchktakephoto.Checked = false;
                fragmentclasseductionchkworkshop.Checked = false;

                OnGetCaption.Invoke(this, new GetClassEduction(value + "-" + fragmentclasseductionchkworkshop.Text));
                Dismiss();
            };




            fragmentclasseductionchktourism.Click += delegate
            {

                fragmentclasseductionchkother.Checked = false;


                captioneventradsport.Checked = false;
                fragmentclasseductionchkfood.Checked = false;
                fragmentclasseductionchkreligion.Checked = false;
                fragmentclasseductionchkskill.Checked = false;
                fragmentclasseductionchklessonschool.Checked = false;
                fragmentclasseductionchklanguage.Checked = false;
                fragmentclasseductionchkmoshavere.Checked = false;
                fragmentclasseductionchkcultrual.Checked = false;
                fragmentclasseductionchkmedicall.Checked = false;
                fragmentclasseductionchkperfect.Checked = false;
                fragmentclasseductionchkmusic.Checked = false;
                fragmentclasseductionchktakephoto.Checked = false;
                fragmentclasseductionchkworkshop.Checked = false;


                OnGetCaption.Invoke(this, new GetClassEduction(value + "-" + fragmentclasseductionchktourism.Text));
                Dismiss();
            };



            captioneventradsport.Click += delegate
            {
                fragmentclasseductionchktourism.Checked = false;
                fragmentclasseductionchkother.Checked = false;
                fragmentclasseductionchkfood.Checked = false;
                fragmentclasseductionchkreligion.Checked = false;
                fragmentclasseductionchkskill.Checked = false;
                fragmentclasseductionchklessonschool.Checked = false;
                fragmentclasseductionchklanguage.Checked = false;
                fragmentclasseductionchkmoshavere.Checked = false;
                fragmentclasseductionchkcultrual.Checked = false;
                fragmentclasseductionchkmedicall.Checked = false;
                fragmentclasseductionchkperfect.Checked = false;
                fragmentclasseductionchkmusic.Checked = false;
                fragmentclasseductionchktakephoto.Checked = false;
                fragmentclasseductionchkworkshop.Checked = false;

                OnGetCaption.Invoke(this, new GetClassEduction(value + "-" + captioneventradsport.Text));
                Dismiss();
            };



            fragmentclasseductionchkfood.Click += delegate
            {
                fragmentclasseductionchktourism.Checked = false;
                captioneventradsport.Checked = false;
                fragmentclasseductionchkother.Checked = false;
                fragmentclasseductionchkreligion.Checked = false;
                fragmentclasseductionchkskill.Checked = false;
                fragmentclasseductionchklessonschool.Checked = false;
                fragmentclasseductionchklanguage.Checked = false;
                fragmentclasseductionchkmoshavere.Checked = false;
                fragmentclasseductionchkcultrual.Checked = false;
                fragmentclasseductionchkmedicall.Checked = false;
                fragmentclasseductionchkperfect.Checked = false;
                fragmentclasseductionchkmusic.Checked = false;
                fragmentclasseductionchktakephoto.Checked = false;
                fragmentclasseductionchkworkshop.Checked = false;
                OnGetCaption.Invoke(this, new GetClassEduction(value + "-" + fragmentclasseductionchkfood.Text));
                Dismiss();
            };



            fragmentclasseductionchkreligion.Click += delegate
            {
                fragmentclasseductionchkother.Checked = false;
                fragmentclasseductionchktourism.Checked = false;
                captioneventradsport.Checked = false;
                fragmentclasseductionchkfood.Checked = false;
                fragmentclasseductionchkreligion.Checked = false;
                fragmentclasseductionchkskill.Checked = false;
                fragmentclasseductionchklessonschool.Checked = false;
                fragmentclasseductionchklanguage.Checked = false;
                fragmentclasseductionchkmoshavere.Checked = false;
                fragmentclasseductionchkcultrual.Checked = false;
                fragmentclasseductionchkmedicall.Checked = false;
                fragmentclasseductionchkperfect.Checked = false;
                fragmentclasseductionchkmusic.Checked = false;
                fragmentclasseductionchktakephoto.Checked = false;
                fragmentclasseductionchkworkshop.Checked = false;

                OnGetCaption.Invoke(this, new GetClassEduction(value + "-" + fragmentclasseductionchkreligion.Text));
                Dismiss();
            };

            fragmentclasseductionchkskill.Click += delegate
            {
                fragmentclasseductionchkother.Checked = false;
                fragmentclasseductionchktourism.Checked = false;
                captioneventradsport.Checked = false;
                fragmentclasseductionchkfood.Checked = false;
                fragmentclasseductionchkreligion.Checked = false;
                fragmentclasseductionchkskill.Checked = false;
                fragmentclasseductionchklessonschool.Checked = false;
                fragmentclasseductionchklanguage.Checked = false;
                fragmentclasseductionchkmoshavere.Checked = false;
                fragmentclasseductionchkcultrual.Checked = false;
                fragmentclasseductionchkmedicall.Checked = false;
                fragmentclasseductionchkperfect.Checked = false;
                fragmentclasseductionchkmusic.Checked = false;
                fragmentclasseductionchktakephoto.Checked = false;
                fragmentclasseductionchkworkshop.Checked = false;

                OnGetCaption.Invoke(this, new GetClassEduction(value + "-" + fragmentclasseductionchkskill.Text));
                Dismiss();
            };
            fragmentclasseductionchklessonschool.Click += delegate
            {
                fragmentclasseductionchkother.Checked = false;
                fragmentclasseductionchktourism.Checked = false;
                captioneventradsport.Checked = false;
                fragmentclasseductionchkfood.Checked = false;
                fragmentclasseductionchkreligion.Checked = false;
                fragmentclasseductionchkskill.Checked = false;
                fragmentclasseductionchklessonschool.Checked = false;
                fragmentclasseductionchklanguage.Checked = false;
                fragmentclasseductionchkmoshavere.Checked = false;
                fragmentclasseductionchkcultrual.Checked = false;
                fragmentclasseductionchkmedicall.Checked = false;
                fragmentclasseductionchkperfect.Checked = false;
                fragmentclasseductionchkmusic.Checked = false;
                fragmentclasseductionchktakephoto.Checked = false;
                fragmentclasseductionchkworkshop.Checked = false;

                OnGetCaption.Invoke(this, new GetClassEduction(value + "-" + fragmentclasseductionchklessonschool.Text));
                Dismiss();
            };
            fragmentclasseductionchklanguage.Click += delegate
            {
                fragmentclasseductionchkother.Checked = false;
                fragmentclasseductionchktourism.Checked = false;
                captioneventradsport.Checked = false;
                fragmentclasseductionchkfood.Checked = false;
                fragmentclasseductionchkreligion.Checked = false;
                fragmentclasseductionchkskill.Checked = false;
                fragmentclasseductionchklessonschool.Checked = false;
                fragmentclasseductionchklanguage.Checked = false;
                fragmentclasseductionchkmoshavere.Checked = false;
                fragmentclasseductionchkcultrual.Checked = false;
                fragmentclasseductionchkmedicall.Checked = false;
                fragmentclasseductionchkperfect.Checked = false;
                fragmentclasseductionchkmusic.Checked = false;
                fragmentclasseductionchktakephoto.Checked = false;
                fragmentclasseductionchkworkshop.Checked = false;

                OnGetCaption.Invoke(this, new GetClassEduction(value + "-" + fragmentclasseductionchklanguage.Text));
                Dismiss();
            };
            fragmentclasseductionchkmoshavere.Click += delegate
            {
                fragmentclasseductionchkother.Checked = false;
                fragmentclasseductionchktourism.Checked = false;
                captioneventradsport.Checked = false;
                fragmentclasseductionchkfood.Checked = false;
                fragmentclasseductionchkreligion.Checked = false;
                fragmentclasseductionchkskill.Checked = false;
                fragmentclasseductionchklessonschool.Checked = false;
                fragmentclasseductionchklanguage.Checked = false;
                fragmentclasseductionchkmoshavere.Checked = false;
                fragmentclasseductionchkcultrual.Checked = false;
                fragmentclasseductionchkmedicall.Checked = false;
                fragmentclasseductionchkperfect.Checked = false;
                fragmentclasseductionchkmusic.Checked = false;
                fragmentclasseductionchktakephoto.Checked = false;
                fragmentclasseductionchkworkshop.Checked = false;

                OnGetCaption.Invoke(this, new GetClassEduction(value + "-" + fragmentclasseductionchkmoshavere.Text));
                Dismiss();
            };
            fragmentclasseductionchkcultrual.Click += delegate
            {
                fragmentclasseductionchkother.Checked = false;
                fragmentclasseductionchktourism.Checked = false;
                captioneventradsport.Checked = false;
                fragmentclasseductionchkfood.Checked = false;
                fragmentclasseductionchkreligion.Checked = false;
                fragmentclasseductionchkskill.Checked = false;
                fragmentclasseductionchklessonschool.Checked = false;
                fragmentclasseductionchklanguage.Checked = false;
                fragmentclasseductionchkmoshavere.Checked = false;
                fragmentclasseductionchkcultrual.Checked = false;
                fragmentclasseductionchkmedicall.Checked = false;
                fragmentclasseductionchkperfect.Checked = false;
                fragmentclasseductionchkmusic.Checked = false;
                fragmentclasseductionchktakephoto.Checked = false;
                fragmentclasseductionchkworkshop.Checked = false;

                OnGetCaption.Invoke(this, new GetClassEduction(value + "-" + fragmentclasseductionchkcultrual.Text));
                Dismiss();
            };
            fragmentclasseductionchkmedicall.Click += delegate
            {
                fragmentclasseductionchktourism.Checked = false;
                captioneventradsport.Checked = false;
                fragmentclasseductionchkfood.Checked = false;
                fragmentclasseductionchkreligion.Checked = false;
                fragmentclasseductionchkskill.Checked = false;
                fragmentclasseductionchklessonschool.Checked = false;
                fragmentclasseductionchklanguage.Checked = false;
                fragmentclasseductionchkmoshavere.Checked = false;
                fragmentclasseductionchkcultrual.Checked = false;
                fragmentclasseductionchkmedicall.Checked = false;
                fragmentclasseductionchkperfect.Checked = false;
                fragmentclasseductionchkmusic.Checked = false;
                fragmentclasseductionchktakephoto.Checked = false;
                fragmentclasseductionchkworkshop.Checked = false;

                OnGetCaption.Invoke(this, new GetClassEduction(value + "-" + fragmentclasseductionchkmedicall.Text));
                Dismiss();
            };
            fragmentclasseductionchkperfect.Click += delegate
            {
                fragmentclasseductionchkother.Checked = false;
                fragmentclasseductionchktourism.Checked = false;
                captioneventradsport.Checked = false;
                fragmentclasseductionchkfood.Checked = false;
                fragmentclasseductionchkreligion.Checked = false;
                fragmentclasseductionchkskill.Checked = false;
                fragmentclasseductionchklessonschool.Checked = false;
                fragmentclasseductionchklanguage.Checked = false;
                fragmentclasseductionchkmoshavere.Checked = false;
                fragmentclasseductionchkcultrual.Checked = false;
                fragmentclasseductionchkmedicall.Checked = false;
                fragmentclasseductionchkperfect.Checked = false;
                fragmentclasseductionchkmusic.Checked = false;
                fragmentclasseductionchktakephoto.Checked = false;
                fragmentclasseductionchkworkshop.Checked = false;

                OnGetCaption.Invoke(this, new GetClassEduction(value + "-" + fragmentclasseductionchkperfect.Text));
                Dismiss();
            };
            fragmentclasseductionchkmusic.Click += delegate
            {
                fragmentclasseductionchkother.Checked = false;
                fragmentclasseductionchktourism.Checked = false;
                captioneventradsport.Checked = false;
                fragmentclasseductionchkfood.Checked = false;
                fragmentclasseductionchkreligion.Checked = false;
                fragmentclasseductionchkskill.Checked = false;
                fragmentclasseductionchklessonschool.Checked = false;
                fragmentclasseductionchklanguage.Checked = false;
                fragmentclasseductionchkmoshavere.Checked = false;
                fragmentclasseductionchkcultrual.Checked = false;
                fragmentclasseductionchkmedicall.Checked = false;
                fragmentclasseductionchkperfect.Checked = false;
                fragmentclasseductionchkmusic.Checked = false;
                fragmentclasseductionchktakephoto.Checked = false;
                fragmentclasseductionchkworkshop.Checked = false;

                OnGetCaption.Invoke(this, new GetClassEduction(value + "-" + fragmentclasseductionchkmusic.Text));
                Dismiss();
            };
            fragmentclasseductionchktakephoto.Click += delegate
            {
                fragmentclasseductionchkother.Checked = false;
                fragmentclasseductionchktourism.Checked = false;
                captioneventradsport.Checked = false;
                fragmentclasseductionchkfood.Checked = false;
                fragmentclasseductionchkreligion.Checked = false;
                fragmentclasseductionchkskill.Checked = false;
                fragmentclasseductionchklessonschool.Checked = false;
                fragmentclasseductionchklanguage.Checked = false;
                fragmentclasseductionchkmoshavere.Checked = false;
                fragmentclasseductionchkcultrual.Checked = false;
                fragmentclasseductionchkmedicall.Checked = false;
                fragmentclasseductionchkperfect.Checked = false;
                fragmentclasseductionchkmusic.Checked = false;
                fragmentclasseductionchktakephoto.Checked = false;
                fragmentclasseductionchkworkshop.Checked = false;

                OnGetCaption.Invoke(this, new GetClassEduction(value + "-" + fragmentclasseductionchktakephoto.Text));
                Dismiss();
            };
            fragmentclasseductionchkworkshop.Click += delegate
            {
                fragmentclasseductionchkother.Checked = false;
                fragmentclasseductionchktourism.Checked = false;
                captioneventradsport.Checked = false;
                fragmentclasseductionchkfood.Checked = false;
                fragmentclasseductionchkreligion.Checked = false;
                fragmentclasseductionchkskill.Checked = false;
                fragmentclasseductionchklessonschool.Checked = false;
                fragmentclasseductionchklanguage.Checked = false;
                fragmentclasseductionchkmoshavere.Checked = false;
                fragmentclasseductionchkcultrual.Checked = false;
                fragmentclasseductionchkmedicall.Checked = false;
                fragmentclasseductionchkperfect.Checked = false;
                fragmentclasseductionchkmusic.Checked = false;
                fragmentclasseductionchktakephoto.Checked = false;
                fragmentclasseductionchkworkshop.Checked = false;

                OnGetCaption.Invoke(this, new GetClassEduction(value + "-" + fragmentclasseductionchkworkshop.Text));
                Dismiss();
            };




            fragmentclasseeductionbtncancell.Click += delegate { Dismiss(); };
            return dlg;
        }
    }
}
 