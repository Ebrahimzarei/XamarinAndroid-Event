using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Evento.Model
{
  public static  class WebAddress
    {
        public static string MyAddress { get; set; } = "http://192.168.43.76:7474/";
        public static string MessageAddress { get; set; } = "https://rest.payamak-panel.com/";

    }
    public class PanelSms
    {
        //نام کاربری مربوط به حساب شما در سامانه
        public string username { get; set; } 
        //کلمه عبور مربوط به حساب شما در سامانه
        public string password { get; set; }   
       // شماره گیرنده،
        public string to { get; set; } 
       // شماره اختصاصی فرستنده
        public string from { get; set; }  
        public string text { get; set; }  
    }
    public class RetPanelSms
    {
        public string Value { get; set; }
        public int RetStatus { get; set; }
        public string StrRetStatus { get; set; }
       
    }
}