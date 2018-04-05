using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
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
                NotifyProperyChanged();
            }
        }
        
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyProperyChanged([CallerMemberName] String property = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }


        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You clicked on the button");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            birthdayYear.BirthYear++;

            // Change the color
            //this.btn.SetResourceReference(BackgroundProperty, "lblbgcolor");
            // Open the new window
            SortingExample sortingExample = new SortingExample();
            sortingExample.Show();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            // Determing if two cars are equal
            // OVerriding the IEquatable interface
            Car car = new Car();
            Car car2 = new Car();
            car2.Year = "2000";
            car.Year = "2000";

            car.Make = "S";
            car2.Make = "S";

            car.Model = "N";
            car2.Model = "N";

            if (car == car2)
            {
                MessageBox.Show("The cars are equal");
            }
            else
            {
                MessageBox.Show("The cars are not equal");
            }

            // Test out classes A-D for polymorphism
            C c = new C();
            c.DoWork();

            A ac = (A)c;
            ac.DoWork();

            B bc = (B)c;
            bc.DoWork();

            B b = new B();
            b.DoWork();
        }

        /// <summary>
        /// Open the heirarchy window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hierarchyBtn_Click(object sender, RoutedEventArgs e)
        {
            HierarchyWindow hierarchyWindow = new HierarchyWindow();
            hierarchyWindow.ShowDialog();
        }

        private void collectionBtn_Click(object sender, RoutedEventArgs e)
        {
            CollectionBinding.CollectionBinding collectionBinding = new CollectionBinding.CollectionBinding();
            collectionBinding.ShowDialog();
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
