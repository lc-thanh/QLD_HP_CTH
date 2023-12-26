using Microsoft.EntityFrameworkCore;
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
    /// Interaction logic for SVLogin.xaml
    /// </summary>
    public partial class SVLogin : Page
    {
        public SVLogin()
        {
            InitializeComponent();
        }
        private bool checkInput()
        {
            if (txtMaSV.Text == "")
            {
                MessageBox.Show("Mã sinh viên không được để trống","",MessageBoxButton.OK,MessageBoxImage.Error);
                return false;
            }
            try
            {
                int.Parse(txtMaSV.Text);
            }catch (Exception ex)
            {
                MessageBox.Show("Sai thông tin đăng nhập", "", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (txtMatKhauSV.Text == "")
            {
                MessageBox.Show("Mật khẩu không được để trống", "", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            return true;
        }
        public void svdn_Click(object sender, RoutedEventArgs e)
        {
           
            if (checkInput())
            {
                QldsvContext qldsvContext = new QldsvContext();
                var sinhVien = qldsvContext.SinhViens.SingleOrDefault(sinhvien => sinhvien.MaSv ==long.Parse(txtMaSV.Text));
                if (sinhVien != null)
                {
                    if(sinhVien.MatKhau == txtMatKhauSV.Text)
                    {
                        if(MessageBox.Show("Đăng nhập thành công", "", MessageBoxButton.OK) == MessageBoxResult.OK)
                        {
                            Application.Current.MainWindow.Hide();
                            WindowSV windowSV = new WindowSV(sinhVien.MaSv);
                            windowSV.Show();
                            
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
