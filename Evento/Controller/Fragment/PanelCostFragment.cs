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

    public class GetAllItemCheckd : EventArgs
    {

        public GetAllItemCheckd(string _GetAllItem)
        {
            GetCost = _GetAllItem;
        }
        public string GetCost { get; set; }
    }
    public class PanelCostFragment : DialogFragment
    {
        TextView PanelCostTextviewCaption;

        CheckBox PanelCostChkboxFree;
        CheckBox PanelCostChkboxPriceOkey;
        CheckBox PanelCostChkBoxNotOkey;
        TextView PanelCostTextviewCaptionPrice;
        Button   PanelCostButtonEnter;

        Context ctx;
        public event EventHandler<GetAllItemCheckd> OnGetCurrentcost;

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

        public PanelCostFragment(Context _ctx)
        {
            ctx = _ctx;
        }


        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            // return inflater.Inflate(Resource.Layout.YourFragment, container, false);
            var dlg = inflater.Inflate(Resource.Layout.layoutPanelCost, container, false);
            var font = Typeface.CreateFromAsset(ctx.Assets, "Estedad.ttf");
            LinearLayout lnaboutus = dlg.FindViewById<LinearLayout>(Resource.Id.PanelCostlinearlayout);
            lnaboutus.SetBackgroundResource(Resource.Drawable.dialog_fragment_round);

            PanelCostTextviewCaptionPrice = dlg.FindViewById<TextView>(Resource.Id.PanelCostTextviewCaptionPrice);
            PanelCostTextviewCaptionPrice.Typeface = font;
            PanelCostTextviewCaption =dlg.FindViewById<TextView>(Resource.Id.PanelCostTextviewCaption);
            PanelCostTextviewCaption.Typeface = font;

                PanelCostChkboxFree = dlg.FindViewById<CheckBox>(Resource.Id.PanelCostChkboxFree);
            PanelCostTextviewCaption.Typeface = font;
            PanelCostTextviewCaptionPrice.Text = "";
            PanelCostChkboxFree.Click += delegate
            {
                PanelCostChkboxPriceOkey.Checked = false;
                PanelCostChkBoxNotOkey.Checked = false;
                PanelCostTextviewCaptionPrice.Text = string.Empty;
            };

            PanelCostChkboxPriceOkey = dlg.FindViewById<CheckBox>(Resource.Id.PanelCostChkboxPriceOkey);
            PanelCostChkboxPriceOkey.Typeface = font;
            PanelCostChkboxPriceOkey.Click += delegate 
            {
                PanelCostChkboxFree.Checked = false;
                PanelCostChkBoxNotOkey.Checked = false;
                Entercost fdialog = new Entercost(ctx);
                fdialog.Show(this.FragmentManager, "ebrahimfragment3");


                fdialog.OnGetCurrentItem += delegate (object sende1r, GetCostItem getcost)
                {
                    int valuenumber = Convert.ToInt32(getcost.GetCost);
                    string num = valuenumber.ToString("N0");
                    string digitpersiannumber = num.Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩");

                    PanelCostTextviewCaptionPrice.Text = digitpersiannumber + "تومان";

                    PanelCostTextviewCaptionPrice.SetTextColor(Android.Graphics.Color.ParseColor("#311b92"));
                    PanelCostTextviewCaptionPrice.Typeface = font;
                    PanelCostTextviewCaptionPrice.Gravity = GravityFlags.Center;
               

                };
            };

            PanelCostChkBoxNotOkey = dlg.FindViewById<CheckBox>(Resource.Id.PanelCostChkBoxNotOkey);
            PanelCostChkBoxNotOkey.Typeface = font;
            PanelCostChkBoxNotOkey.Click += delegate 
            {
                PanelCostChkboxFree.Checked = false;
                PanelCostChkboxPriceOkey.Checked = false;
                PanelCostTextviewCaptionPrice.Text = string.Empty;

            };

         
            

            PanelCostButtonEnter = dlg.FindViewById<Button>(Resource.Id.PanelCostButtonEnter);
            PanelCostButtonEnter.Typeface = font;
            PanelCostButtonEnter.Click += delegate
            {
                if (PanelCostChkboxFree.Checked)
                {
                    OnGetCurrentcost.Invoke(this, new GetAllItemCheckd(PanelCostChkboxFree.Text));
                
                }
                if (PanelCostChkboxPriceOkey.Checked)
                {
                    OnGetCurrentcost.Invoke(this, new GetAllItemCheckd(PanelCostTextviewCaptionPrice.Text));
                    
                }
                if (PanelCostChkBoxNotOkey.Checked)
                {
                    OnGetCurrentcost.Invoke(this, new GetAllItemCheckd(PanelCostChkBoxNotOkey.Text));
                  
                }
                Dismiss();


            };
            return dlg;
        }
    }
}