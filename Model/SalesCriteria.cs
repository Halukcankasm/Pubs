using System;
                ord_date = value;

        private string str_name;
            get
            {
                return str_name;
            }
            set
            {
                str_name = value;
                OnPropertyChanged("Str_name");
            }

        private string title_type;
            get
            {
                return title_type;
            }
            set
            {
                title_type = value;
                OnPropertyChanged("Title_type");
            }

        #endregion Instance Properties
        #region INotifyPropertyChanged Members