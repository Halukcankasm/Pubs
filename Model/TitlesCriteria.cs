using System;

        private string au_id;
            get
            {
                return au_id;
            }
            set
            {
                au_id = value;
                OnPropertyChanged("Au_id");
            }

        private string au_name;
            get
            {
                return au_name;
            }
            set
            {
                au_name = value;
                OnPropertyChanged("Au_name");
            }








        #endregion Instance Properties
        #region INotifyPropertyChanged Members