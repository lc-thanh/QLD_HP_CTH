   M S B A M L   `   `   `  ����E  AQLD_HP_CTH, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:QLD_HP_CTH.WindowAdminPagesQLD_HP_CTH.WindowAdminPages  5      -    'QLD_HP_CTH.WindowAdminPages.QTVNganhMon   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:QLD_HP_CTH.WindowAdminPages     5        N� Title$  QTVNganhMon��5	       N� 
Background
 �����.��5      �  � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5       � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      .+�5   
   �� $��0��6   $��0��6   $��
Mã ngành��6-   $��Center=�6@   $
��Left=�6[   �� 5   
   -   5         ��Name$ 
txtMaNganh��5      $��0��6&   $��1��63   $
��Left=�6C   $	��200��6^   $��30��6j   �� 5   
   $��1��6   $��0��6   $��Mã môn học��6-   $��Center=�6B   $
��Left=�6]   �� 5   
   -   5        $��txtMaMon��5      $��1��6"   $��1��6/   $
��Left=�6?   $	��200��6Z   $��30��6f   �� 5   
   $��2��6   $��0��6"   $��2��62   $��Center=�6F    �� Orientation$ 
Horizontal=�6c   .+�5      �� -   5        $��Tìm kiếm��5      $��30��6(   $��70��64   $��5q�6?   6J   �� 5      -   5        $��Thêm��5      $��30��6$   $��70��60   $��5q�6;   6F   �� 5      -   5        $
��Xóa��5      $��30��6#   $��70��6/   $��5q�6:   6E   5      &   System.Windows.Controls.DataGrid  5   
   -   5        $��dtgBang��5      $��3��6"   $��0��6/   $��2��6?      AutoGenerateColumns$ False��6S      Columns 5       0  *System.Windows.Controls.DataGridTextColumn  5!      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Mã ngành��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 67   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6A   �� *	MaNganh+  5"      $ Mã môn hoc��6%   $	 * 69   
 6C   �� *
MaMonHoc+5$      5%      5&      