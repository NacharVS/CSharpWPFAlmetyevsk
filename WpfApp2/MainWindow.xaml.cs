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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<User> users;
        public MainWindow()
        {
            InitializeComponent();
            users = new List<User>();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            tblock1.Text = tbox1.Text;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            users.Add(new User(tbox1.Text, tbox2.Text, tbox3.Text, tbox4.Text));
            tbox1.Clear();
            tbox2.Clear();
            tbox3.Clear();
            tbox4.Clear();
            ListUsersRefresh();

        }

        private void list1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var buff = users.Find(x => x.Name + " " + x.Surname == list1.SelectedItem.ToString());
            lb1.Content = buff.Name;
            lb2.Content = buff.Surname;
            lb3.Content = buff.SecondName;
            lb4.Content = buff.Vacancy;
            //foreach (var user in users)
            //{

            //if(list1.SelectedItem.ToString() == user.Name + " " + user.Surname)
            //{
            //    lb1.Content = user.Name;
            //    lb2.Content = user.Surname;
            //    lb3.Content = user.SecondName;
            //    lb4.Content = user.Vacancy;

            //}
            //}
        }

        private void ListUsersRefresh()
        {
            list1.Items.Clear();
            foreach (User user in users)
            {
                list1.Items.Add(user.Name + " " + user.Surname);
            }
        }
    }
}
