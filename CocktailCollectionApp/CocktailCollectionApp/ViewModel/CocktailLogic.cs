/* Arshjot Singh Date- 02.06.2015
 * Version 1.0
 * Description - Cocktail View MOdel
 * */
using CocktailCollectionApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailCollectionApp.ViewModel
{
    class CocktailLogic : INotifyPropertyChanged
    {
        DB db;
        User user = new User();
        Cocktail cocktail;
        public event PropertyChangedEventHandler PropertyChanged;
        public async Task Init()
        {
            db = new DB(DB.GetPath());
            await db.Init();
           
        }

       

        public async Task CreateUser(string _name, string _password, string _city, string _province, string _postalcode,string _username)
        {
            user = new User() { name = _name, city = _city, province = _province, postalcode = _postalcode, password = _password, username = _username };
            await db.InsertAsync(user);
        }

        public async Task CreateDrink(string _drinkname, string _ingredients, string _method, string _alcoholcontent, string _userid)
        {
            cocktail = new Cocktail() { name = _drinkname, ingredients = _ingredients, method = _method, alcoholcontent = _alcoholcontent , userid = user.userid.ToString()};
            await db.InsertAsync(cocktail);
        }

        public async Task LoginUser(string _username, string _password)
        {
            user = new User();
            var query = db.Table<User>().Where(v => v.username == _username && v.password == _password);
            int countquery = await query.CountAsync();
            Console.WriteLine(countquery);
            if(countquery>0)
            {
                await query.ToListAsync().ContinueWith(t =>
                {
                    foreach (var User in t.Result)
                    {
                        Console.WriteLine("Name: " + User.name + "Password: " + User.password);
                        User.userid = user.userid;
                    }
                });

                
            }
            else
            {
                user.userid = 1;
            }
           
        }


        /* Here starts the logic for user */
        private string userid;

        public string Userid
        {
            get { return userid; }
            set { userid = value; }
        }


        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if(name != value)
                {
                    name = value; 
                }
                OnPropertyChanged("Name");
            }
        }

        private string username;
        public string Username
        {
            get { return username; }
            set { username = value; OnPropertyChanged("Username"); }
        }

        private string city;

        public string City
        {
            get { return city; }
            set { city = value; OnPropertyChanged("City"); }
        }
        private string province;

        public string Province
        {
            get { return province; }
            set { province = value; OnPropertyChanged("Province"); }
        }

        private string postalcode;
        public string Postalcode
        {
            get { return postalcode; }
            set { postalcode = value; OnPropertyChanged("Postalcode"); }
        }


        private string password;
        public string Password
        {
            get { return password; }
            set { password = value; OnPropertyChanged("Password"); }
        }

        /* starts the logic for drinks */
        private string drinkname;

        public string Drinkname
        {
            get { return drinkname; }
            set { drinkname = value; OnPropertyChanged("DrinkName"); }
        }

        private string ingredients;

        public string Ingredients
        {
            get { return ingredients; }
            set { ingredients = value; OnPropertyChanged("Ingredients"); }
        }
        private string method;

        public string Method
        {
            get { return method; }
            set { method = value; OnPropertyChanged("Method"); }
        }
        private string alcoholcontent;

        public string Alcoholcontent
        {
            get { return alcoholcontent; }
            set { alcoholcontent = value; OnPropertyChanged("AlcoholContent"); }
        }

        private List<string> provincelist;

        public List<string> Provincelist
        {
            get { return provincelist;  }
            set { provincelist = value; }
        }

        /* OnPropertyChange handler */
        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }


    }
}
