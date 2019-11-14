using System;

using System.Globalization;


using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.OS;

using Android.Views;
using Android.Widget;
using Com.Mohamadamin.Persianmaterialdatetimepicker.Date;
using Evento.Controller.activity;

namespace Evento.Controller.Fragment
{

    public class GetdateEvent : EventArgs
    {
        public GetdateEvent(string _getPlace) : base()
        {
            GetPlace = _getPlace;
        }
        public string GetPlace { get; set; }


    }


    public class FilterDate : DialogFragment, Com.Mohamadamin.Persianmaterialdatetimepicker.Date.DatePickerDialog.IOnDateSetListener

    {


        Context ctx;
        public event EventHandler<GetdateEvent> OnGetDateEvent;
        Button filterdatebtncalendar;
    

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
                dialog.Window.SetBackgroundDrawable(inset); dialog.Window.SetLayout(400, 500);
                dialog.Window.SetBackgroundDrawable(new ColorDrawable(Color.Transparent));
            }
        }
 
       

      
        public override Dialog OnCreateDialog(Bundle savedInstanceState)
        {
            Dialog NotTitle = base.OnCreateDialog(savedInstanceState);
            NotTitle.Window.RequestFeature(WindowFeatures.NoTitle);

            return NotTitle;
        }
        public FilterDate(Context _ctx)
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
            var dlg = inflater.Inflate(Resource.Layout.layoutfilterDate, container, false);
            LinearLayout lnaboutus = dlg.FindViewById<LinearLayout>(Resource.Id.filterdatelinearlayout);
            lnaboutus.SetBackgroundResource(Resource.Drawable.dialog_fragment_round);

            var font = Typeface.CreateFromAsset(ctx.Assets, "Estedad.ttf");
           
            TextView filterdatetxtviewcaption = dlg.FindViewById<TextView>(Resource.Id.filterdatetxtviewcaption);
            filterdatetxtviewcaption.Typeface = font;
            
            Button filterdatetxtnowday = dlg.FindViewById<Button>(Resource.Id.filterdatetxtnowday);
            filterdatetxtnowday.Typeface = font;
            filterdatetxtnowday.Click += delegate {  //امروز
                string now = PersianDate(DateTime.Now);


                OnGetDateEvent.Invoke(this, new GetdateEvent(now));
                Dismiss();
             
            };

           

            Button filterdatebtntommorow = dlg.FindViewById<Button>(Resource.Id.filterdatebtntommorow);
            filterdatebtntommorow.Typeface = font;
            filterdatebtntommorow.Click += delegate {

                //فردا
                var today = DateTime.Now;
                var tomorrow = today.AddDays(1);
                string tomm = PersianDate(tomorrow);

                
                OnGetDateEvent.Invoke(this, new GetdateEvent(tomm));
                Dismiss();

            };
        


             filterdatebtncalendar = dlg.FindViewById<Button>(Resource.Id.filterdatebtncalendar);
            filterdatebtncalendar.Typeface = font;
            filterdatebtncalendar.Click += delegate {

                Com.Mohamadamin.Persianmaterialdatetimepicker.Date.DatePickerDialog p = new Com.Mohamadamin.Persianmaterialdatetimepicker.Date.DatePickerDialog();
                Com.Mohamadamin.Persianmaterialdatetimepicker.Date.DatePickerDialog d = Com.Mohamadamin.Persianmaterialdatetimepicker.Date.DatePickerDialog.NewInstance(this, p.SelectedDay.Year, p.SelectedDay.Month, p.SelectedDay.Day);
                d.Show(FragmentManager, "ebrahimdatepicker");
            };

            return dlg;
        }
        string PersianDate(DateTime DateTime1)
        {
            PersianCalendar PersianCalendar1 = new PersianCalendar();
            string year = PersianCalendar1.GetYear(DateTime1).ToString();
            string RemoveOneYear = year.Remove(0, 2);
            int month = PersianCalendar1.GetMonth(DateTime1);
          
            string Month = string.Empty;
            if (month == 1)
            {
                Month = "فروردین";
            }
            if (month == 2)
            {
                Month = "اردیبهشت";
            }
            if (month == 3)
            {
                Month = "خرداد";
            }

            if (month == 4)
            {
                Month = "تیر";
            }
            if (month == 5)
            {
                Month = "مرداد";
            }
            if (month == 6)
            {
                Month = "شهریور";
            }

            if (month == 7)
            {
                Month = "مهر";
            }
            if (month == 8)
            {
                Month = "آبان";
            }
            if (month == 9)
            {
                Month = "آذر";
            }

            if (month == 10)
            {
                Month = "دی";
            }
            if (month == 11)
            {
                Month = "بهمن";
            }
            if (month == 12)
            {
                Month = "اسفند";
            }
            string YearOfMonth = PersianCalendar1.GetDayOfMonth(DateTime1).ToString();
            string ConvertFarsiDate = YearOfMonth.ToString()+ Month + RemoveOneYear;
            return ConvertFarsiDate;
            //return string.Format(@"{0}/{1}/{2}",
            //             PersianCalendar1.GetYear(DateTime1),
            //             PersianCalendar1.GetMonth(DateTime1),
            //             PersianCalendar1.GetDayOfMonth(DateTime1));

        }

        public void OnDateSet(Com.Mohamadamin.Persianmaterialdatetimepicker.Date.DatePickerDialog p0, int p1, int p2, int p3)
        {
            int month = p2 + 1;
            string Month = string.Empty;
            if (month==1)
            {
                Month = "فروردین";
            }
            if (month == 2)
            {
                Month = "اردیبهشت";
            }
            if (month == 3)
            {
                Month = "خرداد";
            }

            if (month == 4)
            {
                Month = "تیر";
            }
            if (month == 5)
            {
                Month = "مرداد";
            }
            if (month == 6)
            {
                Month = "شهریور";
            }

            if (month == 7)
            {
                Month = "مهر";
            }
            if (month == 8)
            {
                Month = "آبان";
            }
            if (month == 9)
            {
                Month = "آذر";
            }

            if (month == 10)
            {
                Month = "دی";
            }
            if (month == 11)
            {
                Month = "بهمن";
            }
            if (month == 12)
            {
                Month = "اسفند";
            }
          
            string year =p1.ToString();
            string removeonechar=year.Remove(0, 2);
            string persiandate = p3.ToString()+"" +Month+removeonechar;
            OnGetDateEvent.Invoke(this, new GetdateEvent(persiandate));
            Dismiss();
        }
    }
}