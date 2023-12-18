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
    /// Interaction logic for Titles.xaml
    /// </summary>
    public partial class Titles : Page, INotifyPropertyChanged
    {
        #region Properties
        public TitlesVM titlesVM { get; set; }

        #region TitlesCriteria
        private TitlesFilter titlesCriteria;
        public TitlesFilter TitlesCriteria
        {
            get
            {
                return titlesCriteria;
            }
            set
            {
                titlesCriteria = value;
                OnPropertyChanged("SelectedAuthorOfTittle");
            }
        }
        #endregion


        #region TypeFiltersComboSource
        private List<String> typeFilters;
        public List<String> TypeFilters
        {
            get
            {
                return typeFilters;
            }
            set
            {
                typeFilters = value;
                OnPropertyChanged("TypeFilters");
            }
        }
        #endregion

        #region AuthorsFiltersComboSource
        private List<AuthorsFilter> authorsFilters;
        public List<AuthorsFilter> AuthorsFilters
        {
            get
            {
                return authorsFilters;
            }
            set
            {
                authorsFilters = value;
                OnPropertyChanged("AuthorsFilters");
            }
        } 
        #endregion

        #region TitlesList
        private List<Model.Titles> titlesList;
        public List<Model.Titles> TitlesList
        {
            get
            {
                return titlesList;
            }
            set
            {
                titlesList = value;
                OnPropertyChanged("TitlesList");
            }
        } 
        #endregion
        #endregion
        public Titles()
        {
            titlesVM = new TitlesVM();
            TitlesCriteria = new TitlesFilter();
            InitializeComponent();
        }


        private void CodeBehind_Loaded(object sender, RoutedEventArgs e)
        {
            GetInfo();
        }

        private void GetInfoBtn_Click(object sender, RoutedEventArgs e)
        {
            TitlesList = titlesVM.SelectTitlesByCriteria(TitlesCriteria);
        }

        private void GetInfo()
        {
            TitlesList = titlesVM.GetAlltitles().ToList();
            AuthorsFilters = titlesVM.SelectAuthorsFilter();
            TypeFilters = titlesVM.SelectTypesOfTittle();
            TitlesList = titlesVM.SelectTitlesByCriteria(TitlesCriteria);
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
