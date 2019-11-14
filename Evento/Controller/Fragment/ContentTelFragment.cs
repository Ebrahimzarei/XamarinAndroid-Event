 
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Net;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Evento.Controller.activity;
using Evento.Model;
using Java.Net;
using Newtonsoft.Json;
using WebEventoo_DomainClasses.Model;

namespace Evento.Controller.Fragment
{
    public class ContentTelFragment : DialogFragment
    {
        public override void OnStart()
        {
            base.OnStart();
            Dialog dialog = Dialog;
            if (dialog != null)
            {
                dialog.Window.SetBackgroundDrawable(new ColorDrawable(Color.Transparent));
                int width = ViewGroup.LayoutParams.MatchParent;
                int height = ViewGroup.LayoutParams.WrapContent;
                dialog.Window.SetLayout(width, height);
                InsetDrawable inset = new InsetDrawable(new ColorDrawable(color: Color.Transparent), 20, 20, 20, 20);
                dialog.Window.SetBackgroundDrawable(inset);
            }
        }
        public override Dialog OnCreateDialog(Bundle savedInstanceState)
        {
            Dialog NotTitle = base.OnCreateDialog(savedInstanceState);
            NotTitle.Window.RequestFeature(WindowFeatures.NoTitle);

            return NotTitle;
        }
        Context ctx;
        Event objr;
        int Id;
        public ContentTelFragment(Context _ctx,int _Id)
        {
            ctx = _ctx;
            Id = _Id;
        }
       // FindEventsItem

        TextView contentteltextviewcaption;
        TextView contentteltextviewtel;
        TextView contentteltextviewcaptiontel;
        TextView contentteltextviewmessage;
        TextView contetntteltextviewCaptionMessage;

        TextView contentteltextviewmcontenttel;
        TextView url;
        



        Button contenttelbuttoncancell;
        //  @+id/contentteliimageviewmap

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var dlg = inflater.Inflate(Resource.Layout.layoutContentTel, container, false);
            var font = Typeface.CreateFromAsset(ctx.Assets, "Estedad.ttf");
            LinearLayout lnaboutus = dlg.FindViewById<LinearLayout>(Resource.Id.contenttellinearlayout);
            lnaboutus.SetBackgroundResource(Resource.Drawable.dialog_fragment_round);

            contentteltextviewmcontenttel = dlg.FindViewById<TextView>(Resource.Id.contentteltextviewmcontenttel);
            objr.Address.ToList().ForEach(x =>
            {
                contentteltextviewmcontenttel.Text = x.AddressTwo;
            });
            string contenttel = contentteltextviewmcontenttel.Text;
            string numberdigittel = contenttel.Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩");
            contentteltextviewmcontenttel.Text = numberdigittel;
            ImageView immap = dlg.FindViewById<ImageView>(Resource.Id.contentteliimageviewmap);
            immap.Click += delegate {
                Intent oi = new Intent(ctx, typeof(MapEnterEventActivity));

                StartActivity(oi);

            };

           url = dlg.FindViewById<TextView>(Resource.Id.contentteltextviewmcontenturl);
            using (HttpClient client = new HttpClient())
            {

                client.BaseAddress = new System.Uri(WebAddress.MyAddress);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                string json = JsonConvert.SerializeObject("", Formatting.Indented);
                var httpContent = new StringContent(json);
                HttpResponseMessage response = client.PostAsync($"api/FindEventsItem/{Id}", httpContent).Result;
                if (response.IsSuccessStatusCode)
                {
                    response.EnsureSuccessStatusCode();
                    var responseJsonString = response.Content.ReadAsStringAsync().Result;
                    var result = JsonConvert.DeserializeObject(responseJsonString).ToString();
                       objr = JsonConvert.DeserializeObject< Event >(result);
                }

            }
            url.Text = objr.AddressUrl;
            url.Click += delegate
            {

                //آدرس اینترنتی
             
               url.SetTextColor(Android.Graphics
               .Color.ParseColor("#311b92"));
                Intent intent = new Intent(Intent.ActionView, Uri.Parse("http://"+url.Text));
                StartActivity(intent);
            };
          

             TextView contetntteltextviewCaptioncontenttel;
            TextView  Captionurl;
           
                contetntteltextviewCaptioncontenttel = dlg.FindViewById<TextView>(Resource.Id.contetntteltextviewCaptioncontenttel);
            contetntteltextviewCaptioncontenttel.Text = objr.Tell;
            string contentcaptiontel = contetntteltextviewCaptioncontenttel.Text;
            string numberdigitcaptiontel = contentcaptiontel.Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩");
            contetntteltextviewCaptioncontenttel.Text = numberdigitcaptiontel;


