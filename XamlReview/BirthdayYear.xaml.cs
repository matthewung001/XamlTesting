using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    /// Interaction logic for BirthdayYear.xaml
    /// </summary>
    public partial class BirthdayYear : UserControl
    {
        public BirthdayYear()
        {
            InitializeComponent();
        }

        // Create a dependency property
        public int BirthYear
        {
            get { return (int)GetValue(BirthYearProperty); }
            set { SetValue(BirthYearProperty, value); }
        }

        public static readonly DependencyProperty BirthYearProperty =
            DependencyProperty.Register("BirthYear", typeof(int), typeof(BirthdayYear), new PropertyMetadata(1983));
    }
}
