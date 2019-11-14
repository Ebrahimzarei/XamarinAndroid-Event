using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Evento.Controller.Fragment
{
    public class GetCaptionRule : EventArgs
    {

        public GetCaptionRule(bool _getcaptionrule) : base()
        {
            GetCaption = _getcaptionrule;
        }
        public bool GetCaption { get; set; }


    }
    //پذیرش قوانین
    public class ContinuRuleFragment : DialogFragment
    {
        TextView fragmentcontinuruletxtviewheader;
        TextView fracontinurulechkrule;
   
        Button fracontinurulbuttonok;
        Button fracontinurulbuttoncancell;
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
        public ContinuRuleFragment(Context _ctx)
        {
            ctx = _ctx;
        }

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }
        public event EventHandler<GetCaptionRule> OnGetCaptionRule;
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var dlg = inflater.Inflate(Resource.Layout.layoutContinueRule, container, false);
            var font = Typeface.CreateFromAsset(ctx.Assets, "Estedad.ttf");
              

        LinearLayout lnaboutus = dlg.FindViewById<LinearLayout>(Resource.Id.fragmentcontinurulelinearlayout);
            lnaboutus.SetBackgroundResource(Resource.Drawable.dialog_fragment_round);

            TextView fragmentcontinuruletxtviewheader;
            TextView fracontinurulechkrule;

            Button fracontinurulbuttonok;
           

            fragmentcontinuruletxtviewheader = dlg.FindViewById<TextView>(Resource.Id.fragmentcontinuruletxtviewheader);
            fragmentcontinuruletxtviewheader.Typeface = font;

            fracontinurulechkrule = dlg.FindViewById<TextView>(Resource.Id.fracontinurulechkrule);
            fracontinurulechkrule.Typeface = font;

        

        


            //فراخوانی webapiو پر کردن لیست ها
            //using (HttpClient client = new HttpClient())
            //{

            //    client.BaseAddress = new Uri(WebAddress.MyAddress);
            //    client.DefaultRequestHeaders.Accept.Clear();
            //    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //    string json = JsonConvert.SerializeObject("", Formatting.Indented);
            //    var httpContent = new StringContent(json);
            //    HttpResponseMessage response = client.PostAsync("api/GetEventsItems", httpContent).Result;
            //    if (response.IsSuccessStatusCode)
            //    {
            //        response.EnsureSuccessStatusCode();
            //        var responseJsonString = response.Content.ReadAsStringAsync().Result;
            //        var result = JsonConvert.DeserializeObject(responseJsonString).ToString();
            //        List<WebEventoo_DomainClasses.Model.Information> objr = JsonConvert.DeserializeObject<List<WebEventoo_DomainClasses.Model.Information>>(result);
            //        var SelectItem = objr.Where(u => u.Type == WebEventoo_DomainClasses.Model.Information.TypeInformation.AboutUs).ToList();

            //        if (SelectItem != null)
            //        {
            //            foreach (var item in SelectItem)
            //            {
            //                var itemone = item.Caption;
            //                AboutUsTextviewtwo.Text = itemone.ToString();
            //            }
            //        }
            //        else
            //        {
            //            Toast.MakeText(this.Context, "انشالله بزودی", ToastLength.Long).Show();

            //        }




            //    }
            //}

            fracontinurulbuttonok = dlg.FindViewById<Button>(Resource.Id.fracontinurulbuttonok);
            fracontinurulbuttonok.Typeface = font;
            fracontinurulbuttonok.Click += delegate { Dismiss(); };
            
            return dlg;

        }
    }
}