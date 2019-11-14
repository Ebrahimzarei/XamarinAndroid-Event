using System;
using System.Collections.Generic;


using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.OS;

using Android.Views;
using Android.Widget;

namespace Evento.Controller.Fragment
{
    
    public class GetPlaceEvent:EventArgs
    {
        public GetPlaceEvent(List<modelitem> _getPlace ):base()
        {
            GetPlace = _getPlace;
        
        }
        public List<modelitem> GetPlace { get; set; }
       


    }
   public class modelitem
    {
        public string itemplace { get; set; }
        public bool ischecked { get; set; }
    }

    public class EnterPlace : DialogFragment
    {
        TextView placetxtviewplacel;
        CheckBox placechk1;
        CheckBox placechk2;
        CheckBox placechk3;
        CheckBox placechk4;
        CheckBox placechk5;
        CheckBox placechk6;
        CheckBox placechk7;
        CheckBox placechk8;
        CheckBox placechk9;
        CheckBox placechk10;

        CheckBox placechk11;
        CheckBox placechk12;
        CheckBox placechk13;
        CheckBox placechk14;
        CheckBox placechk15;
        CheckBox placechk16;
        CheckBox placechk17;
        CheckBox placechk18;
        CheckBox placechk19;
        CheckBox placechk20;

        CheckBox placechk21;
        CheckBox placechk22;
        CheckBox placechk23;
        CheckBox placechk24;
        CheckBox placechk25;
        CheckBox placechk26;
        CheckBox placechk27;
        CheckBox placechk28;
        CheckBox placechk29;
        CheckBox placechk30;
        CheckBox placechk31;
        CheckBox placechk32;
        CheckBox placechk33;
        CheckBox placechk34;
        CheckBox placechk35;
        CheckBox placechk36;
        CheckBox placechk37;
        CheckBox placechk38;
        CheckBox placechk39;
        CheckBox placechk40;

        CheckBox placechk41;
        CheckBox placechk42;
        CheckBox placechk43;
        CheckBox placechk44;
        CheckBox placechk45;
        CheckBox placechk46;
        CheckBox placechk47;
        CheckBox placechk48;
        CheckBox placechk49;
        CheckBox placechk50;

        CheckBox placechk51;
        CheckBox placechk52;
        CheckBox placechk53;
        CheckBox placechk54;
        CheckBox placechk55;
        CheckBox placechk56;
        CheckBox placechk57;
        CheckBox placechk58;
        CheckBox placechk59;
        CheckBox placechk60;

        CheckBox placechk61;
        CheckBox placechk62;
        CheckBox placechk63;
        CheckBox placechk64;

