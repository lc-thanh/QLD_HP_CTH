   M S B A M L   `   `   `  ����E  AQLD_HP_CTH, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:QLD_HP_CTH.WindowAdminPagesQLD_HP_CTH.WindowAdminPages  5      -    'QLD_HP_CTH.WindowAdminPages.QTVBangDiem   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:QLD_HP_CTH.WindowAdminPages     5        N� Title$  QTVBangDiem��5	      .��5      � 
������� � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5       � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5      .+�5   
   �� $��0��6   $��0��6   $��Mã sinh viên��6-   �� 5   
   -   5        $��txtMaSV��5      $��0��6!   $��1��6.   $��30��6>   $	��200��6J   $
��Left=�6V   �� 5"   
   $��2��6   $��0��6   $��	Mã lớp��6-   �� 5#   
   -   5        $��txtMaLop��5#      $��2��6"   $��1��6/   $��30��6?   $	��200��6K   $
��Left=�6W   �� 5%   
   $��3��6   $��0��6   $ ��Điểm thường xuyên 1��6-   �� 5&   
   -   5        $��txtTX1��5&      $��3��6    $��1��6-   $��30��6=   $	��200��6I   $
��Left=�6U   �� 5(   
   $��4��6   $��0��6   $ ��Điểm thường xuyên 2��6-   �� 5)   
   -   5        $��txtTX2��5)      $��4��6    $��1��6-   $��30��6=   $	��200��6I   $
��Left=�6U   �� 5+   
   $��5��6   $��0��6   $��Điểm thi��6-   �� 5,   
   -   5        $��txtThi��5,      $��5��6    $��1��6-   $��30��6=   $	��200��6I   $
��Left=�6U   �� 5.   
   $��6��6   $��0��6   $��Trạng thái học��6-   �� 5/   
   -   5        $��cbTTHoc��5/      $��6��6"   $��1��6/   $��30��6?   $	��200��6K   $
��Left=�6W    �� SelectedIndex$ 0��6r   $��Center=�6�   .@�50      �� .��6   Đang học6%   �� 51      .��6   
Đã học6#   52      �� 54   
   $��7��6   $��0��6   $��Trạng thái thanh toán��6-   �� 55   
   -   5        $��cbTTThanhToan��55      $��7��6(   $��1��65   $��30��6E   $	��200��6Q   $
��Left=�6]   $ 0��6x   $��Center=�6�   .@�56      �� .��6   Chưa thanh toán6,   �� 57      .��6   Đã thanh toán6*   58      �� 5:   
   $��8��6   $��0��6"   $��2��62    �� Orientation$ 
Horizontal=�6F   $��Center=�6_   .+�5;      �� -   5        $��Tìm kiếm��5;      $��30��6(   $��70��64   $��5q�6?   6J   �� 5<      -	   5        $��Thêm��5<      $��30��6$   $��70��60   $��5q�6;   6F   �� 5=      -
   5        $��Sửa��5=      $��30��6#   $��70��6/   $��5q�6:   6E   �� 5>      -   5        $
��Xóa��5>      $��30��6#   $��70��6/   $��5q�6:   6E   5?      &   System.Windows.Controls.DataGrid  5A   
   -   5        $��dtgBang��5A      $��9��6"   $��0��6/   $��2��6?      AutoGenerateColumns$ False��6S      Columns 5C      0  *System.Windows.Controls.DataGridTextColumn  5D      ,  &System.Windows.Controls.DataGridColumn   Header$ Mã sinh viên��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *MaSv+  5E      $ 	Mã lớp��6%    65   �� *MaLop+  5F      $  Điểm thường xuyên 1��6%    6B   �� *	DiemTx1+  5G      $  Điểm thường xuyên 2��6%    6B   �� *	DiemTx2+  5H      $ Điểm thi��6%    67   �� *	DiemThi+  5I      $ Trạng thái học��6%    6=   �� *TrangThaiHoc+  5J      $ Trạng thái thanh toán��6%    6D   �� *TrangThaiThanhToan+5L      5M      5N      