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
    class CustomPayed_Adapter : BaseAdapter
    {

        Context context;
        private List<Model.TestPayed> even;

        public CustomPayed_Adapter(Context context,List<Model.TestPayed>_event)
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
            CustomPayed_AdapterViewHolder holder = null;
            var font = Typeface.CreateFromAsset(context.Assets, "Estedad.ttf");
            if (view != null)
                holder = view.Tag as CustomPayed_AdapterViewHolder;

            if (holder == null)
            {
                holder = new CustomPayed_AdapterViewHolder();
                var inflater = context.GetSystemService(Context.LayoutInflaterService).JavaCast<LayoutInflater>();
                //replace with your item and your holder items
                //comment back in
                view = inflater.Inflate(Resource.Layout.layout_CustomPayed, parent, false);
                holder.CustomPayedtxtViewcaption = view.FindViewById<TextView>(Resource.Id.CustomPayedtxtViewcaption);
                holder.CustomPayedtxtViewcaption.Typeface = font;
                holder.CustomPayedtxtviewcaptiongrouping = view.FindViewById<TextView>(Resource.Id.CustomPayedtxtviewcaptiongrouping);
                holder.CustomPayedtxtviewcaptiongrouping.Typeface = font;
                holder.CustomPayedTextextViewTime = view.FindViewById<TextView>(Resource.Id.CustomPayedTextextViewTime);
                holder.CustomPayedTextextViewTime.Typeface = font;
                holder.CustomPayedTextextViewCost = view.FindViewById<TextView>(Resource.Id.CustomPayedTextextViewCost);
                holder.CustomPayedTextextViewCost.Typeface = font;
                view.Tag = holder;
            }


            string eventcaption = even[position].Number.ToString();
            string numberdigit = eventcaption.Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩");
            holder.CustomPayedtxtViewcaption.Text =  "شماره پرداخت"+" "+ numberdigit;

            holder.CustomPayedtxtviewcaptiongrouping.Text = even[position].Price.ToString();
            string time = even[position].Price.ToString();
            string digitfarsi = time.Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩");
            holder.CustomPayedtxtviewcaptiongrouping.Text = "مبلغ پرداخت"+" "+ digitfarsi+" "+"تومان";
            string cost = even[position].StatusePayed;
            string costconvert = cost.Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩");
            holder.CustomPayedTextextViewTime.Text =  "وضعیت پرداخت"+" "+ costconvert ;
            holder.CustomPayedTextextViewCost.Text = "";
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

    class CustomPayed_AdapterViewHolder : Java.Lang.Object
    {
        //Your adapter views to re-use
        public TextView CustomPayedtxtViewcaption { get; set; }
        public TextView CustomPayedtxtviewcaptiongrouping { get; set; }
        public TextView CustomPayedTextextViewTime { get; set; }
        public TextView CustomPayedTextextViewCost { get; set; }
    }
}