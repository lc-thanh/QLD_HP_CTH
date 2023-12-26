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
using QLD_HP_CTH.WindowGVPages;

namespace QLD_HP_CTH
{
    /// <summary>
    /// Interaction logic for WindowGV.xaml
    /// </summary>
    public partial class WindowGV : Window
    {
        public static WindowGV instance;
        public int maGV;
        public WindowGV(int maGV)
        {
            InitializeComponent();
            this.maGV = maGV;
            instance = this;
            Information.Content = new GVHomePage();
        }
        public void btnHome_Click(object sender, RoutedEventArgs e)
        {
            Information.Content = new GVHomePage();
        }
        public void btnBangDiem_Click(object sender, RoutedEventArgs e)
        {
            Information.Content = new GVBangDiemPage();
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var option = MessageBox.Show("Đóng cửa sổ","",MessageBoxButton.YesNo, MessageBoxImage.Question);
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
