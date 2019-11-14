using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using Evento.Adapter;

namespace Evento.Controller.activity.CustomActivity
{
    [Activity(Label = "Comment_Activity", Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class Comment_Activity : AppCompatActivity
    {
        Button Commmentbtnenterevent;
        TextView Commenttxtviewcaption;
        ImageButton Commentimgbtnlogo;

        Button CommentbtnContact;
        Button Commentbtngift;
        Button CommentbtnEventDay;
        Button CommentbtngroupingGrouping;
        ListView CommentListView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.layout_Comment);
            var font = Typeface.CreateFromAsset(Assets, "Estedad.ttf");

            Commmentbtnenterevent =FindViewById<Button>(Resource.Id.Commmentbtnenterevent);
            Commmentbtnenterevent.Click += delegate { StartActivity(typeof(EnterEvent)); };
            Commmentbtnenterevent.Typeface = font;
             Commenttxtviewcaption = FindViewById<TextView>(Resource.Id.Commenttxtviewcaption);
            Commenttxtviewcaption.Typeface = font;
             Commentimgbtnlogo = FindViewById<ImageButton>(Resource.Id.Commentimgbtnlogo);
            Commentimgbtnlogo.Click += delegate { StartActivity(typeof(MainActivity)); };

            CommentbtnContact = FindViewById<Button>(Resource.Id.CommentbtnContact);
            CommentbtnContact.Typeface = font;
            CommentbtnContact.Click += delegate {
                Intent oi = new Intent(this, typeof(Account));
                StartActivity(oi);
            };
            Commentbtngift = FindViewById<Button>(Resource.Id.Commentbtngift);
           
            Commentbtngift.Click += delegate { StartActivity(typeof(CustomActivity.Suprised_Activity)); };
            Commentbtngift.Typeface = font;
             CommentbtnEventDay = FindViewById<Button>(Resource.Id.CommentbtnEventDay);
            Commentbtngift.Click += delegate { StartActivity(typeof(CustomActivity.EventDay_Activity)); };
            CommentbtnEventDay.Typeface = font;
             CommentbtngroupingGrouping = FindViewById<Button>(Resource.Id.CommentbtngroupingGrouping);
            CommentbtngroupingGrouping.Click += delegate { };
            CommentbtngroupingGrouping.Typeface = font;
             CommentListView =FindViewById<ListView>(Resource.Id.CommentListView);
            List<Model.Test> eventlist = new List<Model.Test>() {
                new Model.Test{id=1,Test1="علی بردبار",Test2="نطری ندارم"},
                 new Model.Test{id=1,Test1=" ناصر رسنگار",Test2="نطری ندارم"},

            };
            CustomComment_Adapter t = new CustomComment_Adapter(this, eventlist);
            CommentListView.Adapter = t;
            // Create your application here
        }
    }
}