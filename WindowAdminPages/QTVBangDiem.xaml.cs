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
    /// Interaction logic for QTVBangDiem.xaml
    /// </summary>
    public partial class QTVBangDiem : Page
    {
        
        public QTVBangDiem()
        {
            QldsvContext qldsvContext = new QldsvContext();
            InitializeComponent();
            var bangDiem = from bangdiem in qldsvContext.BangDiems
                           select bangdiem;
            dtgBang.ItemsSource = null;
            dtgBang.ItemsSource = bangDiem.ToList();
        }

        private void dtgBang_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            QldsvContext qldsvContext = new QldsvContext();
            var item = dtgBang.SelectedItem;
            if (item != null && (dtgBang.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text!="")
            {
                txtMaSV.Text = (dtgBang.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
                txtMaLop.Text = (dtgBang.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
                txtTX1.Text = (dtgBang.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text;
                txtTX2.Text = (dtgBang.SelectedCells[3].Column.GetCellContent(item) as TextBlock).Text;
                txtThi.Text = (dtgBang.SelectedCells[4].Column.GetCellContent(item) as TextBlock).Text;
                cbTTHoc.SelectedIndex = int.Parse((dtgBang.SelectedCells[5].Column.GetCellContent(item) as TextBlock).Text);
                cbTTThanhToan.SelectedIndex = int.Parse((dtgBang.SelectedCells[6].Column.GetCellContent(item) as TextBlock).Text);
            }
        }
        public void btnTimKiem_Click(object sender, EventArgs e)
        {
            QldsvContext qldsvContext = new QldsvContext();
            var diemMSV = from diemmsv in qldsvContext.BangDiems
                          where diemmsv.MaSv == long.Parse(txtMaSV.Text)
                          select diemmsv;
            dtgBang.ItemsSource = null;
            dtgBang.ItemsSource = diemMSV.ToList();
            
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            QldsvContext qldsvContext = new QldsvContext();
            var sinhVien = qldsvContext.SinhViens.SingleOrDefault(sinhvien => sinhvien.MaSv == long.Parse(txtMaSV.Text));
            if(sinhVien == null)
            {
                MessageBox.Show("Sinh viên "+txtMaSV.Text +" không tồn tại trong CSDL sinh viên","",MessageBoxButton.OK,MessageBoxImage.Error);
                return;
            }
            var lop = qldsvContext.Lops.SingleOrDefault(lop => lop.MaLop == int.Parse(txtMaLop.Text));
            if(lop == null)
            {
                MessageBox.Show("Lớp "+ txtMaLop.Text +" không tồn tại trong CSDL lớp","",MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            BangDiem newDiem = new BangDiem();
            newDiem.MaLop = int.Parse(txtMaLop.Text);
            newDiem.MaSv = long.Parse(txtMaSV.Text);
            if(txtTX1.Text == "")
            {
                newDiem.DiemTx1 = null;
            }
            else
            {
                newDiem.DiemTx1 = double.Parse(txtTX1.Text);
            }
            if (txtTX2.Text == "")
            {
                newDiem.DiemTx2 = null;
            }
            else
            {
                newDiem.DiemTx2 = double.Parse(txtTX2.Text);
            }
            if (txtThi.Text == "")
            {
                newDiem.DiemThi = null;
            }
            else
            {
                newDiem.DiemThi = double.Parse(txtThi.Text);
            }
            newDiem.TrangThaiHoc =short.Parse( cbTTHoc.SelectedIndex.ToString());
            newDiem.TrangThaiThanhToan = short.Parse(cbTTThanhToan.SelectedIndex.ToString());
            var option = MessageBox.Show("Xác nhận thêm","",MessageBoxButton.YesNo,MessageBoxImage.Question);
            if (option == MessageBoxResult.No)
            {
                return;
            }
            qldsvContext.BangDiems.Add(newDiem);
            qldsvContext.SaveChanges();
            var bangDiem = from bangdiem in qldsvContext.BangDiems
                           select bangdiem;
            dtgBang.ItemsSource = null;
            dtgBang.ItemsSource = bangDiem.ToList();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            QldsvContext qldsvContext = new QldsvContext();
            var suaDiem = qldsvContext.BangDiems.SingleOrDefault(suadiem => suadiem.MaSv == long.Parse(txtMaSV.Text) && suadiem.MaLop == int.Parse(txtMaLop.Text));
            if(suaDiem==null)
            {
                MessageBox.Show("Không tồn tại bản ghi này để sửa","",MessageBoxButton.OK,MessageBoxImage.Error);
                return;
            }
            var option = MessageBox.Show("Xác nhận sửa", "", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (option == MessageBoxResult.No)
            {
                return;
            }
            suaDiem.MaLop = int.Parse(txtMaLop.Text);
            suaDiem.MaSv = long.Parse(txtMaSV.Text);
            if (txtTX1.Text == "")
            {
                suaDiem.DiemTx1 = null;
            }
            else
            {
                suaDiem.DiemTx1 = double.Parse(txtTX1.Text);
            }
            if (txtTX2.Text == "")
            {
                suaDiem.DiemTx2 = null;
            }
            else
            {
                suaDiem.DiemTx2 = double.Parse(txtTX2.Text);
            }
            if (txtThi.Text == "")
            {
                suaDiem.DiemThi = null;
            }
            else
            {
                suaDiem.DiemThi = double.Parse(txtThi.Text);
            }
            suaDiem.TrangThaiThanhToan = short.Parse(cbTTThanhToan.SelectedIndex.ToString());
            suaDiem.TrangThaiHoc = short.Parse(cbTTHoc.SelectedIndex.ToString());
            qldsvContext.SaveChanges();
            var bangDiem = from bangdiem in qldsvContext.BangDiems
                           select bangdiem;
            dtgBang.ItemsSource = null;
            dtgBang.ItemsSource = bangDiem.ToList();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            QldsvContext qldsvContext = new QldsvContext();
            var xoaDiem = qldsvContext.BangDiems.SingleOrDefault(xoadiem => xoadiem.MaSv==long.Parse(txtMaSV.Text) && xoadiem.MaLop == int.Parse(txtMaLop.Text));
            if(xoaDiem == null)
            {
                MessageBox.Show("Không tồn tại bản ghi này để xóa", "", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            var option = MessageBox.Show("Xác nhận xóa", "", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (option == MessageBoxResult.No)
            {
                return;
            }
            qldsvContext.Remove(xoaDiem);
            qldsvContext.SaveChanges();
            var bangDiem = from bangdiem in qldsvContext.BangDiems
                           select bangdiem;
            dtgBang.ItemsSource = null;
            dtgBang.ItemsSource = bangDiem.ToList();
        }
    }
}
