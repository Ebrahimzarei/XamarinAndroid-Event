using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Evento.Model;
using Evento.Model.ModelImages;
using Newtonsoft.Json;

namespace Evento.Controller.Fragment
{
    public class ConfirmMessageFragment : DialogFragment
    {
        LinearLayout fragmentconfirmsmslinearlayoutmain;
        TextView fragmentconfirmsmstxtviewheader;
        TextView fragmentconfirmsmstxtviewtitle;
        EditText fragmentconfirmsmsedittextsms;
        //تایید
        Button fragmentconfirmsmsbuttonok;
        //ارسال مجدد
        Button fragmentconfirmsmsbuttonresendsms;
        Context ctx;
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
        public ConfirmMessageFragment(Context _ctx)
        {
            ctx = _ctx;
        }
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var dlg = inflater.Inflate(Resource.Layout.layoutconfirmmessage, container, false);
            var font = Typeface.CreateFromAsset(ctx.Assets, "Estedad.ttf");
            fragmentconfirmsmslinearlayoutmain = dlg.FindViewById<LinearLayout>(Resource.Id.fragmentconfirmsmslinearlayoutmain);
            fragmentconfirmsmslinearlayoutmain.SetBackgroundResource(Resource.Drawable.dialog_fragment_round);



            ////تایید
            //Button fragmentconfirmsmsbuttonok;
            ////ارسال مجدد
            //Button fragmentconfirmsmsbuttonresendsms;
            fragmentconfirmsmstxtviewheader = dlg.FindViewById<TextView>(Resource.Id.fragmentconfirmsmstxtviewheader);
            fragmentconfirmsmstxtviewheader.Typeface = font;
            fragmentconfirmsmstxtviewtitle = dlg.FindViewById<TextView>(Resource.Id.fragmentconfirmsmstxtviewtitle);
            fragmentconfirmsmstxtviewtitle.Typeface = font;

            fragmentconfirmsmsedittextsms = dlg.FindViewById<EditText>(Resource.Id.fragmentconfirmsmsedittextsms);
            fragmentconfirmsmsedittextsms.Typeface = font;

            fragmentconfirmsmsbuttonok = dlg.FindViewById<Button>(Resource.Id.fragmentconfirmsmsbuttonok);
            fragmentconfirmsmsbuttonok.Typeface = font;
            DbEventoo DbConnection;
            DbConnection = new DbEventoo();
            var code = new Random().Next(10000, 88888);

            RabdomMessageSms rndmessage = new RabdomMessageSms
            {
                GetMessage = code.ToString()
            };
            DbConnection.RabdomMessageSmsInsert(rndmessage);
            var lastsms = DbConnection.RabdomMessageSmsGetAll().LastOrDefault();
            var tell = DbConnection.NumberTelephonesGetAll().LastOrDefault();
            var getsms = DbConnection.RabdomMessageSmsGetAll().LastOrDefault();
            using (HttpClient client = new HttpClient())
            {

                //client.BaseAddress = new Uri(WebAddress.MessageAddress);
                //client.DefaultRequestHeaders.Accept.Clear();
                //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //string json = JsonConvert.SerializeObject("", Formatting.Indented);
                //var httpContent = new StringContent(json);

                //PanelSms psms = new PanelSms()
                //{
                //    username = "",
                //    password = "",
                //    from = "",
                //    to = tell.GetTelephone,
                //    text = getsms.GetMessage

                //};

              //  HttpResponseMessage response = client.PostAsync("api/SendSMS/SendSMS", httpContent).Result;
                //if (response.IsSuccessStatusCode)
                //{
                //    response.EnsureSuccessStatusCode();
                //    var responseJsonString = response.Content.ReadAsStringAsync().Result;
                //    var result = JsonConvert.DeserializeObject(responseJsonString).ToString();
                //    var panel = JsonConvert.DeserializeObject<RetPanelSms>(result.ToString());
                //    if (panel.RetStatus == 1)
                //    {
                //        var toast = Toast.MakeText(this.Context, "ارسال پیام با موفقیت انجام شد", duration: ToastLength.Long);
                //        toast.SetGravity(GravityFlags.Center, 0, 0);
                //        toast.Show();

                //    }






                //}
            }
            fragmentconfirmsmsbuttonok.Text = "تایید";
            fragmentconfirmsmsbuttonok.Click += delegate
            {
                if (fragmentconfirmsmsedittextsms.Text == getsms.GetMessage)
                {
                    var toast = Toast.MakeText(this.Context, "رویداد شما با موفقیت ثبت شدو در صف انتظار جهت تایید و انتشار قرار گرفت", duration: ToastLength.Long);
                    toast.SetGravity(GravityFlags.Center, 0, 0);
                    toast.Show();
                    DbConnection.ConfirmTellInsert(new ConfirmTell() { CinfitmMessage=1,NumberTell=Convert.ToInt32(tell.GetTelephone)});
                    Dismiss();
                }
                if (fragmentconfirmsmsedittextsms.Text != getsms.GetMessage)
                {
                    var toast = Toast.MakeText(this.Context, "کد وارد شده صحیح نمی باشد.کد صحیح را وارد نمایید", duration: ToastLength.Long);
                    toast.SetGravity(GravityFlags.Center, 0, 0);
                    toast.Show();
                    Dismiss();
                }
            };
            fragmentconfirmsmsbuttonresendsms = dlg.FindViewById<Button>(Resource.Id.fragmentconfirmsmsbuttonresendsms);
            fragmentconfirmsmsedittextsms.Typeface = font;
            fragmentconfirmsmsbuttonresendsms.Click += delegate
            {

                //ارسال مجدد sms
                var codes = new Random().Next(10000, 88888);

                //RabdomMessageSms retrndmessage = new RabdomMessageSms
                //{
                //    GetMessage = code.ToString()
                //};
                //DbConnection.RabdomMessageSmsInsert(retrndmessage);



                using (HttpClient client = new HttpClient())
                {

                    //client.BaseAddress = new Uri(WebAddress.MessageAddress);
                    //client.DefaultRequestHeaders.Accept.Clear();
                    //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    //string json = JsonConvert.SerializeObject("", Formatting.Indented);
                    //var httpContent = new StringContent(json);

                    //PanelSms psms = new PanelSms
                    //{
                    //    username = "",
                    //    password = "",
                    //    from = "",
                    //    to = tell.GetTelephone,
                    //    text = getsms.GetMessage

                    //};

                    //HttpResponseMessage response = client.PostAsync("api/SendSMS/SendSMS", httpContent).Result;
                    //if (response.IsSuccessStatusCode)
                    //{
                    //    response.EnsureSuccessStatusCode();
                    //    var responseJsonString = response.Content.ReadAsStringAsync().Result;
                    //    var result = JsonConvert.DeserializeObject(responseJsonString).ToString();
                    //    var panel = JsonConvert.DeserializeObject<RetPanelSms>(result.ToString());
                    //    if (panel.RetStatus == 1)
                    //    {
                    //        var toast = Toast.MakeText(this.Context, "ارسال پیام با موفقیت انجام شد", duration: ToastLength.Long);
                    //        toast.SetGravity(GravityFlags.Center, 0, 0);
                    //        toast.Show();

                    //    }






                    //}

                };



            };
            return dlg;
        }
    }
}