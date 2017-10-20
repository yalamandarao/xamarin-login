using System;
using System.IO;
using Xamarin.Forms;
using LoginDemo.Droid.Data;
using LoginDemo.Data;

[assembly: Dependency(typeof(SQLite_Andriod))]

namespace LoginDemo.Droid.Data
{
    public class SQLite_Andriod: ISQLite
    {
        public SQLite_Andriod()
        {
        }
		public SQLite.SQLiteConnection GetConnection()
		{
			var sqliteFileName = "TestDB.db3";
			string documentPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
			var path = Path.Combine(documentPath, sqliteFileName);
			var conn = new SQLite.SQLiteConnection(path);
			return conn;
		}
    }
}
