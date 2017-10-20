using System;
using SQLite;
using System.IO;
using Xamarin.Forms;
using LoginDemo.Data;


[assembly: Dependency(typeof(SQLite_iOS))]

namespace LoginDemo.Data
{
    public class SQLite_iOS : ISQLite
    {
        public SQLite_iOS()
        {
        }

        public SQLite.SQLiteConnection GetConnection()
        {
            var fileName = "TestDB.db3";
            string documentPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var libraryPath = Path.Combine(documentPath, "..", "Library");
            var path = Path.Combine(libraryPath, fileName);
            var conn = new SQLite.SQLiteConnection(path);
            return conn;
        }
    }
}
