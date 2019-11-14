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
    class CustomComment_Adapter : BaseAdapter
    {

        Context context;

        private List<Model.Test> even;

        public CustomComment_Adapter(Context context, List<Model.Test> _even)
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
            CustomComment_AdapterViewHolder holder = null;
            var font = Typeface.CreateFromAsset(context.Assets, "Estedad.ttf");
            if (view != null)
                holder = view.Tag as CustomComment_AdapterViewHolder;
            // CustomComment_EditText_EnterComment
            if (holder == null)
            {
                holder = new CustomComment_AdapterViewHolder();
                var inflater = context.GetSystemService(Context.LayoutInflaterService).JavaCast<LayoutInflater>();
                //replace with your item and your holder items
                //comment back in
                view = inflater.Inflate(Resource.Layout.layoutCustomComment, parent, false);
                //holder.Title = view.FindViewById<TextView>(Resource.Id.text);
                view.Tag = holder;
            }
            holder.CustomComment_TextView_ResName = view.FindViewById<TextView>(Resource.Id.CustomComment_TextView_ResName);

            holder.CustomComment_TextView_ResName.Typeface = font;
           
            holder.CustomComment_TextView_Name = view.FindViewById<TextView>(Resource.Id.CustomComment_TextView_Name);
            holder.CustomComment_TextView_Name.Typeface = font;
            holder.CustomComment_TextView_Comment = view.FindViewById<TextView>(Resource.Id.CustomComment_TextView_Comment);
            holder.CustomComment_TextView_Comment.Typeface = font;
            holder.CustomComment_TextView_ResCommnet = view.FindViewById<TextView>(Resource.Id.CustomComment_TextView_Comment);
            holder.CustomComment_TextView_ResCommnet.Typeface = font;
            holder.CustomComment_Button_EnterComment = view.FindViewById<Button>(Resource.Id.CustomComment_Button_EnterComment);
            holder.CustomComment_Button_EnterComment.Typeface = font;
            holder.CustomComment_EditText_EnterComment = view.FindViewById<EditText>(Resource.Id.CustomComment_EditText_EnterComment);
            holder.CustomComment_EditText_EnterComment.Typeface = font;
            
            holder.CustomComment_TextView_ResName.Text = even[position].Test1;
            holder.CustomComment_TextView_ResCommnet.Text = even[position].Test2;
             



            //  CustomComment_EditText_EnterComment { get; set; }

            //fill in your items
            //holder.Title.Text = "new text here";

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

    class CustomComment_AdapterViewHolder : Java.Lang.Object
    {
        public TextView CustomComment_TextView_ResName { get; set; }
        public TextView CustomComment_TextView_Name { get; set; }

        public TextView CustomComment_TextView_Comment { get; set; }
        public TextView CustomComment_TextView_ResCommnet { get; set; }

        public Button CustomComment_Button_EnterComment { get; set; }
        public EditText CustomComment_EditText_EnterComment { get; set; }

    }
}