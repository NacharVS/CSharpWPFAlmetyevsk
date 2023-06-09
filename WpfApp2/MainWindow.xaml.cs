﻿using System;
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
        string[] vacancies = new string[5] { "Traine", "Employe", "Manager", "HighManager", "Director" };
        public MainWindow()
        {
            InitializeComponent();
            cBox.ItemsSource = vacancies;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            tblock1.Text = tbox1.Text;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //users.Add(new User(tbox1.Text, tbox2.Text, tbox3.Text, tbox4.Text));
            MongoDBExamples.CreateDocument(new User(tbox1.Text, tbox2.Text, tbox3.Text, cBox.SelectedValue.ToString()));
            tbox1.Clear();
            tbox2.Clear();
            tbox3.Clear();
            
            ListUsersRefresh();

        }

        private void list1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if(list1.SelectedIndex >= 0)
            {
                var buff = MongoDBExamples.FindDocument(list1.SelectedItem.ToString());
                lb1.Content = buff.Name;
                lb2.Content = buff.Surname;
                lb3.Content = buff.SecondName;
                lb4.Content = buff.Vacancy;
            }
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
            var bufferList = MongoDBExamples.FindAllDocument();
            foreach (User user in bufferList)
            {
                list1.Items.Add(user.Name);
            }
        }

        private void list1_Loaded(object sender, RoutedEventArgs e)
        {
            ListUsersRefresh();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MongoDBExamples.RemoveDocument(list1.SelectedItem.ToString());
            ListUsersRefresh();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            MongoDBExamples.ReplaceDocument(list1.SelectedItem.ToString(), new User(tbox1.Text, tbox2.Text, tbox3.Text, cBox.SelectedValue.ToString()));
            MessageBox.Show("Replacemen succesfully done");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (list1.SelectedIndex >= 0)
            {
                var buff = MongoDBExamples.FindDocument(list1.SelectedItem.ToString());
                tbox1.Text = buff.Name;
                tbox2.Text = buff.Surname;
                tbox3.Text = buff.SecondName;
                cBox.SelectedItem = buff.Vacancy;
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MongoDBExamples.UpdateDocument();
        }
    }
}
