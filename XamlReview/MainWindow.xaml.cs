using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace XamlReview
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        public int Amount { get; set; }
        public int FinalAmount { get; set; }

        private bool _isValidData;
        public bool IsValidData
        {
            get
            {
                return _isValidData;
            }
            set
            {
                _isValidData = value;
                PropertyChanged(this, new PropertyChangedEventArgs("IsValidData"));
            }
        }
        
        public event PropertyChangedEventHandler PropertyChanged;

       


        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You clicked on the button");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            birthdayYear.BirthYear++;

            // Change the color
            //this.btn.SetResourceReference(BackgroundProperty, "lblbgcolor");
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Thanks for clicking on me!");
        }

        /*
        private void ContextMenuClickEventHandler(object sender, RoutedEventArgs e)
        {
            if (e.Source == RedMenuItem)
            {
                ColorTabItem.Header = "Red Item";
                ColorTabItem.Foreground = Brushes.Red;
            }
            else if (e.Source == BlueMenuItem)
            {
                ColorTabItem.Header = "Blue Item";
                ColorTabItem.Foreground = Brushes.Blue;
            }
            else if (e.Source == OrangeMenuItem)
            {
                ColorTabItem.Header = "Orange Item";
                ColorTabItem.Foreground = Brushes.Orange;
            }
        }
        */

    }
}
