using System;


using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.OS;

using Android.Views;
using Android.Widget;
using Evento.Model.ModelImages;

namespace Evento.Controller.Fragment
{

    //جنبه رویداد

    public class GetLongingDescription : EventArgs
    {

        public GetLongingDescription(string _getcaptionlonging) : base()
        {
            GetCaption = _getcaptionlonging;
        }
        public string GetCaption { get; set; }


    }
    public class LongingDescription : DialogFragment
    {
        TextView desclongingtxtviewcaption;
        EditText desclongingedittextcost;
      
        Button desclongingbuttonenter;
        Context ctx;
        string Value;
      

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
        public LongingDescription(Context _ctx,string caption)
        {
            ctx = _ctx;
            Value = caption;
        }
        public event EventHandler<GetLongingDescription> OnGetCaptionHealth;





        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var dlg = inflater.Inflate(Resource.Layout.DescriptionLonging, container, false);
            //
            LinearLayout lnaboutus = dlg.FindViewById<LinearLayout>(Resource.Id.desclonginglinearlayout);
            lnaboutus.SetBackgroundResource(Resource.Drawable.dialog_fragment_round);
            var font = Typeface.CreateFromAsset(ctx.Assets, "Estedad.ttf");




            desclongingtxtviewcaption = dlg.FindViewById<TextView>(Resource.Id.desclongingtxtviewcaption);
        


            
            desclongingtxtviewcaption.Typeface = font;



            desclongingedittextcost = dlg.FindViewById<EditText>(Resource.Id.desclongingedittextcost);
            desclongingedittextcost.Typeface = font;

            desclongingbuttonenter = dlg.FindViewById<Button>(Resource.Id.desclongingbuttonenter);
            desclongingbuttonenter.Typeface = font;
            desclongingbuttonenter.Click += delegate {
                if (string.IsNullOrWhiteSpace(desclongingedittextcost.Text))
                {
                    //ثبت اطلاعات در دیتا بیس
                    DbEventoo Db = new DbEventoo();
                   // Db.RemoveAllLonging();

                   Db.LongingInsert(new Longing() { GetLonging = Value, DescriptionLonging = desclongingedittextcost.Text });

                    Dismiss();
                }
                else
                {
                    Toast.MakeText(Context, "پر کردن نوع رویداد اجباری میباشد", ToastLength.Long).Show();
                }
     

              

            };
            return dlg;
        }

    }
}