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
    /// Interaction logic for QTVNganh.xaml
    /// </summary>
    public partial class QTVNganh : Page
    {
        public QTVNganh()
        {
            InitializeComponent();
            QldsvContext qldsvContext = new QldsvContext();
            var dsNganh = from nganh in qldsvContext.Nganhs
                          select nganh;
            dtgBang.ItemsSource = null;
            dtgBang.ItemsSource = dsNganh.ToList();
        }
        private void dtgBang_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            QldsvContext qldsvContext = new QldsvContext();
            var item = dtgBang.SelectedItem;
            if (item != null)
            {
                txtMaNganh.Text = (dtgBang.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
                txtMaKhoa.Text = (dtgBang.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
                txtTenNganh.Text = (dtgBang.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text;
                txtHeDaoTao.Text = (dtgBang.SelectedCells[3].Column.GetCellContent(item) as TextBlock).Text;
                txtThoiGian.Text = (dtgBang.SelectedCells[4].Column.GetCellContent(item) as TextBlock).Text;
                txtLoaiHinh.Text = (dtgBang.SelectedCells[5].Column.GetCellContent(item) as TextBlock).Text;
                if(txtMaNganh.Text != "")
                {
                    var nganh = qldsvContext.Nganhs.SingleOrDefault(nganh => nganh.MaNganh == int.Parse(txtMaNganh.Text));
                    tbPEO1.Text = nganh.Peo1;
                    tbPEO2.Text = nganh.Peo2;
                    tbPEO3.Text = nganh.Peo3;
                    tbPEO4.Text = nganh.Peo4;
                    tbPEO5.Text = nganh.Peo5;
                }
            }
        }
        public void btnTimKiem_Click(object sender, EventArgs e)
        {
            QldsvContext qldsvContext = new QldsvContext();
            var timKiem = qldsvContext.Nganhs.SingleOrDefault(timkiem => timkiem.MaNganh == int.Parse(txtMaNganh.Text));
            if (timKiem == null)
            {
                MessageBox.Show("Không tìm thấy ngành " + txtMaNganh.Text, "", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            txtMaNganh.Text = timKiem.MaNganh.ToString();
            txtMaKhoa.Text = timKiem.MaKhoa.ToString();
            txtTenNganh.Text = timKiem.TenNganh.ToString();
            txtHeDaoTao.Text = timKiem.HeDaoTao;
            txtThoiGian.Text = timKiem.ThoiGianDaoTao.ToString();
            txtLoaiHinh.Text = timKiem.LoaiHinhDaoTao.ToString();
                tbPEO1.Text = timKiem.Peo1;
                tbPEO2.Text = timKiem.Peo2;
                tbPEO3.Text = timKiem.Peo3;
                tbPEO4.Text = timKiem.Peo4;
                tbPEO5.Text = timKiem.Peo5;
        }
        public void btnThem_Click(object sender, EventArgs e)
        {
            QldsvContext qldsvContext = new QldsvContext();
            Nganh newNganh = new Nganh();
            if (qldsvContext.Nganhs.SingleOrDefault(nganh => nganh.MaNganh == int.Parse(txtMaNganh.Text)) != null)
            {
                MessageBox.Show("Đã tồn tại ngành " + txtMaNganh.Text + " không thể thêm mới", "", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            try
            {
                newNganh.MaNganh = int.Parse(txtMaNganh.Text);
                newNganh.MaKhoa = int.Parse(txtMaKhoa.Text);
                newNganh.TenNganh = txtTenNganh.Text;
                newNganh.HeDaoTao = txtHeDaoTao.Text;
                newNganh.ThoiGianDaoTao = int.Parse(txtThoiGian.Text);
                newNganh.LoaiHinhDaoTao = txtLoaiHinh.Text;
                newNganh.Peo1 = tbPEO1.Text;
                newNganh.Peo2 = tbPEO2.Text;
                newNganh.Peo3 = tbPEO3.Text;
                newNganh.Peo4 = tbPEO4.Text;
                newNganh.Peo5 = tbPEO5.Text;

            }
            catch
            {
                MessageBox.Show("Lỗi", "", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            qldsvContext.Nganhs.Add(newNganh);
            qldsvContext.SaveChanges();
            var dsNganh = from nganh in qldsvContext.Nganhs
                          select nganh;
            dtgBang.ItemsSource = null;
            dtgBang.ItemsSource = dsNganh.ToList();
        }
        public void btnSua_Click(object sender, EventArgs e)
        {
            QldsvContext qldsvContext = new QldsvContext();
            var suaNganh = qldsvContext.Nganhs.SingleOrDefault(nganh => nganh.MaNganh == int.Parse(txtMaNganh.Text));
            if (suaNganh != null)
            {
                suaNganh.MaKhoa = int.Parse(txtMaKhoa.Text);
                suaNganh.TenNganh = txtTenNganh.Text;
                suaNganh.HeDaoTao = txtHeDaoTao.Text;
                suaNganh.ThoiGianDaoTao = int.Parse(txtThoiGian.Text);
                suaNganh.LoaiHinhDaoTao = txtLoaiHinh.Text;
                suaNganh.Peo1 = tbPEO1.Text;
                suaNganh.Peo2 = tbPEO2.Text;
                suaNganh.Peo3 = tbPEO3.Text;
                suaNganh.Peo4 = tbPEO4.Text;
                suaNganh.Peo5 = tbPEO5.Text;
                qldsvContext.SaveChanges();
                var dsNganh = from nganh in qldsvContext.Nganhs
                              select nganh;
                dtgBang.ItemsSource = null;
                dtgBang.ItemsSource = dsNganh.ToList();
            }
        }
        public void btnXoa_Click(object sender, EventArgs e)
        {
            QldsvContext qldsvContext = new QldsvContext();
            var xoaNganh = qldsvContext.Nganhs.SingleOrDefault(nganh => nganh.MaNganh == int.Parse(txtMaNganh.Text));
            if (xoaNganh == null)
            {
                MessageBox.Show("Không tồn tại môn học " + txtMaNganh.Text, "", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            qldsvContext.Remove(xoaNganh);
            qldsvContext.SaveChanges();
            var dsNganh = from nganh in qldsvContext.Nganhs
                          select nganh;
            dtgBang.ItemsSource = null;
            dtgBang.ItemsSource = dsNganh.ToList();
        }
    }
}
