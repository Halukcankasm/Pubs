using System;using System.ComponentModel;using System.Collections.ObjectModel;using System.Data;using System.Data.SqlClient;using MessageBox = System.Windows.MessageBox;namespace Pubs.Model{    public class SalesDetail : INotifyPropertyChanged    {    #region Instance Properties        private string store_id;        public string Store_id        {             get             {              return store_id;             }             set             {
               store_id = value;              OnPropertyChanged("Store_id");             }        }         private string ord_num;        public string Ord_num        {         get         {                return ord_num;         }         set         {
                ord_num = value;          OnPropertyChanged("Ord_num");         }        }         private DateTime? ord_date;        public DateTime? Ord_date        {         get         {                return ord_date;         }         set         {
                ord_date = value;          OnPropertyChanged("Ord_date");         }        }         private short qty;        public short Qty        {         get         {          return qty;         }         set         {
                qty = value;          OnPropertyChanged("Qty");         }        }

        private string payterms;        public string Payterms        {
            get
            {                return payterms;
            }
            set
            {
                payterms = value;
                OnPropertyChanged("Payterms");
            }        }


        private string title_id;        public string Title_id        {
            get
            {                return title_id;
            }
            set
            {
                title_id = value;
                OnPropertyChanged("Title_id");
            }        }

        private string stor_name;        public string Stor_name        {
            get
            {                return stor_name;
            }
            set
            {
                stor_name = value;
                OnPropertyChanged("Stor_name");
            }        }


        private string title;        public string Title        {
            get
            {                return title;
            }
            set
            {
                title = value;
                OnPropertyChanged("Title");
            }        }


        private string titleType;        public string TitleType        {
            get
            {                return titleType;
            }
            set
            {
                titleType = value;
                OnPropertyChanged("TitleType");
            }        }

        private decimal? price;        public decimal? Price        {
            get
            {
                return price;
            }
            set
            {
                price = value;
                OnPropertyChanged("Price");
            }        }
        #endregion Instance Properties        #region INotifyPropertyChanged Members        public event PropertyChangedEventHandler PropertyChanged;        private void OnPropertyChanged(string propertyName)        {         if (PropertyChanged != null)         {          PropertyChanged(this, new PropertyChangedEventArgs(propertyName));         }        }        #endregion INotifyPropertyChanged Members    }}