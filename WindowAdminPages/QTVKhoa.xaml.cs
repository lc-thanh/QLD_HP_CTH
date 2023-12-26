using Microsoft.Identity.Client;
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

namespace QLD_HP_CTH.WindowAdminPages
{
    /// <summary>
    /// Interaction logic for QTVKhoa.xaml
    /// </summary>
    public partial class QTVKhoa : Page
    {
        public QTVKhoa()
        {
            InitializeComponent();
            QldsvContext qldsvContext = new QldsvContext();
            var dsKhoa = from khoa in qldsvContext.Khoas
                         select khoa;
            dtgBang.ItemsSource = null;
            dtgBang.ItemsSource = dsKhoa.ToList();
        }
        public void btnTimKiem_Click(object sender, RoutedEventArgs e)
        {
            QldsvContext qldsvContext = new QldsvContext();
            var timKhoa = qldsvContext.Khoas.SingleOrDefault(khoa => khoa.MaKhoa == int.Parse(txtMaKhoa.Text));
            if( timKhoa == null )
            {
                MessageBox.Show("Không tìm thấy mã khoa "+txtMaKhoa.Text,"",MessageBoxButton.OK, MessageBoxImage.Information );
                return;
            }
            txtMaKhoa.Text = timKhoa.MaKhoa.ToString();
            txtTenKhoa.Text = timKhoa.TenKhoa;
        }
        public void btnThem_Click(object sender, RoutedEventArgs e)
        {
            QldsvContext qldsvContext = new QldsvContext();
            var checkKhoa = qldsvContext.Khoas.SingleOrDefault(khoa => khoa.MaKhoa == int.Parse(txtMaKhoa.Text));
            if( checkKhoa != null )
            {
                MessageBox.Show("Khoa "+  txtMaKhoa.Text+" đã tồn tại không thể thêm","",MessageBoxButton.OK,MessageBoxImage.Error );
                return;
            }
            Khoa newKhoa = new Khoa();
            newKhoa.MaKhoa = int.Parse(txtMaKhoa.Text);
            newKhoa.TenKhoa = txtTenKhoa.Text;
            qldsvContext.Khoas.Add(newKhoa);
            qldsvContext.SaveChanges();
            var dsKhoa = from khoa in qldsvContext.Khoas
                         select khoa;
            dtgBang.ItemsSource = null;
            dtgBang.ItemsSource = dsKhoa.ToList();
        }
        public void btnSua_Click(object sender, RoutedEventArgs e)
        {
            QldsvContext qldsvContext = new QldsvContext();
            var suaKhoa = qldsvContext.Khoas.SingleOrDefault(khoa => khoa.MaKhoa == int.Parse(txtMaKhoa.Text));
            if(suaKhoa == null)
            {
                MessageBox.Show("Khoa " + txtMaKhoa.Text + " đã tồn tại không thể sửa", "", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            suaKhoa.TenKhoa = txtTenKhoa.Text;
            qldsvContext.SaveChanges();
            var dsKhoa = from khoa in qldsvContext.Khoas
                         select khoa;
            dtgBang.ItemsSource = null;
            dtgBang.ItemsSource = dsKhoa.ToList();
        }
        public void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            QldsvContext qldsvContext = new QldsvContext();
            var xoaKhoa = qldsvContext.Khoas.SingleOrDefault(khoa => khoa.MaKhoa == int.Parse(txtMaKhoa.Text));
            if (xoaKhoa == null)
            {
                MessageBox.Show("Khoa " + txtMaKhoa.Text + " không tồn tại không thể xóa", "", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            qldsvContext.Khoas.Remove(xoaKhoa);
            qldsvContext.SaveChanges();
            var dsKhoa = from khoa in qldsvContext.Khoas
                         select khoa;
            dtgBang.ItemsSource = null;
            dtgBang.ItemsSource = dsKhoa.ToList();
        }

        private void DataGrid_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            var item = dtgBang.SelectedItem;
            if( item != null )
            {
                txtMaKhoa.Text = (dtgBang.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
                txtTenKhoa.Text = (dtgBang.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
            }
        }
    }
}
