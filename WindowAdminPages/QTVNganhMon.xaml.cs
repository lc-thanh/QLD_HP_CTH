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
    /// Interaction logic for QTVNganhMon.xaml
    /// </summary>
    public partial class QTVNganhMon : Page
    {
        public QTVNganhMon()
        {
            InitializeComponent();
            QldsvContext qldsvContext = new QldsvContext();
            var dsMonNganh = from ds in qldsvContext.NganhMonHocs
                             select ds;
            dtgBang.ItemsSource = null;
            dtgBang.ItemsSource = dsMonNganh.ToList();
        }
        public void btnTimKiem_Click(object sender, RoutedEventArgs e)
        {
            QldsvContext qldsvContext = new QldsvContext();
            var timNganhMon = from ds in qldsvContext.NganhMonHocs
                              where ds.MaNganh == int.Parse(txtMaNganh.Text)
                             select ds;
            if (timNganhMon == null)
            {
                MessageBox.Show("Không tìm thấy ", "", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            dtgBang.ItemsSource = null;
            dtgBang.ItemsSource = timNganhMon.ToList();
        }
        public void btnThem_Click(object sender, RoutedEventArgs e)
        {
            QldsvContext qldsvContext = new QldsvContext();
            var check = qldsvContext.NganhMonHocs.SingleOrDefault(nganhmon => nganhmon.MaNganh == int.Parse(txtMaNganh.Text) && nganhmon.MaMonHoc == int.Parse(txtMaMon.Text));
            if (check != null)
            {
                MessageBox.Show(" Đã tồn tại không thể thêm", "", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (qldsvContext.Nganhs.SingleOrDefault(nganh => nganh.MaNganh == int.Parse(txtMaNganh.Text)) == null)
            {
                MessageBox.Show(" Ngành" + txtMaNganh.Text + " không tồn tại", "", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (qldsvContext.MonHocs.SingleOrDefault(monhoc => monhoc.MaMonHoc == int.Parse(txtMaMon.Text)) == null)
            {
                MessageBox.Show(" Môn học" + txtMaMon.Text+" không tồn tại", "", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            NganhMonHoc newNganhMon = new NganhMonHoc();
            newNganhMon.MaNganh = int.Parse(txtMaNganh.Text);
            newNganhMon.MaMonHoc = int.Parse(txtMaMon.Text);
            qldsvContext.NganhMonHocs.Add(newNganhMon);
            qldsvContext.SaveChanges();
            var dsMonNganh = from ds in qldsvContext.NganhMonHocs
                             select ds;
            dtgBang.ItemsSource = null;
            dtgBang.ItemsSource = dsMonNganh.ToList();
        }
        public void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            QldsvContext qldsvContext = new QldsvContext();
            var xoaNganhMon = qldsvContext.NganhMonHocs.SingleOrDefault(nganhmon => nganhmon.MaNganh == int.Parse(txtMaNganh.Text) && nganhmon.MaMonHoc == int.Parse(txtMaMon.Text));
            if (xoaNganhMon == null)
            {
                MessageBox.Show("Không tồn tại không thể xóa", "", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            qldsvContext.NganhMonHocs.Remove(xoaNganhMon);
            qldsvContext.SaveChanges();
            var dsMonNganh = from ds in qldsvContext.NganhMonHocs
                             select ds;
            dtgBang.ItemsSource = null;
            dtgBang.ItemsSource = dsMonNganh.ToList();
        }

        private void DataGrid_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            var item = dtgBang.SelectedItem;
            if (item != null)
            {
                txtMaNganh.Text = (dtgBang.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
                txtMaMon.Text = (dtgBang.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
            }
        }
    }
}
