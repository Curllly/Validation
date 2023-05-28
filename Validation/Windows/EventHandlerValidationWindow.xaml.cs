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
    /// Логика взаимодействия для EventHandlerValidationWindow.xaml
    /// </summary>
    public partial class EventHandlerValidationWindow : Window
    {
        public EventHandlerValidationWindow()
        {
            InitializeComponent();
        }

        private void AddUserButton_Click(object sender, RoutedEventArgs e)
        {
            if (stackPanel.Children.OfType<TextBox>().Any(tb => tb.Text.Trim() == ""))
            {
                MessageBox.Show("Все поля должны быть заполнены!");
                return;
            }
            int age = 1;
            if (!int.TryParse(AgeTextBox.Text, out age))
            {
                MessageBox.Show("Возраст должен быть целым числом!");
                return;
            }
            else if (age < 0 || age > 100)
            {
                MessageBox.Show("Возраст должен быть от 0 до 100!");
                return;
            }
            if (Connection.Database.Users.FirstOrDefault(u => u.Username == UsernameTextBox.Text.Trim()) != null)
            {
                MessageBox.Show("Пользователь с таким именем уже существует!");
                return;
            }
            var newUser = new User
            {
                Age = age,
                Name = NameTextBox.Text,
                Username = UsernameTextBox.Text
            };
            Connection.Database.Users.Add(newUser);
            Connection.Database.SaveChanges();
        }
    }
}
