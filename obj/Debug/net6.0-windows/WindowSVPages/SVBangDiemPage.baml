   M S B A M L   `   `   `  ����E  AQLD_HP_CTH, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:QLD_HP_CTH.WindowSVPagesQLD_HP_CTH.WindowSVPages  5      -    'QLD_HP_CTH.WindowSVPages.SVBangDiemPage   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:QLD_HP_CTH.WindowSVPages     5        N� Title$  SVBangDiemPage��5	      .��5      � 
������� � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� $��0��6   $��Bảng điểm��6   $��10q�61   $��20(�6=   $��Center=�6K   �� 5   
   $��1��6    �� Orientation$ 
Horizontal=�6"   
�������$��Center=�6U   .+�5      �� -   5        $��cbTrangThai��5      $	��200��6*   $��30��66    �� SelectedIndex$ 0��6B   $��15(�6T   $��Center=�6b   .@�5      �� .��6   đang học6)   �� 5      .��6   đã hoàn thành6.   5      �� 5      -   5        $	��Xem��5      $��30��6#   $��80��6/   $��20,0,0,0q�6:   
�������$��1q�6_   6s   5      &   System.Windows.Controls.DataGrid  5   
   -   5        $��dtgBangDiem��5       $��2��6   $��Center=�63      AutoGenerateColumns$ False��6P      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Tên môn học��6%      MinWidth$	 200Q�6:   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5   %   �� *	TenMonHoc+  5       $ Mã môn học��6%   $	 200Q�69    5!   %   �� *
MaMonHoc+  5"      $  Điểm thường xuyên 1��6%   $	 200Q�6B    5#   %   �� *	DiemTx1+  5$      $  Điểm thường xuyên 2��6%   $	 200Q�6B    5%   %   �� *	DiemTx2+  5&      $ Điểm thi��6%   $	 200Q�67    5'   %   �� *	DiemThi+  5(      $ Điểm tổng kết��6%   $	 200Q�6<    5)   %   �� *DiemTongKet+  5*      $ Trạng thái��6%   $	 200Q�69    5+   %   �� *TrangThaiHoc+5-      �� 5.   
   $��3��6   $ 
Horizontal=�6"   $��Right=�6;   $��0,0,10,0q�6W   .+�5/      �� $(��"Tổng số tín chỉ đã học:��6   $��20(�66   $��Center=�6D   �� 50      -   5        $��txtSoTCDaHoc��50      $��50��6*   $��30��68   $��0q�6D   $��20(�6X   $��Center=�6f   �� 51      $
��tín��6   $��20(�6"   $��Center=�60   52      53      54      