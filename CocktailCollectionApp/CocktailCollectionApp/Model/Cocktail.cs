/* Arshjot Singh Date- 02.06.2015
 * Version 1.0
 * Description - Cocktail model
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;


namespace CocktailCollectionApp.Model
{
    [Table("Cocktail")]
    class Cocktail
    {
        [AutoIncrement, PrimaryKey]
        public int drinkid { get; set; }
        public string name { get; set; }
        public string ingredients { get; set; }
        public string method { get; set; }
        public string alcoholcontent { get; set; }
       
        public string userid { get; set; }

    }
}
