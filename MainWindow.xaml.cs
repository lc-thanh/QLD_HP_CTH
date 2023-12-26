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

namespace QLD_HP_CTH
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            login.Content = new GVLogin();
        }
        private void btnSinhVien_Click(object sender, RoutedEventArgs e)
        {
            login.Content = new SVLogin();
        }
        private void btnGiangVien_Click(object sender, RoutedEventArgs e)
        {
            login.Content = new GVLogin();
        }
        private void btnQuanTriVien_Click(Object sender, RoutedEventArgs e)
        {
            login.Content = new AdminLogin();
        }
    }
    
}
