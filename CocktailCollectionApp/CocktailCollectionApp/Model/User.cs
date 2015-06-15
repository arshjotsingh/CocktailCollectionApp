/* Arshjot Singh Date- 02.06.2015
 * Version 1.0
 * Description - User model class
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace CocktailCollectionApp
{
    [Table("User")]
    class User
    {
        [PrimaryKey, AutoIncrement]
        public int userid { get; set; }
        public string name { get; set; }
        public string username { get; set; }

        public string password { get; set; }
        public string city { get; set; }
        public string province { get; set; }
        public string postalcode { get; set; }
       
              

    }
}
