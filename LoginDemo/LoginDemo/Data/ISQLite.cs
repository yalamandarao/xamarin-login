using System;
using SQLite;
namespace LoginDemo.Data
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
