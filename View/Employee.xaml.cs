using Pubs.Model;
using Pubs.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Pubs.View
{
    /// <summary>
    /// Interaction logic for Employee.xaml
    /// </summary>
    public partial class Employee : Page, INotifyPropertyChanged
    {
        private EmployeeVM employeVM;

        private List<EmployeeDetail> employeDetailList;

        public List<EmployeeDetail> EmployeDetailList 
        {
            get
            {
                return employeDetailList;
            }
            set
            {
                employeDetailList = value;
                OnPropertyChanged("EmployeDetailList");
            }
        }
        public Employee()
        {
            employeVM = new EmployeeVM();
            EmployeDetailList = new List<EmployeeDetail>();
            InitializeComponent();
        }

        private void CodeBehind_Loaded(object sender, RoutedEventArgs e)
        {
            EmployeDetailList = employeVM.GetAllemployeeDetail(null);
        }

        private void kriteriaNameChanged(object sender, TextChangedEventArgs e)
        {
            string empName = ((TextBox)sender).Text;
            EmployeDetailList = employeVM.GetAllemployeeDetail(empName);

        }


        #region INotifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion INotifyPropertyChanged Members
    }
}
