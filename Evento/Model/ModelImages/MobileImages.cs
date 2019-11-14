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
using SQLite;

namespace Evento.Model.ModelImages
{
    public class MobileImages
    {
        [AutoIncrement, PrimaryKey]
        public int Id { set; get; }
        public byte[] ImageData { set; get; }

        public string NameImage { set; get; }

    }
    //جنبه رویداد
    public class Longing
    {
        [AutoIncrement, PrimaryKey]
        public int Id { set; get; }
        //نوع جنبه رویداد
        public string GetLonging { set; get; }
        //شرح جنبه رویداد
        public string DescriptionLonging { set; get; }

    }
    public class NumberTelephone
    {
        [AutoIncrement, PrimaryKey]
        public int Id { set; get; }
        //شماره تلفن
        public string GetTelephone { set; get; }
       

    }
    public class JanbeEvent
    {
        [AutoIncrement, PrimaryKey]
        public int Id { set; get; }
        //جنبه رویداد
        public string GetCaptinEvent { set; get; }
    }
    public class RabdomMessageSms
    {
        [AutoIncrement, PrimaryKey]
        public int Id { set; get; }
        //پیام رندوم
        public string GetMessage { set; get; }
    }
    public class ConfirmTell
    {
        [AutoIncrement, PrimaryKey]
        public int Id { set; get; }
        
        public int NumberTell { set; get; }
        public int CinfitmMessage { get; set; }
    }
    public class DbEventoo
    {
        readonly string dbConnectionStr =
            System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + "/DBEventoo.db3";
        SQLiteConnection db;
        public DbEventoo()
        {
            db = new SQLiteConnection(dbConnectionStr);
            db.CreateTable<MobileImages>();
            db.CreateTable<Longing>();
            db.CreateTable<JanbeEvent>();
            db.CreateTable<RabdomMessageSms>();
            db.CreateTable<NumberTelephone>();
            db.CreateTable<ConfirmTell>();

        }
        public List<ConfirmTell> ConfirmTellGetAll(string sortField = "Id")
        {
            return db.Query<ConfirmTell>("SELECT * FROM ConfirmTell ORDER BY " + sortField);
        }
        public int ConfirmTellInsert(ConfirmTell models)
        {
            db.Insert(models);
            return models.Id;
        }

        public List<NumberTelephone> NumberTelephonesGetAll(string sortField = "Id")
        {
            return db.Query<NumberTelephone>("SELECT * FROM NumberTelephone ORDER BY " + sortField);
        }
        public int NumberTelephoneInsert(NumberTelephone models)
        {
            db.Insert(models);
            return models.Id;
        }

        public List<RabdomMessageSms> RabdomMessageSmsGetAll(string sortField = "Id")
        {
            return db.Query<RabdomMessageSms>("SELECT * FROM RabdomMessageSms ORDER BY " + sortField);
        }
        public int RabdomMessageSmsInsert(RabdomMessageSms models)
        {
            db.Insert(models);
            return models.Id;
        }
        public List<JanbeEvent> JanbeEventLongingGetAll(string sortField = "Id")
        {
            return db.Query<JanbeEvent>("SELECT * FROM JanbeEvent ORDER BY " + sortField);
        }
        public int JanbeEventInsert(JanbeEvent models)
        {
            db.Insert(models);
            return models.Id;
        }
        public void RemoveAllJanbeEvent()
        {

          //  db.Query<JanbeEvent>("Drop Table JanbeEvent");//
        }


        public List<Longing> LongingGetAll(string sortField = "Id")
        {
            return db.Query<Longing>("SELECT * FROM Longing ORDER BY " + sortField);
        }

        public int LongingInsert(Longing models)
        {
           
            db.Insert(models);
            return models.Id;
        }


        public void RemoveAllLonging()
        {

         //   db.Execute("DELETE FROM Longing");
          //  db.Query<Longing>("Drop Table Longing ");
            //Drop Table MobileImages
        }

        public void RemoveAllImages()
        {

            //  db.Execute("DELETE FROM MobileImages");
         //   db.execSQL("DROP TABLE " + MobileImages);
           // db.ExecuteScalar<MobileImages>("Drop Table MobileImages");
        //    db.Query<MobileImages>("Drop Table MobileImages");
        }

        public List<MobileImages> ImagesGetAll(string sortField = "Id")
        {
            return db.Query<MobileImages>("SELECT * FROM MobileImages ORDER BY " + sortField);
        }
        public int ImagesInsert(MobileImages models)
        {
            db.Insert(models);
            return models.Id;
        }
        public void DeleteItemImages(int Id)
        {
            db.Delete<MobileImages>(Id);
        }



    }
}