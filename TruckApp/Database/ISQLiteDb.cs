using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace TruckApp.Database
{
    public interface ISQLiteDb
    {
        SQLiteAsyncConnection GetConnection();
    }
}
