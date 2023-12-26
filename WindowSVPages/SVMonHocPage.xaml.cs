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
    /// Interaction logic for SVMonHocPage.xaml
    /// </summary>
    public partial class SVMonHocPage : Page
    {
        QldsvContext qldsvContext = new QldsvContext();
        public SVMonHocPage()
        {
            InitializeComponent();
            var dsMonHocSV = from monhocsv in qldsvContext.BangDiems
                            // join monhoc in qldsvContext.MonHocs on monhocsv.MaMonHoc equals monhoc.MaMonHoc
                           //  join lop in qldsvContext.Lops on monhocsv.MaLop equals lop.MaLop
                             join giangvien in qldsvContext.GiangViens on monhocsv.MaLopNavigation.MaGv equals giangvien.MaGv
                             where monhocsv.MaSv == WindowSV.instance.maSV
                             select new {monhocsv.MaLop,
                                 monhocsv.MaLopNavigation.MaMonHoc,
                                 monhocsv.MaLopNavigation.MaMonHocNavigation.TenMonHoc,
                                 giangvien.HoTen,
                                 TrangThaiHoc=monhocsv.TrangThaiHoc==0? "Đang học":"Đã hoàn thành",
                                 monhocsv.MaLopNavigation.ViTriLop};
            dtgMonHocSV.ItemsSource = null;
            dtgMonHocSV.ItemsSource = dsMonHocSV.ToList();
            
        }
    }
}
