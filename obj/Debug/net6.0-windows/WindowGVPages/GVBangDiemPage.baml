   M S B A M L   `   `   `  ����E  AQLD_HP_CTH, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:QLD_HP_CTH.WindowGVPagesQLD_HP_CTH.WindowGVPages  5      -    'QLD_HP_CTH.WindowGVPages.GVBangDiemPage   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:QLD_HP_CTH.WindowGVPages     5        N� Title$  GVBangDiemPage��5	       N� FontSize$ 20(�6   .��5      � 
������� � ColumnDefinitions 5   
   �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��30 �6   �� 5      .+�5   
   �� $��0��6   $��0��6   $��Danh sách lớp��6-   $��20(�6E   $��	100,0,0,0q�6S   $��Center=�6f   �� 5   
   -   5        $��cbDsLop��5      $��0��6"   $��1��6/   $	��200��6?   5       �� 5!   
   -   5        $��0��5!      $��2��6   $��Lấy danh sách��6.   $
��Left=�6[   $	��150��6v   �� 5#   
   $��1��6   $��0��6"   $��3��62    �� Orientation$ 
Horizontal=�6F   $��Center=�6_   .+�5$      �� $��Select Mode��6   �� 5%      -   5        $��Thông thường��5%      
�������$��5q�6\   �� 5&      -   5        $��Nhập điểm��5&      
�������$��5q�6V   5'      �� 5)   
   $��2��6   $��0��6   $��Mã sinh viên��6-   $��Center=�6D   $��	100,0,0,0q�6_   �� 5*   
   -   5        $��txtMaSV��5*      $��2��6!   $��1��6.   $
��Left=�6>   $	��200��6Y   $��30��6e   $��	0,10,0,10q�6q   �� 5+   
   -   5        $��2��5+      $��2��6   $��Tìm kiếm��6.   $��5q�6Z   $
��Left=�6e   $	��100��6�   $��30��6�   �� 5-   
   $��3��6   $��0��6   $ ��Điểm thường xuyên 1��6-   $��Center=�6K   $��	100,0,0,0q�6f   �� 5.   
   -   5        $��txtTX1��5.      $��3��6    $��1��6-   $
��Left=�6=   $	��200��6X   $��30��6d   $��	0,10,0,10q�6p   �� 50   
   $��4��6   $��0��6   $ ��Điểm thường xuyên 2��6-   $��Center=�6K   $��	100,0,0,0q�6f   �� 51   
   -   5        $��txtTX2��51      $��4��6    $��1��6-   $
��Left=�6=   $	��200��6X   $��30��6d   $��	0,10,0,10q�6p   �� 53   
   $��5��6   $��0��6   $��Điểm thi��6-   $��Center=�6@   $��	100,0,0,0q�6[   �� 54   
   -	   5        $��
txtDiemThi��54      $��5��6$   $��1��61   $
��Left=�6A   $	��200��6\   $��30��6h   $��	0,10,0,10q�6t   �� 56   
   -
   5         ��Name$ btnLuu��56      $��6��6!   $��2��6.   $
��Lưu��6>   $��5q�6a   $
��Left=�6l   $	��100��6�   �� 58   
   -   5        $��	txtTenMon��58      $��7��6#   $��0��60   $��3��6@    �� 
IsReadOnly$
 True��6T   
���� ��$��20(�6~   $��Center=�6�   $��0q�6�   &   System.Windows.Controls.DataGrid  5:   
   -   5        $��dtgDanhSach��5:      $��8��6&   $��0��63   $��3��6C      AutoGenerateColumns$ False��6W      Columns 5;      0  *System.Windows.Controls.DataGridTextColumn  5<      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Mã sinh viên��6%   
   Width5  /System.Windows.Controls.DataGridLengthConverter$	
 200 6;   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6G   �� *MaSv+  5=      $	 	Họ tên��6%   $	
 200 65    6A   �� *HoTen+  5>      $	 Điểm TX1��6%   $	
 200 67    6C   �� *	DiemTx1+  5?      $	 Điểm TX2��6%   $	
 200 67    6C   �� *	DiemTx2+  5@      $	 Điểm Thi��6%   $	
 200 67    6C   �� *	DiemThi+5B      5C      5D      