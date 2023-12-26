using QLD_HP_CTH.DataModel;
using System;
using System.Collections.Generic;
using System.Data;
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
    /// Interaction logic for SVHocPhiPage.xaml
    /// </summary>
    public partial class SVHocPhiPage : Page
    {
        QldsvContext qldsvContext = new QldsvContext();
        public SVHocPhiPage()
        {
            int sum=0;
            InitializeComponent();
            var hocPhi = from hocphi in qldsvContext.BangDiems
                         where WindowSV.instance.maSV == hocphi.MaSv 
                         where hocphi.TrangThaiThanhToan == 0
                         select new {hocphi.MaLopNavigation.MaMonHoc,
                             TrangThaiThanhToan = hocphi.TrangThaiThanhToan==0?"Chưa thanh toán" : "Đã thanh toán",
                             hocphi.MaLopNavigation.MaMonHocNavigation.SoTinChi,
                             hocphi.MaLopNavigation.MaMonHocNavigation.TenMonHoc,
                             hocphi.MaLopNavigation.MaMonHocNavigation.SoTienMotTc,
                             sotienmon = hocphi.MaLopNavigation.MaMonHocNavigation.SoTinChi * hocphi.MaLopNavigation.MaMonHocNavigation.SoTienMotTc
                             };
            dtgHocPhi.ItemsSource = null;
            dtgHocPhi.ItemsSource = hocPhi.ToList();
            try
            {
              sum =Convert.ToInt32( hocPhi.Sum(data => data.sotienmon));
            }catch (Exception ex) { }
             txtTongNo.Text=sum.ToString();
        }
        public void btnXem_Click(object sender, EventArgs e)
        {
            if(cbTrangThai.Text == "Chưa thanh toán")
            {
                var hocPhi = from hocphi in qldsvContext.BangDiems
                             where WindowSV.instance.maSV == hocphi.MaSv
                             where hocphi.TrangThaiThanhToan == 0
                             select new {
                                 hocphi.MaLopNavigation.MaMonHoc,
                                 TrangThaiThanhToan = hocphi.TrangThaiThanhToan == 0 ? "Chưa thanh toán" : "Đã thanh toán",
                                 hocphi.MaLopNavigation.MaMonHocNavigation.SoTinChi,
                                 hocphi.MaLopNavigation.MaMonHocNavigation.TenMonHoc,
                                 hocphi.MaLopNavigation.MaMonHocNavigation.SoTienMotTc,
                                 sotienmon = hocphi.MaLopNavigation.MaMonHocNavigation.SoTinChi * hocphi.MaLopNavigation.MaMonHocNavigation.SoTienMotTc
                             };
                dtgHocPhi.ItemsSource = null;
                dtgHocPhi.ItemsSource = hocPhi.ToList();
            }
            if(cbTrangThai.Text=="Đã thanh toán")
            {
                var hocPhi = from hocphi in qldsvContext.BangDiems
                             where WindowSV.instance.maSV == hocphi.MaSv
                             where hocphi.TrangThaiThanhToan == 1
                             select new
                             {
                                 hocphi.MaLopNavigation.MaMonHoc,
                                 TrangThaiThanhToan = hocphi.TrangThaiThanhToan == 0 ? "Chưa thanh toán" : "Đã thanh toán",
                                 hocphi.MaLopNavigation.MaMonHocNavigation.SoTinChi,
                                 hocphi.MaLopNavigation.MaMonHocNavigation.TenMonHoc,
                                 hocphi.MaLopNavigation.MaMonHocNavigation.SoTienMotTc,
                                 sotienmon = hocphi.MaLopNavigation.MaMonHocNavigation.SoTinChi * hocphi.MaLopNavigation.MaMonHocNavigation.SoTienMotTc
                             };
                dtgHocPhi.ItemsSource = null;
                dtgHocPhi.ItemsSource = hocPhi.ToList();
            }
        }
    }
}
