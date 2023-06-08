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

        public MainWindow()
        {
            InitializeComponent();

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            tblock1.Text = tbox1.Text;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            list1.Items.Add(tbox1.Text);
            tbox1.Clear();
        }

        private void list1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lb1.Content = list1.SelectedItem;
        }
    }
}
