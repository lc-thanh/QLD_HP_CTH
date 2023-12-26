using System;
using System.Collections.Generic;

namespace QLD_HP_CTH.DataModel;

public partial class Nganh
{
    public int MaNganh { get; set; }

    public int? MaKhoa { get; set; }

    public string? TenNganh { get; set; }

    public string? HeDaoTao { get; set; }

    public int? ThoiGianDaoTao { get; set; }

    public string? LoaiHinhDaoTao { get; set; }

    public string? Peo1 { get; set; }

    public string? Peo2 { get; set; }

    public string? Peo3 { get; set; }

    public string? Peo4 { get; set; }

    public string? Peo5 { get; set; }

    public virtual Khoa? MaKhoaNavigation { get; set; }

    public virtual ICollection<NganhMonHoc> NganhMonHocs { get; set; } = new List<NganhMonHoc>();

    public virtual ICollection<SinhVien> SinhViens { get; set; } = new List<SinhVien>();
}
