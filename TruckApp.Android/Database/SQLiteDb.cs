using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using SQLite;
using System.IO;
using TruckApp.Android.Database;
using TruckApp.Database;



[assembly: Dependency(typeof(SQLiteDb))]

namespace TruckApp.Android.Database
{
    public class SQLiteDb : ISQLiteDb
    {
        public SQLiteAsyncConnection GetConnection()
        {
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var path = Path.Combine(documentsPath, "TruckOrderDb.db3");

            return new SQLiteAsyncConnection(path);
        }
    }
}