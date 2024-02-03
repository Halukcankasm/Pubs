using Pubs.Model;
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
using System.Windows.Shapes;

namespace Pubs.View.PopUp
{
    /// <summary>
    /// Interaction logic for SalesPopUp.xaml
    /// </summary>
    public partial class SalesPopUp : Window, INotifyPropertyChanged
    {

        private SalesDetail salesDetailContract;
        public SalesDetail SalesDetailContract
        {
            get
            {
                return salesDetailContract;
            }
            set
            {
                salesDetailContract = value;
                OnPropertyChanged("SalesDetailContract");
            }
        }


        public SalesPopUp(SalesDetail salesDetail)
        {          

            InitializeComponent();

            this.SalesDetailContract = salesDetail;
        }

        private void CodeBehind_Loaded(object sender, RoutedEventArgs e)
        {
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
