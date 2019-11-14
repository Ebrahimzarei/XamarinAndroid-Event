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
using Osmdroid.TileProvider.TileSource;
using Osmdroid.Util;
using Osmdroid.Views;
using Osmdroid.Views.Overlay;

namespace Evento.Controller.activity
{
    [Activity(Label = "MapEnterEventActivity")]
    public class MapEnterEventActivity : AppCompatActivity
    {
        Button MapentereventButtonBack;
        ImageView Mapenterebentimgviewback;
        MapView entereventmapView;
        Typeface font;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.layoutMapEnterEvent);

            font = Typeface.CreateFromAsset(Assets, "Estedad.ttf");

            MapentereventButtonBack = FindViewById<Button>(Resource.Id.MapentereventButtonBack);
            MapentereventButtonBack.Typeface = font;
            MapentereventButtonBack.Click += delegate { Finish(); };

            Mapenterebentimgviewback = FindViewById<ImageView>(Resource.Id.Mapenterebentimgviewback);
            Mapenterebentimgviewback.Click += delegate { Finish(); };
            entereventmapView = FindViewById<MapView>(Resource.Id.entereventmapView);
            //     نمایش نقشه روی نقطه خاص
            entereventmapView.SetBuiltInZoomControls(true);
            entereventmapView.Controller.SetZoom(17);
            entereventmapView.SetTileSource(TileSourceFactory.Mapnik);
            entereventmapView.SetMultiTouchControls(true);
            var coordination = new GeoPoint(29.62422, 52.53170);
            entereventmapView.Controller.SetCenter(coordination);

            //اضافه کردن مارکر در نقظه ای خاص


            var myoverlayPoint = new OverlayItem("MyTitle", "MyText",
                new Osmdroid.Util.GeoPoint(29.62422, 52.53170));


            var myoverlays = new List<OverlayItem>();
            myoverlays.Add(myoverlayPoint);

            var myItemIconOverlays = new Osmdroid.Views.Overlay.
                ItemizedIconOverlay(this, myoverlays, null);

            entereventmapView.Overlays.Add(myItemIconOverlays);

        }
    }
}