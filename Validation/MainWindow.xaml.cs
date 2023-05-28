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
using Validation.Windows;

namespace Validation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Connection.Database = new Database.ValidationUserContext();
        }
        private void GoToSimpleValidationWindow(object sender, RoutedEventArgs e) =>
            new EventHandlerValidationWindow().ShowDialog();

        private void GoToValidationRuleWindow(object sender, RoutedEventArgs e)
        {
            ValidationRuleWindow window = new ValidationRuleWindow();
            window.ShowDialog();
        }
        private void GoToIDataErrorWindow(object sender, RoutedEventArgs e)
        {
            IDataErrorInfoWindow window = new IDataErrorInfoWindow();
            window.ShowDialog();
        }
    }
}
