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
using QLD_HP_CTH.DataModel;

namespace QLD_HP_CTH.WindowSVPages
{
    /// <summary>
    /// Interaction logic for SvDaiCuongControl.xaml
    /// </summary>
    public partial class SvDaiCuongControl : UserControl
    {
        QldsvContext qldsvContext = new QldsvContext();
        private long msv = WindowSV.instance.maSV;
        public SvDaiCuongControl()
        {
            InitializeComponent();
            string daiCuong = "daicuong";
            var sv = qldsvContext.SinhViens.SingleOrDefault(sv => sv.MaSv == msv);
            int maNganh = Convert.ToInt32(sv.MaNganh);
            var mon = from nganhMon in qldsvContext.NganhMonHocs
                          where nganhMon.MaNganh == maNganh
                          where nganhMon.MaMonHocNavigation.Loai == daiCuong
                          select new { nganhMon.MaMonHoc,nganhMon.MaMonHocNavigation.SoTinChi, nganhMon.MaMonHocNavigation.TenMonHoc };
            txtTongHP.Text = mon.Count().ToString();
            txtTinChi.Text = mon.Sum(monhoc => monhoc.SoTinChi).ToString();
            dtgDaiCuong.ItemsSource = null;
            dtgDaiCuong.ItemsSource = mon.ToList();
        }
    }
}
