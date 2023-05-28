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
using System.Windows.Shapes;
using Validation.Models;

namespace Validation
{
    /// <summary>
    /// Логика взаимодействия для ValidationRuleWindow.xaml
    /// </summary>
    public partial class ValidationRuleWindow : Window
    {
        public User newUser { get; set; }
        private int errorCount = 0;
        public ValidationRuleWindow()
        {
            InitializeComponent();
            DataContext = newUser = new User();
        }
        private void TextBox_Error(object sender, ValidationErrorEventArgs e)
        {
            if (e.Action == ValidationErrorEventAction.Added)
            {
                errorCount++;
                var errorToolTip = new ToolTip();
                errorToolTip.Content = e.Error.ErrorContent;
                (sender as TextBox).ToolTip = errorToolTip;
            }
            if (e.Action == ValidationErrorEventAction.Removed)
            {
                errorCount--;
            }
            AddUserButton.IsEnabled = errorCount == 0;
        }

        private void AddUserButton_Click(object sender, RoutedEventArgs e)
        {

            Connection.Database.Users.Add(newUser);
            Connection.Database.SaveChanges();
        }
    }
}
