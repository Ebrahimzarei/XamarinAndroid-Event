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

    public class FilterRange : EventArgs
    {

        public FilterRange(string _getcurrnetchk) : base()
        {
            GEtCheckBox = _getcurrnetchk;
        }
        public string GEtCheckBox { get; set; }


    }
    public class RangePlace : DialogFragment

    {
        Context ctx;
        TextView rangeplacetxtviewcaption;
        CheckBox rangeplacechkOnlyshiraz;
        Button rangeplacebtnrangeplace;
        Button rangeplacebtnexit;
        public event EventHandler<FilterRange> OnGetCurrentItem;
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
        public RangePlace(Context _ctx)
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
            var dlg = inflater.Inflate(Resource.Layout.layoutrangeplace, container, false);
           
        Controller.Fragment.EnterPlace fdlg = new Fragment.EnterPlace(ctx);
            var font = Typeface.CreateFromAsset(ctx.Assets, "Estedad.ttf");
            LinearLayout lnaboutus = dlg.FindViewById<LinearLayout>(Resource.Id.rangeplacelinearlayout);
            lnaboutus.SetBackgroundResource(Resource.Drawable.dialog_fragment_round);
            rangeplacetxtviewcaption =dlg.FindViewById<TextView>(Resource.Id.rangeplacetxtviewcaption);
            rangeplacetxtviewcaption.Typeface = font;
            rangeplacebtnexit = dlg.FindViewById<Button>(Resource.Id.rangeplacebtnexit);
            rangeplacebtnexit.Typeface = font;
            rangeplacebtnexit.Click += delegate {

                if (rangeplacebtnrangeplace.Text.StartsWith("انتخاب "))
                {
                    rangeplacebtnrangeplace.Text = "تمام شیراز";
                }
                OnGetCurrentItem.Invoke(this, new FilterRange(rangeplacebtnrangeplace.Text));
                Dismiss();

            }; 
            rangeplacechkOnlyshiraz = dlg.FindViewById<CheckBox>(Resource.Id.rangeplacechkOnlyshiraz);
            rangeplacechkOnlyshiraz.Typeface = font;
             rangeplacebtnrangeplace = dlg.FindViewById<Button>(Resource.Id.rangeplacebtnrangeplace);
            rangeplacebtnrangeplace.Typeface = font;
            rangeplacebtnrangeplace.Click += delegate {
                
                fdlg.Show(this.FragmentManager, "ebrahimfragmententerplace");
                fdlg.OnGetPlaceEvent += Fdlg_OnGetPlaceEvent;
                rangeplacechkOnlyshiraz.Checked = false;


            };
      
            return dlg;
        }

     

    

        private void Fdlg_OnGetPlaceEvent(object sender, GetPlaceEvent e)
        {

            rangeplacebtnrangeplace.Text = "";
            foreach (var item in e.GetPlace)
            {
             
                rangeplacebtnrangeplace.Text += item.itemplace+"  ";
            }
            //  rangeplacebtnrangeplace.Text = a;


          //  Dismiss();

        }
    }
}