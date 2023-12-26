using System;
using System.Collections.Generic;

namespace QLD_HP_CTH.DataModel;

public partial class NganhMonHoc
{
    public int? MaNganh { get; set; }

    public int? MaMonHoc { get; set; }

    public int MaNganhMonHoc { get; set; }

    public virtual MonHoc? MaMonHocNavigation { get; set; }

    public virtual Nganh? MaNganhNavigation { get; set; }
}
