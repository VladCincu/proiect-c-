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

namespace EVCarsAutonomy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new Uri("Home.xaml", UriKind.Relative));
        }

        private void ToggleMenu(object sender, RoutedEventArgs e)
        {
            // Implementați logica pentru afișarea/ascunderea meniului hamburger
        }

        private void NavigateToHome(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Uri("Home.xaml", UriKind.Relative));
        }

        private void NavigateToFind(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Uri("Find.xaml", UriKind.Relative));
        }

        private void NavigateToCalculate(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Uri("Calculate.xaml", UriKind.Relative));
        }

        private void ExitApplication(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
   

        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
    }
}
