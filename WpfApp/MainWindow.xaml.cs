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

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (sender == TeacherRadioButton)
            {
                TeacherControl.Visibility = Visibility.Visible;
                StudentControl.Visibility = Visibility.Collapsed;
            }
            else if (sender == StudentRadioButton)
            {
                StudentControl.Visibility = Visibility.Visible;
                TeacherControl.Visibility = Visibility.Collapsed;
            }
        }

        private void TeacherRadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
