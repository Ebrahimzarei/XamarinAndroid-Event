using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace Evento.Controller.Fragment
{
  

    public class FilterMain : DialogFragment
    {
       
        Button filtermainbtnplace;
        Button filtermainbtndate;
        Button filtermainbtneventcost;


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
        Button filtermainbtnٍente;
      
        public override Dialog OnCreateDialog(Bundle savedInstanceState)
        {
            Dialog NotTitle = base.OnCreateDialog(savedInstanceState);
            NotTitle.Window.RequestFeature(WindowFeatures.NoTitle);

            return NotTitle;
        }
        Context ctx;
        public FilterMain(Context _ctx)
        {
            ctx = _ctx;
        }
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            // return inflater.Inflate(Resource.Layout.YourFragment, container, false);
            
            

            var dlg = inflater.Inflate(Resource.Layout.layoutFilterMain, container, false);
            var font = Typeface.CreateFromAsset(ctx.Assets, "Estedad.ttf");
            LinearLayout lnaboutus = dlg.FindViewById<LinearLayout>(Resource.Id.filtermainlinearlayout);
            lnaboutus.SetBackgroundResource(Resource.Drawable.dialog_fragment_round);
            TextView filtermaintxtviewcaption = dlg.FindViewById<TextView>(Resource.Id.filtermaintxtviewcaption);
            filtermaintxtviewcaption.Typeface = font;
             filtermainbtndate = dlg.FindViewById<Button>(Resource.Id.filtermainbtndate);
            filtermainbtndate.Typeface = font;
            filtermainbtndate.Click += delegate {
               
            Fragment.FilterDate fdlg = new Fragment.FilterDate(ctx);
                
                fdlg.Show(this.FragmentManager, "ebrahimfragmentfliterdate");
                fdlg.OnGetDateEvent += Fdlg_OnGetDateEvent;
            };
             filtermainbtnplace = dlg.FindViewById<Button>(Resource.Id.filtermainbtnplace);
            filtermainbtnplace.Typeface = font;
            filtermainbtnplace.Click+= delegate
            {
              
                Controller.Fragment.RangePlace fdlg = new Fragment.RangePlace(ctx);

                fdlg.OnGetCurrentItem += Fdlg_OnGetCurrentItem1;
                fdlg.Show(this.FragmentManager, "ebrahimfragmententerRange");
            
               
            };
            filtermainbtneventcost = dlg.FindViewById<Button>(Resource.Id.filtermainbtneventcost);
            filtermainbtneventcost.Typeface = font;
            filtermainbtneventcost.Click += delegate {
               
                Controller.Fragment.FilterCost fdlg = new Fragment.FilterCost(ctx);
                fdlg.Show(this.FragmentManager, "ebrahimfragmententeFiltercost");
                fdlg.OnGetcostEvent += Fdlg_OnGetcostEvent;

            };
          
            filtermainbtnٍente = dlg.FindViewById<Button>(Resource.Id.filtermainbtnٍenter);
            filtermainbtnٍente.Typeface = font;
            filtermainbtnٍente.Click += delegate { Dismiss(); };

            return dlg;
        }

        private void Fdlg_OnGetcostEvent(object sender, GetcostEvent e)
        {
     
                filtermainbtneventcost.Text = e.GetPlace;
         
         
            


            filtermainbtneventcost.SetTextColor(Android.Graphics.Color.ParseColor("#311b92"));
        }

        private void Fdlg_OnGetDateEvent(object sender, GetdateEvent e)
        {

          


            string date = e.GetPlace;
            string numberdigit = date.Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩");
            filtermainbtndate.Text = numberdigit;
            filtermainbtndate.SetTextColor(Android.Graphics.Color.ParseColor("#311b92"));
        }

        private void Fdlg_OnGetCurrentItem1(object sender, FilterRange e)
        {
           
            //if (e.GEtCheckBox==string.Empty)
            //{
                filtermainbtnplace.Text = e.GEtCheckBox;
            //}
            //else
            //{
                //filtermainbtnplace.Text = "تمام شیراز";
            //}

            filtermainbtnplace.SetTextColor(Android.Graphics.Color.ParseColor("#311b92"));


        }

    



   
    }
}



//evntoo.Controller.Fragment.Captionvent fdlg = new Fragment.Captionvent(this);
//fdlg.Show(this.FragmentManager, "ebrahimfragment1");