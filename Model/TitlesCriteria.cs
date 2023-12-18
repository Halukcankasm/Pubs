using System;using System.ComponentModel;using System.Collections.ObjectModel;using System.Data;using System.Data.SqlClient;using MessageBox = System.Windows.MessageBox;namespace Pubs.Model{    public class TitlesCriteria : INotifyPropertyChanged    {    #region Instance Properties        private string title_id;        public string Title_id        {             get             {              return title_id;             }             set             {              title_id = value;              OnPropertyChanged("Title_id");             }        }         private string title;        public string Title        {         get         {          return title;         }         set         {          title = value;          OnPropertyChanged("Title");         }        }         private string type;        public string Type        {         get         {          return type;         }         set         {          type = value;          OnPropertyChanged("Type");         }        }         private string pub_id;        public string Pub_id        {         get         {          return pub_id;         }         set         {          pub_id = value;          OnPropertyChanged("Pub_id");         }        }         private decimal? price;        public decimal? Price        {         get         {          return price;         }         set         {          price = value;          OnPropertyChanged("Price");         }        }         private decimal? advance;        public decimal? Advance        {         get         {          return advance;         }         set         {          advance = value;          OnPropertyChanged("Advance");         }        }         private int? royalty;        public int? Royalty        {         get         {          return royalty;         }         set         {          royalty = value;          OnPropertyChanged("Royalty");         }        }         private int? ytd_sales;        public int? Ytd_sales        {         get         {          return ytd_sales;         }         set         {          ytd_sales = value;          OnPropertyChanged("Ytd_sales");         }        }         private string notes;        public string Notes        {         get         {          return notes;         }         set         {          notes = value;          OnPropertyChanged("Notes");         }        }         private DateTime pubdate;        public DateTime Pubdate        {         get         {          return pubdate;         }         set         {          pubdate = value;          OnPropertyChanged("Pubdate");         }        }

        private string au_id;        public string Au_id        {
            get
            {
                return au_id;
            }
            set
            {
                au_id = value;
                OnPropertyChanged("Au_id");
            }        }

        private string au_name;        public string Au_name        {
            get
            {
                return au_name;
            }
            set
            {
                au_name = value;
                OnPropertyChanged("Au_name");
            }        }








        #endregion Instance Properties
        #region INotifyPropertyChanged Members        public event PropertyChangedEventHandler PropertyChanged;        private void OnPropertyChanged(string propertyName)        {         if (PropertyChanged != null)         {          PropertyChanged(this, new PropertyChangedEventArgs(propertyName));         }        }        #endregion INotifyPropertyChanged Members    }}