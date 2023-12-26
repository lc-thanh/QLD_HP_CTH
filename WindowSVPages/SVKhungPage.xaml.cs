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

namespace QLD_HP_CTH.WindowSVPages
{
    /// <summary>
    /// Interaction logic for SVKhungPage.xaml
    /// </summary>
    public partial class SVKhungPage : Page
    {
        public SVKhungPage()
        {
            InitializeComponent();
        }
        public void btnDaiCuong_Click(object sender, RoutedEventArgs e)
        {
            UCChuyenNganh.Visibility = Visibility.Collapsed;
            UCDaiCuong.Visibility = Visibility.Visible;
        }
        public void btnChuyenNganh_Click(object sender, RoutedEventArgs e)
        {
            UCChuyenNganh.Visibility = Visibility.Visible;
            UCDaiCuong.Visibility = Visibility.Collapsed;
        }
    }
}
