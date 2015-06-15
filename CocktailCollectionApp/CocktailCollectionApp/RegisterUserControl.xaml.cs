/* Arshjot Singh Date- 02.06.2015
 * Version 1.0
 * Description - Register User control class
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CocktailCollectionApp.ViewModel;

namespace CocktailCollectionApp
{
    /// <summary>
    /// Interaction logic for RegisterUserControl.xaml
    /// </summary>
    public partial class RegisterUserControl : UserControl
    {
        CocktailLogic cl = new CocktailLogic();
        public RegisterUserControl()
        {
            InitializeComponent();

            this.DataContext = cl;


        }

        private async void btnsumbit_Click(object sender, RoutedEventArgs e)
        {
            await cl.CreateUser(cl.Name, cl.Password, cl.City, cl.Province, cl.Postalcode, cl.Username);
        }

        private async void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            await cl.Init();
            //  cl.Provincelist.Add("Ontario");
        }
        private void Save_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            //Your code
            //await 
        }

        private void Save_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = !(string.IsNullOrEmpty(cl.Username) || string.IsNullOrEmpty(cl.Password) || string.IsNullOrEmpty(cl.City) || string.IsNullOrEmpty(cl.Province) || string.IsNullOrEmpty(cl.Postalcode));


        }
    }
}
