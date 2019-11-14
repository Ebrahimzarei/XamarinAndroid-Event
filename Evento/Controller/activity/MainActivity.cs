using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V4.View;
using Android.Graphics;

using Android.Views;
using System.Collections.Generic;

using Android.Content;

using Java.Lang;

using WebEventoo_DomainClasses.Model;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Evento.Adapter;
using System;
using Android.Support.V7.Widget;
using static Android.Support.V7.Widget.RecyclerView;
using System.Net.Http;
using Evento.Model;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Linq;

namespace Evento.Controller.activity
{
 



[Activity(Label = "@string/app_name", Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class MainActivity : AppCompatActivity
    {

     


        Button btnenterevent;
        TextView maintxtviewgroup;
        ImageButton mainimgbtnlogo;
        Button mainbtnfilter;
        Button mainbtnsearch;
        Button mainbtndelete;
        EditText mainedtxtsearch;

        ListView mainlstevent;
        Button mainbtnContact;
        Button mainbtngift;
        Button mainbtnEventDay;
        Button mainbtngroupingGrouping;

      
        Typeface font;
    
     
      
       
        protected async override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);


            SetContentView(Resource.Layout.activity_main);

            font = Typeface.CreateFromAsset(Assets, "Estedad.ttf");

            btnenterevent = FindViewById<Button>(Resource.Id.mainbtnenterevent);

          
            btnenterevent.Typeface = font;

            btnenterevent.Click += delegate
            {

                Intent oi = new Intent(this, typeof(EnterEvent));
                StartActivity(oi);




            };

            maintxtviewgroup = FindViewById<TextView>(Resource.Id.maintxtviewgroup);
            maintxtviewgroup.Typeface = font;
            mainimgbtnlogo = FindViewById<ImageButton>(Resource.Id.mainimgbtnlogo);

            mainbtnfilter = FindViewById<Button>(Resource.Id.mainbtnfilter);
            mainbtnfilter.Typeface = font;
            mainbtnfilter.Click += delegate {

                Controller.Fragment.FilterMain fdlg = new Controller.Fragment.FilterMain(this);
                fdlg.Show(this.FragmentManager, "ebrahimfragmentfliterMainToFilterMain");
            };


            mainbtnsearch = FindViewById<Button>(Resource.Id.mainbtnsearch);

            mainbtndelete = FindViewById<Button>(Resource.Id.mainbtndelete);
            mainbtndelete.Click += Mainbtndelete_Click;
            mainedtxtsearch = FindViewById<EditText>(Resource.Id.mainedtxtsearch);
            mainedtxtsearch.Typeface = font;

            mainedtxtsearch.TextChanged += Mainedtxtsearch_TextChanged;





            mainlstevent = FindViewById<ListView>(Resource.Id.mainlstevent);





            //فراخوانی webapiو پر کردن لیست ها
            using (HttpClient client = new HttpClient())
            {

                client.BaseAddress = new Uri(WebAddress.MyAddress);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                string json = JsonConvert.SerializeObject("", Formatting.Indented);
                var httpContent = new StringContent(json);
                HttpResponseMessage response = client.PostAsync("api/GetEventsItems", httpContent).Result;
                if (response.IsSuccessStatusCode)
                {
                    response.EnsureSuccessStatusCode();
                    var responseJsonString = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject(responseJsonString).ToString();
                    List<Event> objr = JsonConvert.DeserializeObject<List<Event>>(result);
                    var SelectItem = objr.Where(u => u.Statusevent == Event.StatuseEvent.Published).ToList();
                    if (SelectItem != null)
                    {
                        MainShowEventAdapter t = new MainShowEventAdapter(this, SelectItem);
                        mainlstevent.Adapter = t;

                        ViewGroup headerView = (ViewGroup)LayoutInflater.Inflate(Resource.Layout.layoutMainHeaderListview, mainlstevent, false);
                        ViewPager vpagerslider = headerView.FindViewById<ViewPager>(Resource.Id.Mainviewpagerslider);
                        var images = SelectItem.Select(x => x.SliderImages).ToList();
                        vpagerslider.Adapter = new ImageAdapter(this, images);
                        var dots = headerView.FindViewById<TabLayout>(Resource.Id.Maintablayoutdots);
                        dots.SetupWithViewPager(vpagerslider, true);
                        var timer = new System.Timers.Timer
                        {
                            Interval = 3000,
                            Enabled = true
                        };
                        int page = 0;
                        timer.Elapsed += (sender, args) =>
                        {
                            RunOnUiThread(() =>
                            {
                                if (page <= vpagerslider.Adapter.Count)
                                {
                                    page++;
                                }
                                else
                                {
                                    page = 0;
                                }
                                vpagerslider.SetCurrentItem(page, true);

                            });
                        };


                        mainlstevent.AddHeaderView(headerView);
                    }




                }
            }

            //MainShowEventAdapter t = new MainShowEventAdapter(this, eventlist);
            //mainlstevent.Adapter = t;
















            //  mainlstevent.ItemClick += Mainlstevent_ItemClick;







            mainbtnContact = FindViewById<Button>(Resource.Id.mainbtnContact);
            mainbtnContact.Typeface = font;
            mainbtnContact.Click += delegate {

                //اطلاعات من

                Intent oi = new Intent(this, typeof(Account));
                StartActivity(oi);

            };
            mainbtngift = FindViewById<Button>(Resource.Id.mainbtngift);
            mainbtngift.Typeface = font;
            mainbtngift.Click += delegate {
                //پیشنهاد ویژه
                Intent oi = new Intent(this, typeof(CustomActivity.Suprised_Activity));
                StartActivity(oi);
            };
            mainbtnEventDay = FindViewById<Button>(Resource.Id.mainbtnEventDay);
            mainbtnEventDay.Click += delegate {
                //رویداد های روز
                Intent oi = new Intent(this, typeof(CustomActivity.EventDay_Activity));
                StartActivity(oi);

            };
            mainbtnEventDay.Typeface = font;
            mainbtngroupingGrouping = FindViewById<Button>(Resource.Id.mainbtngroupingGrouping);
            mainbtngroupingGrouping.Click += delegate {

                Intent oi = new Intent(this, typeof(Grouping));
                StartActivity(oi);

            };
            mainbtngroupingGrouping.Typeface = font;



        }
       

        private void Mainedtxtsearch_TextChanged(object sender, Android.Text.TextChangedEventArgs e)
        {
            if (e.AfterCount >= 1)
            {

                mainbtnsearch.Visibility = ViewStates.Visible;
                mainbtndelete.Visibility = ViewStates.Visible;
                mainedtxtsearch.TextAlignment = TextAlignment.Center;



            }
            else
            {
                mainbtnsearch.Visibility = ViewStates.Gone;
                mainbtndelete.Visibility = ViewStates.Gone;
                mainedtxtsearch.TextAlignment = TextAlignment.Center;

            }
        }

        private void Mainbtndelete_Click(object sender, System.EventArgs e)
        {
            mainedtxtsearch.Text = "";
        }
    }
    public class ImageAdapter :PagerAdapter
    {
        readonly Context context;
        public List<byte[]> images;
        private int[] imagelist =
        {
            Resource.Drawable.gemtestslide,
             Resource.Drawable.colorimagetestslider,


        };
        public ImageAdapter(Context cnt,List<byte[]>_lstImages)
        {
            context = cnt;
            images = _lstImages;
        }
        public override int Count
        {
            get
            {
                //if (images.Count!=null)
                //{
                //    return images.Count;
                //}

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
            //if (images.Count <= 0)
            //{
            //    imageview.SetImageResource(imagelist[position]);
            //    //var bmp = BitmapFactory.DecodeByteArray(images[position], 00, images[position].Length);
            //    //imageview.SetImageBitmap(bmp);
            //}
            //else
            //{
                imageview.SetImageResource(imagelist[position]);
         //   }
            ((ViewPager)container).AddView(imageview, 0);
            return imageview;


        }


     public override void DestroyItem(View container, int position, Java.Lang.Object @object) => ((ViewPager)container).RemoveView((ImageView)@object);
         

    }

 



}

