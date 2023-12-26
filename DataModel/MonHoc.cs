using System;
using System.Collections.Generic;

namespace QLD_HP_CTH.DataModel;

public partial class MonHoc
{
    public int MaMonHoc { get; set; }

    public string? TenMonHoc { get; set; }

    public int? SoTinChi { get; set; }

    public int? SoTienMotTc { get; set; }

    public double? HeSoTx1 { get; set; }

    public double? HeSoTx2 { get; set; }

    public string? Loai { get; set; }

    public virtual ICollection<Lop> Lops { get; set; } = new List<Lop>();

    public virtual ICollection<NganhMonHoc> NganhMonHocs { get; set; } = new List<NganhMonHoc>();
}
