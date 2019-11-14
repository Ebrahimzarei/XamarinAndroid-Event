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
using Evento.Controller.activity.CustomActivity;

namespace Evento.Controller.activity
{
    [Activity(Label = "Food_Activity")]
    public class Food_Activity : Activity
    {
        Button foodsbtnenterevent;
        TextView foodstxtviewcaption;
        ImageButton foodsimgbtnlogo;

        Button foodsbtnContact;
        Button foodsbtngift;
        Button foodsbtnEventDay;
        Button foodsbtngroupingGrouping;

        Button foodsbtnexhibition;
        Button foodsbtncoffeshop;
        Button foodsbtnresturant;
        Button foodsbtnfastfoods;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.layout_Foods);
            var font = Typeface.CreateFromAsset(Assets, "Estedad.ttf");
            foodsbtnenterevent = FindViewById<Button>(Resource.Id.Foodbtnenterevent);
            foodsbtnenterevent.Typeface = font;
            foodsbtnenterevent.Click += delegate { StartActivity(typeof(EnterEvent)); };
            foodstxtviewcaption = FindViewById<TextView>(Resource.Id.Foodtxtviewgroup);
            foodstxtviewcaption.Text = "اغذیه فروشی";
            foodstxtviewcaption.Typeface = font;
            foodsimgbtnlogo = FindViewById<ImageButton>(Resource.Id.Foodimgbtnlogo);
            foodsimgbtnlogo.Click += delegate { StartActivity(typeof(MainActivity)); };

            foodsbtnContact = FindViewById<Button>(Resource.Id.FoodbtnContact);
            foodsbtnContact.Click += delegate { StartActivity(typeof(Account)); };
            foodsbtnContact.Typeface = font;
            foodsbtngift = FindViewById<Button>(Resource.Id.Foodbtngift);
            foodsbtngift.Click += delegate { StartActivity(typeof(Suprised_Activity)); };
            foodsbtngift.Typeface = font;
            foodsbtnEventDay = FindViewById<Button>(Resource.Id.FoodbtnEventDay);
            foodsbtnEventDay.Click += delegate { StartActivity(typeof(EventDay_Activity)); };
            foodsbtnEventDay.Typeface = font;
            foodsbtngroupingGrouping = FindViewById<Button>(Resource.Id.FoodbtngroupingGrouping);
            foodsbtngroupingGrouping.Typeface = font;
            foodsbtngroupingGrouping.Click += delegate { StartActivity(typeof(Grouping)); };


            foodsbtnexhibition = FindViewById<Button>(Resource.Id.foodsbtnexhibition);
            foodsbtnexhibition.Typeface = font;
            foodsbtnexhibition.Click += delegate {
                Intent oi = new Intent(this, typeof(CategoryEvent));
                oi.PutExtra("Key", "اغذیه فروشی-نمایشگاه");
                StartActivity(oi);
            };
      
            foodsbtncoffeshop = FindViewById<Button>(Resource.Id.foodsbtncoffeshop);
            foodsbtncoffeshop.Typeface = font;
            foodsbtncoffeshop.Click += delegate {
                 Intent oi = new Intent(this, typeof(CategoryEvent));
                 oi.PutExtra("Key", "اغذیه فروشی-کافی شاپ");
                 StartActivity(oi);
             };
            foodsbtnresturant = FindViewById<Button>(Resource.Id.foodsbtnresturant);
            foodsbtnresturant.Typeface = font;
            foodsbtnresturant.Click += delegate {
                 Intent oi = new Intent(this, typeof(CategoryEvent));
                 oi.PutExtra("Key", "اغذیه فروشی-رستوران");
                 StartActivity(oi);
             };
            foodsbtnfastfoods = FindViewById<Button>(Resource.Id.foodsbtnfastfoods);
            foodsbtnfastfoods.Typeface = font;
            foodsbtnfastfoods.Click += delegate {
                 Intent oi = new Intent(this, typeof(CategoryEvent));
                 oi.PutExtra("Key", "اغذبه فروشی-فست فود");
                 StartActivity(oi);
             };

            // Create your application here
        }
    }
}