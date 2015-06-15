/* Arshjot Singh Date- 02.06.2015
 * Version 1.0
 * Description - Drinks User control class
 * */
using CocktailCollectionApp.ViewModel;
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

namespace CocktailCollectionApp
{
    /// <summary>
    /// Interaction logic for DrinksUserControl.xaml
    /// </summary>
    public partial class DrinksUserControl : UserControl
    {
        CocktailLogic cl = new CocktailLogic();
        public DrinksUserControl()
        {
            InitializeComponent();
            this.DataContext = cl;
        }

        private async void btnSubmitDrink_Click(object sender, RoutedEventArgs e)
        {
            await cl.CreateDrink(cl.Drinkname, cl.Ingredients, cl.Method, cl.Alcoholcontent, "anonymous");
            MessageBox.Show("Drink Added successfully.");
        }

        private async void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            await cl.Init();
        }

        private void Save_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            //Your code
            //await 
        }

        private void Save_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = !(string.IsNullOrEmpty(cl.Drinkname) || string.IsNullOrEmpty(cl.Ingredients) || string.IsNullOrEmpty(cl.Method));


        }
    }
}
