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
    /// Interaction logic for GVLogin.xaml
    /// </summary>
    public partial class GVLogin : Page
    {
        public GVLogin()
        {
            InitializeComponent();
        }
        private bool checkInput()
        {
            if (txtMaGV.Text == "")
            {
                MessageBox.Show("Mã giảng viên không được trống","",MessageBoxButton.OK,MessageBoxImage.Error);
                return false;
            }
            try
            {
                int.Parse(txtMaGV.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sai thông tin đăng nhập", "", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (txtMatKhauGV.Text == "")
            {
                MessageBox.Show("Mật khẩu không được trống", "", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            return true;
        }
        public void dngv_Click(object sender, RoutedEventArgs e)
        {
            if(checkInput())
            {
                QldsvContext qldsvContext = new QldsvContext();

                var giangVien = qldsvContext.GiangViens.SingleOrDefault(giangvien => giangvien.MaGv==int.Parse( txtMaGV.Text));
                
                if(giangVien != null)
                {
                    if(giangVien.MatKhau == txtMatKhauGV.Text)
                    {
                        if(MessageBox.Show("Đăng nhập thành công", "", MessageBoxButton.OK) == MessageBoxResult.OK)
                        {
                            Application.Current.MainWindow.Hide();
                            WindowGV windowGV = new WindowGV(giangVien.MaGv);
                            windowGV.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Thông tin đăng nhập không chính xác", "", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Thông tin đăng nhập không chính xác", "", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
    
}
