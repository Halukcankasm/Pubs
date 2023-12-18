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

namespace Pubs.Source.CustomControls
{
    public class TypesOfTittleComboBox : ComboBox, INotifyPropertyChanged
    {

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

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsAllOptionIncludeProperty =
            DependencyProperty.Register("IsAllOptionInclude", typeof(bool), typeof(HamburgerMenu),
                new PropertyMetadata(false));
        public bool IsAllOptionInclude
        {
            get { return (bool)GetValue(IsAllOptionIncludeProperty); }
            set { SetValue(IsAllOptionIncludeProperty, value); }
        }

        static TypesOfTittleComboBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TypesOfTittleComboBox), new FrameworkPropertyMetadata(typeof(TypesOfTittleComboBox)));
            titlesVM = new TitlesVM();
        }

        protected override void OnSelectionChanged(SelectionChangedEventArgs e)
        {
            base.OnSelectionChanged(e);
            if (this.SelectedItem != null && this.SelectedItem.ToString() == "Hepsi")
            {
                this.SelectedItem = null;
            }
        }

        public override void OnApplyTemplate()
        {          

            base.OnApplyTemplate();
            UpdateHandAngles();
        }

        private void UpdateHandAngles()
        {
            var itemSource = new ObservableCollection<string>(titlesVM.SelectTypesOfTittle());
            if (IsAllOptionInclude == true)
            {
                itemSource.Insert(0, "Hepsi");
            }
            this.ItemsSource = itemSource;
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
