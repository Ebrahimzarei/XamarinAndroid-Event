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
  public  class ClustomSuprised_Adapter : BaseAdapter
    {

        Context context;
        private List<Model.ItemEvent> even;
        public ClustomSuprised_Adapter(Context context,List<Model.ItemEvent>_even)
        {
            this.context = context;
            this.even = _even;
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
            ClustomSuprised_AdapterViewHolder holder = null;
            var font = Typeface.CreateFromAsset(context.Assets, "Estedad.ttf");

            if (view != null)
                holder = view.Tag as ClustomSuprised_AdapterViewHolder;

            if (holder == null)
            {
                holder = new ClustomSuprised_AdapterViewHolder();
                var inflater = context.GetSystemService(Context.LayoutInflaterService).JavaCast<LayoutInflater>();
                //replace with your item and your holder items
                //comment back in
               view = inflater.Inflate(Resource.Layout.layout_CustomSuprised, parent, false);
                //holder.Title = view.FindViewById<TextView>(Resource.Id.text);
                view.Tag = holder;
            }
            holder.CustomSuprisedtxtViewcaption = view.FindViewById<TextView>(Resource.Id.CustomSuprisedtxtViewcaption);
            holder.CustomSuprisedtxtViewcaption.Typeface = font;
            holder.CustomSuprisedtxtviewcaptiongrouping = view.FindViewById<TextView>(Resource.Id.CustomSuprisedtxtviewcaptiongrouping);
            holder.CustomSuprisedtxtviewcaptiongrouping.Typeface = font;
            holder.CustomSuprisedTextextViewTime = view.FindViewById<TextView>(Resource.Id.CustomSuprisedTextextViewTime);
            holder.CustomSuprisedTextextViewTime.Typeface = font;
            holder.CustomSuprisedTextextViewCost = view.FindViewById<TextView>(Resource.Id.CustomSuprisedTextextViewCost);
            holder.CustomSuprisedTextextViewCost.Typeface = font;
            string eventcaption = even[position].caption;
            
            string numberdigit = eventcaption.Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩");
            holder.CustomSuprisedtxtViewcaption.Text = eventcaption;

            holder.CustomSuprisedtxtviewcaptiongrouping.Text = even[position].category;
            string time = even[position].Timeevent;
            string digitfarsi = time.Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩");
            holder.CustomSuprisedTextextViewTime.Text = digitfarsi;
            string cost = even[position].Cost;
            string costconvert = cost.Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩");
            holder.CustomSuprisedTextextViewCost.Text = costconvert + "تومان";

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

    class ClustomSuprised_AdapterViewHolder : Java.Lang.Object
    {
        //Your adapter views to re-use
       public ImageView CustomSuprisedImage { get; set; }
        public TextView CustomSuprisedtxtViewcaption { get; set; }
        public TextView CustomSuprisedtxtviewcaptiongrouping { get; set; }
        public TextView CustomSuprisedTextextViewTime { get; set; }
        public TextView CustomSuprisedTextextViewCost { get; set; }
    }
}