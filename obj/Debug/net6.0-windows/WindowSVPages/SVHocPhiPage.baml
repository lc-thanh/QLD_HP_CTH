   M S B A M L   `   `   `  ����E  AQLD_HP_CTH, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:QLD_HP_CTH.WindowSVPagesQLD_HP_CTH.WindowSVPages  5      +    %QLD_HP_CTH.WindowSVPages.SVHocPhiPage   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:QLD_HP_CTH.WindowSVPages     5        N� Title$  SVHocPhiPage��5	      .��5      � 
������� � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      �� 5      $
��auto �6   .+�5   
   �� $��0��6   $'��!Danh sách học phí từng môn��6   $��10q�6B   $��20(�6N   �� 5   
   $��1��6    �� Orientation$ 
Horizontal=�6"   
�������$��Center=�6U   .+�5      �� -   5        $��cbTrangThai��5      $	��200��6*   $��30��66    �� SelectedIndex$ 0��6B   $��15(�6T   $��Center=�6b   .@�5      �� .��6   Chưa thanh toán60   �� 5      .��6   Đã thanh toán6.   5      �� 5      -   5        $	��Xem��5      $��30��6#   $��80��6/   $��20,0,0,0q�6:   
�������$��1q�6_   6s   5      &   System.Windows.Controls.DataGrid  5   
   -   5        $��	dtgHocPhi��5       $��2��6   $��Center=�61      AutoGenerateColumns$ False��6N      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Tên môn học��6%      MinWidth$	 200Q�6:   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5   %   �� *	TenMonHoc+  5      $ Mã môn học��6%   $	 200Q�69    5   %   �� *
MaMonHoc+  5       $ Số tín chỉ��6%   $	 200Q�69    5!   %   �� *
SoTinChi+  5"      $ Số tiền/tín chỉ��6%   $	 200Q�6>    5#   %   �� *SoTienMotTc+  5$      $ Số tiền/môn��6%   $	 200Q�6:    5%   %   �� *	sotienmon+  5&      $ Trạng thái thanh toán��6%   $	 200Q�6D    5'   %   �� *TrangThaiThanhToan+5)      �� 5*   
   $��3��6   $ 
Horizontal=�6"   
�������$��Right=�6U   $��0,0,10,0q�6q   .+�5+      �� $!��Tổng dư nợ học phí:��6   $��20(�62   $��Center=�6@   �� 5,      -   5        $��	txtTongNo��5,      $	��100��6'   $��30��66   $��0q�6B   
�������$��20(�6p   $��Center=�6~   �� 5-      $	��VND��6   $��20(�6"   $��Center=�60   5.      5/      50      