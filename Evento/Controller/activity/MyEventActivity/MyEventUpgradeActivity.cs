
using System.IO;


using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.OS;

using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using Calligraphy;

namespace Evento.Controller.activity.MyEventActivity
{
    [Activity(Label = "MyEventUpgradeActivity", Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class MyEventUpgradeActivity : AppCompatActivity
    {
        TextView myeventUpgradettxtviewcaption;
        Button MyeventupgradeButtonBack;
        ImageView Myeventupgradetimgviewback;
        EditText enterevenedittextHelpCaption;

        CheckBox MyEventUpgradeChkfiveThousend;
        EditText MyEventUpgradeEdittexthelpSixThousend;
        CheckBox MyEventUpgradeChkSixThousend;
        EditText MyEventUpgradeEditTextHelpTwoThousend;
        CheckBox MyEventUpgradeChkTwoThousend;
        Button myeventupgradebuttonesave;

        LinearLayout myeventupgradelinearLayoutcamera;
        protected override void AttachBaseContext(Context context)
        {
            base.AttachBaseContext(CalligraphyContextWrapper.Wrap(context));
        }
        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);
            if (requestCode == 100 && resultCode == Result.Ok && data != null)
            {
                ImageView img = new ImageView(this);
                img.LayoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.MatchParent);
                img.SetScaleType(ImageView.ScaleType.CenterCrop);
                img.Visibility = ViewStates.Visible;
                img.LayoutParameters.Height = 8;
                img.LayoutParameters.Width = 8;

                Stream stream = ContentResolver.OpenInputStream(data.Data);

                Bitmap bitmap = BitmapFactory.DecodeStream(stream);
                MemoryStream mem = new MemoryStream();
                bitmap.Compress(Bitmap.CompressFormat.Png, 30, mem);
                byte[] selectedImageBytes;
                selectedImageBytes = mem.ToArray();
                img.SetImageBitmap(BitmapFactory.DecodeByteArray(selectedImageBytes, 00, selectedImageBytes.Length));

                myeventupgradelinearLayoutcamera.AddView(img, 170, 170);
               


            }
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            CalligraphyConfig.InitDefault(new CalligraphyConfig.Builder()
      .SetDefaultFontPath("Estedad.ttf").Build());
            SetContentView(Resource.Layout.layoutMyEvenyUpgarade);
            var font = Typeface.CreateFromAsset(Assets, "Estedad.ttf");
             myeventupgradelinearLayoutcamera = FindViewById<LinearLayout>(Resource.Id.myeventupgradelinearLayoutcamera); ;

             myeventUpgradettxtviewcaption = FindViewById<TextView>(Resource.Id.myeventUpgradettxtviewcaption);
            myeventUpgradettxtviewcaption.Typeface = font;
           
             MyeventupgradeButtonBack = FindViewById<Button>(Resource.Id.MyeventupgradeButtonBack);
            MyeventupgradeButtonBack.Typeface = font;
            MyeventupgradeButtonBack.Click += delegate { Finish(); };
             Myeventupgradetimgviewback = FindViewById<ImageView>(Resource.Id.Myeventupgradetimgviewback);
            Myeventupgradetimgviewback.Click += delegate { Finish(); };
             enterevenedittextHelpCaption = FindViewById<EditText>(Resource.Id.enterevenedittextHelpCaption); ;
            enterevenedittextHelpCaption.Typeface = font;
            enterevenedittextHelpCaption.Click += delegate {

              //  string help = "با انتخاب این گزینه رویداد شما در صفحه 'پیشنهاد ویژه' نیز نشان داده خواهد شد";
                Drawable errorIcon = Resources.GetDrawable(Resource.Drawable.academicblack32);



                enterevenedittextHelpCaption.SetError(Android.Text.Html.FromHtml("<font color='White'>با انتخاب این گزینه رویداد شما در صفحه 'پیشنهاد ویژه' نیز نشان داده خواهد شد</font>"), errorIcon);

            };
            enterevenedittextHelpCaption.FocusChange += delegate {

                //  string help = "با انتخاب این گزینه رویداد شما در صفحه 'پیشنهاد ویژه' نیز نشان داده خواهد شد";
                Drawable errorIcon = Resources.GetDrawable(Resource.Drawable.academicblack32);



                enterevenedittextHelpCaption.SetError(Android.Text.Html.FromHtml("<font color='White'>با انتخاب این گزینه رویداد شما در صفحه 'پیشنهاد ویژه' نیز نشان داده خواهد شد</font>"), errorIcon);

            };

            MyEventUpgradeChkfiveThousend = FindViewById<CheckBox>(Resource.Id.MyEventUpgradeChkfiveThousend);
            MyEventUpgradeChkfiveThousend.Typeface = font;

            string ChkfiveThousend = MyEventUpgradeChkfiveThousend.Text;
            string numberdigittthree = ChkfiveThousend.Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩");
            MyEventUpgradeChkfiveThousend.Text = numberdigittthree;


            MyEventUpgradeEdittexthelpSixThousend = FindViewById<EditText>(Resource.Id.MyEventUpgradeEdittexthelpSixThousend);
            MyEventUpgradeEdittexthelpSixThousend.Typeface = font;
            MyEventUpgradeEdittexthelpSixThousend.Click += delegate {
                Drawable errorIcon = Resources.GetDrawable(Resource.Drawable.academicblack32);



                MyEventUpgradeEdittexthelpSixThousend.SetError(Android.Text.Html.FromHtml("<font color='White'>با انتخاب این گزینه تصویر منتخب رویداد شما در اسلایدر صفحه اصلی نیز نمایش داده خواهد شد</font>"), errorIcon);

            };
            MyEventUpgradeEdittexthelpSixThousend.FocusChange += delegate {
                Drawable errorIcon = Resources.GetDrawable(Resource.Drawable.academicblack32);



                MyEventUpgradeEdittexthelpSixThousend.SetError(Android.Text.Html.FromHtml("<font color='White'>با انتخاب این گزینه تصویر منتخب رویداد شما در اسلایدر صفحه اصلی نیز نمایش داده خواهد شد</font>"), errorIcon);

            };

            MyEventUpgradeChkSixThousend = FindViewById<CheckBox>(Resource.Id.MyEventUpgradeChkSixThousend);
            MyEventUpgradeChkSixThousend.Typeface = font;
            string txtviewdescription = MyEventUpgradeChkSixThousend.Text;
            string numberdigittsix = txtviewdescription.Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩");
            MyEventUpgradeChkSixThousend.Text = numberdigittsix;

            MyEventUpgradeChkSixThousend.Click += delegate {

                if (MyEventUpgradeChkSixThousend.Checked)
                {
                    var intentbrowserimage = new Intent();
                    intentbrowserimage.SetAction(Intent.ActionGetContent);
                    intentbrowserimage.SetType("image/*");
                    StartActivityForResult(intentbrowserimage, 100);
                }
                else
                {
                    return;
                }
              
            };

             MyEventUpgradeEditTextHelpTwoThousend = FindViewById<EditText>(Resource.Id.MyEventUpgradeEditTextHelpTwoThousend);

             MyEventUpgradeChkTwoThousend = FindViewById<CheckBox>(Resource.Id.MyEventUpgradeChkTwoThousend);
            MyEventUpgradeChkTwoThousend.Typeface = font;
            string ChkTwoThousend = MyEventUpgradeChkTwoThousend.Text;
            string numberdigittwo = ChkTwoThousend.Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩");
            MyEventUpgradeChkTwoThousend.Text = numberdigittwo;


            MyEventUpgradeEditTextHelpTwoThousend.Click += delegate {

                Drawable errorIcon = Resources.GetDrawable(Resource.Drawable.academicblack32);



                MyEventUpgradeEditTextHelpTwoThousend.SetError(Android.Text.Html.FromHtml("<font color='White'>با انتخاب این گزینه رویداد شما در صفحه اینستاگرام ایونتو نیز منتشر خواهد شد</font>"), errorIcon);

            };
            MyEventUpgradeEditTextHelpTwoThousend.FocusChange += delegate {

                Drawable errorIcon = Resources.GetDrawable(Resource.Drawable.academicblack32);



                MyEventUpgradeEditTextHelpTwoThousend.SetError(Android.Text.Html.FromHtml("<font color='White'>با انتخاب این گزینه رویداد شما در صفحه اینستاگرام ایونتو نیز منتشر خواهد شد</font>"), errorIcon);

            };
            myeventupgradebuttonesave = FindViewById<Button>(Resource.Id.myeventupgradebuttonesave);
            myeventupgradebuttonesave.Click += delegate {



                string ValueToast = "ارتقا رویداد با موفقیت انجام شد";


                Snackbar snackBar = Snackbar.Make(myeventupgradebuttonesave, ValueToast, Snackbar.LengthIndefinite).SetAction("باشه", (v) =>
                {
                    Finish();
                });
                snackBar.Show();
            };


            // Create your application here
        }
    }
}