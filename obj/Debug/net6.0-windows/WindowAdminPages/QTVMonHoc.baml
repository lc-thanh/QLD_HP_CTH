   M S B A M L   `   `   `  ����E  AQLD_HP_CTH, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:QLD_HP_CTH.WindowAdminPagesQLD_HP_CTH.WindowAdminPages  5      +    %QLD_HP_CTH.WindowAdminPages.QTVMonHoc   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:QLD_HP_CTH.WindowAdminPages     5        N� Title$  	QTVMonHoc��5	       N� 
Background
 �����.��5      �  � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5       � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      .+�5   
   �� $��0��6   $��0��6   $��Mã môn học��6-   $��Center=�6B   $
��Left=�6]   �� 5   
   -   5        $��txtMa��5      $��0��6   $��1��6,   $��Center=�6<   $
��Left=�6W   $	��200��6r   $��30��6~   �� 5   
   $��1��6   $��0��6   $��Tên môn học��6-   $��Center=�6C   $
��Left=�6^   �� 5    
   -   5        $��txtTen��5       $��1��6    $��1��6-   $��Center=�6=   $
��Left=�6X   $	��200��6s   $��30��6   �� 5"   
   $��2��6   $��0��6   $��Số tín chỉ��6-   $��Center=�6B   $
��Left=�6]   �� 5#   
   -   5        $��txtSoTC��5#      $��2��6!   $��1��6.   $��Center=�6>   $
��Left=�6Y   $	��200��6t   $��30��6�   �� 5%   
   $��3��6   $��0��6   $��Số tiền 1 tín chỉ��6-   $��Center=�6I   $
��Left=�6d   �� 5&   
   -   5        $��	txtSoTien��5&      $��3��6#   $��1��60   $��Center=�6@   $
��Left=�6[   $	��200��6v   $��30��6�   �� 5(   
   $��4��6   $��0��6   $��Hệ số TX1��6-   $��Center=�6A   $
��Left=�6\   �� 5)   
   -   5        $��txtTX1��5)      $��4��6    $��1��6-   $��Center=�6=   $
��Left=�6X   $	��200��6s   $��30��6   �� 5+   
   $��5��6   $��0��6   $��Hệ số TX2��6-   $��Center=�6A   $
��Left=�6\   �� 5,   
   -   5        $��txtTX2��5,      $��5��6    $��1��6-   $��Center=�6=   $
��Left=�6X   $	��200��6s   $��30��6   �� 5.   
   $��6��6   $��0��6   $��Loại��6-   $��Center=�6<   $
��Left=�6W   �� 5/   
   -   5        $��cbLoai��5/      $��6��6!   $��1��6.   $��Center=�6>   $
��Left=�6Y   $	��200��6t   $��30��6�    �� SelectedIndex$ 0��6�   $��15(�6�   .@�50      �� .��6   Đại cương6&   �� 51      .��6   Chuyên ngành6)   52      �� 54   
   $��7��6   $��0��6"   $��2��62   $��Center=�6F    �� Orientation$ 
Horizontal=�6c   .+�55      �� -   5        $��Tìm kiếm��55      $��30��6(   $��70��64   $��5q�6?   6J   �� 56      -	   5        $��Thêm��56      $��30��6$   $��70��60   $��5q�6;   6F   �� 57      -
   5        $��Sửa��57      $��30��6#   $��70��6/   $��5q�6:   6E   �� 58      -   5        $
��Xóa��58      $��30��6#   $��70��6/   $��5q�6:   6E   59      &   System.Windows.Controls.DataGrid  5;   
   -   5        $��dtgBang��5;      $��8��6"   $��2��6/   $��0��6C      AutoGenerateColumns$ False��6S      Columns 5<      0  *System.Windows.Controls.DataGridTextColumn  5=      ,  &System.Windows.Controls.DataGridColumn   Header$ Mã môn học��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 69   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6C   �� *
MaMonHoc+  5>      $ Tên môn học��6%   $	 * 6:   
 6D   �� *	TenMonHoc+  5?      $ Số tín chỉ��6%   $	 * 69   
 6C   �� *
SoTinChi+  5@      $ Số tiền 1 tín chỉ��6%   $	 * 6@   
 6J   �� *SoTienMotTc+  5A      $ Hệ số TX1��6%   $	 * 68   
 6B   �� *	HeSoTx1+  5B      $ Hệ số TX2��6%   $	 * 68   
 6B   �� *	HeSoTx2+  5C      $ Loại��6%   $	 * 63   
 6=   �� *Loai+5E      5F      5G      