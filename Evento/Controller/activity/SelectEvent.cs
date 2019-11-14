


using Android.App;
using Android.Content;
using Android.OS;

using Android.Support.V4.View;

using Android.Widget;

using Android.Graphics;

using WebEventoo_DomainClasses.Model;

using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Calligraphy;
using Evento.Controller.Fragment;
using System;
using System.Net.Http;
using Evento.Model;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Collections.Generic;
using Android.Views;

namespace Evento.Controller.activity
{
    [Activity(Label = "SelectEvent", Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class SelectEvent : AppCompatActivity
    {
        ImageButton selecteventimgbtnlogo;

        TextView selecteventtxtviewcaption;
        Button selecteventbtnenterevent;
        TextView selecteventtxtviewcaptionfgfg;
       

       TextView selecteventtxtviewmajor;
       TextView selecteventtxtviewsport;
        TextView selecteventtxtviewplace;
        TextView selecteventtxtviewdate;
        TextView selecteventtxtviewprice;
        TextView selecteventxtviewdescription;

        Button selecteventbtnreport;
        Button selecteventbtncomment;

        Button selecteventbtnshare;
        Button selecteventbtnbookmark;
        Button btncobtactus;
        TextView selecteventxtviecaunt;

        TextView selecteventtxtviewcaptiongroup;
        TextView selecteventtxtviewcaptionplace;
        TextView selecteventtxtviewcaptiontime;
        TextView selecteventtxtviewcaptioncost;
        TextView selecteventtxtviewcaptiondescription;


        ViewPager selecteventvpagerslider;

        TextView selecteventxtviewaddress;
        TextView selecteventtxtviewcaptionaddress;
        TextView selecteventxtviewurl;
        TextView selecteventtxtviewcaptionurl;
        Event objr;
        protected override void AttachBaseContext(Context context)
        {
            base.AttachBaseContext(CalligraphyContextWrapper.Wrap(context));
        }

        protected async override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            CalligraphyConfig.InitDefault(new CalligraphyConfig.Builder()
            .SetDefaultFontPath("Estedad.ttf")

        .Build()
    );
            string StrId = Intent.GetStringExtra("Id");

            int id = int.Parse(StrId);


            SetContentView(Resource.Layout.layoutSelectEvent);


            using (HttpClient client = new HttpClient())
            {
             
    

                client.BaseAddress = new Uri(WebAddress.MyAddress);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                string json = JsonConvert.SerializeObject(StrId, Formatting.Indented);
                var httpContent = new StringContent(json);
              HttpResponseMessage response = client.PostAsync("api/FindEventsItem/"+id, httpContent).Result;
                //var response = await client.PostAsync("api/FindEventsItem/", content);
                if (response.IsSuccessStatusCode)
                {
                    response.EnsureSuccessStatusCode();
                    var responseJsonString = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject(responseJsonString);

                     objr = JsonConvert.DeserializeObject<Event>(result.ToString());
                 
                

               


                }
            }

            var font = Typeface.CreateFromAsset(Assets, "Estedad.ttf");
             selecteventxtviewaddress = FindViewById<TextView>(Resource.Id.selecteventxtviewaddress);
            selecteventxtviewaddress.Typeface = font;
            string txtviewaddress = selecteventxtviewaddress.Text;
            string numberdigit = txtviewaddress.Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩");
            selecteventxtviewaddress.Text = numberdigit;

            selecteventtxtviewcaptionaddress = FindViewById<TextView>(Resource.Id.selecteventtxtviewcaptionaddress);
            selecteventtxtviewcaptionaddress.Typeface = font;
            string txtviewcaptionaddress = selecteventtxtviewcaptionaddress.Text;
            string numberdigittwo = txtviewcaptionaddress.Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩");
            selecteventtxtviewcaptionaddress.Text = numberdigittwo;

            selecteventxtviewurl = FindViewById<TextView>(Resource.Id.selecteventxtviewurl);
            selecteventxtviewurl.Typeface = font;
            string txtviewurl = selecteventxtviewurl.Text;
            string numberdigitthree = txtviewurl.Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩");
            selecteventxtviewurl.Text = numberdigitthree;

            selecteventtxtviewcaptionurl = FindViewById<TextView>(Resource.Id.selecteventtxtviewcaptionurl);
            selecteventtxtviewcaptionurl.Typeface = font;
            string tviewcaptionurl = selecteventtxtviewcaptionurl.Text;
            string numberdigitfor = tviewcaptionurl.Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩");
            selecteventtxtviewcaptionurl.Text = numberdigitfor;

            selecteventtxtviewcaptiongroup = FindViewById<TextView>(Resource.Id.selecteventtxtviewcaptiongroup);
            selecteventtxtviewcaptiongroup.Typeface = font;
            selecteventtxtviewcaptionplace = FindViewById<TextView>(Resource.Id.selecteventtxtviewcaptionplace);
            selecteventtxtviewcaptionplace.Typeface = font;
            selecteventtxtviewcaptiontime = FindViewById<TextView>(Resource.Id.selecteventtxtviewcaptiontime);
            selecteventtxtviewcaptiontime.Typeface = font;
            selecteventtxtviewcaptioncost = FindViewById<TextView>(Resource.Id.selecteventtxtviewcaptioncost);
            selecteventtxtviewcaptioncost.Typeface = font;
            selecteventtxtviewcaptiondescription = FindViewById<TextView>(Resource.Id.selecteventtxtviewcaptiondescription);
            selecteventtxtviewcaptiondescription.Typeface = font;


            selecteventxtviecaunt = FindViewById<TextView>(Resource.Id.selecteventxtviecaunt);
            selecteventxtviecaunt.Typeface = font;
            selecteventvpagerslider = FindViewById<ViewPager>(Resource.Id.selecteventvpagerslider);

            selecteventvpagerslider.Adapter = new SelectImageImageAdapter(this, objr.Image);
            //    (this);
            var dots = FindViewById<TabLayout>(Resource.Id.selecteventtablayoutdots);
            dots.SetupWithViewPager(selecteventvpagerslider, true);

            btncobtactus = FindViewById<Button>(Resource.Id.button);
            btncobtactus.Typeface = font;

            btncobtactus.Click += delegate {
                //اطلاعات تماس
                ContentTelFragment fdlg = new ContentTelFragment(this,id);
                fdlg.Show(this.FragmentManager, "ContenttellFragmentShow");

            };
             selecteventtxtviewcaption =FindViewById<TextView>(Resource.Id.selecteventtxtviewcaption);
            selecteventtxtviewcaption.Typeface = font;
            selecteventtxtviewcaption.Text = objr.CaptionEvent;
               selecteventbtnenterevent = FindViewById<Button>(Resource.Id.selecteventbtnenterevent);

            //var fontenterevent = Typeface.CreateFromAsset(Assets, "titr.ttf");
            selecteventbtnenterevent.Typeface = font;
            selecteventbtnenterevent.Click += delegate { StartActivity(typeof(EnterEvent)); };

             selecteventtxtviewcaptionfgfg = FindViewById<TextView>(Resource.Id.selecteventtxtviewcaption);
            selecteventtxtviewcaptionfgfg.Typeface = font;
             selecteventimgbtnlogo = FindViewById<ImageButton>(Resource.Id.selecteventimgbtnlogo);

            selecteventimgbtnlogo.Click += delegate { StartActivity(typeof(MainActivity)); };

         
            
        
       
          

            selecteventtxtviewmajor = FindViewById<TextView>(Resource.Id.selecteventtxtviewmajor);
            selecteventtxtviewmajor.Typeface = font;

            selecteventtxtviewsport = FindViewById<TextView>(Resource.Id.selecteventtxtviewsport);
            selecteventtxtviewsport.Typeface = font;
           // selecteventtxtviewsport.Text = "dfdfd;";
            if (objr.Type == Event.TypeEvent.ClassLearn)
            {
                selecteventtxtviewsport.Text = "کلاس های آموزشی";
            }
            if (objr.Type == Event.TypeEvent.Cultrual)
            {
                selecteventtxtviewsport.Text = "فرهنگی هنری";
            }
            if (objr.Type == Event.TypeEvent.Food)
            {
                selecteventtxtviewsport.Text = "خوراکی";
            }
            if (objr.Type == Event.TypeEvent.Health)
            {
                selecteventtxtviewsport.Text = "سلامتی و زیبایی";
            }
            if (objr.Type == Event.TypeEvent.Public)
            {
                selecteventtxtviewsport.Text = "داوطلبانه و مردمی;";
            }
            if (objr.Type == Event.TypeEvent.Religuse)
            {
                selecteventtxtviewsport.Text = "خوراکی";
            }
            if (objr.Type == Event.TypeEvent.Sciences)
            {
                selecteventtxtviewsport.Text = "علمی و تخصصی";
            }
            if (objr.Type == Event.TypeEvent.Sport)
            {
                selecteventtxtviewsport.Text = "ورزشی";
            }
            if (objr.Type == Event.TypeEvent.Toursm)
            {
                selecteventtxtviewsport.Text = "گردشگری";
            }

            selecteventtxtviewplace = FindViewById<TextView>(Resource.Id.selecteventtxtviewplace);
            selecteventtxtviewplace.Typeface = font;
            if (objr.Address!=null)
            {
  foreach (var item in objr.Address)
            {
 selecteventtxtviewplace.Text =item.AddressTwo;
            }
            }
          
           

            selecteventtxtviewdate = FindViewById<TextView>(Resource.Id.selecteventtxtviewdate);
            selecteventtxtviewdate.Typeface = font;
        // "22اردیبهشت تا 25شهریور"
            

            string ttxtviewdate = selecteventtxtviewdate.Text = objr.ToDate + "تا" + objr.FromDate;
            string numberdigitdate = ttxtviewdate.Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩");
            selecteventtxtviewdate.Text = numberdigitdate;



            selecteventtxtviewmajor = FindViewById<TextView>(Resource.Id.selecteventtxtviewmajor);
            selecteventtxtviewmajor.Typeface = font;
            selecteventtxtviewmajor.Text = objr.CaptionEvent;

            selecteventtxtviewprice = FindViewById<TextView>(Resource.Id.selecteventtxtviewprice);
            selecteventtxtviewprice.Typeface = font;
            string txtviewrice;
            if (objr.Payed==Event.Cost.AddCost)
            {
                selecteventtxtviewprice.Text = "تومان" + objr.Price;
            }
            if (objr.Payed == Event.Cost.Free)
            {
                selecteventtxtviewprice.Text = "رایگان";
            }
            if (objr.Payed == Event.Cost.NotCost)
            {
                selecteventtxtviewprice.Text = "هزینه درج نشود";
            }


             txtviewrice = selecteventtxtviewprice.Text = "تومان" + objr.Price;
            string numberdigitprice = txtviewrice.Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩");
            selecteventtxtviewprice.Text = numberdigitprice;



       

            selecteventxtviewdescription = FindViewById<TextView>(Resource.Id.selecteventxtviewdescription);
            selecteventxtviewdescription.Typeface = font;
            selecteventxtviewdescription.Text = objr.Description;

            selecteventbtnreport = FindViewById<Button>(Resource.Id.selecteventbtnreport);
            selecteventbtnreport.Typeface = font;
            selecteventbtnreport.Click += delegate {

                Controller.Fragment.Reportevent fdlg = new Controller.Fragment.Reportevent(this);
                fdlg.Show(this.FragmentManager, "ebrahimfragmentreportevent");

            };
       
     


                  selecteventbtncomment = FindViewById<Button>(Resource.Id.selecteventbtncomment);
            selecteventbtncomment.Typeface = font;
            selecteventbtncomment.Click += delegate {
                //نظرات رویداد
                Intent oi = new Intent(this, typeof(CustomActivity.Comment_Activity));
                StartActivity(oi);

            };

            selecteventbtnshare = FindViewById<Button>(Resource.Id.selecteventbtnshare);
            selecteventbtnshare.Typeface = font;
            selecteventbtnshare.Click += delegate 
            {

                Intent sharingIntent = new Intent(Android.Content.Intent.ActionSend);
                //در خط زیر نوع داده ای که قراره به اشتراک گذاشته بشه رو تعیین میکنیم که تو این کد یه متن تعریف شده
                sharingIntent.SetType("text/plain");
                sharingIntent.PutExtra(Android.Content.Intent.ExtraSubject, "اشتراک");
                string text = selecteventtxtviewmajor.Text+string.Empty + selecteventtxtviewsport.Text + string.Empty + selecteventtxtviewplace.Text + string.Empty + selecteventtxtviewdate.Text + string.Empty + selecteventtxtviewprice.Text +string.Empty + selecteventxtviewdescription.Text;
                sharingIntent.PutExtra(Android.Content.Intent.ExtraText, text);
                StartActivity(Intent.CreateChooser(sharingIntent, "اشتراک با"));
            };

            selecteventbtnbookmark = FindViewById<Button>(Resource.Id.selecteventbtnbookmark);
            selecteventbtnbookmark.Typeface = font;
            selecteventbtnbookmark.Click += delegate {


                Snackbar snackBar = Snackbar.Make(selecteventbtnbookmark, "رویداد مورد نظر ذخیره شد", Snackbar.LengthIndefinite).SetAction("باشه", (v) =>
                {
                   
                });

                //set  action button text color 
                snackBar.SetActionTextColor(Android.Graphics.Color.Green);

                snackBar.Show();
            };
        }
    }
    public class SelectImageImageAdapter : PagerAdapter
    {
        readonly Context context;
        private int[] imagelist =
        {
            Resource.Drawable.gemtestslide,
             Resource.Drawable.colorimagetestslider,


        };
        private List<Images> _img;
        public SelectImageImageAdapter(Context cnt,List<WebEventoo_DomainClasses.Model.Images> Img)
        {
            context = cnt;
            _img = Img;
        }
        public override int Count
        {
            get
            {
                if (_img!=null)
                {
   return _img.Count;
                }
                return imagelist.Length;



            }
        }

        public override bool IsViewFromObject(View view, Java.Lang.Object @object)
        {
            return view == ((ImageView)@object);
        }

        public override Java.Lang.Object InstantiateItem(ViewGroup container, int position)
        {
            ImageView imageview = new ImageView(context);
            imageview.SetScaleType(ImageView.ScaleType.FitCenter);
           
            if (_img!=null)
            {
              
                    var bmp = BitmapFactory.DecodeByteArray(_img[position].ImageData, 00, _img[position].ImageData.Length);
                imageview.SetImageBitmap(bmp);
            }
            else
            {
     imageview.SetImageResource(imagelist[position]);
            }
            //if (_img!=null)
            //{
            //    foreach (var item in _img)
            //    {
            //    var bmp = BitmapFactory.DecodeByteArray(item.ImageData, 00, item.ImageData.Length);
            //     imageview.SetImageBitmap(bmp);
            //    }
            //}
          

            ((ViewPager)container).AddView(imageview, 0);
            return imageview;


        }


        public override void DestroyItem(View container, int position, Java.Lang.Object @object) => ((ViewPager)container).RemoveView((ImageView)@object);


    }


}