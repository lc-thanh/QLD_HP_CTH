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

namespace QLD_HP_CTH.WindowSVPages
{
    /// <summary>
    /// Interaction logic for SVHomePage.xaml
    /// </summary>
    public partial class SVHomePage : Page
    {
        QldsvContext qldsvContext = new QldsvContext();
        private long maSV = WindowSV.instance.maSV;
        public SVHomePage()
        {
            InitializeComponent();
            var sinhVien = qldsvContext.SinhViens.SingleOrDefault(sinhvien => sinhvien.MaSv == maSV);
            txtMaSV.Text = Convert.ToString(maSV);
            txtHoTen.Text = sinhVien.HoTen;
            txtGioiTinh.Text = sinhVien.GioiTinh;
            txtNgaySinh.Text =((DateTime)sinhVien.NgaySinh).ToString("dd-MM-yyyy");
            txtDiaChi.Text = sinhVien.DiaChi;
            txtSDT.Text = sinhVien.SoDt;
        }
    }
}
