using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
using Pubs.View;
using SQLDBHelper;

namespace Pubs
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SqlConnection cnn { get; set; }
        Titles titles;
        Authors authors;
        //Employee employee;
        public MainWindow()
        {
            titles = new Titles();
            authors = new Authors();
            //employee = new Employee();
            InitializeComponent();
        }

        private void booksBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = titles;
        }

        private void writersBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = authors;
        }

        private void employesBtn_Click(object sender, RoutedEventArgs e)
        {
            //MainFrame.Content = employee;
        }
    }
}
