   M S B A M L   `   `   `  ����E  AQLD_HP_CTH, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:QLD_HP_CTH.WindowSVPagesQLD_HP_CTH.WindowSVPages  5      0    *QLD_HP_CTH.WindowSVPages.SvDaiCuongControl   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:QLD_HP_CTH.WindowSVPages     5      .��5	      � 
�������  � RowDefinitions  5
   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      .+�5   
   �� $��0��6   $��Center=�6   $��Đại cương��6:   
���"�"�$��20(�6g   �� 5   
   $��1��6    �� Orientation$ 
Horizontal=�6"   $
��Left=�6;   .+�5      �� $��Tổng số học phần:��6   $��Center=�60   �� 5      -   5        $��	txtTongHP��5      $��0q�6'   $��Center=�6;    �� 
IsReadOnly$
 True��6V   5      �� 5   
   $��2��6   $ 
Horizontal=�6"   $
��Left=�6;   .+�5      �� $��Tổng số tín chỉ:��6   $��Center=�6/   �� 5      -   5        $��	txtTinChi��5      $��0q�6'   $��Center=�6;   $
 True��6V   5      &   System.Windows.Controls.DataGrid  5   
   -   5        $��dtgDaiCuong��5      $��3��6&      AutoGenerateColumns$ False��63      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Mã học phần��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6:   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6D   �� *
MaMonHoc+  5      $ Tên học phần��6%   $ * 6;    6E   �� *	TenMonHoc+  5      $ 	Số tín��6%   $ * 65    6?   �� *
SoTinChi+5      5       5!      