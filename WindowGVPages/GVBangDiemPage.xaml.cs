using QLD_HP_CTH.DataModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
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

namespace QLD_HP_CTH.WindowGVPages
{
    /// <summary>
    /// Interaction logic for GVBangDiemPage.xaml
    /// </summary>
    public partial class GVBangDiemPage : Page
    {
        public GVBangDiemPage()
        {

            QldsvContext qldsvContext = new QldsvContext();
            InitializeComponent();
            var dsLop = from lop in qldsvContext.Lops
                        where lop.MaGv == WindowGV.instance.maGV
                        select lop.MaLop;
            foreach (var lop in dsLop)
            {
                cbDsLop.Items.Add(lop.ToString());
            }
            txtTX1.IsReadOnly = true;
            txtTX2.IsReadOnly = true;
            txtDiemThi.IsReadOnly = true;
            txtDiemThi.BorderThickness = new Thickness(0);
            txtTX2.BorderThickness = new Thickness(0);
            txtTX1.BorderThickness = new Thickness(0);
            txtTX1.Background = new SolidColorBrush(Colors.Silver);
            txtTX2.Background = new SolidColorBrush(Colors.Silver);
            txtDiemThi.Background = new SolidColorBrush(Colors.Silver);
            btnLuu.Visibility = Visibility.Collapsed;

        }
        public void btnXem_Click(object sender, RoutedEventArgs e)
        {

            QldsvContext qldsvContext = new QldsvContext();
            if (cbDsLop.SelectedItem != null)
            {
                var dsSV = from sinhvien in qldsvContext.BangDiems
                           where sinhvien.MaLop == int.Parse(cbDsLop.Text)
                           select new
                           {
                               sinhvien.MaLopNavigation.MaMonHocNavigation.TenMonHoc,
                               sinhvien.MaSv,
                               sinhvien.MaSvNavigation.HoTen,
                               sinhvien.DiemTx1,
                               sinhvien.DiemTx2,
                               sinhvien.DiemThi
                           };
                foreach (var sv in dsSV)
                {
                    txtTenMon.Text = sv.TenMonHoc;
                    break;
                }
                dtgDanhSach.ItemsSource = null;
                dtgDanhSach.ItemsSource = dsSV.ToList();
            }
        }
        public void btnThongThuong_Click(object sender, RoutedEventArgs e)
        {
            txtTX1.IsReadOnly = true;
            txtTX2.IsReadOnly = true;
            txtDiemThi.IsReadOnly = true;
            txtDiemThi.BorderThickness = new Thickness(0);
            txtTX2.BorderThickness = new Thickness(0);
            txtTX1.BorderThickness = new Thickness(0);
            txtTX1.Background = new SolidColorBrush(Colors.Silver);
            txtTX2.Background = new SolidColorBrush(Colors.Silver);
            txtDiemThi.Background = new SolidColorBrush(Colors.Silver);
            btnLuu.Visibility = Visibility.Collapsed;
        }
        public void btnNhapDiem_Click(object sender, RoutedEventArgs e)
        {
            txtTX1.IsReadOnly = false;
            txtTX2.IsReadOnly = false;
            txtDiemThi.IsReadOnly = false;
            txtDiemThi.BorderThickness = new Thickness(2);
            txtTX2.BorderThickness = new Thickness(2);
            txtTX1.BorderThickness = new Thickness(2);
            txtTX1.Background = new SolidColorBrush(Colors.White);
            txtTX2.Background = new SolidColorBrush(Colors.White);
            txtDiemThi.Background = new SolidColorBrush(Colors.White);
            btnLuu.Visibility = Visibility.Visible;
        }
        public void btnTimKiem_Click(object sender, RoutedEventArgs e)
        {
            QldsvContext qldsvContext = new QldsvContext();
            if (txtMaSV.Text != "")
            {
                var sinhVien = (from sinhvien in qldsvContext.BangDiems
                                where sinhvien.MaSv == int.Parse(txtMaSV.Text)
                                where sinhvien.MaLop == int.Parse(cbDsLop.Text)
                                select new
                                {
                                    sinhvien.DiemTx1,
                                    sinhvien.DiemTx2,
                                    sinhvien.DiemThi
                                }).SingleOrDefault();
                if (sinhVien != null)
                {
                    txtTX1.Text = sinhVien.DiemTx1.ToString();
                    txtTX2.Text = sinhVien.DiemTx2.ToString();
                    txtDiemThi.Text = sinhVien.DiemThi.ToString();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sinh viên trong lớp này", "", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }

        }
        public void btnLuu_Click(object sender, RoutedEventArgs e)
        {
            QldsvContext qldsvContext = new QldsvContext();

            try
            {

                if (txtMaSV.Text != "")
                {

                    var xacNhanLuu = MessageBox.Show("Xác nhận lưu thay đổi", "", MessageBoxButton.YesNo, MessageBoxImage.Question);
                    if (xacNhanLuu == MessageBoxResult.Yes)
                    {
                        
                        long msv = long.Parse(txtMaSV.Text);
                        var sinhVien = qldsvContext.BangDiems.SingleOrDefault(sinhvien => sinhvien.MaLop ==int.Parse( cbDsLop.Text) && sinhvien.MaSv == msv);
                        try
                        {
                            if (txtTX1.Text != "" && sinhVien != null)
                            {
                                sinhVien.DiemTx1 = double.Parse(txtTX1.Text);
                                if (sinhVien.DiemTx1 < 0 || sinhVien.DiemTx1 > 10) throw new Exception();
                            }
                            if (txtTX2.Text != "" && sinhVien != null)
                            {
                                sinhVien.DiemTx2 = double.Parse(txtTX2.Text);
                                if (sinhVien.DiemTx2 < 0 || sinhVien.DiemTx2 > 10) throw new Exception();
                            }
                            if (txtDiemThi.Text != "" && sinhVien != null)
                            {
                                sinhVien.DiemThi = double.Parse(txtDiemThi.Text);
                                if (sinhVien.DiemThi < 0 || sinhVien.DiemThi > 10) throw new Exception();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi nhập dữ liệu ", "", MessageBoxButton.OK, MessageBoxImage.Error);
                            return;
                        }
                        
                        qldsvContext.SaveChanges();
                        var dsSV = from sinhvien in qldsvContext.BangDiems
                                   where sinhvien.MaLop == int.Parse(cbDsLop.Text)
                                   select new
                                   {
                                       sinhvien.MaLopNavigation.MaMonHocNavigation.TenMonHoc,
                                       sinhvien.MaSv,
                                       sinhvien.MaSvNavigation.HoTen,
                                       sinhvien.DiemTx1,
                                       sinhvien.DiemTx2,
                                       sinhvien.DiemThi
                                   };
                        dtgDanhSach.ItemsSource = null;
                        dtgDanhSach.ItemsSource = dsSV.ToList();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ", "", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void dtgDanhSach_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            var item = dtgDanhSach.SelectedItem;
            if (item != null)
            {
                txtMaSV.Text = (dtgDanhSach.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
                txtTX1.Text = (dtgDanhSach.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text;
                txtTX2.Text = (dtgDanhSach.SelectedCells[3].Column.GetCellContent(item) as TextBlock).Text;
                txtDiemThi.Text = (dtgDanhSach.SelectedCells[4].Column.GetCellContent(item) as TextBlock).Text;
            }
        }
    }
}
