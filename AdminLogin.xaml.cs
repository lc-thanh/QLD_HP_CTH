using QLD_HP_CTH.DataModel;
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
    /// Interaction logic for AdminLogin.xaml
    /// </summary>
    public partial class AdminLogin : Page
    {
        QldsvContext qldsvContext = new QldsvContext();
        public AdminLogin()
        {
            InitializeComponent();
            
        }
        private bool checkInput()
        {
            if (txtTaiKhoan.Text == "")
            {
                MessageBox.Show("Tài khoản không được để trống", "", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Mật khẩu không được để trống", "", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            return true;
        }
        private void dangNhapQTV_Click(object sender, RoutedEventArgs e)
        {
            if (checkInput())
            {
                var QTV = (from qtv in qldsvContext.AdminTaiKhoans
                          where qtv.TaiKhoan == txtTaiKhoan.Text
                          where qtv.MatKhau == txtMatKhau.Text
                          select qtv).SingleOrDefault();
                if(QTV != null)
                { 
                    WindowAdmin qtvWindow = new WindowAdmin();
                    qtvWindow.Show();
                    Application.Current.MainWindow.Hide();
                   
                }
                else
                {
                    MessageBox.Show("Sai thông tin đăng nhập","",MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
