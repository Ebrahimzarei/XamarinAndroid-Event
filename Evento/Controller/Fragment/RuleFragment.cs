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
using Newtonsoft.Json;

namespace Evento.Controller.Fragment
{
    public class RuleFragment : DialogFragment
    {
        TextView ruletxtviewcaption;
        TextView ruletxtviewone;
        TextView ruletxtviewtwo;
        TextView ruletxtviewthree;
        TextView ruletxtviewfor;
        TextView ruletxtviewfive;
        TextView ruletxtviewsix;
        TextView ruletxtviewseven;
        Button rulebtnenter;
        Context ctx;
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }
        public RuleFragment(Context _ctx)
        {
            ctx = _ctx;
        }
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

        public   override  View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var dlg = inflater.Inflate(Resource.Layout.layoutRule, container, false);
            var font = Typeface.CreateFromAsset(ctx.Assets, "Estedad.ttf");
            LinearLayout lnaboutus = dlg.FindViewById<LinearLayout>(Resource.Id.rulelinearlayout);
            lnaboutus.SetBackgroundResource(Resource.Drawable.dialog_fragment_round);
            TextView ruletxtviewcaption = dlg.FindViewById<TextView>(Resource.Id.ruletxtviewcaption);
            ruletxtviewcaption.Typeface = font;
            TextView ruletxtviewone = dlg.FindViewById<TextView>(Resource.Id.ruletxtviewone);
            ruletxtviewone.Typeface = font;
            TextView ruletxtviewtwo = dlg.FindViewById<TextView>(Resource.Id.ruletxtviewtwo);
            ruletxtviewtwo.Typeface = font;
            ruletxtviewtwo.Visibility = ViewStates.Gone;
            TextView ruletxtviewthree = dlg.FindViewById<TextView>(Resource.Id.ruletxtviewthree);
            ruletxtviewthree.Typeface = font;
            ruletxtviewthree.Visibility = ViewStates.Gone;
            TextView ruletxtviewfor = dlg.FindViewById<TextView>(Resource.Id.ruletxtviewfor);
            ruletxtviewfor.Typeface = font;
            ruletxtviewfor.Visibility = ViewStates.Gone;
            TextView ruletxtviewfive = dlg.FindViewById<TextView>(Resource.Id.ruletxtviewfive);
            ruletxtviewfive.Typeface = font;
            ruletxtviewfive.Visibility = ViewStates.Gone;
            TextView ruletxtviewsix = dlg.FindViewById<TextView>(Resource.Id.ruletxtviewsix);
            ruletxtviewsix.Typeface = font;
            ruletxtviewsix.Visibility = ViewStates.Gone;
            TextView ruletxtviewseven = dlg.FindViewById<TextView>(Resource.Id.ruletxtviewseven);
            ruletxtviewseven.Typeface = font;
            ruletxtviewseven.Visibility = ViewStates.Gone;
            Button rulebtnenter = dlg.FindViewById<Button>(Resource.Id.rulebtnenter);
            rulebtnenter.Typeface = font;
            //فراخوانی webapiو پر کردن لیست ها
            using (HttpClient client = new HttpClient())
            {

                client.BaseAddress = new Uri(WebAddress.MyAddress);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                string json = JsonConvert.SerializeObject("", Formatting.Indented);
                var httpContent = new StringContent(json);
                HttpResponseMessage response =   client.PostAsync("api/GetInformationItems", httpContent).Result;
                if (response.IsSuccessStatusCode)
                {
                    response.EnsureSuccessStatusCode();
                    var responseJsonString =  response.Content.ReadAsStringAsync().Result;
                    var result = JsonConvert.DeserializeObject(responseJsonString).ToString();
                    List<WebEventoo_DomainClasses.Model.Information> objr = JsonConvert.DeserializeObject<List<WebEventoo_DomainClasses.Model.Information>>(result);
                    var SelectItem = objr.Where(u => u.Type ==WebEventoo_DomainClasses.Model.Information.TypeInformation.Rule).ToList();

                    if (SelectItem != null)
                    {
                        foreach (var item in SelectItem)
                        {
                            var itemone = item.Caption;
                            ruletxtviewone.Text = itemone.ToString();
                        }
                    }
                    else {
                        Toast.MakeText(this.Context, "انشالله بزودی", ToastLength.Long).Show();

                    }




                }
            }


          
            rulebtnenter.Click += delegate { Dismiss(); };


            return dlg;
        }
    }
}