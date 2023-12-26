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
using System.Windows.Shapes;
using QLD_HP_CTH.WindowAdminPages;

namespace QLD_HP_CTH
{
    /// <summary>
    /// Interaction logic for WindowAdmin.xaml
    /// </summary>
    public partial class WindowAdmin : Window
    {
        public WindowAdmin()
        {
            InitializeComponent();
        }
        private void btnMonHoc_Click(object sender, RoutedEventArgs e)
        {
            Information.Content = new QTVMonHoc();
        }
        private void btnNganh_Click(object sender, RoutedEventArgs e)
        {
            Information.Content = new QTVNganh();
        }
        private void btnNganhMon_Click(object sender, RoutedEventArgs e)
        {
            Information.Content = new QTVNganhMon();
        }
        private void btnBangDiem_Click(object sender, RoutedEventArgs e)
        {
            Information.Content = new QTVBangDiem();
        }
        private void btnKhoa_Click(object sender, RoutedEventArgs e)
        {
            Information.Content = new QTVKhoa();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var option = MessageBox.Show("Xác nhận đóng","",MessageBoxButton.YesNo, MessageBoxImage.Question);
            if(option == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
            Application.Current.MainWindow.Show();
        }
    }
}
