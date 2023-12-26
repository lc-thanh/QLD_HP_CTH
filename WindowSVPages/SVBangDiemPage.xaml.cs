using QLD_HP_CTH.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation;
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
    /// Interaction logic for SVBangDiemPage.xaml
    /// </summary>
    public partial class SVBangDiemPage : Page
    {
        QldsvContext qldsvContext = new QldsvContext();
        public SVBangDiemPage()
        {
            InitializeComponent();
            var bangDiem = from bangdiem in qldsvContext.BangDiems
                           where bangdiem.TrangThaiHoc == 0
                           where WindowSV.instance.maSV == bangdiem.MaSv
                           select new
                           {
                               bangdiem.MaLopNavigation.MaMonHoc,
                               bangdiem.MaLopNavigation.MaMonHocNavigation.TenMonHoc,
                               bangdiem.MaLopNavigation.MaMonHocNavigation.SoTinChi,
                               bangdiem.DiemTx1,
                               bangdiem.DiemTx2,
                               bangdiem.DiemThi,
                               TrangThaiHoc=bangdiem.TrangThaiHoc==0? "Đang học":"Đã hoàn thành",
                               DiemTongKet = bangdiem.DiemThi
                           };
            dtgBangDiem.ItemsSource = null;
            dtgBangDiem.ItemsSource = bangDiem.ToList();
            var tcDaHoc = from tcdahoc in qldsvContext.BangDiems
                          where WindowSV.instance.maSV == tcdahoc.MaSv
                          where tcdahoc.TrangThaiHoc == 1
                          select tcdahoc.MaLopNavigation.MaMonHocNavigation.SoTinChi;
            txtSoTCDaHoc.Text = tcDaHoc.Sum().ToString();
        }
        public void btnXem_Click(object sender, RoutedEventArgs e)
        {
            if(cbTrangThai.Text == "đang học")
            {
                var bangDiem = from bangdiem in qldsvContext.BangDiems
                               where bangdiem.TrangThaiHoc == 0
                               where WindowSV.instance.maSV == bangdiem.MaSv
                               select new
                               {
                                   bangdiem.MaLopNavigation.MaMonHoc,
                                   bangdiem.MaLopNavigation.MaMonHocNavigation.TenMonHoc,
                                   bangdiem.MaLopNavigation.MaMonHocNavigation.SoTinChi,
                                   bangdiem.DiemTx1,
                                   bangdiem.DiemTx2,
                                   bangdiem.DiemThi,
                                   TrangThaiHoc = bangdiem.TrangThaiHoc == 0 ? "Đang học" : "Đã hoàn thành",
                                   DiemTongKet=bangdiem.DiemThi
                               };
                dtgBangDiem.ItemsSource = null;
                dtgBangDiem.ItemsSource = bangDiem.ToList();
            }
            if (cbTrangThai.Text == "đã hoàn thành")
            {
                var bangDiem = from bangdiem in qldsvContext.BangDiems
                               where bangdiem.TrangThaiHoc == 1
                               where WindowSV.instance.maSV == bangdiem.MaSv
                               select new
                               {
                                   bangdiem.MaLopNavigation.MaMonHoc,
                                   bangdiem.MaLopNavigation.MaMonHocNavigation.TenMonHoc,
                                   bangdiem.MaLopNavigation.MaMonHocNavigation.SoTinChi,
                                   bangdiem.DiemTx1,
                                   bangdiem.DiemTx2,
                                   bangdiem.DiemThi,
                                   TrangThaiHoc = bangdiem.TrangThaiHoc == 0 ? "Đang học" : "Đã hoàn thành",
                                   DiemTongKet = bangdiem.DiemTx1*bangdiem.MaLopNavigation.MaMonHocNavigation.HeSoTx1+bangdiem.DiemTx2*bangdiem.MaLopNavigation.MaMonHocNavigation.HeSoTx2+bangdiem.DiemThi*(1.0-bangdiem.MaLopNavigation.MaMonHocNavigation.HeSoTx1-bangdiem.MaLopNavigation.MaMonHocNavigation.HeSoTx2)
                               };
                dtgBangDiem.ItemsSource = null;
                dtgBangDiem.ItemsSource = bangDiem.ToList();
            }
        }
    }
}
