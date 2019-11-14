using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Evento.Adapter
{
    class CustomEventDay_Adapter : BaseAdapter
    {

        Context context;
        private List<Model.ItemEvent> even;

        public CustomEventDay_Adapter(Context context, List<Model.ItemEvent> _even)
        {
            this.context = context;
            even = _even;
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
            CustomEventDay_AdapterViewHolder holder = null;
            var font = Typeface.CreateFromAsset(context.Assets, "Estedad.ttf");

            if (view != null)
                holder = view.Tag as CustomEventDay_AdapterViewHolder;

            if (holder == null)
            {
                holder = new CustomEventDay_AdapterViewHolder();
                var inflater = context.GetSystemService(Context.LayoutInflaterService).JavaCast<LayoutInflater>();
                //replace with your item and your holder items
                //comment back in
              view = inflater.Inflate(Resource.Layout.Layout_CustomEventDay, parent, false);
                //holder.Title = view.FindViewById<TextView>(Resource.Id.text);
                view.Tag = holder;
            }

            holder.CustomEventDaytxtViewcaption = view.FindViewById<TextView>(Resource.Id.CustomEventDaytxtViewcaption);
            holder.CustomEventDaytxtViewcaption.Typeface = font;
            holder.CustomEventDaytxtviewcaptiongrouping = view.FindViewById<TextView>(Resource.Id.CustomEventDaytxtviewcaptiongrouping);
            holder.CustomEventDaytxtviewcaptiongrouping.Typeface = font;
            holder.CustomEventDayTextextViewTime = view.FindViewById<TextView>(Resource.Id.CustomEventDayTextextViewTime);
            holder.CustomEventDayTextextViewTime.Typeface = font;
            holder.CustomEventDayTextextViewCost = view.FindViewById<TextView>(Resource.Id.CustomEventDayTextextViewCost);
            holder.CustomEventDayTextextViewCost.Typeface = font;

            string eventcaption = even[position].caption;
            string numberdigit = eventcaption.Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩");
            holder.CustomEventDaytxtViewcaption.Text = eventcaption;

            holder.CustomEventDaytxtviewcaptiongrouping.Text = even[position].category;
            string time = even[position].Timeevent;
            string digitfarsi = time.Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩");
            holder.CustomEventDayTextextViewTime.Text = digitfarsi;
            string cost = even[position].Cost;
            string costconvert = cost.Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩");
            holder.CustomEventDayTextextViewCost.Text = costconvert + "تومان";



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

    class CustomEventDay_AdapterViewHolder : Java.Lang.Object
    {
        public ImageView CustomEventDayImage { get; set; }
        public TextView CustomEventDaytxtViewcaption { get; set; }

        public TextView CustomEventDaytxtviewcaptiongrouping { get; set; }
        public TextView CustomEventDayTextextViewTime { get; set; }
        public TextView CustomEventDayTextextViewCost { get; set; }
         
    }
}