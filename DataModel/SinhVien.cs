using System;
using System.Collections.Generic;

namespace QLD_HP_CTH.DataModel;

public partial class SinhVien
{
    public long MaSv { get; set; }

    public int? MaNganh { get; set; }

    public string? HoTen { get; set; }

    public DateTime? NgaySinh { get; set; }

    public string? GioiTinh { get; set; }

    public string? DiaChi { get; set; }

    public string? SoDt { get; set; }

    public string? MatKhau { get; set; }

    public virtual ICollection<BangDiem> BangDiems { get; set; } = new List<BangDiem>();

    public virtual Nganh? MaNganhNavigation { get; set; }
}
