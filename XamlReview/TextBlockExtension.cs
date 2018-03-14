using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace XamlReview
{
    class TextBlockExtension
    {
        // Create an attached property to the textbox in the WPF
        // The text box can only accept letters and symbols but no numbers
        // Use regex to parse
        public static bool GetAllowOnlyString(DependencyObject obj)
        {
            return (bool)obj.GetValue(AllowOnlyStringProperty);
        }

        public static void SetAllowOnlyString(DependencyObject obj, bool value)
        {
            obj.SetValue(AllowOnlyStringProperty, value);
        }


        // Using a DependencyProperty as the backing store for AllowOnlyString
        // This enables animation, resources, etc....
        public static readonly DependencyProperty AllowOnlyStringProperty =
            DependencyProperty.RegisterAttached("AllowOnlyString", typeof(bool), typeof(MainWindow), new PropertyMetadata(false, AllowOnlyString));

        private static void AllowOnlyString(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is TextBox)
            {
                TextBox obj = d as TextBox;
                obj.TextChanged += (s, arg) =>
                {
                    TextBox txt = s as TextBox;
                    if (!Regex.IsMatch(txt.Text, "^[a-zA-Z]*$"))
                    {
                        obj.BorderBrush = Brushes.Red;
                        MessageBox.Show("Only letters are allowed!");
                    }
                };
            }

        }
    }
}
