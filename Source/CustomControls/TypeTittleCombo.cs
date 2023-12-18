using Pubs.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Pubs.Source.CustomControls
{
    public class TypeTittleCombo : Control, INotifyPropertyChanged
    {
        private ComboBox TypeComboBox;

        private static TitlesVM titlesVM;

        private List<string> typeList;
        public List<string> TypeList
        {
            get
            {
                return typeList;
            }
            set
            {
                typeList = value;
                OnPropertyChanged("TypeList");
            }
        }

        static TypeTittleCombo()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TypeTittleCombo), new FrameworkPropertyMetadata(typeof(TypeTittleCombo)));
            titlesVM = new TitlesVM();
        }

        public override void OnApplyTemplate()
        {
            TypeComboBox = Template.FindName("TypeComboBox", this) as ComboBox;

            UpdateHandAngles();

            base.OnApplyTemplate();
        }

        private void UpdateHandAngles()
        {
            TypeComboBox.ItemsSource = titlesVM.SelectTypesOfTittle();
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
