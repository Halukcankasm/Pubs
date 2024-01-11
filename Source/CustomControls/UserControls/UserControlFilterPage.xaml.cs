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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Pubs.Source.CustomControls.UserControls
{
    /// <summary>
    /// Interaction logic for UserControlFilterPage.xaml
    /// </summary>
    public partial class UserControlFilterPage : UserControl, INotifyPropertyChanged
    {


        private ObservableCollection<UIElement> kriteria;
        public ObservableCollection<UIElement> Kriteria
        {
            get
            {
                return kriteria;
            }
            set
            {
                kriteria = value;
                OnPropertyChanged("Kriteria");
            }
        }

        private ObservableCollection<UIElement> dataArea;
        public ObservableCollection<UIElement> DataArea
        {
            get
            {
                return dataArea;
            }
            set
            {
                dataArea = value;
                OnPropertyChanged("DataArea");
            }
        }

        private readonly Duration openCloseDuration = new Duration(TimeSpan.FromSeconds(0.5));

        public UserControlFilterPage()
        {
            Kriteria = new ObservableCollection<UIElement>();
            DataArea = new ObservableCollection<UIElement>();
            InitializeComponent();
            kriteriAArea.Width = 0;
        }

        private void CodeBehind_Loaded(object sender, RoutedEventArgs e)
        {

            if (kriteriAArea.Children.Count == 0 && Kriteria != null && Kriteria.Count > 0)
            {
                foreach (UIElement item in Kriteria)
                {
                    kriteriAArea.Children.Add(item);
                }

            }

            if (dataAArea.Children.Count == 0 && DataArea != null && DataArea.Count > 0)
            {
                foreach (UIElement item in DataArea)
                {
                    dataAArea.Children.Add(item);
                }
            }

        }

        private void NavButton_Cheched(object sender, RoutedEventArgs e)
        {
            var maxWidth = Kriteria.Max(y => y.DesiredSize.Width);
            var maxHeight = Kriteria.Max(x => x.DesiredSize.Height);

            DoubleAnimation withAnimation = new DoubleAnimation(maxWidth, openCloseDuration);
            kriteriAArea.BeginAnimation(WidthProperty, withAnimation);
        }

        private void NavButton_UnCheched(object sender, RoutedEventArgs e)
        {
            DoubleAnimation withAnimation = new DoubleAnimation(0, openCloseDuration);
            kriteriAArea.BeginAnimation(WidthProperty, withAnimation);
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
