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

namespace QLD_HP_CTH.WindowGVPages
{
    /// <summary>
    /// Interaction logic for GVHomePage.xaml
    /// </summary>
    public partial class GVHomePage : Page
    {
        QldsvContext qldsvContext = new QldsvContext();
        public GVHomePage()
        {
            InitializeComponent();
            var giangVien = qldsvContext.GiangViens.SingleOrDefault(giangvien => giangvien.MaGv == WindowGV.instance.maGV);
            txtHoTen.Text = giangVien.HoTen;
            txtMaGV.Text = giangVien.MaGv.ToString();
            txtDiaChi.Text = giangVien.DiaChi;
            txtGioiTinh.Text = giangVien.GioiTinh;
            txtSDT.Text = giangVien.SoDt;
            txtNgaySinh.Text = ((DateTime)giangVien.NgaySinh).ToString("dd-MM-yyyy");
        }
    }
}
