using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using Evento.Model.ModelImages;

namespace Evento.Adapter.Adapter_Images
{
    class BrowsImageEnterEvent_Adapter : RecyclerView.Adapter
    {
       // List<string> images;
       // List<byte[]> ByteImages;
        Context context;
        Button btndel;
        DbEventoo Db;
        List<MobileImages> images;
        public BrowsImageEnterEvent_Adapter(Context c, List<MobileImages> _Images)
        {
            context = c;
            //  ByteImages = bimages;
            images = _Images;
        }
        public override int ItemCount => images.Count();

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            RecyclerViewHolder viewHolder = holder as RecyclerViewHolder;
            viewHolder.btndel.Text = " حذف"+position+1;
            int num = position + 1;
           
            foreach (var item in images)
            {
               // img = item.ToArray();
               Paint paintText = new Paint();
                paintText.AntiAlias = true;
                //رنگ متن
                paintText.Color=(Color.Blue);
                //سایز متن
                paintText.TextSize=(50);
                //استایل متن
                paintText.SetStyle(Paint.Style.Fill);
                //ایجاد سایه بروی متن
                paintText.SetShadowLayer(10f, 10f, 10f, Color.Black);

                Rect rectText = new Rect();
                string captionString = "تصویر اصلی";
               
                viewHolder.Images.SetImageBitmap(BitmapFactory.DecodeByteArray(item.ImageData, 00, item.Id));

            }
            btndel = ((RecyclerViewHolder)holder).btndel;
            // viewHolder.Images.SetImageResource(img[position]);
            btndel.Tag = position + 1;
            btndel.Click -= Btndel_Click;
            btndel.Click += Btndel_Click; 
        }

        private void Btndel_Click(object sender, EventArgs e)
        {
            int x = int.Parse(btndel.Tag.ToString());
             Db = new DbEventoo();
            Db.DeleteItemImages(x);
          //  ByteImages.RemoveAt(x);
            NotifyDataSetChanged();
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            LayoutInflater layoutinflater = LayoutInflater.From(parent.Context);
            View view = layoutinflater.Inflate(Resource.Layout.layoutEnterEvent_Images, parent, false);
            return new RecyclerViewHolder(view);
        }
    }
    public class RecyclerViewHolder:RecyclerView.ViewHolder
    {
        public ImageView Images;
        public Button btndel;
        public RecyclerViewHolder(View itemView) : base(itemView)
        {
            Images = itemView.FindViewById<ImageView>(Resource.Id.EnterEvent_image_ImageViewPic);
       btndel = itemView.FindViewById<Button>(Resource.Id.EnterEvent_image_buttonDel);
        }


    }
}