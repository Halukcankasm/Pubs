using Pubs.Model;
using Pubs.View.PopUp;
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
    /// Interaction logic for Sales.xaml
    /// </summary>
    public partial class Sales : Page, INotifyPropertyChanged
    {

        public SalesVM salesVM { get; set; }
        public TitlesVM TitlesVM { get; set; }

        private List<Model.SalesDetail> salesList;
        public List<Model.SalesDetail> SalesList
        { 
            get
            {
                return salesList;
            }
            set
            {
                salesList = value;
                OnPropertyChanged("SalesList");
            }
        }



        private ObservableCollection<string> typesOfTitles;
        public ObservableCollection<string> TypesOfTitles
        {
            get
            {
                return typesOfTitles;
            }
            set
            {
                typesOfTitles = value;
                OnPropertyChanged("TypesOfTitles");
            }
        }

        private ObservableCollection<string> storeNames;
        public ObservableCollection<string> StoreNames
        {
            get
            {
                return storeNames;
            }
            set
            {
                storeNames = value;
                OnPropertyChanged("StoreNames");
            }
        }

        private Model.SalesCriteria salesCriterias;
        public Model.SalesCriteria SalesCriterias
        {
            get
            {
                return salesCriterias;
            }
            set
            {
                salesCriterias = value;
                OnPropertyChanged("SalesCriterias");
            }
        }

        public Sales()
        {
            SalesCriterias = new SalesCriteria();
            TypesOfTitles = new ObservableCollection<string>();
            StoreNames = new ObservableCollection<string>();

            salesVM = new SalesVM();
            TitlesVM = new TitlesVM();
            InitializeComponent();

        }


        private void CodeBehind_Loaded(object sender, RoutedEventArgs e)
        {
            GetInfo();
        }

        private void GetInfo()
        {
            if (SalesCriterias.Title_type == "Hepsi" || SalesCriterias.Str_name == "Hepsi")
            {
                SalesCriterias.Title_type = null;
                SalesCriterias.Str_name = null;
            }
            SalesList =  salesVM.GetSalesDetailWithColumn( SalesCriterias);
            StoreNames = new ObservableCollection<string>(salesVM.SelectStoreNames());
            TypesOfTitles = new ObservableCollection<string>(TitlesVM.SelectTypesOfTittle());

            TypesOfTitles.Insert(0, "Hepsi");
            StoreNames.Insert(0, "Hepsi");
        }

        private void ListViewItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var selectedSale = (SalesDetail)(((ListBoxItem)sender).Content);
            SalesPopUp salesPopUp = new SalesPopUp(selectedSale);
            salesPopUp.ShowDialog();
        }


        private void GetInfo_Click(object sender, RoutedEventArgs e)
        {
            if (SalesCriterias.Title_type == "Hepsi" || SalesCriterias.Str_name == "Hepsi")
            {
                SalesCriterias.Title_type = null;
                SalesCriterias.Str_name = null;
            }
            SalesList = salesVM.GetSalesDetailWithColumn(SalesCriterias);
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
