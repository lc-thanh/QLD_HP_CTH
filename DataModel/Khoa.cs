using System;
using System.Collections.Generic;

namespace QLD_HP_CTH.DataModel;

public partial class Khoa
{
    public int MaKhoa { get; set; }

    public string? TenKhoa { get; set; }

    public virtual ICollection<Nganh> Nganhs { get; set; } = new List<Nganh>();
}
