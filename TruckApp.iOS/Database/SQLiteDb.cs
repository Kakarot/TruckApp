using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using SQLite;
using System.IO;
using TruckApp.Database;
using TruckApp.iOS;

using Foundation;
using UIKit;
using TruckApp.iOS.Persistence;

[assembly: Dependency(typeof(SQLiteDb))]

namespace TruckApp.iOS.Persistence
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