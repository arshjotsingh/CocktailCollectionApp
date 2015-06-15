/* Arshjot Singh Date- 02.06.2015
 * Version 1.0
 * Description - Database model
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using System.IO;

namespace CocktailCollectionApp.Model
{
    class DB : SQLiteAsyncConnection
    {
        static public string GetPath()
        {
            return Path.Combine(Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData), "DrinksCollection.db");
        }

        public DB(string databasePath)
            : base(databasePath, true)
        { }
        public async Task Init()
        {
            await CreateTableAsync<User>();
            await CreateTableAsync<Cocktail>();
        }
    }
}
