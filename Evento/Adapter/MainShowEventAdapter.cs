
using System.Collections.Generic;
using System.Linq;
using Android.App;
using Android.Content;
using Android.Graphics;

using Android.Runtime;
using Android.Views;
using Android.Widget;
using Evento.Controller.activity;
using WebEventoo_DomainClasses.Model;

namespace Evento.Adapter
{
    class MainShowEventAdapter : BaseAdapter
    {

        Context context;
        private List<Event> even;
        //List<Images> img;

        public MainShowEventAdapter(Context context, List<Event> _event)
        {
            this.context = context;
            even = _event;
          
        }


        public override Java.Lang.Object GetItem(int position)
        {
            return position;
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = convertView;
            MainShowEventAdapterViewHolder holder = null;
          var font = Typeface.CreateFromAsset(context.Assets, "Estedad.ttf");
          //  var font = Typeface.CreateFromAsset(context.Assets, "Tanha.ttf");

            if (view != null)
                holder = view.Tag as MainShowEventAdapterViewHolder;

            if (holder == null)
            {
                holder = new MainShowEventAdapterViewHolder();
                var inflater = context.GetSystemService(Context.LayoutInflaterService).JavaCast<LayoutInflater>();
                view = inflater.Inflate(Resource.Layout.layoutShowevent, parent, false);



                view.Tag = holder;
            }

          
            holder.showeventtxtvieweventcaption = view.FindViewById<TextView>(Resource.Id.showeventtxtViewcaption);
            holder.showeventtxtvieweventcaption.Typeface = font;
            holder.showeventtxtviewgrouping = view.FindViewById<TextView>(Resource.Id.showeventtxtviewcaptiongrouping);
            holder.showeventtxtviewgrouping.Typeface = font;

            holder.showeventtxttime = view.FindViewById<TextView>(Resource.Id.MainTextextViewTime);
            holder.showeventtxttime.Typeface = font;

            holder.showeventtxtPrice = view.FindViewById<TextView>(Resource.Id.MainTextextViewCost);
            holder.showeventtxtPrice.Typeface = font;
            holder.imageView1 = view.FindViewById<ImageView>(Resource.Id.imageView1);

            holder.MainTextextViewLonging = view.FindViewById<TextView>(Resource.Id.MainTextextViewLonging);
            holder.MainTextextViewDescLonging = view.FindViewById<TextView>(Resource.Id.MainTextextViewDescLonging);

            //اغذیه فروشی
            if (even[position].TypeCaption==Event.TypeCaptionEvent.LongingfoodLive)
            {
                holder.MainTextextViewLonging.Text += "جنبه رویداد"+"-"+"اجرای زنده";
            }
            if (even[position].TypeCaption == Event.TypeCaptionEvent.Longingfoodlottery)
            {
                holder.MainTextextViewLonging.Text += "جنبه رویداد" + "-" + "قرعه کشی";
            }
            if (even[position].TypeCaption == Event.TypeCaptionEvent.Longingfoodmajorlive)
            {
                holder.MainTextextViewLonging.Text += "جنبه رویداد" + "-" + "پخش مسابقات زنده";
            }
            if (even[position].TypeCaption == Event.TypeCaptionEvent.Longingfoodgift)
            {
                holder.MainTextextViewLonging.Text += "جنبه رویداد" + "-" + "اشانتیون";
            }
            if (even[position].TypeCaption == Event.TypeCaptionEvent.Longingfoodexhibition)
            {
                holder.MainTextextViewLonging.Text += "جنبه رویداد" + "-" + "نمایشگاه جنبی";
            }
            if (even[position].TypeCaption == Event.TypeCaptionEvent.Longingfoodopening)
            {
                holder.MainTextextViewLonging.Text += "جنبه رویداد" + "-" + "افتتاحیه";
            }
            if (even[position].TypeCaption == Event.TypeCaptionEvent.Longingfooddiscount)
            {
                holder.MainTextextViewLonging.Text += "جنبه رویداد" + "-" + "تخفیف";
                holder.MainTextextViewDescLonging.Text = even[position].OtherLonging;
            }
            holder.MainTextextViewDescLonging.Visibility=ViewStates.Invisible;
            if (even[position].TypeCaption == Event.TypeCaptionEvent.Longingfoodother)
            {
                holder.MainTextextViewLonging.Text += "جنبه رویداد" + "-" + "سایر";
                holder.MainTextextViewDescLonging.Text = even[position].OtherLonging;
            }

            holder.MainTextextViewDescLonging.Visibility =ViewStates.Invisible;
            //کلاس آموزشی

            if (even[position].TypeCaption == Event.TypeCaptionEvent.LongingclassLive)
            {
                holder.MainTextextViewLonging.Text += "جنبه رویداد" + "-" + "جلسه رایگان";
            }
            if (even[position].TypeCaption == Event.TypeCaptionEvent.Longingclasslottery)
            {
                holder.MainTextextViewLonging.Text += "جنبه رویداد" + "-" + "قرعه کشی";
            }
            if (even[position].TypeCaption == Event.TypeCaptionEvent.LongingclassotherLive)
            {
                holder.MainTextextViewLonging.Text += "جنبه رویداد" + "-" + "کارگاه جنبی";
            }
            if (even[position].TypeCaption == Event.TypeCaptionEvent.Longingclassgiftlottery)
            {
                holder.MainTextextViewLonging.Text += "جنبه رویداد" + "-" + "اشانتیون";
            }
            if (even[position].TypeCaption == Event.TypeCaptionEvent.LongingclassexhibitionLive)
            {
                holder.MainTextextViewLonging.Text += "جنبه رویداد" + "-" + "نمایشگاه جنبی";
            }
            if (even[position].TypeCaption == Event.TypeCaptionEvent.Longingclassopening)
            {
                holder.MainTextextViewLonging.Text += "جنبه رویداد" + "-" + "افتتاحیه";
            }
            if (even[position].TypeCaption == Event.TypeCaptionEvent.Longingclassdiscount)
            {
                holder.MainTextextViewLonging.Text += "جنبه رویداد" + "-" + "تخفیف";
                holder.MainTextextViewDescLonging.Text = even[position].OtherLonging;
            }
            holder.MainTextextViewDescLonging.Visibility = ViewStates.Invisible;
            if (even[position].TypeCaption == Event.TypeCaptionEvent.Longingclassdiscount)
            {
                holder.MainTextextViewLonging.Text += "جنبه رویداد" + "-" + "سایر";
                holder.MainTextextViewDescLonging.Text = even[position].OtherLonging;
            }

            holder.MainTextextViewDescLonging.Visibility = ViewStates.Invisible;

            // فروشگاه

            if (even[position].TypeCaption == Event.TypeCaptionEvent.LongingStoreLive)
            {
                holder.MainTextextViewLonging.Text += "جنبه رویداد" + "-" + "اجرای زنده";
            }
            if (even[position].TypeCaption == Event.TypeCaptionEvent.LongingStorelottery)
            {
                holder.MainTextextViewLonging.Text += "جنبه رویداد" + "-" + "قرعه کشی";
            }
            if (even[position].TypeCaption == Event.TypeCaptionEvent.LongingStoregift)
            {
                holder.MainTextextViewLonging.Text += "جنبه رویداد" + "-" + "اشانتیون";
            }
            if (even[position].TypeCaption == Event.TypeCaptionEvent.LongingStoreexhibition)
            {
                holder.MainTextextViewLonging.Text += "جنبه رویداد" + "-" + "نمایشگاه جنبی";
            }
            if (even[position].TypeCaption == Event.TypeCaptionEvent.LongingStoreopening)
            {
                holder.MainTextextViewLonging.Text += "جنبه رویداد" + "-" + "افتتاحیه";
            }
            if (even[position].TypeCaption == Event.TypeCaptionEvent.LongingStorediscount)
            {
                holder.MainTextextViewLonging.Text += "جنبه رویداد" + "-" + "تخفیف";
            }
            if (even[position].TypeCaption == Event.TypeCaptionEvent.LongingStoreother)
            {
                holder.MainTextextViewLonging.Text += "جنبه رویداد" + "-" + "سایر";
                holder.MainTextextViewDescLonging.Text = even[position].OtherLonging;
            }
         
            holder.MainTextextViewDescLonging.Visibility = ViewStates.Invisible;

            string eventcaption = even[position].CaptionEvent;
            string numberdigit= eventcaption.Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩");
            holder.showeventtxtvieweventcaption.Text = eventcaption;
            if (even[position].Place!=null)
            {
foreach (var item in even[position].Place)
            {
                holder.showeventtxtviewgrouping.Text ="شیراز"+ item.Name;
            }
            }
            else
            {
                holder.showeventtxtviewgrouping.Text = "شیراز";
            }
            
            // = even[position].Place.Select(x=>x.Name);
            string timefromdate = even[position].FromDate; 
            string timetodate = even[position].ToDate;
            string digitfarsi= timefromdate.Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩");
            string digitfarsitodate = timefromdate.Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩");
            holder.showeventtxttime.Text = "از "+ digitfarsitodate + "تا"+ digitfarsi;
            if (even[position].Payed == Event.Cost.AddCost)
            {
                string costed = even[position].Price;
                string costconverted = costed.Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩");
                holder.showeventtxtPrice.Text = costconverted + "تومان";
            }
            if (even[position].Payed == Event.Cost.Free)
            {
                holder.showeventtxtPrice.Text = "رایگان";
            }
            if (even[position].Payed == Event.Cost.Free)
            {
                holder.showeventtxtPrice.Text = "قیمت درج نشود";
            }


            if (even[position].Image != null)
            {
                foreach (var item in even[position].Image)
                {

                    var bmp = BitmapFactory.DecodeByteArray(item.ImageData, 00, item.ImageData.Length);
                    holder.imageView1.SetImageBitmap(bmp);

                 
                }


            }
            if (!holder.showeventtxtvieweventcaption.HasOnClickListeners)
            {         holder.showeventtxtvieweventcaption.Click += delegate
            {
               // Toast.MakeText(context, even[position].Id.ToString(), ToastLength.Short).Show();
   Intent oi = new Intent(context, typeof(SelectEvent));
                oi.PutExtra("Id", even[position].Id.ToString());
                context.StartActivity(oi);

            };
            }
       
            if (!holder.showeventtxtviewgrouping.HasOnClickListeners)
            {
                holder.showeventtxtviewgrouping.Click += delegate
            {
                Intent oi = new Intent(context, typeof(SelectEvent));
                oi.PutExtra("Id", even[position].Id.ToString());
                context.StartActivity(oi);

            };
            }
            if (!holder.showeventtxttime.HasOnClickListeners)
            {  holder.showeventtxttime.Click += delegate
            {
                Intent oi = new Intent(context, typeof(SelectEvent));
                oi.PutExtra("Id", even[position].Id.ToString());
                context.StartActivity(oi);

            };
            }
            if (!holder.showeventtxtPrice.HasOnClickListeners)
            {  holder.showeventtxtPrice.Click += delegate
            {
                Intent oi = new Intent(context, typeof(SelectEvent));
                oi.PutExtra("Id", even[position].Id.ToString());
                context.StartActivity(oi);

            }; }
            if (!holder.imageView1.HasOnClickListeners)
            {
   holder.imageView1.Click += delegate
            {
                Intent oi = new Intent(context, typeof(SelectEvent));
                oi.PutExtra("Id", even[position].Id.ToString());
                context.StartActivity(oi);

            };
            }
             

            return view;
        }

        //Fill in cound here, currently 0
        public override int Count
        {
            get
            {
                return even.Count;
            }
        }

    }

    class MainShowEventAdapterViewHolder : Java.Lang.Object
    {

        public TextView showeventtxtvieweventcaption { get; set; }
        public TextView showeventtxtviewgrouping { get; set; }

        public TextView showeventtxttime { get; set; }
        public TextView showeventtxtPrice { get; set; }
        public ImageView imageView1 { get; set; }
        public TextView MainTextextViewLonging { get; set; }
        public TextView MainTextextViewDescLonging { get; set; }

    }
}