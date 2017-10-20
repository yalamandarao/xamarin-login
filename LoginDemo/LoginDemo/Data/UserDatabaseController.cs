using System;
using Xamarin.Forms;
using SQLite;
using LoginDemo.Models;
using System.Text;
using System.Linq;
using System.Collections.Generic;


namespace LoginDemo.Data
{
    public class UserDatabaseController
    {
        static object locker = new object();
        SQLiteConnection database;
        public UserDatabaseController()
        {
            database = DependencyService.Get<ISQLite>().GetConnection();
            database.CreateTable<User>();
        }

        public User GetUser()
        {
            lock (locker)
            {

                if(database.Table<User>().Count() == 0)
                {
                    return null;
                }
                else
                {
                    return database.Table<User>().First();
                }
            }
        }

        public int SaveUser(User user)
        {
            lock (locker)
            {
                if(user.id != 0)
                {
                    database.Update(user);
                    return user.id;
                }
                else
                {
                    return database.Insert(user);
                }
            }
        }

        public int DeleteUser(int id)
        {
            lock (locker)
            {
                return database.Delete<User>(id);
            }
        }

    }
}
