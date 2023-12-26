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
    /// Interaction logic for SVChuyenNganhControl.xaml
    /// </summary>
    public partial class SVChuyenNganhControl : UserControl
    {
        QldsvContext qldsvContext = new QldsvContext();
        public SVChuyenNganhControl()
        {
            string chuyenNganh = "chuyennganh";
            InitializeComponent();
            long msv = WindowSV.instance.maSV;
            var sinhVien = qldsvContext.SinhViens.SingleOrDefault(sinhvien => sinhvien.MaSv == msv);
            int maNganh =Convert.ToInt32( sinhVien.MaNganh);
            var mon = from nganhMon in qldsvContext.NganhMonHocs
                      where nganhMon.MaNganh == maNganh
                      where nganhMon.MaMonHocNavigation.Loai == chuyenNganh
                      select new {nganhMon.MaMonHoc,nganhMon.MaMonHocNavigation.TenMonHoc,nganhMon.MaMonHocNavigation.SoTinChi };
            txtTongHP.Text = mon.Count().ToString();
            txtTinChi.Text = mon.Sum(mon => mon.SoTinChi).ToString();
            dtgChuyenNganh.ItemsSource = null;
            dtgChuyenNganh.ItemsSource = mon.ToList();
        }
    }
}
