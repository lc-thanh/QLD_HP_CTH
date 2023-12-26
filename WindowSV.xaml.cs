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
using QLD_HP_CTH.WindowSVPages;

namespace QLD_HP_CTH
{
    /// <summary>
    /// Interaction logic for WindowSV.xaml
    /// </summary>
    public partial class WindowSV : Window
    {
        public static WindowSV instance { get; private set; }
        public long maSV { get; private set; }
        public WindowSV(long MSV)
        {
            InitializeComponent();
            instance = this;
            this.maSV = MSV;
            if(Information.Content == null)
            {
                Information.Content = new SVHomePage();
            }
            btnKhung.Visibility = Visibility.Collapsed;
            btnChiTiet.Visibility = Visibility.Collapsed;
        }
        public void btnHome_Click(object sender, RoutedEventArgs e)
        {
            btnKhung.Visibility = Visibility.Collapsed;
            btnChiTiet.Visibility = Visibility.Collapsed;
            Information.Content = new SVHomePage();
        }
        public void btnMonHoc_Click(object sender, RoutedEventArgs e)
        {
            btnKhung.Visibility = Visibility.Collapsed;
            btnChiTiet.Visibility = Visibility.Collapsed;
            Information.Content = new SVMonHocPage();
        }
        public void btnHocPhi_Click(object sender, RoutedEventArgs e)
        {
            btnKhung.Visibility = Visibility.Collapsed;
            btnChiTiet.Visibility = Visibility.Collapsed;
            Information.Content = new SVHocPhiPage();
        }
        public void btnBangDiem_Click(object sender, RoutedEventArgs e)
        {
            btnKhung.Visibility = Visibility.Collapsed;
            btnChiTiet.Visibility = Visibility.Collapsed;
            Information.Content=new SVBangDiemPage();
        }
        public void btnChuongTrinh_Click(object sender, RoutedEventArgs e)
        {
            Information.Content = null;
            btnKhung.Visibility = Visibility.Visible;
            btnChiTiet.Visibility = Visibility.Visible;
        }
        public void btnChiTiet_Click(object sender, RoutedEventArgs e)
        {
            Information.Content = new SVChiTietPage();
        }
        public void btnKhung_Click(object sender, RoutedEventArgs e)
        {
            Information.Content = new SVKhungPage();
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var option=MessageBox.Show("Đóng cửa sổ","",MessageBoxButton.YesNo, MessageBoxImage.Question);
            if(option == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Application.Current.MainWindow.Show();
            }
        }
    }
}
