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
    public class GetCurrentItem : EventArgs
    {

        public GetCurrentItem(string _getcurrnetchk) : base()
        {
            GEtCheckBox = _getcurrnetchk;
        }
        public string GEtCheckBox { get; set; }


    }
    public class Captionvent : DialogFragment
    {
        CheckBox captioneventradfarhangi;
        CheckBox captioneventradsport;
        CheckBox captioneventradelmi;
        CheckBox captioneventradpeople;
        CheckBox captioneventradtourism;
        CheckBox captioneventradmazhabi;
        //خوراکی ها
        CheckBox captioneventradFoods;
        //سلامتی و زیبایی
        CheckBox captioneventradhealth;
        //کلاس های آموزشی
        CheckBox captioneventradclasseduction;
        //فروشگاه
        CheckBox captioneventradstore;
     


        TextView captioneventtxtviewheader;
        Context ctx;

        Button captioneventbtnenter;
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
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);


            // Create your fragment here
        }
        public Captionvent(Context _ctx)
        {
            ctx = _ctx;
        }
        public event EventHandler<GetCurrentItem> OnGetCurrentItem;


        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            // return inflater.Inflate(Resource.Layout.YourFragment, container, false);

            var dlg = inflater.Inflate(Resource.Layout.layoutCaptionEvent, container, false);
          


            LinearLayout lnaboutus = dlg.FindViewById<LinearLayout>(Resource.Id.captioneventlinearlayout);
            lnaboutus.SetBackgroundResource(Resource.Drawable.dialog_fragment_round);


            var font = Typeface.CreateFromAsset(ctx.Assets, "Estedad.ttf");
            captioneventtxtviewheader = dlg.FindViewById<TextView>(Resource.Id.captioneventtxtviewheader); ;
            captioneventtxtviewheader.Typeface = font;
            //خوراکی ها
            captioneventradFoods = dlg.FindViewById<CheckBox>(Resource.Id.captioneventradFoods);
            //سلامتی و زیبایی
            captioneventradhealth = dlg.FindViewById<CheckBox>(Resource.Id.captioneventradhealth);

            //کلاس های آموزشی
            captioneventradclasseduction = dlg.FindViewById<CheckBox>(Resource.Id.captioneventradclasseduction);

            captioneventradFoods.Typeface = font;
            captioneventradhealth.Typeface = font;

            captioneventradclasseduction.Typeface = font;
            //فروشگاه ها
            captioneventradstore = dlg.FindViewById<CheckBox>(Resource.Id.captioneventradstore);
            captioneventradstore.Typeface = font;

           




            captioneventradfarhangi = dlg.FindViewById<CheckBox>(Resource.Id.captioneventradfarhangi);
            captioneventradfarhangi.Typeface = font;


            captioneventradsport = dlg.FindViewById<CheckBox>(Resource.Id.captioneventradsport);
            captioneventradsport.Typeface = font;

            captioneventradelmi = dlg.FindViewById<CheckBox>(Resource.Id.captioneventradelmi);
            captioneventradelmi.Typeface = font;


            captioneventradpeople = dlg.FindViewById<CheckBox>(Resource.Id.captioneventradpeople);
            captioneventradpeople.Typeface = font;

            captioneventradtourism = dlg.FindViewById<CheckBox>(Resource.Id.captioneventradtourism);
            captioneventradtourism.Typeface = font;

            captioneventradmazhabi = dlg.FindViewById<CheckBox>(Resource.Id.captioneventradmazhabi);
            captioneventradmazhabi.Typeface = font;

            captioneventbtnenter = dlg.FindViewById<Button>(Resource.Id.captioneventbtnenter);
            captioneventbtnenter.Typeface = font;

         


            captioneventradstore.Click += delegate {

                captioneventradfarhangi.Checked = false;
               
                captioneventradsport.Checked = false;
                captioneventradelmi.Checked = false;
                captioneventradpeople.Checked = false;
                captioneventradtourism.Checked = false;
                captioneventradmazhabi.Checked = false;

                captioneventradFoods.Checked = false;
                captioneventradhealth.Checked = false;
                captioneventradclasseduction.Checked = false;

                FragmnetStore fdialog = new FragmnetStore(ctx);
                fdialog.Show(this.FragmentManager, "ebrahimStoreFragment");
                fdialog.OnGetCaptionStore += delegate (object sender, GetStore e) {
                    OnGetCurrentItem.Invoke(this, new GetCurrentItem(e.GetCaption));
                    Dismiss();
                };

            };

            captioneventradfarhangi.Click += delegate {
                captioneventradstore.Checked = false;
               
                captioneventradsport.Checked = false;
                captioneventradelmi.Checked = false;
                captioneventradpeople.Checked = false;
                captioneventradtourism.Checked = false;
                captioneventradmazhabi.Checked = false;
               
                captioneventradFoods.Checked = false;
                captioneventradhealth.Checked = false;
                captioneventradclasseduction.Checked = false;


                CaptionCulturalFragment fdialog = new CaptionCulturalFragment(ctx);
                fdialog.Show(this.FragmentManager, "ebrahimCulturalFragment");
                fdialog.OnGetCaptionCultrual += delegate (object sender, GetCaptionCultrual e) {
                    OnGetCurrentItem.Invoke(this, new GetCurrentItem(e.GetCaption));
                    Dismiss();
                };

            };
            captioneventradsport.Click += delegate {
                captioneventradstore.Checked = false;
              
                captioneventradfarhangi.Checked = false;

                captioneventradelmi.Checked = false;
                captioneventradpeople.Checked = false;
                captioneventradtourism.Checked = false;
                captioneventradmazhabi.Checked = false;

                captioneventradFoods.Checked = false;
                captioneventradhealth.Checked = false;
                captioneventradclasseduction.Checked = false;

                CaptionSportFragment fdialog = new CaptionSportFragment(ctx);
                fdialog.Show(this.FragmentManager, "ebragimCaptionSportFragment");
                fdialog.OnGetCaptionSport += delegate (object sender, GetCaptionSport e) {
                    OnGetCurrentItem.Invoke(this, new GetCurrentItem(e.GetValue));
                    Dismiss();

                };
            };

            captioneventradelmi.Click += delegate {
                captioneventradstore.Checked = false;
               
                captioneventradfarhangi.Checked = false;
                captioneventradsport.Checked = false;

                captioneventradpeople.Checked = false;
                captioneventradtourism.Checked = false;
                captioneventradmazhabi.Checked = false;

                captioneventradFoods.Checked = false;
                captioneventradhealth.Checked = false;
                captioneventradclasseduction.Checked = false;

                CaptionProfessionsFragment fdialog = new CaptionProfessionsFragment(ctx);
                fdialog.Show(this.FragmentManager, "ebragimCaptionProfessionsFragment");
                fdialog.OnGetCaptionProfessions += delegate (object sender, GetCaptionProfessions e) {
                    OnGetCurrentItem.Invoke(this, new GetCurrentItem(e.GetValue));
                    Dismiss();
                };
            };
            captioneventradpeople.Click += delegate {
                captioneventradstore.Checked = false;
          
                captioneventradfarhangi.Checked = false;
                captioneventradsport.Checked = false;
                captioneventradelmi.Checked = false;

                captioneventradtourism.Checked = false;
                captioneventradmazhabi.Checked = false;

                captioneventradFoods.Checked = false;
                captioneventradhealth.Checked = false;
                captioneventradclasseduction.Checked = false;

                CaptionPeopleFragment fdialog = new CaptionPeopleFragment(ctx);
                fdialog.Show(this.FragmentManager, "ebragimCaptionPeopleFragment");
                fdialog.OngetCaptionPeople += delegate (object sender, GetCaptionPeople e) {
                    OnGetCurrentItem.Invoke(this, new GetCurrentItem(e.GEtValue));
                    Dismiss();
                };
            };
            captioneventradtourism.Click += delegate {
                captioneventradstore.Checked = false;
              
                captioneventradfarhangi.Checked = false;
                captioneventradsport.Checked = false;
                captioneventradelmi.Checked = false;
                captioneventradpeople.Checked = false;

                captioneventradmazhabi.Checked = false;

                captioneventradFoods.Checked = false;
                captioneventradhealth.Checked = false;
                captioneventradclasseduction.Checked = false;

                CaptionTourismFragment fdialog = new CaptionTourismFragment(ctx);
                fdialog.Show(this.FragmentManager, "ebragimCaptionTourismFragment");
                fdialog.OnGetCaptionTourism += delegate (object sender, GetCaptionTourism e) {
                    OnGetCurrentItem.Invoke(this, new GetCurrentItem(e.GetValue));
                    Dismiss();
                };
            };
            captioneventradmazhabi.Click += delegate {
                captioneventradstore.Checked = false;
           
                captioneventradfarhangi.Checked = false;
                captioneventradsport.Checked = false;
                captioneventradelmi.Checked = false;
                captioneventradpeople.Checked = false;
                captioneventradtourism.Checked = false;

                captioneventradFoods.Checked = false;
                captioneventradhealth.Checked = false;
                captioneventradclasseduction.Checked = false;

                CaptionReligiouseFragment fdialog = new CaptionReligiouseFragment(ctx);
                fdialog.Show(this.FragmentManager, "ebragimCaptionTourismFragment");
                fdialog.OngetCaptionreligiouse += delegate (object sender, GetCaptionReligiouse e) {
                    OnGetCurrentItem.Invoke(this, new GetCurrentItem(e.GetValue));
                    Dismiss();
                };
            };

            captioneventradFoods.Click += delegate {
                captioneventradstore.Checked = false;
            
                captioneventradmazhabi.Checked = false;
                captioneventradfarhangi.Checked = false;
                captioneventradsport.Checked = false;
                captioneventradelmi.Checked = false;
                captioneventradpeople.Checked = false;
                captioneventradtourism.Checked = false;

                // captioneventradFoods.Checked = false;
                captioneventradhealth.Checked = false;
                captioneventradclasseduction.Checked = false;

                FoodFragment fdialog = new FoodFragment(ctx);
                fdialog.Show(this.FragmentManager, "ebragimFoodFragmentFragment");
                fdialog.OnGetCaptionFood += delegate (object sender, GetCaptionFood e) {
                    OnGetCurrentItem.Invoke(this, new GetCurrentItem(e.GetCaption));
                    Dismiss();
                };
            };
            captioneventradhealth.Click += delegate {
                captioneventradstore.Checked = false;
        
                captioneventradmazhabi.Checked = false;
                captioneventradfarhangi.Checked = false;
                captioneventradsport.Checked = false;
                captioneventradelmi.Checked = false;
                captioneventradpeople.Checked = false;
                captioneventradtourism.Checked = false;

                captioneventradFoods.Checked = false;
                //  captioneventradhealth.Checked = false;
                captioneventradclasseduction.Checked = false;

                HealthFragment fdialog = new HealthFragment(ctx);
                fdialog.Show(this.FragmentManager, "ebragimHealthtFragment");
                fdialog.OnGetCaptionHealth += delegate (object sender, GetHealth e) {
                    OnGetCurrentItem.Invoke(this, new GetCurrentItem(e.GetCaption));
                    Dismiss();
                };
            };
            captioneventradclasseduction.Click += delegate {
                captioneventradstore.Checked = false;
              
                captioneventradmazhabi.Checked = false;
                captioneventradfarhangi.Checked = false;
                captioneventradsport.Checked = false;
                captioneventradelmi.Checked = false;
                captioneventradpeople.Checked = false;
                captioneventradtourism.Checked = false;

                captioneventradFoods.Checked = false;
                captioneventradhealth.Checked = false;
                //  captioneventradclasseduction.Checked = false;

                ClassEductionFragment fdialog = new ClassEductionFragment(ctx);
                fdialog.Show(this.FragmentManager, "ebragimclassEductionFragment");
                fdialog.OnGetCaption += delegate (object sender, GetClassEduction e) {
                    OnGetCurrentItem.Invoke(this, new GetCurrentItem(e.GetCaption));
                    Dismiss();
                };
            };

            //   captioneventbtnenter.Text = "خروج";

            captioneventbtnenter.Click += delegate {




                Dismiss();

            };
            return dlg;

        }
    }
}