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

namespace QLD_HP_CTH.WindowAdminPages
{
    /// <summary>
    /// Interaction logic for QTVMonHoc.xaml
    /// </summary>
    public partial class QTVMonHoc : Page
    {
        public QTVMonHoc()
        {
            InitializeComponent();
            QldsvContext qldsvContext = new QldsvContext();
            var dsMonHoc = from monhoc in qldsvContext.MonHocs
                           select monhoc;
            dtgBang.ItemsSource = null;
            dtgBang.ItemsSource = dsMonHoc.ToList();
        }

        private void dtgBang_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            var item = dtgBang.SelectedItem;
            if (item != null)
            {
                txtMa.Text = (dtgBang.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
                txtTen.Text = (dtgBang.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
                txtSoTC.Text = (dtgBang.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text;
                txtSoTien.Text = (dtgBang.SelectedCells[3].Column.GetCellContent(item) as TextBlock).Text;
                txtTX1.Text = (dtgBang.SelectedCells[4].Column.GetCellContent(item) as TextBlock).Text;
                txtTX2.Text = (dtgBang.SelectedCells[5].Column.GetCellContent(item) as TextBlock).Text;
                cbLoai.SelectedIndex = (dtgBang.SelectedCells[6].Column.GetCellContent(item) as TextBlock).Text == "daicuong" ? 0 : 1;
            }
        }
        public void btnTimKiem_Click(object sender, EventArgs e)
        {
            QldsvContext qldsvContext = new QldsvContext();
            var timKiem = qldsvContext.MonHocs.SingleOrDefault(timkiem => timkiem.MaMonHoc == int.Parse(txtMa.Text));
            if(timKiem == null)
            {
                MessageBox.Show("Không tìm thấy môn học "+txtMa.Text,"",MessageBoxButton.OK,MessageBoxImage.Error);
                return;
            }
            txtMa.Text = timKiem.MaMonHoc.ToString();
            txtTen.Text = timKiem.TenMonHoc;
            txtSoTC.Text = timKiem.SoTinChi.ToString();
            txtSoTien.Text = timKiem.SoTienMotTc.ToString();
            txtTX1.Text = timKiem.HeSoTx1.ToString();
            txtTX2.Text = timKiem.HeSoTx2.ToString();
            cbLoai.SelectedIndex = timKiem.Loai == "daicuong" ? 0 : 1;
        }
        public void btnThem_Click(object sender, EventArgs e)
        {
            QldsvContext qldsvContext = new QldsvContext();
            MonHoc newMonHoc = new MonHoc();
            if(qldsvContext.MonHocs.SingleOrDefault(monhoc => monhoc.MaMonHoc == int.Parse(txtMa.Text)) != null)
            {
                MessageBox.Show("Đã tồn tại môn học "+txtMa.Text+" không thể thêm mới","",MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            try
            {
                newMonHoc.MaMonHoc = int.Parse(txtMa.Text);
                newMonHoc.TenMonHoc = txtTen.Text;
                newMonHoc.SoTinChi = int.Parse(txtSoTC.Text);
                newMonHoc.SoTienMotTc = int.Parse(txtSoTien.Text);
                newMonHoc.HeSoTx1 = double.Parse(txtTX1.Text);
                newMonHoc.HeSoTx2 = double.Parse(txtTX2.Text);
                newMonHoc.Loai = cbLoai.SelectedIndex == 0 ? "daicuong" : "chuyennganh";
            }
            catch
            {
                MessageBox.Show("Lỗi","",MessageBoxButton.OK,MessageBoxImage.Error); 
                return;
            }
            qldsvContext.MonHocs.Add(newMonHoc);
            qldsvContext.SaveChanges();
            var dsMonHoc = from monhoc in qldsvContext.MonHocs
                           select monhoc;
            dtgBang.ItemsSource = null;
            dtgBang.ItemsSource = dsMonHoc.ToList();
        }
        public void btnSua_Click(object sender, EventArgs e)
        {
            QldsvContext qldsvContext = new QldsvContext();
            var suaMonHoc = qldsvContext.MonHocs.SingleOrDefault(monhoc => monhoc.MaMonHoc == int.Parse(txtMa.Text));
            if(suaMonHoc != null)
            {
                suaMonHoc.TenMonHoc = txtTen.Text;
                suaMonHoc.SoTinChi = int.Parse(txtSoTC.Text);
                suaMonHoc.SoTienMotTc = int.Parse(txtSoTien.Text);
                suaMonHoc.HeSoTx1 = double.Parse(txtTX1.Text);
                suaMonHoc.HeSoTx2 = double.Parse(txtTX2.Text);
                suaMonHoc.Loai = cbLoai.SelectedIndex == 0 ? "daicuong" : "chuyennganh";
                qldsvContext.SaveChanges();
                var dsMonHoc = from monhoc in qldsvContext.MonHocs
                               select monhoc;
                dtgBang.ItemsSource = null;
                dtgBang.ItemsSource = dsMonHoc.ToList();
            }
        }
        public void btnXoa_Click(object sender, EventArgs e)
        {
            QldsvContext qldsvContext = new QldsvContext();
            var xoaMonHoc = qldsvContext.MonHocs.SingleOrDefault(monhoc => monhoc.MaMonHoc == int.Parse(txtMa.Text));
            if(xoaMonHoc == null)
            {
                MessageBox.Show("Không tồn tại môn học "+txtMa.Text,"",MessageBoxButton.OK,MessageBoxImage.Error);
                return;
            }
            qldsvContext.Remove(xoaMonHoc);
            qldsvContext.SaveChanges();
            var dsMonHoc = from monhoc in qldsvContext.MonHocs
                           select monhoc;
            dtgBang.ItemsSource = null;
            dtgBang.ItemsSource = dsMonHoc.ToList();
        }
    }
}
