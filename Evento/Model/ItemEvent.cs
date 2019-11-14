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
    public class ItemEvent
    {
        public int id { get; set; }
        public string caption { get; set; }
        public string category { get; set; }
        public string Placeevebt { get; set; }
        public string Timeevent { get; set; }
        public string image { get; set; }
        public string Cost { get; set; }
    }
    public class Test
    {
        public int id { get; set; }
        public string Test1 { get; set; }
        public string Test2 { get; set; }
        public string Test3 { get; set; }
        public string Test4 { get; set; }
        public string Test5 { get; set; }
        public string Test6 { get; set; }
    }
    public class TestPayed
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public int Number { get; set; }
        public string StatusePayed { get; set; }
    }
}