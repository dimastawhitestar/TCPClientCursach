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

namespace Clientkurs
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnReg(object sender, RoutedEventArgs e)
        {
            RegistrationButton.Visibility = Visibility.Collapsed;
            LoginButton.Visibility = Visibility.Visible;
            autorization_panel.Visibility = Visibility.Collapsed;
            registration_panel.Visibility = Visibility.Visible;
            grid1.Height = new GridLength(370);
        }
        private void btnLog(object sender, RoutedEventArgs e)
        {
            RegistrationButton.Visibility = Visibility.Visible;
            LoginButton.Visibility = Visibility.Collapsed;
            autorization_panel.Visibility = Visibility.Visible;
            registration_panel.Visibility = Visibility.Collapsed;
            grid1.Height = new GridLength(200);
        }
    }
}
