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
    /// Interaction logic for SVChiTietPage.xaml
    /// </summary>
    public partial class SVChiTietPage : Page
    {
        QldsvContext qldsvContext = new QldsvContext();
        public SVChiTietPage()
        {
            InitializeComponent();
            var chiTiet = (from chitiet in qldsvContext.SinhViens
                          where chitiet.MaSv == WindowSV.instance.maSV
                          select new
                          {
                              chitiet.MaNganh,
                              chitiet.MaNganhNavigation.MaKhoaNavigation.TenKhoa,
                              chitiet.MaNganhNavigation.TenNganh,
                              chitiet.MaNganhNavigation.HeDaoTao,
                              chitiet.MaNganhNavigation.ThoiGianDaoTao,
                              chitiet.MaNganhNavigation.LoaiHinhDaoTao
                          }).SingleOrDefault();
            txtTenKhoa.Text = chiTiet.TenKhoa;
            txtHeDaoTao.Text = chiTiet.HeDaoTao;
            txtTenNganh.Text = chiTiet.TenNganh;
            txtMaNganh.Text = chiTiet.MaNganh.ToString();
            txtThoiGian.Text = chiTiet.ThoiGianDaoTao.ToString() + " năm";
            txtLoaiHinh.Text = chiTiet.LoaiHinhDaoTao;
            var khoiLuong = from khoiluong in qldsvContext.NganhMonHocs
                            where chiTiet.MaNganh == khoiluong.MaNganh
                            select khoiluong.MaMonHocNavigation.SoTinChi;
            txtKhoiLuong.Text = khoiLuong.Sum().ToString() + " tín chỉ";
            //Mục tiêu đào tạo
            var mucTieu = (from muctieu in qldsvContext.SinhViens
                           where muctieu.MaSv == WindowSV.instance.maSV
                           select new {
                                muctieu.MaNganhNavigation.Peo1,
                               muctieu.MaNganhNavigation.Peo2,
                               muctieu.MaNganhNavigation.Peo3,
                               muctieu.MaNganhNavigation.Peo4,
                               muctieu.MaNganhNavigation.Peo5
                           }).SingleOrDefault();
            tbPEO1.Text = mucTieu.Peo1;
            tbPEO2.Text = mucTieu.Peo2;
            tbPEO3.Text = mucTieu.Peo3;
            tbPEO4.Text = mucTieu.Peo4;
            tbPEO5.Text = mucTieu.Peo5;
        }
    }
}
