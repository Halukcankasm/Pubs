using System;using System.ComponentModel;using System.Collections.ObjectModel;using System.Data;using System.Data.SqlClient;using MessageBox = System.Windows.MessageBox;namespace Pubs.Model{    public class SalesCriteria : INotifyPropertyChanged    {    #region Instance Properties        private DateTime? ord_date;        public DateTime? Ord_date        {             get             {              return ord_date;             }             set             {
                ord_date = value;              OnPropertyChanged("Ord_date");             }        }

        private string str_name;        public string Str_name        {
            get
            {
                return str_name;
            }
            set
            {
                str_name = value;
                OnPropertyChanged("Str_name");
            }        }

        private string title_type;        public string Title_type        {
            get
            {
                return title_type;
            }
            set
            {
                title_type = value;
                OnPropertyChanged("Title_type");
            }        }

        #endregion Instance Properties
        #region INotifyPropertyChanged Members        public event PropertyChangedEventHandler PropertyChanged;        private void OnPropertyChanged(string propertyName)        {         if (PropertyChanged != null)         {          PropertyChanged(this, new PropertyChangedEventArgs(propertyName));         }        }        #endregion INotifyPropertyChanged Members    }}