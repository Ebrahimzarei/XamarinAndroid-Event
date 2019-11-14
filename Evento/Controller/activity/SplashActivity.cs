
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Support.V7.App;
using Android.Widget;


namespace Evento.Controller.activity
{
    [Activity(Label = "Eventoo", Theme = "@style/Theme.AppCompat.Light.NoActionBar", MainLauncher = true)]
    public class SplashActivity : AppCompatActivity
    //*Android.Support.V7.App.AppCompatActivity*/
    {
        TextView TxtViewcaption;
        Typeface font;
        protected async override void OnCreate(Bundle savedInstanceState)
        {



                base.OnCreate(savedInstanceState);

                SetContentView(Resource.Layout.layoutSplash);

            TxtViewcaption = FindViewById<TextView>(Resource.Id.splashtxtcaption);
                 font = Typeface.CreateFromAsset(Assets, "Estedad.ttf");
            TxtViewcaption.Typeface = font;





            await Task.Run(async () =>
             {
                 await Task.Delay(400);

                 RunOnUiThread(() =>
                 {



                     var intent = new Intent(this, typeof(MainActivity));
                     StartActivity(intent);
                     this.Finish();

                 });
             });
      

        }
    }
}