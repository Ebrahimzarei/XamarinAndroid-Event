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

    public class GetLonging : EventArgs
    {

        public GetLonging(string _getcaptionlonging) : base()
        {
            GetCaption = _getcaptionlonging;
        }
        public string GetCaption { get; set; }


    }
    public class FragmentLonging : DialogFragment
    {
        TextView fragmentLongingtxtviewheader;
        CheckBox Longingchkdiscount;
        CheckBox longingchkother;
        Button longingbuttoncancell;
        Context ctx;
        string TypeLonging;
        string value = "جنبه رویداد";
        //فروشگاه
        CheckBox Longingchkstorelive;
        CheckBox Longingchkstorelottery;
        CheckBox Longingchkstoregift;
        CheckBox Longingchkstoreexhibition;
        CheckBox Longingchkstoreopening;
        //کلاس آموزشی
        CheckBox Longingchkclasseductonfree;
        CheckBox Longingchkclasseductonlottery;
        CheckBox Longingchkclasseductonother;
         CheckBox Longingchkclasseductongift;
        CheckBox Longingchkclasseductonexhibition;
        CheckBox Longingchkclasseductonopening;
        //اغذیه فروشی
        CheckBox Longingchkfoodlive;
        CheckBox Longingchkfoodlottery;
        CheckBox Longingchkfoodmajorlive;
        CheckBox Longingchkfoodgift;
        CheckBox Longingchkfoodexhibition;
        CheckBox Longingchkfoodopening;

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
        public FragmentLonging(Context _ctx,string Longing)
        {
            ctx = _ctx;
            TypeLonging = Longing;
        }
        public event EventHandler<GetLonging> OnGetCaptionLonging;





        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var dlg = inflater.Inflate(Resource.Layout.FragmnetLonging, container, false);
            //
            LinearLayout lnaboutus = dlg.FindViewById<LinearLayout>(Resource.Id.fragmentLonginglinearlayout);
            lnaboutus.SetBackgroundResource(Resource.Drawable.dialog_fragment_round);
            var font = Typeface.CreateFromAsset(ctx.Assets, "Estedad.ttf");
            //فروشگاه
              Longingchkstorelive = dlg.FindViewById<CheckBox>(Resource.Id.Longingchkstorelive); 
              Longingchkstorelottery = dlg.FindViewById<CheckBox>(Resource.Id.Longingchkstorelottery);
              Longingchkstoregift = dlg.FindViewById<CheckBox>(Resource.Id.Longingchkstoregift);
              Longingchkstoreexhibition = dlg.FindViewById<CheckBox>(Resource.Id.Longingchkstoreexhibition);
              Longingchkstoreopening = dlg.FindViewById<CheckBox>(Resource.Id.Longingchkstoreopening);
            //کلاس آموزشی
              Longingchkclasseductonfree = dlg.FindViewById<CheckBox>(Resource.Id.Longingchkclasseductonfree);
              Longingchkclasseductonlottery = dlg.FindViewById<CheckBox>(Resource.Id.Longingchkclasseductonlottery);
              Longingchkclasseductonother = dlg.FindViewById<CheckBox>(Resource.Id.Longingchkclasseductonother);
              Longingchkclasseductongift = dlg.FindViewById<CheckBox>(Resource.Id.Longingchkclasseductongift);
              Longingchkclasseductonexhibition = dlg.FindViewById<CheckBox>(Resource.Id.Longingchkclasseductonexhibition);
              Longingchkclasseductonopening = dlg.FindViewById<CheckBox>(Resource.Id.Longingchkclasseductonopening);
            //اغذیه فروشی
              Longingchkfoodlive = dlg.FindViewById<CheckBox>(Resource.Id.Longingchkfoodlive);
              Longingchkfoodlottery = dlg.FindViewById<CheckBox>(Resource.Id.Longingchkfoodlottery);
              Longingchkfoodmajorlive = dlg.FindViewById<CheckBox>(Resource.Id.Longingchkfoodmajorlive);
              Longingchkfoodgift = dlg.FindViewById<CheckBox>(Resource.Id.Longingchkfoodgift);
              Longingchkfoodexhibition = dlg.FindViewById<CheckBox>(Resource.Id.Longingchkfoodexhibition);
              Longingchkfoodopening = dlg.FindViewById<CheckBox>(Resource.Id.Longingchkfoodopening);

            if (TypeLonging.StartsWith("فروشگاه"))
            {
                //کلاس آموزشی
                 Longingchkclasseductonfree.Visibility=ViewStates.Gone;
                 Longingchkclasseductonlottery.Visibility = ViewStates.Gone;
                Longingchkclasseductonother.Visibility = ViewStates.Gone;
                Longingchkclasseductongift.Visibility = ViewStates.Gone;
                Longingchkclasseductonexhibition.Visibility = ViewStates.Gone;
                Longingchkclasseductonopening.Visibility = ViewStates.Gone;
                //اغذیه فروشی
                 Longingchkfoodlive.Visibility = ViewStates.Gone;
                 Longingchkfoodlottery.Visibility = ViewStates.Gone;
                 Longingchkfoodmajorlive.Visibility = ViewStates.Gone;
                 Longingchkfoodgift.Visibility = ViewStates.Gone;
                 Longingchkfoodexhibition.Visibility = ViewStates.Gone;
                 Longingchkfoodopening.Visibility = ViewStates.Gone;

                Longingchkstorelive.Click+=delegate {

                      DbEventoo Db = new DbEventoo();
                      //   Db.RemoveAllLonging();
                      OnGetCaptionLonging.Invoke(this, new GetLonging("فروشگاه"+"-" + Longingchkstorelive.Text));

                       Db.LongingInsert(new Longing() { GetLonging = "فروشگاه", DescriptionLonging = Longingchkstorelive.Text });

                      Dismiss();
                  };
                  Longingchkstorelottery.Click += delegate {

                   DbEventoo Db = new DbEventoo();
                    
                      Db.LongingInsert(new Longing() { GetLonging = "فروشگاه", DescriptionLonging = Longingchkstorelottery.Text });
                      OnGetCaptionLonging.Invoke(this, new GetLonging("فروشگاه"+"-" + Longingchkstorelottery.Text));
                

                      Dismiss();
                  };
                Longingchkstoregift.Click += delegate {
                    DbEventoo Db = new DbEventoo();
                    //   Db.RemoveAllLonging();
                    OnGetCaptionLonging.Invoke(this, new GetLonging("فروشگاه"+"-" + Longingchkstoregift.Text));
                    Db.LongingInsert(new Longing() { GetLonging = "فروشگاه", DescriptionLonging = Longingchkstoregift.Text });

                    Dismiss();
                };
                Longingchkstoreexhibition.Click += delegate {
                  DbEventoo Db = new DbEventoo();
                    //   Db.RemoveAllLonging();
                    OnGetCaptionLonging.Invoke(this, new GetLonging("فروشگاه"+"-" + Longingchkstoreexhibition.Text));
                   Db.LongingInsert(new Longing() { GetLonging = "فروشگاه", DescriptionLonging = Longingchkstoreexhibition.Text });

                    Dismiss();
                };
                Longingchkstoreopening.Click += delegate {

                   DbEventoo Db = new DbEventoo();
                    //    Db.RemoveAllLonging();
                    OnGetCaptionLonging.Invoke(this, new GetLonging("فروشگاه"+"-" + Longingchkstoreopening.Text));
                  Db.LongingInsert(new Longing() { GetLonging = "فروشگاه", DescriptionLonging = Longingchkstoreopening.Text });

                    Dismiss();
                };
            }
            if (TypeLonging.StartsWith("کلاس"))
            {
                  Longingchkstorelive.Visibility=ViewStates.Gone;
                  Longingchkstorelottery.Visibility = ViewStates.Gone;
                Longingchkstoregift.Visibility = ViewStates.Gone;
                Longingchkstoreexhibition.Visibility = ViewStates.Gone;
                Longingchkstoreopening.Visibility = ViewStates.Gone;

                //اغذیه فروشی
                Longingchkfoodlive.Visibility = ViewStates.Gone;
                Longingchkfoodlottery.Visibility = ViewStates.Gone;
                Longingchkfoodmajorlive.Visibility = ViewStates.Gone;
                Longingchkfoodgift.Visibility = ViewStates.Gone;
                Longingchkfoodexhibition.Visibility = ViewStates.Gone;
                Longingchkfoodopening.Visibility = ViewStates.Gone;

                Longingchkclasseductonfree.Click += delegate {
                    DbEventoo Db = new DbEventoo();

                    Db.LongingInsert(new Longing() { GetLonging = "کلاس آموزشی", DescriptionLonging = Longingchkclasseductonfree.Text });
                    OnGetCaptionLonging.Invoke(this, new GetLonging("کلاس آموزشی"+"-" + Longingchkclasseductonfree.Text));
                    Dismiss();
                }; ;
                Longingchkclasseductonlottery.Click += delegate {
                    DbEventoo Db = new DbEventoo();

                    Db.LongingInsert(new Longing() { GetLonging = "کلاس آموزشی", DescriptionLonging = Longingchkclasseductonlottery.Text });
                    OnGetCaptionLonging.Invoke(this, new GetLonging("کلاس آموزشی" +"-"+ Longingchkclasseductonlottery.Text));
                    Dismiss();
                };
                Longingchkclasseductonother.Click += delegate {
                    DbEventoo Db = new DbEventoo();

                    Db.LongingInsert(new Longing() { GetLonging = "کلاس آموزشی", DescriptionLonging = Longingchkclasseductonother.Text });
                    OnGetCaptionLonging.Invoke(this, new GetLonging("کلاس آموزشی"+"-" + Longingchkclasseductonother.Text));
                    Dismiss();
                };
                Longingchkclasseductongift.Click += delegate {
                    DbEventoo Db = new DbEventoo();

                    Db.LongingInsert(new Longing() { GetLonging = "کلاس آموزشی", DescriptionLonging = Longingchkclasseductongift.Text });
                    OnGetCaptionLonging.Invoke(this, new GetLonging("کلاس آموزشی"+"-" + Longingchkclasseductongift.Text));
                    Dismiss();
                };
                Longingchkclasseductonexhibition.Click += delegate {
                    DbEventoo Db = new DbEventoo();

                    Db.LongingInsert(new Longing() { GetLonging = "کلاس آموزشی", DescriptionLonging = Longingchkclasseductonexhibition.Text });
                    OnGetCaptionLonging.Invoke(this, new GetLonging("کلاس آموزشی"+"-" + Longingchkclasseductonexhibition.Text));
                    Dismiss();
                };
                Longingchkclasseductonopening.Click += delegate {

                    OnGetCaptionLonging.Invoke(this, new GetLonging("کلاس آموزشی"+"-" + Longingchkclasseductonopening.Text));
                    Dismiss();
                };

            }
            if (TypeLonging.StartsWith("اغذیه فروشی"))
            {
                //اغذیه فروشی
                Longingchkstorelive.Visibility = ViewStates.Gone;
                Longingchkstorelottery.Visibility = ViewStates.Gone;
                Longingchkstoregift.Visibility = ViewStates.Gone;
                Longingchkstoreexhibition.Visibility = ViewStates.Gone;
                Longingchkstoreopening.Visibility = ViewStates.Gone;

                //کلاس آموزشی
                Longingchkclasseductonfree.Visibility = ViewStates.Gone;
                Longingchkclasseductonlottery.Visibility = ViewStates.Gone;
                Longingchkclasseductonother.Visibility = ViewStates.Gone;
                Longingchkclasseductongift.Visibility = ViewStates.Gone;
                Longingchkclasseductonexhibition.Visibility = ViewStates.Gone;
                Longingchkclasseductonopening.Visibility = ViewStates.Gone;

                //اغذیه فروشی
                Longingchkfoodlive.Click += delegate {
                    DbEventoo Db = new DbEventoo();

                    Db.LongingInsert(new Longing() { GetLonging = "اغذیه فروشی", DescriptionLonging = Longingchkfoodlive.Text });
                    OnGetCaptionLonging.Invoke(this, new GetLonging("اغذیه فروشی"+"-" + Longingchkfoodlive.Text));
                    Dismiss();

                };
                Longingchkfoodlottery.Click += delegate {
                    DbEventoo Db = new DbEventoo();

                    Db.LongingInsert(new Longing() { GetLonging = "اغذیه فروشی", DescriptionLonging = Longingchkfoodlottery.Text });

                    OnGetCaptionLonging.Invoke(this, new GetLonging("اغذیه فروشی"+"-" + Longingchkfoodlottery.Text));
                    Dismiss();
                };
                Longingchkfoodmajorlive.Click += delegate {
                    DbEventoo Db = new DbEventoo();

                    Db.LongingInsert(new Longing() { GetLonging = "اغذیه فروشی", DescriptionLonging = Longingchkfoodmajorlive.Text });

                    OnGetCaptionLonging.Invoke(this, new GetLonging("اغذیه فروشی"+"-" + Longingchkfoodmajorlive.Text));
                    Dismiss();
                };
                Longingchkfoodgift.Click += delegate {
                    DbEventoo Db = new DbEventoo();

                    Db.LongingInsert(new Longing() { GetLonging = "اغذیه فروشی", DescriptionLonging = Longingchkfoodgift.Text });
                    OnGetCaptionLonging.Invoke(this, new GetLonging("اغذیه فروشی"+"-" + Longingchkfoodgift.Text));
                    Dismiss();
                };
                Longingchkfoodexhibition.Click += delegate {
                    DbEventoo Db = new DbEventoo();

                    Db.LongingInsert(new Longing() { GetLonging = "اغذیه فروشی", DescriptionLonging = Longingchkfoodexhibition.Text });

                    OnGetCaptionLonging.Invoke(this, new GetLonging("اغذیه فروشی"+"-" + Longingchkfoodexhibition.Text));
                    Dismiss();
                };
                Longingchkfoodopening.Click += delegate {
                    DbEventoo Db = new DbEventoo();

                    Db.LongingInsert(new Longing() { GetLonging = "اغذیه فروشی", DescriptionLonging = Longingchkfoodopening.Text });

                    OnGetCaptionLonging.Invoke(this, new GetLonging("اغذیه فروشی"+"-" + Longingchkfoodopening.Text));
                    Dismiss();
                };

            }


            fragmentLongingtxtviewheader = dlg.FindViewById<TextView>(Resource.Id.fragmentLongingtxtviewheader);
            Longingchkdiscount = dlg.FindViewById<CheckBox>(Resource.Id.Longingchkdiscount);


            fragmentLongingtxtviewheader.Text = "جنبه رویداد";
            fragmentLongingtxtviewheader.Typeface = font;
            Longingchkdiscount.Typeface = font;
            Longingchkdiscount.Click += delegate
            {
                //تخفیف
                Controller.Fragment.LongingDescription fdlg = new Fragment.LongingDescription(this.ctx, Longingchkdiscount.Text);
                fdlg.Show(this.FragmentManager, "ebrahimfragment122");
                
                Dismiss();
            };
            longingchkother = dlg.FindViewById<CheckBox>(Resource.Id.longingchkother);
            longingchkother.Typeface = font;

            longingchkother.Click += delegate
            {
                //سایر
              
                Controller.Fragment.LongingDescription fdlg = new Fragment.LongingDescription(this.ctx, longingchkother.Text);
                fdlg.Show(this.FragmentManager, "ebrahimfragment122");
                //OnGetCaptionHealth.Invoke(this, new GetLonging(value + "-" + longingchkother.Text));
                Dismiss();
            };



            longingbuttoncancell = dlg.FindViewById<Button>(Resource.Id.longingbuttoncancell);
            longingbuttoncancell.Typeface = font;
            longingbuttoncancell.Click += delegate { Dismiss(); };
            return dlg;
        }

    }
}