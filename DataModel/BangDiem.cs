using System;
using System.Collections.Generic;

namespace QLD_HP_CTH.DataModel;

public partial class BangDiem
{
    public long MaSv { get; set; }

    public int MaLop { get; set; }

    public double? DiemTx1 { get; set; }

    public double? DiemTx2 { get; set; }

    public double? DiemThi { get; set; }

    public short? TrangThaiHoc { get; set; }

    public short? TrangThaiThanhToan { get; set; }

    public int MaBangDiem { get; set; }

    public virtual Lop MaLopNavigation { get; set; } = null!;

    public virtual SinhVien MaSvNavigation { get; set; } = null!;
}
