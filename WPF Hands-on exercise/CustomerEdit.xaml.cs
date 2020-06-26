using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using HandsOnLab1.ClientEntities;

namespace HandsOnLab1
{
    /// <summary>
    /// Interaction logic for CustomerEdit.xaml
    /// </summary>
    public partial class CustomerEdit : UserControl
    {
        private CustomerUpdate _customer = new CustomerUpdate(123);

        public CustomerEdit()
        {
            InitializeComponent();
            DataContext = this;
        }

        public CustomerUpdate Customer
        {
            get => _customer;
            set
            {
                if (_customer != null)
                {
                    _customer = value;
                    OnPropertyChanged("Customer");
                }
            }
        }

        private void ExecutedSave(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Assume that the save worked.");
        }

        private void CanSave(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        #region INotifyPropertyChanged Members

        /// <summary>
        /// Implicit implementation of the INotifyPropertyChanged.PropertyChanged event./// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Throws the <c>PropertyChanged</c> event.
        /// </summary>
        /// <param name="propertyName">The name of the property that was modified.</param>
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new
                PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}
