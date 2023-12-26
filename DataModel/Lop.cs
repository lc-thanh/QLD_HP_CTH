using System;
using System.Collections.Generic;

namespace QLD_HP_CTH.DataModel;

public partial class Lop
{
    public int MaLop { get; set; }

    public int? MaGv { get; set; }

    public int? MaMonHoc { get; set; }

    public string? ViTriLop { get; set; }

    public virtual ICollection<BangDiem> BangDiems { get; set; } = new List<BangDiem>();

    public virtual MonHoc? MaMonHocNavigation { get; set; }
}
