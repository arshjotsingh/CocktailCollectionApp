/* Arshjot Singh Date- 02.06.2015
 * Version 1.0
 * Description - Login User control class
 * */
using CocktailCollectionApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace CocktailCollectionApp
{
    /// <summary>
    /// Interaction logic for LoginUserControl.xaml
    /// </summary>
    public partial class LoginUserControl : UserControl
    {
        CocktailLogic cl = new CocktailLogic();
        public LoginUserControl()
        {
            InitializeComponent();
            this.DataContext = cl;
        }

        private async  void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            await cl.LoginUser(cl.Username,cl.Password);
        }
        private async void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            await cl.Init();
           
        }


        private void tbUserNameLogin_LostFocus(object sender, RoutedEventArgs e)
        {
            var input = (sender as TextBox).Text;
            
        }

        private void tbUserNameLogin_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !IsTextAllowed(e.Text);
        }

        private static bool IsTextAllowed(string text)
        {
            Regex regex = new Regex("[ABCEGHJKLMNPRSTVXY][0-9][ABCEGHJKLMNPRSTVWXYZ][0-9][ABCEGHJKLMNPRSTVWXYZ][0-9]"); //regex that matches disallowed text
         //   MessageBox.Show(""+!regex.IsMatch(text));
            return !regex.IsMatch(text);
        }

        private void Save_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            //Your code
            //await 
        }

        private void Save_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = !(string.IsNullOrEmpty(cl.Username) && string.IsNullOrEmpty(cl.Password));

        }
    }
}
