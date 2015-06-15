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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CocktailLogic cl = new CocktailLogic();
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            WelcomeUserControl wuc = new WelcomeUserControl();
            panelCocktail.Children.Add(wuc);
            this.DataContext = cl;
            await cl.Init();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            LoginUserControl luc = new LoginUserControl();
            panelCocktail.Children.Clear();
            panelCocktail.Children.Add(luc);
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            RegisterUserControl ruc = new RegisterUserControl();
            panelCocktail.Children.Clear();
            panelCocktail.Children.Add(ruc);
        }

        private void btnDrinks_Click(object sender, RoutedEventArgs e)
        {
            DrinksUserControl duc = new DrinksUserControl();
            panelCocktail.Children.Clear();
            panelCocktail.Children.Add(duc);
        }
    }
}