            Captionurl = dlg.FindViewById<TextView>(Resource.Id.contetntteltextviewCaptionurl);
            string contentcaptionurl = Captionurl.Text;
            string numberdigitcaptionurl = contentcaptionurl.Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩");
             Captionurl.Text = numberdigitcaptionurl;

            Captionurl.Click += delegate {

                //آدرس اینترنتی
               url.SetTextColor(Android.Graphics
               .Color.ParseColor("#311b92"));
                Intent intent = new Intent(Intent.ActionView, Uri.Parse("http://" + url.Text));
                StartActivity(intent);


            };








            contentteltextviewcaption =dlg.FindViewById<TextView>(Resource.Id.contentteltextviewcaption);
            contentteltextviewcaption.Typeface = font;
            string textviewcaption = contentteltextviewcaption.Text;
            string numberdigitcaption = textviewcaption.Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩");
            contentteltextviewcaption.Text = numberdigitcaption;

             contentteltextviewtel = dlg.FindViewById<TextView>(Resource.Id.contentteltextviewtel);
            contentteltextviewtel.Typeface = font;
            string textviewtel = contentteltextviewtel.Text;
            string numberdigittviewtel = textviewtel.Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩");
            contentteltextviewtel.Text = numberdigittviewtel;
            contentteltextviewtel.Click += delegate {
                contentteltextviewtel.SetTextColor(Android.Graphics
                 .Color.ParseColor("#311b92"));


                string dial = "tel:" + contentteltextviewmessage.Text;
                Android.Net.Uri uri = Android.Net.Uri.Parse(dial);
                Intent intent = new Intent(Intent.ActionDial, uri);
                StartActivity(intent);


            };


             contentteltextviewcaptiontel = dlg.FindViewById<TextView>(Resource.Id.contentteltextviewcaptiontel);
            contentteltextviewcaptiontel.Typeface = font;
            string textviewcaptiontel = contentteltextviewcaptiontel.Text;
            string captiontel = textviewcaptiontel.Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩");
            contentteltextviewcaptiontel.Text = captiontel;
            contentteltextviewcaptiontel.Click += delegate {
                //تماس
                contentteltextviewtel.SetTextColor(Android.Graphics
                    .Color.ParseColor("#311b92"));
                string dial = "tel:" + contentteltextviewmessage.Text;
            Android.Net.Uri uri = Android.Net.Uri.Parse(dial);
                Intent intent = new Intent(Intent.ActionDial, uri);
                StartActivity(intent);


            };

             contentteltextviewmessage = dlg.FindViewById<TextView>(Resource.Id.contentteltextviewmessage);
            contentteltextviewmessage.Typeface = font;
            contentteltextviewmessage.Text = objr.Tell;
            string textviewmessage = contentteltextviewmessage.Text;
            string viewmessage = textviewmessage.Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩");
            contentteltextviewmessage.Text = viewmessage;
            contentteltextviewmessage.Click += delegate {
                //ارسال پیغام
                contentteltextviewmessage.SetTextColor(Android.Graphics
                   .Color.ParseColor("#311b92"));
                
                Intent intent = new Intent(Intent.ActionView, uri:Android.Net.Uri.Parse("sms:" + contentteltextviewmessage.Text));
                intent.PutExtra("sms_body", "");
                StartActivity(intent);
            };

             contetntteltextviewCaptionMessage = dlg.FindViewById<TextView>(Resource.Id.contetntteltextviewCaptionMessage);
            contetntteltextviewCaptionMessage.Typeface = font;

            string CaptionMessage = contetntteltextviewCaptionMessage.Text;
            string tionMessage = CaptionMessage.Replace("0", "٠").Replace("1", "١").Replace("2", "٢").Replace("3", "٣").Replace("4", "٤").Replace("5", "٥").Replace("6", "٦").Replace("7", "٧").Replace("8", "٨").Replace("9", "٩");
            contetntteltextviewCaptionMessage.Text = tionMessage;

            contetntteltextviewCaptionMessage.Click += delegate {
                contentteltextviewmessage.SetTextColor(Android.Graphics
                 .Color.ParseColor("#311b92"));
                //ارسال پیغام
                Intent intent = new Intent(Intent.ActionView, uri: Android.Net.Uri.Parse("sms:" + contentteltextviewmessage.Text));
                intent.PutExtra("sms_body", "");
                StartActivity(intent);
            };


             contenttelbuttoncancell = dlg.FindViewById<Button>(Resource.Id.contenttelbuttoncancell);
            contenttelbuttoncancell.Typeface = font;



            contenttelbuttoncancell.Click += delegate { Dismiss(); };
            return dlg;
        }
    }
}