        Button placebtnsave;
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
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
           
        }
        public EnterPlace(Context _ctx )
        {
            ctx = _ctx;
            
        }
        public override Dialog OnCreateDialog(Bundle savedInstanceState)
        {
            Dialog NotTitle = base.OnCreateDialog(savedInstanceState);
            NotTitle.Window.RequestFeature(WindowFeatures.NoTitle);

            return NotTitle;
        }
        public event EventHandler<GetPlaceEvent> OnGetPlaceEvent;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {

            var dlg = inflater.Inflate(Resource.Layout.layoutPlace, container, false);
            LinearLayout lnaboutus = dlg.FindViewById<LinearLayout>(Resource.Id.ll2);
            lnaboutus.SetBackgroundResource(Resource.Drawable.dialog_fragment_round);



            var font = Typeface.CreateFromAsset(ctx.Assets, "Estedad.ttf");

            placetxtviewplacel = dlg.FindViewById<TextView>(Resource.Id.placetxtviewplace);
            placetxtviewplacel.Typeface = font;
            placechk1 = dlg.FindViewById<CheckBox>(Resource.Id.placechk1); ;
            placechk1.Typeface = font;
           

            placechk2 = dlg.FindViewById<CheckBox>(Resource.Id.placechk2); ;
            placechk2.Typeface = font;
           ;

            placechk3 = dlg.FindViewById<CheckBox>(Resource.Id.placechk3); ;
            placechk3.Typeface = font;
           

            placechk4 = dlg.FindViewById<CheckBox>(Resource.Id.placechk4); ;
            placechk4.Typeface = font;
           

            placechk5 = dlg.FindViewById<CheckBox>(Resource.Id.placechk5); ;
            placechk5.Typeface = font;
          

            placechk6 = dlg.FindViewById<CheckBox>(Resource.Id.placechk6); ;
            placechk6.Typeface = font;
           
            placechk7 = dlg.FindViewById<CheckBox>(Resource.Id.placechk7); ;
            placechk7.Typeface = font;
           

            placechk8 = dlg.FindViewById<CheckBox>(Resource.Id.placechk8); ;
            placechk8.Typeface = font;
           

            placechk9 = dlg.FindViewById<CheckBox>(Resource.Id.placechk9); ;
            placechk9.Typeface = font;
           
            placechk10 = dlg.FindViewById<CheckBox>(Resource.Id.placechk10);
            placechk10.Typeface = font;
          
            placechk11 = dlg.FindViewById<CheckBox>(Resource.Id.placechk11);
            placechk11.Typeface = font;
          
            placechk12 = dlg.FindViewById<CheckBox>(Resource.Id.placechk12);
            placechk12.Typeface = font;
           


            placechk13 = dlg.FindViewById<CheckBox>(Resource.Id.placechk13);
            placechk13.Typeface = font;
           
            placechk14 = dlg.FindViewById<CheckBox>(Resource.Id.placechk14);
            placechk14.Typeface = font;
           
            placechk15 = dlg.FindViewById<CheckBox>(Resource.Id.placechk15);
            placechk15.Typeface = font;
          

            placechk16 = dlg.FindViewById<CheckBox>(Resource.Id.placechk16);
            placechk16.Typeface = font;
          
            placechk17 = dlg.FindViewById<CheckBox>(Resource.Id.placechk17);
            placechk17.Typeface = font;
          

            placechk18 = dlg.FindViewById<CheckBox>(Resource.Id.placechk18);
            placechk18.Typeface = font;
         

            placechk19 = dlg.FindViewById<CheckBox>(Resource.Id.placechk19);
            placechk19.Typeface = font;
           
            placechk20 = dlg.FindViewById<CheckBox>(Resource.Id.placechk20);
            placechk20.Typeface = font;
          

            placechk21 = dlg.FindViewById<CheckBox>(Resource.Id.placechk21); ;
            placechk21.Typeface = font;
           
            placechk22 = dlg.FindViewById<CheckBox>(Resource.Id.placechk22); ;
            placechk22.Typeface = font;
          
            placechk23 = dlg.FindViewById<CheckBox>(Resource.Id.placechk23); ;
            placechk23.Typeface = font;
           

            placechk24 = dlg.FindViewById<CheckBox>(Resource.Id.placechk24); ;
            placechk24.Typeface = font;
          

            placechk25 = dlg.FindViewById<CheckBox>(Resource.Id.placechk25); ;
            placechk25.Typeface = font;
            

            placechk26 = dlg.FindViewById<CheckBox>(Resource.Id.placechk26); ;
            placechk26.Typeface = font;
         

            placechk27 = dlg.FindViewById<CheckBox>(Resource.Id.placechk27); ;
            placechk27.Typeface = font;
           
            placechk28 = dlg.FindViewById<CheckBox>(Resource.Id.placechk28); ;
            placechk28.Typeface = font;
            

            placechk29 = dlg.FindViewById<CheckBox>(Resource.Id.placechk29); ;
            placechk29.Typeface = font;
          

            placechk30 = dlg.FindViewById<CheckBox>(Resource.Id.placechk30); ;
            placechk30.Typeface = font;
           

            placechk31 = dlg.FindViewById<CheckBox>(Resource.Id.placechk31); ;
            placechk31.Typeface = font;
           

            placechk32 = dlg.FindViewById<CheckBox>(Resource.Id.placechk32); ;
            placechk32.Typeface = font;
           

            placechk33 = dlg.FindViewById<CheckBox>(Resource.Id.placechk33); ;
            placechk33.Typeface = font;
          

            placechk34 = dlg.FindViewById<CheckBox>(Resource.Id.placechk34); ;
            placechk34.Typeface = font;
         
            placechk35 = dlg.FindViewById<CheckBox>(Resource.Id.placechk35); ;
            placechk35.Typeface = font;
           

            placechk36 = dlg.FindViewById<CheckBox>(Resource.Id.placechk36); ;
            placechk36.Typeface = font;
           
            placechk37 = dlg.FindViewById<CheckBox>(Resource.Id.placechk37); ;
            placechk37.Typeface = font;
           

            placechk38 = dlg.FindViewById<CheckBox>(Resource.Id.placechk38); ;
            placechk38.Typeface = font;
            

            placechk39 = dlg.FindViewById<CheckBox>(Resource.Id.placechk39); ;
            placechk39.Typeface = font;
           

            placechk40 = dlg.FindViewById<CheckBox>(Resource.Id.placechk40); ;
            placechk40.Typeface = font;
         

            placechk41 = dlg.FindViewById<CheckBox>(Resource.Id.placechk41); ; ;
            placechk41.Typeface = font;
         

            placechk42 = dlg.FindViewById<CheckBox>(Resource.Id.placechk42);
            placechk42.Typeface = font;
          


            placechk43 = dlg.FindViewById<CheckBox>(Resource.Id.placechk43); ;
            placechk43.Typeface = font;
         
            placechk44 = dlg.FindViewById<CheckBox>(Resource.Id.placechk44); ;
            placechk44.Typeface = font;
          

            placechk45 = dlg.FindViewById<CheckBox>(Resource.Id.placechk45); ;
            placechk45.Typeface = font;
          

            placechk46 = dlg.FindViewById<CheckBox>(Resource.Id.placechk46); ;
            placechk46.Typeface = font;
           

            placechk47 = dlg.FindViewById<CheckBox>(Resource.Id.placechk47); ;
            placechk47.Typeface = font;
          

            placechk48 = dlg.FindViewById<CheckBox>(Resource.Id.placechk48); ;
            placechk48.Typeface = font;
          

            placechk49 = dlg.FindViewById<CheckBox>(Resource.Id.placechk49); ;
            placechk49.Typeface = font;
          

            placechk50 = dlg.FindViewById<CheckBox>(Resource.Id.placechk50); ;
            placechk50.Typeface = font;
           

            placechk51 = dlg.FindViewById<CheckBox>(Resource.Id.placechk51); ;
            placechk51.Typeface = font;
           

            placechk52 = dlg.FindViewById<CheckBox>(Resource.Id.placechk52); ;
            placechk52.Typeface = font;
           

            placechk53 = dlg.FindViewById<CheckBox>(Resource.Id.placechk53); ;
            placechk53.Typeface = font;
          

            placechk54 = dlg.FindViewById<CheckBox>(Resource.Id.placechk54); ;
            placechk54.Typeface = font;
           

            placechk55 = dlg.FindViewById<CheckBox>(Resource.Id.placechk55); ;
            placechk55.Typeface = font;
           
            placechk56 = dlg.FindViewById<CheckBox>(Resource.Id.placechk56); ;
            placechk56.Typeface = font;
           

            placechk57 = dlg.FindViewById<CheckBox>(Resource.Id.placechk57); ;
            placechk57.Typeface = font;
           

            placechk58 = dlg.FindViewById<CheckBox>(Resource.Id.placechk58); ;
            placechk58.Typeface = font;
          

            placechk59 = dlg.FindViewById<CheckBox>(Resource.Id.placechk59); ;
            placechk59.Typeface = font;
          

            placechk60 = dlg.FindViewById<CheckBox>(Resource.Id.placechk60); ;
            placechk60.Typeface = font;
          

            placechk61 = dlg.FindViewById<CheckBox>(Resource.Id.placechk61); ;
            placechk61.Typeface = font;
           

            placechk62 = dlg.FindViewById<CheckBox>(Resource.Id.placechk62); ;
            placechk62.Typeface = font;
          

            placechk63 = dlg.FindViewById<CheckBox>(Resource.Id.placechk63); ;
            placechk63.Typeface = font;
           
            placechk64 = dlg.FindViewById<CheckBox>(Resource.Id.placechk64); ;
            placechk64.Typeface = font;
            placechk64.Click += delegate {
             
            };

            placebtnsave = dlg.FindViewById<Button>(Resource.Id.placebtnsave);
            placebtnsave.Typeface = font;
            List<modelitem> strchk=new List<modelitem>();
            

          
            placebtnsave.Click += delegate {
                //if (placechk1.Checked|| placechk2.Checked || placechk3.Checked|| placechk4.Checked || placechk5.Checked || placechk6.Checked || placechk7.Checked || placechk8.Checked || placechk9.Checked || placechk10.Checked || placechk11.Checked || placechk12.Checked || placechk13.Checked || placechk14.Checked || placechk15.Checked || placechk16.Checked || placechk17.Checked || placechk18.Checked || placechk19.Checked || placechk20.Checked)
                //{
                    if (placechk1.Checked)
                    {
                 
                    strchk.Add(new modelitem { itemplace = placechk1.Text });
                   
                    }
                    if (placechk2.Checked)
                    {
                  
                    strchk.Add(new modelitem { itemplace = placechk2.Text });
                }
                    if (placechk3.Checked)
                    {
                    strchk.Add(new modelitem { itemplace = placechk3.Text });
                }
                    if (placechk4.Checked)
                    {
                    strchk.Add(new modelitem { itemplace = placechk4.Text });
                }
                    if (placechk5.Checked)
                    {
                    strchk.Add(new modelitem { itemplace = placechk5.Text });
                }
                    if (placechk6.Checked)
                    {
                    strchk.Add(new modelitem { itemplace = placechk6.Text  });
                }
                    if (placechk7.Checked)
                    {
                    strchk.Add(new modelitem { itemplace = placechk7.Text });
                }
                    if (placechk8.Checked)
                    {
                    strchk.Add(new modelitem { itemplace = placechk8.Text });
                }
                    if (placechk9.Checked)
                    {
                    strchk.Add(new modelitem { itemplace = placechk9.Text });
                }
                    if (placechk10.Checked)
                    {
                    strchk.Add(new modelitem { itemplace = placechk10.Text });
                }
                    if (placechk11.Checked)
                    {
                    strchk.Add(new modelitem { itemplace = placechk11.Text });
                }
                    if (placechk12.Checked)
                    {
                    strchk.Add(new modelitem { itemplace = placechk12.Text });
                }
                    if (placechk13.Checked)
                    {
                    strchk.Add(new modelitem { itemplace = placechk13.Text });
                }
                    if (placechk14.Checked)
                    {
                    strchk.Add(new modelitem { itemplace = placechk14.Text });
                }
                    if (placechk15.Checked)
                    {
                    strchk.Add(new modelitem { itemplace = placechk15.Text });

                }
                    if (placechk16.Checked)
                    {
                    strchk.Add(new modelitem { itemplace = placechk16.Text });
                }
                    if (placechk17.Checked)
                    {
                    strchk.Add(new modelitem { itemplace = placechk17.Text });
                }
                    if (placechk18.Checked)
                    {
                    strchk.Add(new modelitem { itemplace = placechk18.Text });
                }
                    if (placechk19.Checked)
                    {
                    strchk.Add(new modelitem { itemplace = placechk19.Text });
                }
                    if (placechk20.Checked)
                    {
                    strchk.Add(new modelitem { itemplace = placechk20.Text });
                }

                //}
             
                //if (placechk21.Checked || placechk22.Checked || placechk23.Checked || placechk24.Checked || placechk25.Checked || placechk26.Checked || placechk27.Checked || placechk28.Checked || placechk29.Checked || placechk30.Checked || placechk31.Checked || placechk32.Checked || placechk33.Checked || placechk34.Checked || placechk35.Checked || placechk36.Checked || placechk37.Checked || placechk38.Checked || placechk39.Checked || placechk40.Checked)
                //{
                    if (placechk21.Checked)
                    {
                    strchk.Add(new modelitem { itemplace = placechk21.Text });
                }
                    if (placechk22.Checked)
                    {
                    strchk.Add(new modelitem { itemplace = placechk22.Text });
                }
                    if (placechk23.Checked)
                    {
                    strchk.Add(new modelitem { itemplace = placechk23.Text });
                }
                    if (placechk24.Checked)
                    {
                    strchk.Add(new modelitem { itemplace = placechk24.Text });
                }
                    if (placechk25.Checked)
                    {
                    strchk.Add(new modelitem { itemplace = placechk25.Text });
                }
                    if (placechk26.Checked)
                    {
                    strchk.Add(new modelitem { itemplace = placechk26.Text });
                }
                    if (placechk27.Checked)
                    {
                    strchk.Add(new modelitem { itemplace = placechk27.Text });
                }
                    if (placechk28.Checked)
                    {
                    strchk.Add(new modelitem { itemplace = placechk28.Text });
                }
                    if (placechk29.Checked)
                    {
                    strchk.Add(new modelitem { itemplace = placechk29.Text });
                }
                    if (placechk30.Checked)
                    {
                    strchk.Add(new modelitem { itemplace = placechk30.Text });
                }
                    if (placechk31.Checked)
                    {
                    strchk.Add(new modelitem { itemplace = placechk31.Text });
                }
                    if (placechk32.Checked)
                    {
                    strchk.Add(new modelitem { itemplace = placechk32.Text });
                }
                    if (placechk33.Checked)
                    {
                    strchk.Add(new modelitem { itemplace = placechk33.Text });
                }
                    if (placechk34.Checked)
                    {
                    strchk.Add(new modelitem { itemplace = placechk34.Text });
                }
                    if (placechk35.Checked)
                    {
                    strchk.Add(new modelitem { itemplace = placechk35.Text });

                }
                    if (placechk36.Checked)
                    {
                    strchk.Add(new modelitem { itemplace = placechk36.Text });
                }
                    if (placechk37.Checked)
                    {
                    strchk.Add(new modelitem { itemplace = placechk37.Text });
                }
                    if (placechk38.Checked)
                    {
                    strchk.Add(new modelitem { itemplace = placechk38.Text });
                }
                    if (placechk39.Checked)
                    {
                    strchk.Add(new modelitem { itemplace = placechk39.Text });
                }
                    if (placechk40.Checked)
                    {
                    strchk.Add(new modelitem { itemplace = placechk40.Text });
                }
                //}
                //if (placechk41.Checked || placechk42.Checked || placechk43.Checked || placechk44.Checked || placechk45.Checked || placechk46.Checked || placechk47.Checked || placechk48.Checked || placechk49.Checked || placechk50.Checked || placechk51.Checked || placechk52.Checked || placechk53.Checked || placechk54.Checked || placechk55.Checked || placechk56.Checked || placechk57.Checked || placechk58.Checked || placechk59.Checked || placechk60.Checked)
                //{
                    if (placechk41.Checked)
                    {
                    strchk.Add(new modelitem { itemplace = placechk41.Text });
                }
                    if (placechk42.Checked)
                    {
                    strchk.Add(new modelitem { itemplace = placechk42.Text });
                }
                    if (placechk43.Checked)
                    {
                    strchk.Add(new modelitem { itemplace = placechk43.Text });
                }
                    if (placechk44.Checked)
                    {
                    strchk.Add(new modelitem { itemplace = placechk44.Text });
                }
                    if (placechk45.Checked)
                    {
                    strchk.Add(new modelitem { itemplace = placechk45.Text });
                }
                    if (placechk46.Checked)
                    {
                    strchk.Add(new modelitem { itemplace = placechk46.Text });
                }
                    if (placechk47.Checked)
                    {
                    strchk.Add(new modelitem { itemplace = placechk47.Text });
                }
                    if (placechk48.Checked)
                    {
                    strchk.Add(new modelitem { itemplace = placechk48.Text });
                }
                    if (placechk49.Checked)
                    {
                    strchk.Add(new modelitem { itemplace = placechk49.Text });
                }
                    if (placechk50.Checked)
                    {
                    strchk.Add(new modelitem { itemplace = placechk50.Text });
                }
                    if (placechk51.Checked)
                    {
                    strchk.Add(new modelitem { itemplace = placechk51.Text });
                }
                    if (placechk52.Checked)
                    {
                    strchk.Add(new modelitem { itemplace = placechk2.Text });
                }
                    if (placechk53.Checked)
                    {
                    strchk.Add(new modelitem { itemplace = placechk53.Text });
                }
                    if (placechk54.Checked)
                    {
                    strchk.Add(new modelitem { itemplace = placechk54.Text });
                }
                    if (placechk55.Checked)
                    {
                    strchk.Add(new modelitem { itemplace = placechk55.Text });

                }
                    if (placechk56.Checked)
                    {
                    strchk.Add(new modelitem { itemplace = placechk56.Text });
                }
                    if (placechk57.Checked)
                    {
                    strchk.Add(new modelitem { itemplace = placechk2.Text });
                }
                    if (placechk58.Checked)
                    {
                    strchk.Add(new modelitem { itemplace = placechk58.Text });
                }
                    if (placechk59.Checked)
                    {
                    strchk.Add(new modelitem { itemplace = placechk59.Text });
                }
                    if (placechk60.Checked)
                    {
                    strchk.Add(new modelitem { itemplace = placechk60.Text });
                }
                //}
                //if (placechk61.Checked || placechk62.Checked || placechk63.Checked || placechk64.Checked )
                //{
                    if (placechk61.Checked)
                    {
                    strchk.Add(new modelitem { itemplace = placechk61.Text });
                }
                    if (placechk62.Checked)
                    {
                    strchk.Add(new modelitem { itemplace = placechk62.Text });
                }
                    if (placechk63.Checked)
                    {
                    strchk.Add(new modelitem { itemplace = placechk63.Text });
                }
                    if (placechk64.Checked)
                    {
                    strchk.Add(new modelitem { itemplace = placechk64.Text });
                }

            
              
                OnGetPlaceEvent.Invoke(this, new GetPlaceEvent(strchk));
                Dismiss();


            };

   
            return dlg;
        }
    }
}