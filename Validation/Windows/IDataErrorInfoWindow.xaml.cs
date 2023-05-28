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

namespace Validation.Windows
{
    /// <summary>
    /// Логика взаимодействия для IDataErrorInfoWindow.xaml
    /// </summary>
    public partial class IDataErrorInfoWindow : Window
    {
        public User newUser { get; set; }
        public IDataErrorInfoWindow()
        {
            InitializeComponent();
            DataContext = newUser = new User() 
            {
                Name = string.Empty,
                Age = 0,
                Username = string.Empty,
            };
        }

        private void AddUserButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
