using System;
               store_id = value;
                ord_num = value;
                ord_date = value;
                qty = value;

        private string payterms;
            get
            {
            }
            set
            {
                payterms = value;
                OnPropertyChanged("Payterms");
            }


        private string title_id;
            get
            {
            }
            set
            {
                title_id = value;
                OnPropertyChanged("Title_id");
            }

        private string stor_name;
            get
            {
            }
            set
            {
                stor_name = value;
                OnPropertyChanged("Stor_name");
            }


        private string title;
            get
            {
            }
            set
            {
                title = value;
                OnPropertyChanged("Title");
            }


        private string titleType;
            get
            {
            }
            set
            {
                titleType = value;
                OnPropertyChanged("TitleType");
            }

        private decimal? price;
            get
            {
                return price;
            }
            set
            {
                price = value;
                OnPropertyChanged("Price");
            }
