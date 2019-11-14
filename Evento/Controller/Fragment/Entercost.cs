using System;
using System.Globalization;
using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.InputMethodServices;
using Android.OS;
using Android.Text;
using Android.Views;
using Android.Views.InputMethods;
using Android.Widget;
using Java.Lang;
using Java.Text;

namespace Evento.Controller.Fragment
{
    public class GetCostItem : EventArgs
    {

        public GetCostItem(string _GetCost)
        {
            GetCost = _GetCost;
        }
        public string GetCost { get; set; }
    }

    public class Entercost : DialogFragment
    {
        TextView entercosttxtviewcaption;
        EditText entercostedittextcost;
        Button entercostbtnpay;
        Context ctx;
        public Entercost(Context _ctx)
        {
            ctx = _ctx;
        }
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
        public event EventHandler<GetCostItem> OnGetCurrentItem;
        public override Dialog OnCreateDialog(Bundle savedInstanceState)
        {
            Dialog NotTitle = base.OnCreateDialog(savedInstanceState);
            NotTitle.Window.RequestFeature(WindowFeatures.NoTitle);
           

            return NotTitle;
        }
        private Handler mHandler = new Handler();

        //public void run()
        //{


        //    //  InputMethodManager inputMethodManager = ((InputMethodManager)((InputMethodService)));

        //    InputMethodManager inp = (InputMethodManager)ctx.GetSystemService(Activity.InputMethodService);
        //    inp.ToggleSoftInputFromWindow(entercostedittextcost.ApplicationWindowToken,ShowSoftInputFlags.Forced, 0);

        //    entercostedittextcost.RequestFocus();

        //}
   
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);








    }
      

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            // return inflater.Inflate(Resource.Layout.YourFragment, container, false);
            var dlg = inflater.Inflate(Resource.Layout.layoutentercost, container, false);
          
            var font = Typeface.CreateFromAsset(ctx.Assets, "Estedad.ttf");
            LinearLayout lnaboutus = dlg.FindViewById<LinearLayout>(Resource.Id.entercostlinearlayout);
            lnaboutus.SetBackgroundResource(Resource.Drawable.dialog_fragment_round);

            entercosttxtviewcaption = dlg.FindViewById<TextView>(Resource.Id.entercosttxtviewcaption);
            entercosttxtviewcaption.Typeface = font;

            entercostedittextcost = dlg.FindViewById<EditText>(Resource.Id.entercostedittextcost);
            entercosttxtviewcaption.Typeface = font;
         //  run();
            Dialog.Window.SetSoftInputMode(SoftInput.StateAlwaysVisible);
            entercostedittextcost.RequestFocus();
           
           








            //  entercostedittextcost.Text = "1000";





            entercostbtnpay = dlg.FindViewById<Button>(Resource.Id.entercostbtnpay);
            entercosttxtviewcaption.Typeface = font;
          
      
       
           


            entercostbtnpay.Click += delegate {
                string getnumber = entercostedittextcost.Text;
                //string digitpersiannumber = getnumber.Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩");
                OnGetCurrentItem.Invoke(this, new GetCostItem(getnumber));
                Dismiss();

            };

            return dlg;
        }

      
    }
    
}