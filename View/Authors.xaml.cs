using Pubs.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for Authors.xaml
    /// </summary>
    public partial class Authors : Page, INotifyPropertyChanged
    {
        private AuthorsVM authorsVM;

        private ObservableCollection<Model.Authors> authorsList; 
        public ObservableCollection<Model.Authors> AuthorsList
        {
            get
            {
                return authorsList;
            }
            set 
            {
                authorsList = value;
                OnPropertyChanged("AuthorsList");
            }
        }

        private bool isUpdate;
        public bool IsUpdate
        {
            get
            {
                return isUpdate;
            }
            set
            {
                isUpdate = value;
                OnPropertyChanged("IsUpdate");
            }
        }



        public Authors()
        {
            IsUpdate = false;
            authorsVM = new AuthorsVM();
            InitializeComponent();
        }



        private void CodeBehind_Loaded(object sender, RoutedEventArgs e)
        {
            GetInfo();
            IsUpdate = true;
        }

        private void GetInfo()
        {
            AuthorsList = new ObservableCollection<Model.Authors>(authorsVM.SelectAllauthors());
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
